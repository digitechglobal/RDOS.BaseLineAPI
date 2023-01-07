DROP FUNCTION collectoutletaccumulate(baselinedate VARCHAR);
CREATE FUNCTION collectoutletaccumulate(baselinedate VARCHAR) RETURNS TABLE (
    "Id" uuid,
    "BaselineDate" timestamp,
    "CustomerId" character varying(100),
    "CustomerName" character varying(255),
    "CustomerShiptoId" character varying(100),
    "CustomerShiptoName" character varying(255),
    "TMKProgramType" character varying(100),
    "TMKProgramId" character varying(100),
    "TMKProgramDesc" character varying(255),
    "FrequencyType" character varying(100),
    "FrequnecyValue" character varying(255),
    "TMKProgramLevelId" character varying(100),
    "TMKProgramLevelDesc" character varying(255),
    "AccumulateType" character varying(100),
    "AccuByProgTarget" numeric,
    "AccuByProgActual" numeric,
    "AccuByProgProgress" numeric,
    "ProductType" character varying(100),
    "AccuProductId" character varying(100),
    "AccuProductDesc" character varying(255),
    "AccuByProdTarget" numeric,
    "AccuByProdTargetUOM" character varying(255),
    "AccuByProdActual" numeric,
    "AccuByProdActualUOM" character varying(255),
    "AccuByProdProgress" numeric,
    "AccuWeightType" character varying(100),
    "AccuWeighProductId" character varying(100),
    "AccuWeighProductDesc" character varying(255),
    "AccuWeightByProgTarget" numeric,
    "AccuWeightByProgTargetUOM" character varying(255),
    "AccuWeightByProgActual" numeric,
    "AccuWeightByProgActualUOM" character varying(255),
    "AccuWeightByProgProgress" numeric,
    "CreatedDate" timestamp,
    "UpdatedDate" timestamp,
    "CreatedBy" character varying(255),
    "UpdatedBy" character varying(255),
    "IsDeleted" boolean
) LANGUAGE plpgsql AS $func$ BEGIN
	RETURN QUERY
    select 
    uuid_generate_v4()::uuid, --"Id" 
    now()::timestamp, --"BaselineDate" later
    rawSo."CustomerId"::character varying(100), --"CustomerId" 
    rawSo."CustomerName"::character varying(255), --"CustomerName" 
    rawSo."CustomerShiptoId"::character varying(100), --"CustomerShiptoId" 
    rawSo."CustomerShiptoName"::character varying(255), --"CustomerShiptoName" 
    rawSo."TradePromotionType"::character varying(100), --"TMKProgramType" 
    display."Code"::character varying(100), --"TMKProgramId" 
    display."FullName"::character varying(255), --"TMKProgramDesc" 
    case 
		when display."FrequencyDisplay" = '01' then 'Sales Week'
		when display."FrequencyDisplay" = '02' then 'Sales Period'
		when display."FrequencyDisplay" = '03' then 'Sales Quater'
		when display."FrequencyDisplay" = '04' then 'Sales Year'
		else NULL end ::character varying(100), --"FrequencyType" 
    NULL::character varying(255), --"FrequnecyValue" later
    displayDefStructure."LevelCode"::character varying(100), --"TMKProgramLevelId" 
    displayDefStructure."LevelName"::character varying(255), --"TMKProgramLevelDesc" 
    case 
		when display."SalesOutput" = 1 then 'REV' --doanh Số    
		when display."SalesOutput" = 2 then 'VOL' -- sản lượng   
	else NULL end::character varying(100), --"AccumulateType" 
    case 
		when display."SalesOutput" = 1 then displayDefStructure."OutputToBeAchieved"
		when display."SalesOutput" = 2 then displayDefStructure."SalesToBeAchieved"
	end::numeric, --"AccuByProgTarget" 
    NULL::numeric, --"AccuByProgActual" **
    NULL::numeric, --"AccuByProgProgress" **
    case
		when displayDefStructure."ProductTypeForDisplay" = '01' then 'SKU'
		when displayDefStructure."ProductTypeForDisplay" = '02' then 'ItemGroup'
		when displayDefStructure."ProductTypeForDisplay" = '03' then 'ProductHiearachy'
		else NULL
	end::character varying(100), --"ProductType" 
    rawSo."ItemId"::character varying(100), --"AccuProductId" 
    rawSo."InventoryDescription"::character varying(255), --"AccuProductDesc" 
    NULL::numeric, --"AccuByProdTarget"  Later
    NULL::character varying(255), --"AccuByProdTargetUOM" Later
    case 
		when display."SalesOutput" = 1 then rawSo."ShippedExtendAmt" --doanh Số    
		when display."SalesOutput" = 2 then 
			if conFromSales Is not NULL then
				case 
					when conFromSales."DM" = 1 then rawSo."ShippedBaseQuantities" * conFromSales."ConversionFactor"
					when conFromSales."DM" = 2 then rawSo."ShippedBaseQuantities" / conFromSales."ConversionFactor"
					else 0
				end
			else if conToSales Is not NULL then
				case 
					when conToSales."DM" = 1 then rawSo."ShippedBaseQuantities" / conToSales."ConversionFactor"
					when conToSales."DM" = 2 then rawSo."ShippedBaseQuantities" * conToSales."ConversionFactor"
					else 0
				end
			else 0
			end
	else NULL end::numeric, --"AccuByProdActual" 
    case 
		when display."SalesOutput" = 1 then NULL --doanh Số    
		when display."SalesOutput" = 2 then rawSo."SalesUnitId" -- sản lượng   
	else NULL end::character varying(255), --"AccuByProdActualUOM" 
    NULL::numeric, --"AccuByProdProgress"  later
	
    NULL::character varying(100), --"AccuWeightType" 
    NULL::character varying(100), --"AccuWeighProductId" 
    NULL::character varying(255), --"AccuWeighProductDesc" 
    NULL::numeric, --"AccuWeightByProgTarget" 
    NULL::character varying(255), --"AccuWeightByProgTargetUOM" 
    NULL::numeric, --"AccuWeightByProgActual" 
    NULL::character varying(255), --"AccuWeightByProgActualUOM" 
    NULL::numeric, --"AccuWeightByProgProgress" 
    now()::timestamp, --"CreatedDate" 
    NULL::timestamp, --"UpdatedDate" 
    NULL::character varying(255), --"CreatedBy" 
    NULL::character varying(255), --"UpdatedBy" 
    FALSE::boolean --"IsDeleted" 

