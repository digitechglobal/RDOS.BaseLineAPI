-- DROP FUNCTION collectoutletpnmbyRev(salesperiod VARCHAR);

CREATE FUNCTION collectoutletpnmbyRev(salesperiod VARCHAR, saleorgid varchar) RETURNS TABLE (
  "Id" uuid,
  "SalesPeriod" character varying(255),
  "CustomerId" character varying(255),
  "CustomerName" character varying(255),
  "CustomerShiptoId" character varying(255),
  "CustomerShiptoName" character varying(255),
  "ValueType" character varying(255),
  "Value" numeric,
  "CreatedDate" timestamp,
  "UpdatedDate" timestamp,
  "CreatedBy" character varying(255),
  "UpdatedBy" character varying(255)
) LANGUAGE plpgsql AS $func$ BEGIN RETURN QUERY
select
  uuid_generate_v4():: uuid,--"Id" 
  salesperiod:: character varying(255),--"SalesPeriod" 
  rawSo."CustomerId":: character varying(255),--"CustomerId" 
  rawSo."CustomerName":: character varying(255),--"CustomerName" 
  rawSo."CustomerShiptoId":: character varying(255),--"CustomerShiptoId" 
  rawSo."CustomerShiptoName":: character varying(255),--"CustomerShiptoName" 
  'Rev':: character varying(255),--"ValueType" 
  case when conFromPurchase is not null then
				(case 
					when conFromPurchase."DM" = 1 then rawSo."ShippedExtendAmt" * conFromPurchase."ConversionFactor"
					when conFromPurchase."DM" = 2 then rawSo."ShippedExtendAmt" / conFromPurchase."ConversionFactor"
					else 0
				end)
	when conToPurchase Is not NULL then
				(case 
					when conToPurchase."DM" = 1 then rawSo."ShippedExtendAmt" / conToPurchase."ConversionFactor"
					when conToPurchase."DM" = 2 then rawSo."ShippedExtendAmt" * conToPurchase."ConversionFactor"
					else 0
				end)
	else 0
  end:: numeric,--"Value" 
  now():: timestamp,--"CreatedDate" 
  NULL:: timestamp,--"UpdatedDate" 
  NULL:: character varying(255),--"CreatedBy" 
  NULL:: character varying(255)--"UpdatedBy" 
from "BL_RawSOs" as rawSo
join "InventoryItems" as invenItem on invenItem."InventoryItemId" = rawSo."ItemId" 
join "Uoms" as baseUnit on rawSo."BaseUnitId" = baseUnit."UomId"
join "Uoms" as purchaseUnit on rawSo."PurchaseUnitId" = purchaseUnit."UomId"
left join "ItemsUOMConversions" as conFromPurchase on conFromPurchase."ItemID" = invenItem."Id" 
	and conFromPurchase."FromUnit" = purchaseUnit."Id"
	and conFromPurchase."ToUnit" = baseUnit."Id"
left join "ItemsUOMConversions" as conToPurchase on conToPurchase."ItemID" = invenItem."Id" 
	and conToPurchase."FromUnit" = baseUnit."Id"
	and conToPurchase."ToUnit" = purchaseUnit."Id"
where rawSo."SalesPeriodId" = salesperiod and rawSo."SalesOrgId" = saleorgid and rawSo."WorkingDay" = TRUE and rawSo."IsReturn" = FALSE
;
END $func$;

SELECT * FROM  collectoutletpnmbyRev('SPBUHBuhBUH', 'BRUHBRUHBRUH')
LIMIT
  100;