from "BL_RawSOs" as rawSo
join "DisDisplays" as display on rawSo."PromotionId" = display."Code" 
	and display."IsCheckSalesOutput" = TRUE
join "DisDefinitionStructures" as displayDefStructure on displayDefStructure."DisplayCode" = display."Code" 
	and displayDefStructure."LevelCode" = rawSo."ProgramCustomersDetailId" 
join "DisDefinitionProductTypeDetails" as disproductdetail on disproductdetail."DisplayCode" = display."Code" 
	and disproductdetail."LevelCode" = displayDefStructure."LevelCode" 
	and disproductdetail."ProductCode" = rawSo."ItemId"
join "DisApproveRegistrationCustomerDetails" as disApprove on disApprove."DisplayCode" = display."Code"  
	and disApprove."CustomerCode" = rawSo."CustomerId" 
	and disApprove."CustomerShipToCode"  = rawSo."CustomerShiptoId" and disApprove."Status" = '02' and disApprove."DisplayLevel" = rawSo."ProgramCustomersDetailId"
--
join "InventoryItems" as invenItem on invenItem."InventoryItemId" = rawSo."ItemId" 
join "Uoms" as baseUnit on rawSo."BaseUnitId" = baseUnit."UomId"
join "Uoms" as salesUnit on rawSo."SalesUnitId" = salesUnit."UomId"
left join "ItemsUOMConversions" as conFromSales on conFromSales."ItemID" = invenItem."Id" 
	and conFromSales."FromUnit" = salesUnit."Id"
	and conFromSales."ToUnit" = baseUnit."Id"
left join "ItemsUOMConversions" as conToSales on conToSales."ItemID" = invenItem."Id" 
	and conToSales."FromUnit" = baseUnit."Id"
	and conToSales."ToUnit" = salesUnit."Id"
where rawSo."TradePromotionType" IS NOT NULL and rawSo."TradePromotionType" = 'Display'
;

END $func$;
SELECT
    *
FROM
    collectoutletaccumulate('2022-11-14')
LIMIT 100;