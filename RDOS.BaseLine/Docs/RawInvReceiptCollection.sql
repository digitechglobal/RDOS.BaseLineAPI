-- Adjustment
DROP FUNCTION collectreceiptadjustment(baselinedate VARCHAR, settingref VARCHAR, typedata VARCHAR);
CREATE FUNCTION collectreceiptadjustment(baselinedate VARCHAR, settingref VARCHAR, typedata VARCHAR) RETURNS TABLE (
    "Id" uuid,
    "BaselineDate" timestamp,
    "BaselineSettingRef" varchar(50),
    "Month" timestamp,
    "SalesPeriod" varchar(100),
    "BaseLineType" varchar(50),
    "ItemId" varchar(100),
    "InventoryShortName" varchar(255),
    "InventoryReportName" varchar(255),
    "InventoryDescription" varchar(255),
    "InQuantityType" varchar(50),
    "InQuantityTypeValue" varchar(255),
    "InQuantityTypeDesc" varchar(255),
    "InQuantity" integer,
    "InBaseUOM" varchar(255),
	"InSalesQuantity" integer,
	"InSalesUOM" varchar(100),
	"InPurchaseQuantity" integer,
	"InPurchaseUOM" varchar(100),
    "LocationId" varchar(100),
    "WareHouseId" varchar(100),
    "WareHouseName" varchar(255),
    "DistributorId" varchar(100),
    "DistributorName" varchar(255),
    "DMSCode" varchar(100),
    "PrincipalLinkedCode" varchar(100),
    "DistributorCountrysId" varchar(100),
    "DistributorCountrysDesc" varchar(255),
    "DistributorCountrysShortName" varchar(255),
    "DistributorStatesId" varchar(100),
    "DistributorStatesDesc" varchar(255),
    "DistributorStatesShortName" varchar(255),
    "DistributorProvincesId" varchar(100),
    "DistributorProvincesDesc" varchar(255),
    "DistributorProvincesShortName" varchar(255),
    "DistributorCitysId" varchar(100),
    "DistributorCitysDesc" varchar(255),
    "DistributorCitysShortName" varchar(255),
    "DistributorDistrictsId" varchar(100),
    "DistributorDistrictsDesc" varchar(255),
    "DistributorDistrictsShortName" varchar(255),
    "DistributorWardsId" varchar(100),
    "DistributorWardsDesc" varchar(255),
    "DistributorWardsShortName" varchar(255),
    "DistributorStreet" varchar(255),
    "DistributorDeptNo" varchar(255),
    "DistributorLongtiue" varchar(255),
    "DistributorLattitue" varchar(255),
    "DistributorShipToId" varchar(100),
    "ShiptoName" varchar(255),
    "ShiptoCodeOnERP" varchar(100),
    "DistributorShipToFullName" varchar(255),
    "DistributorShipToCountrysId" varchar(100),
    "DistributorShipToCountrysDesc" varchar(255),
    "DistributorShipToCountrysShortName" varchar(255),
    "DistributorShipToStatesId" varchar(100),
    "DistributorShipToStatesDesc" varchar(255),
    "DistributorShipToStatesShortName" varchar(255),
    "DistributorShipToProvincesId" varchar(100),
    "DistributorShipToProvincesDesc" varchar(255),
    "DistributorShipToProvincesShortName" varchar(255),
    "DistributorShipToCitysId" varchar(100),
    "DistributorShipToCitysDesc" varchar(255),
    "DistributorShipToCitysShortName" varchar(255),
    "DistributorShipToDistrictsId" varchar(100),
    "DistributorShipToDistrictsDesc" varchar(255),
    "DistributorShipToDistrictsShortName" varchar(255),
    "DistributorShipToWardsId" varchar(100),
    "DistributorShipToWardsDesc" varchar(255),
    "DistributorShipToWardsShortName" varchar(255),
    "DistributorShipToStreet" varchar(255),
    "DistributorShipToDeptNo" varchar(255),
    "DistributorShipToLongtiue" varchar(255),
    "DistributorShipToLattitue" varchar(255),
    "ItemGroupId" varchar(100),
    "ItemGroupDesc" varchar(255),
    "InventoryAttributeId1" varchar(100),
    "InventoryAttributeName1" varchar(255),
    "InventoryAttributeDesc1" varchar(255),
    "InventoryAttributeValueId1" varchar(100),
    "InventoryAttributeValueDesc1" varchar(255),
    "InventoryAttributeId2" varchar(100),
    "InventoryAttributeName2" varchar(255),
    "InventoryAttributeDesc2" varchar(255),
    "InventoryAttributeValueId2" varchar(100),
    "InventoryAttributeValueDesc2" varchar(255),
    "InventoryAttributeId3" varchar(100),
    "InventoryAttributeName3" varchar(255),
    "InventoryAttributeDesc3" varchar(255),
    "InventoryAttributeValueId3" varchar(100),
    "InventoryAttributeValueDesc3" varchar(255),
    "InventoryAttributeId4" varchar(100),
    "InventoryAttributeName4" varchar(255),
    "InventoryAttributeDesc4" varchar(255),
    "InventoryAttributeValueId4" varchar(100),
    "InventoryAttributeValueDesc4" varchar(255),
    "InventoryAttributeId5" varchar(100),
    "InventoryAttributeName5" varchar(255),
    "InventoryAttributeDesc5" varchar(255),
    "InventoryAttributeValueId5" varchar(100),
    "InventoryAttributeValueDesc5" varchar(255),
    "InventoryAttributeId6" varchar(100),
    "InventoryAttributeName6" varchar(255),
    "InventoryAttributeDesc6" varchar(255),
    "InventoryAttributeValueId6" varchar(100),
    "InventoryAttributeValueDesc6" varchar(255),
    "InventoryAttributeId7" varchar(100),
    "InventoryAttributeName7" varchar(255),
    "InventoryAttributeDesc7" varchar(255),
    "InventoryAttributeValueId7" varchar(100),
    "InventoryAttributeValueDesc7" varchar(255),
    "InventoryAttributeId8" varchar(100),
    "InventoryAttributeName8" varchar(255),
    "InventoryAttributeDesc8" varchar(255),
    "InventoryAttributeValueId8" varchar(100),
    "InventoryAttributeValueDesc8" varchar(255),
    "InventoryAttributeId9" varchar(100),
    "InventoryAttributeName9" varchar(255),
    "InventoryAttributeDesc9" varchar(255),
    "InventoryAttributeValueId9" varchar(100),
    "InventoryAttributeValueDesc9" varchar(255),
    "InventoryAttributeId10" varchar(100),
    "InventoryAttributeName10" varchar(255),
    "InventoryAttributeDesc10" varchar(255),
    "InventoryAttributeValueId10" varchar(100),
    "InventoryAttributeValueDesc10" varchar(255),
    "Hierarchy" uuid,
    "CreatedDate" timestamp,
    "UpdatedDate" timestamp,
    "CreatedBy" character varying(250),
    "UpdatedBy" character varying(250),
    "IsDeleted" boolean,
    "SalesOrgId" varchar(100),
    "SalesOrgDesc" varchar(255),
    "BranchId" varchar(100),
    "BranchName" varchar(255),
    "RegionId" varchar(100),
    "RegionName" varchar(255),
    "SubRegionId" varchar(100),
    "SubRegionName" varchar(255),
    "AreaId" varchar(100),
    "AreaName" varchar(255),
    "SubAreaId" varchar(100),
    "SubAreaName" varchar(255),
    "DSAId" varchar(100),
    "DSADesc" varchar(255),
	"RouteZoneId" varchar(100),
    "RouteZoneDesc" varchar(255)
) LANGUAGE plpgsql AS $func$ BEGIN
    RETURN QUERY
    Select
        uuid_generate_v4() :: uuid, --as "Id",
        CAST(baselinedate AS timestamp) :: timestamp,
        settingref :: varchar(50),
        NULL :: timestamp,
        NULL :: varchar(100),
        typedata :: varchar(50),
        inventoryItem."InventoryItemId" :: varchar(100), --as "ItemId",
        inventoryItem."ShortName" :: varchar(255), --as "InventoryShortName",
        inventoryItem."ReportName" :: varchar(255), --as "InventoryReportName",
        inventoryItem."Description" :: varchar(255), --as "InventoryDescription",
        invtransaction."TransactionType" :: varchar(50), --as "OutQuantityType",
        systemsetting."SettingValue" :: varchar(255), --as "OutQuantityTypeValue",
        systemsetting."Description" :: varchar(255), --as "OutQuantityTypeDesc",
        invtransaction."Receipt" :: integer, --as "OutQuantity",
		baseuom."UomId" :: varchar(255), --as "OutBaseUOM",
		(invtransaction."Receipt" / salesconvs."ConversionFactor") :: integer,
		salesuom."UomId":: varchar(100),
		(invtransaction."Receipt" / purchaseconvs."ConversionFactor") :: integer, 
		purchaseuom."UomId":: varchar(100),
        invtransaction."LocationCode" :: varchar(100), -- as "LocationId"
        invtransaction."WareHouseCode" :: varchar(100), --as "WareHouseId",
        shiptoInfo."ShiptoName" :: varchar(255), --as "WareHouseName",
        distributorInfo."Code" :: varchar(100), --as "DistributorId",
        distributorInfo."Name" :: varchar(255), --as "DistributorName",
        distributorInfo."DMSCode" :: varchar(100), --as "DMSCode",
        distributorInfo."PrincipalLinkedCode" :: varchar(100), --as "PrincipalLinkedCode",
        countryInfo."CountryCode" :: varchar(100), --as "DistributorCountrysId",
        countryInfo."Description" :: varchar(255), --as "DistributorCountrysDesc",
        countryInfo."ShortName" :: varchar(255), --as "DistributorCountrysShortName",
        stateInfo."StateCode" :: varchar(100), --as "DistributorStatesId",
        stateInfo."Description" :: varchar(255), --as "DistributorStatesDesc",
        stateInfo."ShortName" :: varchar(255), --as "DistributorStatesShortName",
        provinceInfo."ProvinceCode" :: varchar(100), --as "DistributorProvincesId",
        provinceInfo."Description" :: varchar(255), --as "DistributorProvincesDesc",
        provinceInfo."ShortName" :: varchar(255), --as "DistributorProvincesShortName",
        cityInfo."CityCode" :: varchar(100), --as "DistributorCitysId",
        cityInfo."Description" :: varchar(255), --as "DistributorCitysDesc",
        cityInfo."ShortName" :: varchar(255), --as "DistributorCitysShortName",
        districtInfo."DistrictCode" :: varchar(100), --as "DistributorDistrictsId",
        districtInfo."Description" :: varchar(255), --as "DistributorDistrictsDesc",
        districtInfo."ShortName" :: varchar(255), --as "DistributorDistrictsShortName",
        wardInfo."WardCode" :: varchar(100), --as "DistributorWardsId",
        wardInfo."Description" :: varchar(255), --as "DistributorWardsDesc",
        wardInfo."ShortName" :: varchar(255), --as "DistributorWardsShortName",
        distributorInfo."BusinessAddressStreet" :: varchar(255), --as "DistributorStreet",
        distributorInfo."BusinessAddressDept" :: varchar(255), --as "DistributorDeptNo",
        distributorInfo."BusinessAddressLong" :: varchar(255), --as "DistributorLongtiue",
        distributorInfo."BusinessAddressLat" :: varchar(255), --as "DistributorLattitue",
        shiptoInfo."ShiptoCode" :: varchar(100), --as "DistributorShipToId",
        shiptoInfo."ShiptoName" :: varchar(255), --as "ShiptoName",
        shiptoInfo."ShiptoCodeOnERP" :: varchar(100), --as "ShiptoCodeOnERP",
        shiptoInfo."FullName" :: varchar(255), --as "DistributorShipToFullName",
        shiptoCountryInfo."CountryCode" :: varchar(100), --as "DistributorShipToCountrysId",
        shiptoCountryInfo."Description" :: varchar(255), --as "DistributorShipToCountrysDesc",
        shiptoCountryInfo."ShortName" :: varchar(255), --as "DistributorShipToCountrysShortName",
        shiptoStateInfo."StateCode" :: varchar(100), --as "DistributorShipToStatesId",
        shiptoStateInfo."Description" :: varchar(255), --as "DistributorShipToStatesDesc",
        shiptoStateInfo."ShortName" :: varchar(255), --as "DistributorShipToStatesShortName",
        shiptoProvinceInfo."ProvinceCode" :: varchar(100), --as "DistributorShipToProvincesId",
        shiptoProvinceInfo."Description" :: varchar(255), --as "DistributorShipToProvincesDesc",
        shiptoProvinceInfo."ShortName" :: varchar(255), --as "DistributorShipToProvincesShortName",
        shiptoCityInfo."CityCode" :: varchar(100), --as "DistributorShipToCitysId",
        shiptoCityInfo."Description" :: varchar(255), --as "DistributorShipToCitysDesc",
        shiptoCityInfo."ShortName" :: varchar(255), --as "DistributorShipToCitysShortName",
        shiptoDistrictInfo."DistrictCode" :: varchar(100), --as "DistributorShipToDistrictsId",
        shiptoDistrictInfo."Description" :: varchar(255), --as "DistributorShipToDistrictsDesc",
        shiptoDistrictInfo."ShortName" :: varchar(255), --as "DistributorShipToDistrictsShortName",
        shiptoWardInfo."WardCode" :: varchar(100), --as "DistributorShipToWardsId",
        shiptoWardInfo."Description" :: varchar(255), --as "DistributorShipToWardsDesc",
        shiptoWardInfo."ShortName" :: varchar(255), --as "DistributorShipToWardsShortName",
        shiptoInfo."Street" :: varchar(255), --as "DistributorShipToStreet",
        shiptoInfo."DepartmentNumber" :: varchar(255), --as "DistributorShipToDeptNo",
        shiptoInfo."Long" :: varchar(255), --as "DistributorShipToLongtiue",
        shiptoInfo."Lat" :: varchar(255), --as "DistributorShipToLattitue",
        itemGroup."Code" :: varchar(100), --as "ItemGroupId",
        itemGroup."Description" :: varchar(255), --as "ItemGroupDesc",
        itemSetting1."AttributeId" :: varchar(100), --as "InventoryAttributeId1",
        itemSetting1."AttributeName" :: varchar(255), --as "InventoryAttributeName1",
        itemSetting1."Description" :: varchar(255), --as "InventoryAttributeDesc1",
        itemAttribute1."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId1",
        itemAttribute1."Description" :: varchar(255), --as "InventoryAttributeValueDesc1",
        itemSetting2."AttributeId" :: varchar(100), --as "InventoryAttributeId2",
        itemSetting2."AttributeName" :: varchar(255), --as "InventoryAttributeName2",
        itemSetting2."Description" :: varchar(255), --as "InventoryAttributeDesc2",
        itemAttribute2."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId2",
        itemAttribute2."Description" :: varchar(255), --as "InventoryAttributeValueDesc2",
        itemSetting3."AttributeId" :: varchar(100), --as "InventoryAttributeId3",
        itemSetting3."AttributeName" :: varchar(255), --as "InventoryAttributeName3",
        itemSetting3."Description" :: varchar(255), --as "InventoryAttributeDesc3",
        itemAttribute3."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId3",
        itemAttribute3."Description" :: varchar(255), --as "InventoryAttributeValueDesc3",
        itemSetting4."AttributeId" :: varchar(100), --as "InventoryAttributeId4",
        itemSetting4."AttributeName" :: varchar(255), --as "InventoryAttributeName4",
        itemSetting4."Description" :: varchar(255), --as "InventoryAttributeDesc4",
        itemAttribute4."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId4",
        itemAttribute4."Description" :: varchar(255), --as "InventoryAttributeValueDesc4",
        itemSetting5."AttributeId" :: varchar(100), --as "InventoryAttributeId5",
        itemSetting5."AttributeName" :: varchar(255), --as "InventoryAttributeName5",
        itemSetting5."Description" :: varchar(255), --as "InventoryAttributeDesc5",
        itemAttribute5."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId5",
        itemAttribute5."Description" :: varchar(255), --as "InventoryAttributeValueDesc5",
        itemSetting6."AttributeId" :: varchar(100), --as "InventoryAttributeId6",
        itemSetting6."AttributeName" :: varchar(255), --as "InventoryAttributeName6",
        itemSetting6."Description" :: varchar(255), --as "InventoryAttributeDesc6",
        itemAttribute6."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId6",
        itemAttribute6."Description" :: varchar(255), --as "InventoryAttributeValueDesc6",
        itemSetting7."AttributeId" :: varchar(100), --as "InventoryAttributeId7",
        itemSetting7."AttributeName" :: varchar(255), --as "InventoryAttributeName7",
        itemSetting7."Description" :: varchar(255), --as "InventoryAttributeDesc7",
        itemAttribute7."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId7",
        itemAttribute7."Description" :: varchar(255), --as "InventoryAttributeValueDesc7",
        itemSetting8."AttributeId" :: varchar(100), --as "InventoryAttributeId8",
        itemSetting8."AttributeName" :: varchar(255), --as "InventoryAttributeName8",
        itemSetting8."Description" :: varchar(255), --as "InventoryAttributeDesc8",
        itemAttribute8."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId8",
        itemAttribute8."Description" :: varchar(255), --as "InventoryAttributeValueDesc8",
        itemSetting9."AttributeId" :: varchar(100), --as "InventoryAttributeId9",
        itemSetting9."AttributeName" :: varchar(255), --as "InventoryAttributeName9",
        itemSetting9."Description" :: varchar(255), --as "InventoryAttributeDesc9",
        itemAttribute9."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId9",
        itemAttribute9."Description" :: varchar(255), --as "InventoryAttributeValueDesc9",
        itemSetting10."AttributeId" :: varchar(100), --as "InventoryAttributeId10",
        itemSetting10."AttributeName" :: varchar(255), --as "InventoryAttributeName10",
        itemSetting10."Description" :: varchar(255), --as "InventoryAttributeDesc10",
        itemAttribute10."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId10",
        itemAttribute10."Description" :: varchar(255), --as "InventoryAttributeValueDesc10",
        inventoryItem."Hierarchy" :: uuid, --as "Hierarchy",
        invtransaction."TransactionDate" :: timestamp, --as "CreatedDate",
        invtransaction."UpdatedDate" :: timestamp, --as "UpdatedDate",
        invtransaction."CreatedBy" :: character varying(250), --as "CreatedBy",
        NULL :: character varying(250), --as "UpdatedBy",
        invtransaction."IsDeleted" :: boolean, -- as "IsDeleted"
        salesOrgInfo."Code" :: varchar(100),
        salesOrgInfo."Description" :: varchar(255),
        case when branchValue."TerritoryValueKey" IS NOT NULL then branchValue."TerritoryValueKey" else null end :: varchar(100),
        case when branchValue."Name" IS NOT NULL then branchValue."Name" else null end :: varchar(255),
        case when regionValue."TerritoryValueKey" IS NOT NULL then regionValue."TerritoryValueKey" else null end :: varchar(100),
        case when regionValue."Name" IS NOT NULL then regionValue."Name" else null end :: varchar(255),
        case when subRegionValue."TerritoryValueKey" IS NOT NULL then subRegionValue."TerritoryValueKey" else null end :: varchar(100),
        case when subRegionValue."Name" IS NOT NULL then subRegionValue."Name" else null end :: varchar(255),
        case when areaValue."TerritoryValueKey" IS NOT NULL then areaValue."TerritoryValueKey" else null end :: varchar(100),
        case when areaValue."Name" IS NOT NULL then areaValue."Name" else null end :: varchar(255),
        case when subAreaValue."TerritoryValueKey" IS NOT NULL then subAreaValue."TerritoryValueKey" else null end :: varchar(100),
        case when subAreaValue."Name" IS NOT NULL then subAreaValue."Name" else null end :: varchar(255),
        dsaInfo."Code" :: varchar(100),
        dsaInfo."Description" :: varchar(255),
		case when routezoneInfo."RouteZoneCode" IS NOT NULL then routezoneInfo."RouteZoneCode" else null end :: varchar(100),
        case when routezoneInfo."Description" IS NOT NULL then routezoneInfo."Description" else null end :: varchar(255)
    From 
        "INV_AdjustmentDetails" as invtransaction
        join "InventoryItems" as inventoryItem on inventoryItem."InventoryItemId" = invtransaction."ItemCode"
		left join "ItemsUOMConversions" as salesconvs on salesconvs."ItemID" = inventoryItem."Id"
		and salesconvs."FromUnit" = inventoryItem."SalesUnit" 
		and salesconvs."ToUnit" = inventoryItem."BaseUnit"
		Join "Uoms" as salesuom on salesuom."Id" = inventoryItem."SalesUnit"
		Join "Uoms" as purchaseuom on purchaseuom."Id" = inventoryItem."PurchaseUnit"
		Join "Uoms" as baseuom on baseuom."Id" = inventoryItem."BaseUnit"
		left join "ItemsUOMConversions" as purchaseconvs on purchaseconvs."ItemID" = inventoryItem."Id"
		and purchaseconvs."FromUnit" = inventoryItem."PurchaseUnit" 
		and purchaseconvs."ToUnit" = inventoryItem."BaseUnit"
        join "ItemGroups" as itemGroup on itemGroup."Code" = inventoryItem."GroupId"
        join "SystemSettings" as systemsetting on systemsetting."SettingKey" = invtransaction."TransactionType"
        join "Distributors" as distributorInfo on distributorInfo."Code" = invtransaction."DistributorCode"
        left join "Countrys" as countryInfo on countryInfo."Id" = distributorInfo."BusinessAddressCountry"
        left join "States" as stateInfo on stateInfo."Id" = distributorInfo."BusinessAddressState"
        left join "Provinces" as provinceInfo on provinceInfo."Id" = distributorInfo."BusinessAddressProvince"
        left join "Districts" as districtInfo on districtInfo."Id" = distributorInfo."BusinessAddressDistrict"
        left join "Wards" as wardInfo on wardInfo."Id" = distributorInfo."BusinessAddressWard"
        left join "Citys" as cityInfo on cityInfo."Id" = distributorInfo."BusinessAddressCity"
        join "DistributorShiptos" as shiptoInfo on shiptoInfo."ShiptoCode" = invtransaction."WareHouseCode"
        and shiptoInfo."DistributorId" = distributorInfo."Id"
        left join "Countrys" as shiptoCountryInfo on shiptoCountryInfo."Id" = shiptoInfo."Country"
        left join "States" as shiptoStateInfo on shiptoStateInfo."Id" = shiptoInfo."State"
        left join "Provinces" as shiptoProvinceInfo on shiptoProvinceInfo."Id" = shiptoInfo."Province"
        left join "Districts" as shiptoDistrictInfo on shiptoDistrictInfo."Id" = shiptoInfo."District"
        left join "Wards" as shiptoWardInfo on shiptoWardInfo."Id" = shiptoInfo."Wards"
        left join "Citys" as shiptoCityInfo on shiptoCityInfo."Id" = shiptoInfo."City"
        left join "ItemAttributes" as itemAttribute1 on itemAttribute1."Id" = inventoryItem."Attribute1"
        left join "ItemSettings" as itemSetting1 on itemSetting1."AttributeId" = itemAttribute1."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute2 on itemAttribute2."Id" = inventoryItem."Attribute2"
        left join "ItemSettings" as itemSetting2 on itemSetting2."AttributeId" = itemAttribute2."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute3 on itemAttribute3."Id" = inventoryItem."Attribute3"
        left join "ItemSettings" as itemSetting3 on itemSetting3."AttributeId" = itemAttribute3."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute4 on itemAttribute4."Id" = inventoryItem."Attribute4"
        left join "ItemSettings" as itemSetting4 on itemSetting4."AttributeId" = itemAttribute4."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute5 on itemAttribute5."Id" = inventoryItem."Attribute5"
        left join "ItemSettings" as itemSetting5 on itemSetting5."AttributeId" = itemAttribute5."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute6 on itemAttribute6."Id" = inventoryItem."Attribute6"
        left join "ItemSettings" as itemSetting6 on itemSetting6."AttributeId" = itemAttribute6."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute7 on itemAttribute7."Id" = inventoryItem."Attribute7"
        left join "ItemSettings" as itemSetting7 on itemSetting7."AttributeId" = itemAttribute7."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute8 on itemAttribute8."Id" = inventoryItem."Attribute8"
        left join "ItemSettings" as itemSetting8 on itemSetting8."AttributeId" = itemAttribute8."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute9 on itemAttribute9."Id" = inventoryItem."Attribute9"
        left join "ItemSettings" as itemSetting9 on itemSetting9."AttributeId" = itemAttribute9."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute10 on itemAttribute10."Id" = inventoryItem."Attribute10"
        left join "ItemSettings" as itemSetting10 on itemSetting10."AttributeId" = itemAttribute10."ItemAttributeMaster"
        join "DSA_Deliveries" as dsaDistributor on dsaDistributor."DistributorCode" = invtransaction."DistributorCode"
		join "DSA_DistributorSellingAreas" as dsaInfo on dsaInfo."Code" = dsaDistributor."DSACode"
		join "SC_SalesOrganizationStructures" as salesOrgInfo on salesOrgInfo."Code" = dsaInfo."SOStructureCode"
		left join lateral (select * from handleterritoryvalue(dsaInfo."MappingNode")) as branchValue on branchValue."TerritoryLevelCode" = 'TL01'
		left join lateral (select * from handleterritoryvalue(dsaInfo."MappingNode")) as regionValue on regionValue."TerritoryLevelCode" = 'TL02'
		left join lateral (select * from handleterritoryvalue(dsaInfo."MappingNode")) as subRegionValue on subRegionValue."TerritoryLevelCode" = 'TL03'
		left join lateral (select * from handleterritoryvalue(dsaInfo."MappingNode")) as areaValue on areaValue."TerritoryLevelCode" = 'TL04'
		left join lateral (select * from handleterritoryvalue(dsaInfo."MappingNode")) as subAreaValue on subAreaValue."TerritoryLevelCode" = 'TL05'
		left join "RZ_RouteZoneInfomations" as routezoneInfo on routezoneInfo."Id" = (select routezoneInfo1."Id"
																					from "RZ_RouteZoneInfomations" as routezoneInfo1
																					where routezoneInfo1."DSACode" = dsaInfo."Code" 
																					and routezoneInfo1."Status" = 'Active'
																					and (CAST(routezoneInfo1."EffectiveDate" as DATE) <= CAST(baselinedate AS DATE)
																					and CAST(baselinedate AS DATE) <= CASE WHEN routezoneInfo1."ValidUntil" IS NOT NULL 
																						 							THEN CAST(routezoneInfo1."ValidUntil" AS DATE)
																													ELSE CAST(now() AS DATE)
																													END)
																					order by routezoneInfo1."EffectiveDate" desc
																					LIMIT 1)
    where 
        invtransaction."IsDeleted" = false
        and invtransaction."ItemKey" IS NOT NULL
        and CAST(baselinedate as DATE) = CAST(invtransaction."TransactionDate" as DATE)
        and invtransaction."TransactionType" = 'INV01'
;
END $func$;
SELECT
    *
FROM
    collectreceiptadjustment('2022-10-19', 'BLS1', 'Daily')
LIMIT 100;

-- Transfer
DROP FUNCTION collectreceipttransfer(baselinedate VARCHAR, settingref VARCHAR, typedata VARCHAR);
CREATE FUNCTION collectreceipttransfer(baselinedate VARCHAR, settingref VARCHAR, typedata VARCHAR) RETURNS TABLE (
    "Id" uuid,
    "BaselineDate" timestamp,
    "BaselineSettingRef" varchar(50),
    "Month" timestamp,
    "SalesPeriod" varchar(100),
    "BaseLineType" varchar(50),
    "ItemId" varchar(100),
    "InventoryShortName" varchar(255),
    "InventoryReportName" varchar(255),
    "InventoryDescription" varchar(255),
    "InQuantityType" varchar(50),
    "InQuantityTypeValue" varchar(255),
    "InQuantityTypeDesc" varchar(255),
    "InQuantity" integer,
    "InBaseUOM" varchar(255),
	"InSalesQuantity" integer,
	"InSalesUOM" varchar(100),
	"InPurchaseQuantity" integer,
	"InPurchaseUOM" varchar(100),
    "LocationId" varchar(100),
    "WareHouseId" varchar(100),
    "WareHouseName" varchar(255),
    "DistributorId" varchar(100),
    "DistributorName" varchar(255),
    "DMSCode" varchar(100),
    "PrincipalLinkedCode" varchar(100),
    "DistributorCountrysId" varchar(100),
    "DistributorCountrysDesc" varchar(255),
    "DistributorCountrysShortName" varchar(255),
    "DistributorStatesId" varchar(100),
    "DistributorStatesDesc" varchar(255),
    "DistributorStatesShortName" varchar(255),
    "DistributorProvincesId" varchar(100),
    "DistributorProvincesDesc" varchar(255),
    "DistributorProvincesShortName" varchar(255),
    "DistributorCitysId" varchar(100),
    "DistributorCitysDesc" varchar(255),
    "DistributorCitysShortName" varchar(255),
    "DistributorDistrictsId" varchar(100),
    "DistributorDistrictsDesc" varchar(255),
    "DistributorDistrictsShortName" varchar(255),
    "DistributorWardsId" varchar(100),
    "DistributorWardsDesc" varchar(255),
    "DistributorWardsShortName" varchar(255),
    "DistributorStreet" varchar(255),
    "DistributorDeptNo" varchar(255),
    "DistributorLongtiue" varchar(255),
    "DistributorLattitue" varchar(255),
    "DistributorShipToId" varchar(100),
    "ShiptoName" varchar(255),
    "ShiptoCodeOnERP" varchar(100),
    "DistributorShipToFullName" varchar(255),
    "DistributorShipToCountrysId" varchar(100),
    "DistributorShipToCountrysDesc" varchar(255),
    "DistributorShipToCountrysShortName" varchar(255),
    "DistributorShipToStatesId" varchar(100),
    "DistributorShipToStatesDesc" varchar(255),
    "DistributorShipToStatesShortName" varchar(255),
    "DistributorShipToProvincesId" varchar(100),
    "DistributorShipToProvincesDesc" varchar(255),
    "DistributorShipToProvincesShortName" varchar(255),
    "DistributorShipToCitysId" varchar(100),
    "DistributorShipToCitysDesc" varchar(255),
    "DistributorShipToCitysShortName" varchar(255),
    "DistributorShipToDistrictsId" varchar(100),
    "DistributorShipToDistrictsDesc" varchar(255),
    "DistributorShipToDistrictsShortName" varchar(255),
    "DistributorShipToWardsId" varchar(100),
    "DistributorShipToWardsDesc" varchar(255),
    "DistributorShipToWardsShortName" varchar(255),
    "DistributorShipToStreet" varchar(255),
    "DistributorShipToDeptNo" varchar(255),
    "DistributorShipToLongtiue" varchar(255),
    "DistributorShipToLattitue" varchar(255),
    "ItemGroupId" varchar(100),
    "ItemGroupDesc" varchar(255),
    "InventoryAttributeId1" varchar(100),
    "InventoryAttributeName1" varchar(255),
    "InventoryAttributeDesc1" varchar(255),
    "InventoryAttributeValueId1" varchar(100),
    "InventoryAttributeValueDesc1" varchar(255),
    "InventoryAttributeId2" varchar(100),
    "InventoryAttributeName2" varchar(255),
    "InventoryAttributeDesc2" varchar(255),
    "InventoryAttributeValueId2" varchar(100),
    "InventoryAttributeValueDesc2" varchar(255),
    "InventoryAttributeId3" varchar(100),
    "InventoryAttributeName3" varchar(255),
    "InventoryAttributeDesc3" varchar(255),
    "InventoryAttributeValueId3" varchar(100),
    "InventoryAttributeValueDesc3" varchar(255),
    "InventoryAttributeId4" varchar(100),
    "InventoryAttributeName4" varchar(255),
    "InventoryAttributeDesc4" varchar(255),
    "InventoryAttributeValueId4" varchar(100),
    "InventoryAttributeValueDesc4" varchar(255),
    "InventoryAttributeId5" varchar(100),
    "InventoryAttributeName5" varchar(255),
    "InventoryAttributeDesc5" varchar(255),
    "InventoryAttributeValueId5" varchar(100),
    "InventoryAttributeValueDesc5" varchar(255),
    "InventoryAttributeId6" varchar(100),
    "InventoryAttributeName6" varchar(255),
    "InventoryAttributeDesc6" varchar(255),
    "InventoryAttributeValueId6" varchar(100),
    "InventoryAttributeValueDesc6" varchar(255),
    "InventoryAttributeId7" varchar(100),
    "InventoryAttributeName7" varchar(255),
    "InventoryAttributeDesc7" varchar(255),
    "InventoryAttributeValueId7" varchar(100),
    "InventoryAttributeValueDesc7" varchar(255),
    "InventoryAttributeId8" varchar(100),
    "InventoryAttributeName8" varchar(255),
    "InventoryAttributeDesc8" varchar(255),
    "InventoryAttributeValueId8" varchar(100),
    "InventoryAttributeValueDesc8" varchar(255),
    "InventoryAttributeId9" varchar(100),
    "InventoryAttributeName9" varchar(255),
    "InventoryAttributeDesc9" varchar(255),
    "InventoryAttributeValueId9" varchar(100),
    "InventoryAttributeValueDesc9" varchar(255),
    "InventoryAttributeId10" varchar(100),
    "InventoryAttributeName10" varchar(255),
    "InventoryAttributeDesc10" varchar(255),
    "InventoryAttributeValueId10" varchar(100),
    "InventoryAttributeValueDesc10" varchar(255),
    "Hierarchy" uuid,
    "CreatedDate" timestamp,
    "UpdatedDate" timestamp,
    "CreatedBy" character varying(250),
    "UpdatedBy" character varying(250),
    "IsDeleted" boolean,
    "SalesOrgId" varchar(100),
    "SalesOrgDesc" varchar(255),
    "BranchId" varchar(100),
    "BranchName" varchar(255),
    "RegionId" varchar(100),
    "RegionName" varchar(255),
    "SubRegionId" varchar(100),
    "SubRegionName" varchar(255),
    "AreaId" varchar(100),
    "AreaName" varchar(255),
    "SubAreaId" varchar(100),
    "SubAreaName" varchar(255),
    "DSAId" varchar(100),
    "DSADesc" varchar(255),
	"RouteZoneId" varchar(100),
    "RouteZoneDesc" varchar(255)
) LANGUAGE plpgsql AS $func$ BEGIN
    RETURN QUERY
    Select
        uuid_generate_v4() :: uuid, --as "Id",
        CAST(baselinedate AS timestamp) :: timestamp,
        settingref :: varchar(50),
        NULL :: timestamp,
        NULL :: varchar(100),
        typedata :: varchar(50),
        inventoryItem."InventoryItemId" :: varchar(100), --as "ItemId",
        inventoryItem."ShortName" :: varchar(255), --as "InventoryShortName",
        inventoryItem."ReportName" :: varchar(255), --as "InventoryReportName",
        inventoryItem."Description" :: varchar(255), --as "InventoryDescription",
        invtransaction."TransactionType" :: varchar(50), --as "OutQuantityType",
        systemsetting."SettingValue" :: varchar(255), --as "OutQuantityTypeValue",
        systemsetting."Description" :: varchar(255), --as "OutQuantityTypeDesc",
        invtransaction."Receipt" :: integer, --as "OutQuantity",
		baseuom."UomId" :: varchar(255), --as "OutBaseUOM",
		(invtransaction."Receipt" / salesconvs."ConversionFactor") :: integer,
		salesuom."UomId":: varchar(100),
		(invtransaction."Receipt" / purchaseconvs."ConversionFactor") :: integer, 
		purchaseuom."UomId":: varchar(100),
        invtransaction."LocationCode" :: varchar(100), -- as "LocationId"
        invtransaction."WareHouseCode" :: varchar(100), --as "WareHouseId",
        shiptoInfo."ShiptoName" :: varchar(255), --as "WareHouseName",
        distributorInfo."Code" :: varchar(100), --as "DistributorId",
        distributorInfo."Name" :: varchar(255), --as "DistributorName",
        distributorInfo."DMSCode" :: varchar(100), --as "DMSCode",
        distributorInfo."PrincipalLinkedCode" :: varchar(100), --as "PrincipalLinkedCode",
        countryInfo."CountryCode" :: varchar(100), --as "DistributorCountrysId",
        countryInfo."Description" :: varchar(255), --as "DistributorCountrysDesc",
        countryInfo."ShortName" :: varchar(255), --as "DistributorCountrysShortName",
        stateInfo."StateCode" :: varchar(100), --as "DistributorStatesId",
        stateInfo."Description" :: varchar(255), --as "DistributorStatesDesc",
        stateInfo."ShortName" :: varchar(255), --as "DistributorStatesShortName",
        provinceInfo."ProvinceCode" :: varchar(100), --as "DistributorProvincesId",
        provinceInfo."Description" :: varchar(255), --as "DistributorProvincesDesc",
        provinceInfo."ShortName" :: varchar(255), --as "DistributorProvincesShortName",
        cityInfo."CityCode" :: varchar(100), --as "DistributorCitysId",
        cityInfo."Description" :: varchar(255), --as "DistributorCitysDesc",
        cityInfo."ShortName" :: varchar(255), --as "DistributorCitysShortName",
        districtInfo."DistrictCode" :: varchar(100), --as "DistributorDistrictsId",
        districtInfo."Description" :: varchar(255), --as "DistributorDistrictsDesc",
        districtInfo."ShortName" :: varchar(255), --as "DistributorDistrictsShortName",
        wardInfo."WardCode" :: varchar(100), --as "DistributorWardsId",
        wardInfo."Description" :: varchar(255), --as "DistributorWardsDesc",
        wardInfo."ShortName" :: varchar(255), --as "DistributorWardsShortName",
        distributorInfo."BusinessAddressStreet" :: varchar(255), --as "DistributorStreet",
        distributorInfo."BusinessAddressDept" :: varchar(255), --as "DistributorDeptNo",
        distributorInfo."BusinessAddressLong" :: varchar(255), --as "DistributorLongtiue",
        distributorInfo."BusinessAddressLat" :: varchar(255), --as "DistributorLattitue",
        shiptoInfo."ShiptoCode" :: varchar(100), --as "DistributorShipToId",
        shiptoInfo."ShiptoName" :: varchar(255), --as "ShiptoName",
        shiptoInfo."ShiptoCodeOnERP" :: varchar(100), --as "ShiptoCodeOnERP",
        shiptoInfo."FullName" :: varchar(255), --as "DistributorShipToFullName",
        shiptoCountryInfo."CountryCode" :: varchar(100), --as "DistributorShipToCountrysId",
        shiptoCountryInfo."Description" :: varchar(255), --as "DistributorShipToCountrysDesc",
        shiptoCountryInfo."ShortName" :: varchar(255), --as "DistributorShipToCountrysShortName",
        shiptoStateInfo."StateCode" :: varchar(100), --as "DistributorShipToStatesId",
        shiptoStateInfo."Description" :: varchar(255), --as "DistributorShipToStatesDesc",
        shiptoStateInfo."ShortName" :: varchar(255), --as "DistributorShipToStatesShortName",
        shiptoProvinceInfo."ProvinceCode" :: varchar(100), --as "DistributorShipToProvincesId",
        shiptoProvinceInfo."Description" :: varchar(255), --as "DistributorShipToProvincesDesc",
        shiptoProvinceInfo."ShortName" :: varchar(255), --as "DistributorShipToProvincesShortName",
        shiptoCityInfo."CityCode" :: varchar(100), --as "DistributorShipToCitysId",
        shiptoCityInfo."Description" :: varchar(255), --as "DistributorShipToCitysDesc",
        shiptoCityInfo."ShortName" :: varchar(255), --as "DistributorShipToCitysShortName",
        shiptoDistrictInfo."DistrictCode" :: varchar(100), --as "DistributorShipToDistrictsId",
        shiptoDistrictInfo."Description" :: varchar(255), --as "DistributorShipToDistrictsDesc",
        shiptoDistrictInfo."ShortName" :: varchar(255), --as "DistributorShipToDistrictsShortName",
        shiptoWardInfo."WardCode" :: varchar(100), --as "DistributorShipToWardsId",
        shiptoWardInfo."Description" :: varchar(255), --as "DistributorShipToWardsDesc",
        shiptoWardInfo."ShortName" :: varchar(255), --as "DistributorShipToWardsShortName",
        shiptoInfo."Street" :: varchar(255), --as "DistributorShipToStreet",
        shiptoInfo."DepartmentNumber" :: varchar(255), --as "DistributorShipToDeptNo",
        shiptoInfo."Long" :: varchar(255), --as "DistributorShipToLongtiue",
        shiptoInfo."Lat" :: varchar(255), --as "DistributorShipToLattitue",
        itemGroup."Code" :: varchar(100), --as "ItemGroupId",
        itemGroup."Description" :: varchar(255), --as "ItemGroupDesc",
        itemSetting1."AttributeId" :: varchar(100), --as "InventoryAttributeId1",
        itemSetting1."AttributeName" :: varchar(255), --as "InventoryAttributeName1",
        itemSetting1."Description" :: varchar(255), --as "InventoryAttributeDesc1",
        itemAttribute1."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId1",
        itemAttribute1."Description" :: varchar(255), --as "InventoryAttributeValueDesc1",
        itemSetting2."AttributeId" :: varchar(100), --as "InventoryAttributeId2",
        itemSetting2."AttributeName" :: varchar(255), --as "InventoryAttributeName2",
        itemSetting2."Description" :: varchar(255), --as "InventoryAttributeDesc2",
        itemAttribute2."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId2",
        itemAttribute2."Description" :: varchar(255), --as "InventoryAttributeValueDesc2",
        itemSetting3."AttributeId" :: varchar(100), --as "InventoryAttributeId3",
        itemSetting3."AttributeName" :: varchar(255), --as "InventoryAttributeName3",
        itemSetting3."Description" :: varchar(255), --as "InventoryAttributeDesc3",
        itemAttribute3."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId3",
        itemAttribute3."Description" :: varchar(255), --as "InventoryAttributeValueDesc3",
        itemSetting4."AttributeId" :: varchar(100), --as "InventoryAttributeId4",
        itemSetting4."AttributeName" :: varchar(255), --as "InventoryAttributeName4",
        itemSetting4."Description" :: varchar(255), --as "InventoryAttributeDesc4",
        itemAttribute4."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId4",
        itemAttribute4."Description" :: varchar(255), --as "InventoryAttributeValueDesc4",
        itemSetting5."AttributeId" :: varchar(100), --as "InventoryAttributeId5",
        itemSetting5."AttributeName" :: varchar(255), --as "InventoryAttributeName5",
        itemSetting5."Description" :: varchar(255), --as "InventoryAttributeDesc5",
        itemAttribute5."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId5",
        itemAttribute5."Description" :: varchar(255), --as "InventoryAttributeValueDesc5",
        itemSetting6."AttributeId" :: varchar(100), --as "InventoryAttributeId6",
        itemSetting6."AttributeName" :: varchar(255), --as "InventoryAttributeName6",
        itemSetting6."Description" :: varchar(255), --as "InventoryAttributeDesc6",
        itemAttribute6."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId6",
        itemAttribute6."Description" :: varchar(255), --as "InventoryAttributeValueDesc6",
        itemSetting7."AttributeId" :: varchar(100), --as "InventoryAttributeId7",
        itemSetting7."AttributeName" :: varchar(255), --as "InventoryAttributeName7",
        itemSetting7."Description" :: varchar(255), --as "InventoryAttributeDesc7",
        itemAttribute7."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId7",
        itemAttribute7."Description" :: varchar(255), --as "InventoryAttributeValueDesc7",
        itemSetting8."AttributeId" :: varchar(100), --as "InventoryAttributeId8",
        itemSetting8."AttributeName" :: varchar(255), --as "InventoryAttributeName8",
        itemSetting8."Description" :: varchar(255), --as "InventoryAttributeDesc8",
        itemAttribute8."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId8",
        itemAttribute8."Description" :: varchar(255), --as "InventoryAttributeValueDesc8",
        itemSetting9."AttributeId" :: varchar(100), --as "InventoryAttributeId9",
        itemSetting9."AttributeName" :: varchar(255), --as "InventoryAttributeName9",
        itemSetting9."Description" :: varchar(255), --as "InventoryAttributeDesc9",
        itemAttribute9."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId9",
        itemAttribute9."Description" :: varchar(255), --as "InventoryAttributeValueDesc9",
        itemSetting10."AttributeId" :: varchar(100), --as "InventoryAttributeId10",
        itemSetting10."AttributeName" :: varchar(255), --as "InventoryAttributeName10",
        itemSetting10."Description" :: varchar(255), --as "InventoryAttributeDesc10",
        itemAttribute10."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId10",
        itemAttribute10."Description" :: varchar(255), --as "InventoryAttributeValueDesc10",
        inventoryItem."Hierarchy" :: uuid, --as "Hierarchy",
        invtransaction."TransactionDate" :: timestamp, --as "CreatedDate",
        invtransaction."UpdatedDate" :: timestamp, --as "UpdatedDate",
        invtransaction."CreatedBy" :: character varying(250), --as "CreatedBy",
        NULL :: character varying(250), --as "UpdatedBy",
        invtransaction."IsDeleted" :: boolean, -- as "IsDeleted"
        salesOrgInfo."Code" :: varchar(100),
        salesOrgInfo."Description" :: varchar(255),
        case when branchValue."TerritoryValueKey" IS NOT NULL then branchValue."TerritoryValueKey" else null end :: varchar(100),
        case when branchValue."Name" IS NOT NULL then branchValue."Name" else null end :: varchar(255),
        case when regionValue."TerritoryValueKey" IS NOT NULL then regionValue."TerritoryValueKey" else null end :: varchar(100),
        case when regionValue."Name" IS NOT NULL then regionValue."Name" else null end :: varchar(255),
        case when subRegionValue."TerritoryValueKey" IS NOT NULL then subRegionValue."TerritoryValueKey" else null end :: varchar(100),
        case when subRegionValue."Name" IS NOT NULL then subRegionValue."Name" else null end :: varchar(255),
        case when areaValue."TerritoryValueKey" IS NOT NULL then areaValue."TerritoryValueKey" else null end :: varchar(100),
        case when areaValue."Name" IS NOT NULL then areaValue."Name" else null end :: varchar(255),
        case when subAreaValue."TerritoryValueKey" IS NOT NULL then subAreaValue."TerritoryValueKey" else null end :: varchar(100),
        case when subAreaValue."Name" IS NOT NULL then subAreaValue."Name" else null end :: varchar(255),
        dsaInfo."Code" :: varchar(100),
        dsaInfo."Description" :: varchar(255),
		case when routezoneInfo."RouteZoneCode" IS NOT NULL then routezoneInfo."RouteZoneCode" else null end :: varchar(100),
        case when routezoneInfo."Description" IS NOT NULL then routezoneInfo."Description" else null end :: varchar(255)
    From 
        "INV_WhTransferDetails" as invtransaction
        join "InventoryItems" as inventoryItem on inventoryItem."InventoryItemId" = invtransaction."ItemCode"
		left join "ItemsUOMConversions" as salesconvs on salesconvs."ItemID" = inventoryItem."Id"
		and salesconvs."FromUnit" = inventoryItem."SalesUnit" 
		and salesconvs."ToUnit" = inventoryItem."BaseUnit"
		Join "Uoms" as salesuom on salesuom."Id" = inventoryItem."SalesUnit"
		Join "Uoms" as purchaseuom on purchaseuom."Id" = inventoryItem."PurchaseUnit"
		Join "Uoms" as baseuom on baseuom."Id" = inventoryItem."BaseUnit"
		left join "ItemsUOMConversions" as purchaseconvs on purchaseconvs."ItemID" = inventoryItem."Id"
		and purchaseconvs."FromUnit" = inventoryItem."PurchaseUnit" 
		and purchaseconvs."ToUnit" = inventoryItem."BaseUnit"
        join "ItemGroups" as itemGroup on itemGroup."Code" = inventoryItem."GroupId"
        join "SystemSettings" as systemsetting on systemsetting."SettingKey" = invtransaction."TransactionType"
        join "Distributors" as distributorInfo on distributorInfo."Code" = invtransaction."DistributorCode"
        left join "Countrys" as countryInfo on countryInfo."Id" = distributorInfo."BusinessAddressCountry"
        left join "States" as stateInfo on stateInfo."Id" = distributorInfo."BusinessAddressState"
        left join "Provinces" as provinceInfo on provinceInfo."Id" = distributorInfo."BusinessAddressProvince"
        left join "Districts" as districtInfo on districtInfo."Id" = distributorInfo."BusinessAddressDistrict"
        left join "Wards" as wardInfo on wardInfo."Id" = distributorInfo."BusinessAddressWard"
        left join "Citys" as cityInfo on cityInfo."Id" = distributorInfo."BusinessAddressCity"
        join "DistributorShiptos" as shiptoInfo on shiptoInfo."ShiptoCode" = invtransaction."WareHouseCode"
        and shiptoInfo."DistributorId" = distributorInfo."Id"
        left join "Countrys" as shiptoCountryInfo on shiptoCountryInfo."Id" = shiptoInfo."Country"
        left join "States" as shiptoStateInfo on shiptoStateInfo."Id" = shiptoInfo."State"
        left join "Provinces" as shiptoProvinceInfo on shiptoProvinceInfo."Id" = shiptoInfo."Province"
        left join "Districts" as shiptoDistrictInfo on shiptoDistrictInfo."Id" = shiptoInfo."District"
        left join "Wards" as shiptoWardInfo on shiptoWardInfo."Id" = shiptoInfo."Wards"
        left join "Citys" as shiptoCityInfo on shiptoCityInfo."Id" = shiptoInfo."City"
        left join "ItemAttributes" as itemAttribute1 on itemAttribute1."Id" = inventoryItem."Attribute1"
        left join "ItemSettings" as itemSetting1 on itemSetting1."AttributeId" = itemAttribute1."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute2 on itemAttribute2."Id" = inventoryItem."Attribute2"
        left join "ItemSettings" as itemSetting2 on itemSetting2."AttributeId" = itemAttribute2."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute3 on itemAttribute3."Id" = inventoryItem."Attribute3"
        left join "ItemSettings" as itemSetting3 on itemSetting3."AttributeId" = itemAttribute3."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute4 on itemAttribute4."Id" = inventoryItem."Attribute4"
        left join "ItemSettings" as itemSetting4 on itemSetting4."AttributeId" = itemAttribute4."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute5 on itemAttribute5."Id" = inventoryItem."Attribute5"
        left join "ItemSettings" as itemSetting5 on itemSetting5."AttributeId" = itemAttribute5."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute6 on itemAttribute6."Id" = inventoryItem."Attribute6"
        left join "ItemSettings" as itemSetting6 on itemSetting6."AttributeId" = itemAttribute6."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute7 on itemAttribute7."Id" = inventoryItem."Attribute7"
        left join "ItemSettings" as itemSetting7 on itemSetting7."AttributeId" = itemAttribute7."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute8 on itemAttribute8."Id" = inventoryItem."Attribute8"
        left join "ItemSettings" as itemSetting8 on itemSetting8."AttributeId" = itemAttribute8."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute9 on itemAttribute9."Id" = inventoryItem."Attribute9"
        left join "ItemSettings" as itemSetting9 on itemSetting9."AttributeId" = itemAttribute9."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute10 on itemAttribute10."Id" = inventoryItem."Attribute10"
        left join "ItemSettings" as itemSetting10 on itemSetting10."AttributeId" = itemAttribute10."ItemAttributeMaster"
        join "DSA_Deliveries" as dsaDistributor on dsaDistributor."DistributorCode" = invtransaction."DistributorCode"
		join "DSA_DistributorSellingAreas" as dsaInfo on dsaInfo."Code" = dsaDistributor."DSACode"
		join "SC_SalesOrganizationStructures" as salesOrgInfo on salesOrgInfo."Code" = dsaInfo."SOStructureCode"
		left join lateral (select * from handleterritoryvalue(dsaInfo."MappingNode")) as branchValue on branchValue."TerritoryLevelCode" = 'TL01'
		left join lateral (select * from handleterritoryvalue(dsaInfo."MappingNode")) as regionValue on regionValue."TerritoryLevelCode" = 'TL02'
		left join lateral (select * from handleterritoryvalue(dsaInfo."MappingNode")) as subRegionValue on subRegionValue."TerritoryLevelCode" = 'TL03'
		left join lateral (select * from handleterritoryvalue(dsaInfo."MappingNode")) as areaValue on areaValue."TerritoryLevelCode" = 'TL04'
		left join lateral (select * from handleterritoryvalue(dsaInfo."MappingNode")) as subAreaValue on subAreaValue."TerritoryLevelCode" = 'TL05'
		left join "RZ_RouteZoneInfomations" as routezoneInfo on routezoneInfo."Id" = (select routezoneInfo1."Id"
																					from "RZ_RouteZoneInfomations" as routezoneInfo1
																					where routezoneInfo1."DSACode" = dsaInfo."Code" 
																					and routezoneInfo1."Status" = 'Active'
																					and (CAST(routezoneInfo1."EffectiveDate" as DATE) <= CAST(baselinedate AS DATE)
																					and CAST(baselinedate AS DATE) <= CASE WHEN routezoneInfo1."ValidUntil" IS NOT NULL 
																						 							THEN CAST(routezoneInfo1."ValidUntil" AS DATE)
																													ELSE CAST(now() AS DATE)
																													END)
																					order by routezoneInfo1."EffectiveDate" desc
																					LIMIT 1)
    where 
        invtransaction."IsDeleted" = false
        and invtransaction."ItemKey" IS NOT NULL
        and CAST(baselinedate as DATE) = CAST(invtransaction."TransactionDate" as DATE)
        and invtransaction."TransactionType" = 'INV01'
;
END $func$;
SELECT
    *
FROM
    collectreceipttransfer('2022-10-06', 'BLS1', 'Daily')
LIMIT 100;

-- Transaction
DROP FUNCTION collectreceiptinv(baselinedate VARCHAR, settingref VARCHAR, typedata VARCHAR);
CREATE FUNCTION collectreceiptinv(baselinedate VARCHAR, settingref VARCHAR, typedata VARCHAR) RETURNS TABLE (
    "Id" uuid,
    "BaselineDate" timestamp,
    "BaselineSettingRef" varchar(50),
    "Month" timestamp,
    "SalesPeriod" varchar(100),
    "BaseLineType" varchar(50),
    "ItemId" varchar(100),
    "InventoryShortName" varchar(255),
    "InventoryReportName" varchar(255),
    "InventoryDescription" varchar(255),
    "InQuantityType" varchar(50),
    "InQuantityTypeValue" varchar(255),
    "InQuantityTypeDesc" varchar(255),
    "InQuantity" integer,
    "InBaseUOM" varchar(255),
	"InSalesQuantity" integer,
	"InSalesUOM" varchar(100),
	"InPurchaseQuantity" integer,
	"InPurchaseUOM" varchar(100),
    "LocationId" varchar(100),
    "WareHouseId" varchar(100),
    "WareHouseName" varchar(255),
    "DistributorId" varchar(100),
    "DistributorName" varchar(255),
    "DMSCode" varchar(100),
    "PrincipalLinkedCode" varchar(100),
    "DistributorCountrysId" varchar(100),
    "DistributorCountrysDesc" varchar(255),
    "DistributorCountrysShortName" varchar(255),
    "DistributorStatesId" varchar(100),
    "DistributorStatesDesc" varchar(255),
    "DistributorStatesShortName" varchar(255),
    "DistributorProvincesId" varchar(100),
    "DistributorProvincesDesc" varchar(255),
    "DistributorProvincesShortName" varchar(255),
    "DistributorCitysId" varchar(100),
    "DistributorCitysDesc" varchar(255),
    "DistributorCitysShortName" varchar(255),
    "DistributorDistrictsId" varchar(100),
    "DistributorDistrictsDesc" varchar(255),
    "DistributorDistrictsShortName" varchar(255),
    "DistributorWardsId" varchar(100),
    "DistributorWardsDesc" varchar(255),
    "DistributorWardsShortName" varchar(255),
    "DistributorStreet" varchar(255),
    "DistributorDeptNo" varchar(255),
    "DistributorLongtiue" varchar(255),
    "DistributorLattitue" varchar(255),
    "DistributorShipToId" varchar(100),
    "ShiptoName" varchar(255),
    "ShiptoCodeOnERP" varchar(100),
    "DistributorShipToFullName" varchar(255),
    "DistributorShipToCountrysId" varchar(100),
    "DistributorShipToCountrysDesc" varchar(255),
    "DistributorShipToCountrysShortName" varchar(255),
    "DistributorShipToStatesId" varchar(100),
    "DistributorShipToStatesDesc" varchar(255),
    "DistributorShipToStatesShortName" varchar(255),
    "DistributorShipToProvincesId" varchar(100),
    "DistributorShipToProvincesDesc" varchar(255),
    "DistributorShipToProvincesShortName" varchar(255),
    "DistributorShipToCitysId" varchar(100),
    "DistributorShipToCitysDesc" varchar(255),
    "DistributorShipToCitysShortName" varchar(255),
    "DistributorShipToDistrictsId" varchar(100),
    "DistributorShipToDistrictsDesc" varchar(255),
    "DistributorShipToDistrictsShortName" varchar(255),
    "DistributorShipToWardsId" varchar(100),
    "DistributorShipToWardsDesc" varchar(255),
    "DistributorShipToWardsShortName" varchar(255),
    "DistributorShipToStreet" varchar(255),
    "DistributorShipToDeptNo" varchar(255),
    "DistributorShipToLongtiue" varchar(255),
    "DistributorShipToLattitue" varchar(255),
    "ItemGroupId" varchar(100),
    "ItemGroupDesc" varchar(255),
    "InventoryAttributeId1" varchar(100),
    "InventoryAttributeName1" varchar(255),
    "InventoryAttributeDesc1" varchar(255),
    "InventoryAttributeValueId1" varchar(100),
    "InventoryAttributeValueDesc1" varchar(255),
    "InventoryAttributeId2" varchar(100),
    "InventoryAttributeName2" varchar(255),
    "InventoryAttributeDesc2" varchar(255),
    "InventoryAttributeValueId2" varchar(100),
    "InventoryAttributeValueDesc2" varchar(255),
    "InventoryAttributeId3" varchar(100),
    "InventoryAttributeName3" varchar(255),
    "InventoryAttributeDesc3" varchar(255),
    "InventoryAttributeValueId3" varchar(100),
    "InventoryAttributeValueDesc3" varchar(255),
    "InventoryAttributeId4" varchar(100),
    "InventoryAttributeName4" varchar(255),
    "InventoryAttributeDesc4" varchar(255),
    "InventoryAttributeValueId4" varchar(100),
    "InventoryAttributeValueDesc4" varchar(255),
    "InventoryAttributeId5" varchar(100),
    "InventoryAttributeName5" varchar(255),
    "InventoryAttributeDesc5" varchar(255),
    "InventoryAttributeValueId5" varchar(100),
    "InventoryAttributeValueDesc5" varchar(255),
    "InventoryAttributeId6" varchar(100),
    "InventoryAttributeName6" varchar(255),
    "InventoryAttributeDesc6" varchar(255),
    "InventoryAttributeValueId6" varchar(100),
    "InventoryAttributeValueDesc6" varchar(255),
    "InventoryAttributeId7" varchar(100),
    "InventoryAttributeName7" varchar(255),
    "InventoryAttributeDesc7" varchar(255),
    "InventoryAttributeValueId7" varchar(100),
    "InventoryAttributeValueDesc7" varchar(255),
    "InventoryAttributeId8" varchar(100),
    "InventoryAttributeName8" varchar(255),
    "InventoryAttributeDesc8" varchar(255),
    "InventoryAttributeValueId8" varchar(100),
    "InventoryAttributeValueDesc8" varchar(255),
    "InventoryAttributeId9" varchar(100),
    "InventoryAttributeName9" varchar(255),
    "InventoryAttributeDesc9" varchar(255),
    "InventoryAttributeValueId9" varchar(100),
    "InventoryAttributeValueDesc9" varchar(255),
    "InventoryAttributeId10" varchar(100),
    "InventoryAttributeName10" varchar(255),
    "InventoryAttributeDesc10" varchar(255),
    "InventoryAttributeValueId10" varchar(100),
    "InventoryAttributeValueDesc10" varchar(255),
    "Hierarchy" uuid,
    "CreatedDate" timestamp,
    "UpdatedDate" timestamp,
    "CreatedBy" character varying(250),
    "UpdatedBy" character varying(250),
    "IsDeleted" boolean,
    "SalesOrgId" varchar(100),
    "SalesOrgDesc" varchar(255),
    "BranchId" varchar(100),
    "BranchName" varchar(255),
    "RegionId" varchar(100),
    "RegionName" varchar(255),
    "SubRegionId" varchar(100),
    "SubRegionName" varchar(255),
    "AreaId" varchar(100),
    "AreaName" varchar(255),
    "SubAreaId" varchar(100),
    "SubAreaName" varchar(255),
    "DSAId" varchar(100),
    "DSADesc" varchar(255),
	"RouteZoneId" varchar(100),
    "RouteZoneDesc" varchar(255)
) LANGUAGE plpgsql AS $func$ BEGIN
    RETURN QUERY
    Select
        uuid_generate_v4() :: uuid, --as "Id",
        CAST(baselinedate AS timestamp) :: timestamp,
        settingref :: varchar(50),
        NULL :: timestamp,
        NULL :: varchar(100),
        typedata :: varchar(50),
        inventoryItem."InventoryItemId" :: varchar(100), --as "ItemId",
        inventoryItem."ShortName" :: varchar(255), --as "InventoryShortName",
        inventoryItem."ReportName" :: varchar(255), --as "InventoryReportName",
        inventoryItem."Description" :: varchar(255), --as "InventoryDescription",
        invtransaction."TransactionType" :: varchar(50), --as "OutQuantityType",
        systemsetting."SettingValue" :: varchar(255), --as "OutQuantityTypeValue",
        systemsetting."Description" :: varchar(255), --as "OutQuantityTypeDesc",
        invtransaction."BaseQuantity" :: integer, --as "OutQuantity",
		baseuom."UomId" :: varchar(255), --as "OutBaseUOM",
		(invtransaction."BaseQuantity" / salesconvs."ConversionFactor") :: integer,
		salesuom."UomId":: varchar(100),
		(invtransaction."BaseQuantity" / purchaseconvs."ConversionFactor") :: integer, 
		purchaseuom."UomId":: varchar(100),
        invtransaction."LocationCode" :: varchar(100), -- as "LocationId"
        invtransaction."WareHouseCode" :: varchar(100), --as "WareHouseId",
        shiptoInfo."ShiptoName" :: varchar(255), --as "WareHouseName",
        distributorInfo."Code" :: varchar(100), --as "DistributorId",
        distributorInfo."Name" :: varchar(255), --as "DistributorName",
        distributorInfo."DMSCode" :: varchar(100), --as "DMSCode",
        distributorInfo."PrincipalLinkedCode" :: varchar(100), --as "PrincipalLinkedCode",
        countryInfo."CountryCode" :: varchar(100), --as "DistributorCountrysId",
        countryInfo."Description" :: varchar(255), --as "DistributorCountrysDesc",
        countryInfo."ShortName" :: varchar(255), --as "DistributorCountrysShortName",
        stateInfo."StateCode" :: varchar(100), --as "DistributorStatesId",
        stateInfo."Description" :: varchar(255), --as "DistributorStatesDesc",
        stateInfo."ShortName" :: varchar(255), --as "DistributorStatesShortName",
        provinceInfo."ProvinceCode" :: varchar(100), --as "DistributorProvincesId",
        provinceInfo."Description" :: varchar(255), --as "DistributorProvincesDesc",
        provinceInfo."ShortName" :: varchar(255), --as "DistributorProvincesShortName",
        cityInfo."CityCode" :: varchar(100), --as "DistributorCitysId",
        cityInfo."Description" :: varchar(255), --as "DistributorCitysDesc",
        cityInfo."ShortName" :: varchar(255), --as "DistributorCitysShortName",
        districtInfo."DistrictCode" :: varchar(100), --as "DistributorDistrictsId",
        districtInfo."Description" :: varchar(255), --as "DistributorDistrictsDesc",
        districtInfo."ShortName" :: varchar(255), --as "DistributorDistrictsShortName",
        wardInfo."WardCode" :: varchar(100), --as "DistributorWardsId",
        wardInfo."Description" :: varchar(255), --as "DistributorWardsDesc",
        wardInfo."ShortName" :: varchar(255), --as "DistributorWardsShortName",
        distributorInfo."BusinessAddressStreet" :: varchar(255), --as "DistributorStreet",
        distributorInfo."BusinessAddressDept" :: varchar(255), --as "DistributorDeptNo",
        distributorInfo."BusinessAddressLong" :: varchar(255), --as "DistributorLongtiue",
        distributorInfo."BusinessAddressLat" :: varchar(255), --as "DistributorLattitue",
        shiptoInfo."ShiptoCode" :: varchar(100), --as "DistributorShipToId",
        shiptoInfo."ShiptoName" :: varchar(255), --as "ShiptoName",
        shiptoInfo."ShiptoCodeOnERP" :: varchar(100), --as "ShiptoCodeOnERP",
        shiptoInfo."FullName" :: varchar(255), --as "DistributorShipToFullName",
        shiptoCountryInfo."CountryCode" :: varchar(100), --as "DistributorShipToCountrysId",
        shiptoCountryInfo."Description" :: varchar(255), --as "DistributorShipToCountrysDesc",
        shiptoCountryInfo."ShortName" :: varchar(255), --as "DistributorShipToCountrysShortName",
        shiptoStateInfo."StateCode" :: varchar(100), --as "DistributorShipToStatesId",
        shiptoStateInfo."Description" :: varchar(255), --as "DistributorShipToStatesDesc",
        shiptoStateInfo."ShortName" :: varchar(255), --as "DistributorShipToStatesShortName",
        shiptoProvinceInfo."ProvinceCode" :: varchar(100), --as "DistributorShipToProvincesId",
        shiptoProvinceInfo."Description" :: varchar(255), --as "DistributorShipToProvincesDesc",
        shiptoProvinceInfo."ShortName" :: varchar(255), --as "DistributorShipToProvincesShortName",
        shiptoCityInfo."CityCode" :: varchar(100), --as "DistributorShipToCitysId",
        shiptoCityInfo."Description" :: varchar(255), --as "DistributorShipToCitysDesc",
        shiptoCityInfo."ShortName" :: varchar(255), --as "DistributorShipToCitysShortName",
        shiptoDistrictInfo."DistrictCode" :: varchar(100), --as "DistributorShipToDistrictsId",
        shiptoDistrictInfo."Description" :: varchar(255), --as "DistributorShipToDistrictsDesc",
        shiptoDistrictInfo."ShortName" :: varchar(255), --as "DistributorShipToDistrictsShortName",
        shiptoWardInfo."WardCode" :: varchar(100), --as "DistributorShipToWardsId",
        shiptoWardInfo."Description" :: varchar(255), --as "DistributorShipToWardsDesc",
        shiptoWardInfo."ShortName" :: varchar(255), --as "DistributorShipToWardsShortName",
        shiptoInfo."Street" :: varchar(255), --as "DistributorShipToStreet",
        shiptoInfo."DepartmentNumber" :: varchar(255), --as "DistributorShipToDeptNo",
        shiptoInfo."Long" :: varchar(255), --as "DistributorShipToLongtiue",
        shiptoInfo."Lat" :: varchar(255), --as "DistributorShipToLattitue",
        itemGroup."Code" :: varchar(100), --as "ItemGroupId",
        itemGroup."Description" :: varchar(255), --as "ItemGroupDesc",
        itemSetting1."AttributeId" :: varchar(100), --as "InventoryAttributeId1",
        itemSetting1."AttributeName" :: varchar(255), --as "InventoryAttributeName1",
        itemSetting1."Description" :: varchar(255), --as "InventoryAttributeDesc1",
        itemAttribute1."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId1",
        itemAttribute1."Description" :: varchar(255), --as "InventoryAttributeValueDesc1",
        itemSetting2."AttributeId" :: varchar(100), --as "InventoryAttributeId2",
        itemSetting2."AttributeName" :: varchar(255), --as "InventoryAttributeName2",
        itemSetting2."Description" :: varchar(255), --as "InventoryAttributeDesc2",
        itemAttribute2."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId2",
        itemAttribute2."Description" :: varchar(255), --as "InventoryAttributeValueDesc2",
        itemSetting3."AttributeId" :: varchar(100), --as "InventoryAttributeId3",
        itemSetting3."AttributeName" :: varchar(255), --as "InventoryAttributeName3",
        itemSetting3."Description" :: varchar(255), --as "InventoryAttributeDesc3",
        itemAttribute3."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId3",
        itemAttribute3."Description" :: varchar(255), --as "InventoryAttributeValueDesc3",
        itemSetting4."AttributeId" :: varchar(100), --as "InventoryAttributeId4",
        itemSetting4."AttributeName" :: varchar(255), --as "InventoryAttributeName4",
        itemSetting4."Description" :: varchar(255), --as "InventoryAttributeDesc4",
        itemAttribute4."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId4",
        itemAttribute4."Description" :: varchar(255), --as "InventoryAttributeValueDesc4",
        itemSetting5."AttributeId" :: varchar(100), --as "InventoryAttributeId5",
        itemSetting5."AttributeName" :: varchar(255), --as "InventoryAttributeName5",
        itemSetting5."Description" :: varchar(255), --as "InventoryAttributeDesc5",
        itemAttribute5."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId5",
        itemAttribute5."Description" :: varchar(255), --as "InventoryAttributeValueDesc5",
        itemSetting6."AttributeId" :: varchar(100), --as "InventoryAttributeId6",
        itemSetting6."AttributeName" :: varchar(255), --as "InventoryAttributeName6",
        itemSetting6."Description" :: varchar(255), --as "InventoryAttributeDesc6",
        itemAttribute6."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId6",
        itemAttribute6."Description" :: varchar(255), --as "InventoryAttributeValueDesc6",
        itemSetting7."AttributeId" :: varchar(100), --as "InventoryAttributeId7",
        itemSetting7."AttributeName" :: varchar(255), --as "InventoryAttributeName7",
        itemSetting7."Description" :: varchar(255), --as "InventoryAttributeDesc7",
        itemAttribute7."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId7",
        itemAttribute7."Description" :: varchar(255), --as "InventoryAttributeValueDesc7",
        itemSetting8."AttributeId" :: varchar(100), --as "InventoryAttributeId8",
        itemSetting8."AttributeName" :: varchar(255), --as "InventoryAttributeName8",
        itemSetting8."Description" :: varchar(255), --as "InventoryAttributeDesc8",
        itemAttribute8."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId8",
        itemAttribute8."Description" :: varchar(255), --as "InventoryAttributeValueDesc8",
        itemSetting9."AttributeId" :: varchar(100), --as "InventoryAttributeId9",
        itemSetting9."AttributeName" :: varchar(255), --as "InventoryAttributeName9",
        itemSetting9."Description" :: varchar(255), --as "InventoryAttributeDesc9",
        itemAttribute9."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId9",
        itemAttribute9."Description" :: varchar(255), --as "InventoryAttributeValueDesc9",
        itemSetting10."AttributeId" :: varchar(100), --as "InventoryAttributeId10",
        itemSetting10."AttributeName" :: varchar(255), --as "InventoryAttributeName10",
        itemSetting10."Description" :: varchar(255), --as "InventoryAttributeDesc10",
        itemAttribute10."ItemAttributeCode" :: varchar(100), --as "InventoryAttributeValueId10",
        itemAttribute10."Description" :: varchar(255), --as "InventoryAttributeValueDesc10",
        inventoryItem."Hierarchy" :: uuid, --as "Hierarchy",
        invtransaction."CreatedDate" :: timestamp, --as "CreatedDate",
        invtransaction."UpdatedDate" :: timestamp, --as "UpdatedDate",
        invtransaction."CreatedBy" :: character varying(250), --as "CreatedBy",
        NULL :: character varying(250), --as "UpdatedBy",
        invtransaction."IsDeleted" :: boolean, -- as "IsDeleted"
        salesOrgInfo."Code" :: varchar(100),
        salesOrgInfo."Description" :: varchar(255),
        case when branchValue."TerritoryValueKey" IS NOT NULL then branchValue."TerritoryValueKey" else null end :: varchar(100),
        case when branchValue."Name" IS NOT NULL then branchValue."Name" else null end :: varchar(255),
        case when regionValue."TerritoryValueKey" IS NOT NULL then regionValue."TerritoryValueKey" else null end :: varchar(100),
        case when regionValue."Name" IS NOT NULL then regionValue."Name" else null end :: varchar(255),
        case when subRegionValue."TerritoryValueKey" IS NOT NULL then subRegionValue."TerritoryValueKey" else null end :: varchar(100),
        case when subRegionValue."Name" IS NOT NULL then subRegionValue."Name" else null end :: varchar(255),
        case when areaValue."TerritoryValueKey" IS NOT NULL then areaValue."TerritoryValueKey" else null end :: varchar(100),
        case when areaValue."Name" IS NOT NULL then areaValue."Name" else null end :: varchar(255),
        case when subAreaValue."TerritoryValueKey" IS NOT NULL then subAreaValue."TerritoryValueKey" else null end :: varchar(100),
        case when subAreaValue."Name" IS NOT NULL then subAreaValue."Name" else null end :: varchar(255),
        dsaInfo."Code" :: varchar(100),
        dsaInfo."Description" :: varchar(255),
		case when routezoneInfo."RouteZoneCode" IS NOT NULL then routezoneInfo."RouteZoneCode" else null end :: varchar(100),
        case when routezoneInfo."Description" IS NOT NULL then routezoneInfo."Description" else null end :: varchar(255)
    From 
        "INV_InventoryTransactions" as invtransaction
        join "InventoryItems" as inventoryItem on inventoryItem."InventoryItemId" = invtransaction."ItemCode"
		left join "ItemsUOMConversions" as salesconvs on salesconvs."ItemID" = inventoryItem."Id"
		and salesconvs."FromUnit" = inventoryItem."SalesUnit" 
		and salesconvs."ToUnit" = inventoryItem."BaseUnit"
		Join "Uoms" as salesuom on salesuom."Id" = inventoryItem."SalesUnit"
		Join "Uoms" as purchaseuom on purchaseuom."Id" = inventoryItem."PurchaseUnit"
		Join "Uoms" as baseuom on baseuom."Id" = inventoryItem."BaseUnit"
		left join "ItemsUOMConversions" as purchaseconvs on purchaseconvs."ItemID" = inventoryItem."Id"
		and purchaseconvs."FromUnit" = inventoryItem."PurchaseUnit" 
		and purchaseconvs."ToUnit" = inventoryItem."BaseUnit"
        join "ItemGroups" as itemGroup on itemGroup."Code" = inventoryItem."GroupId"
        join "SystemSettings" as systemsetting on systemsetting."SettingKey" = invtransaction."TransactionType"
        join "Distributors" as distributorInfo on distributorInfo."Code" = invtransaction."DistributorCode"
        left join "Countrys" as countryInfo on countryInfo."Id" = distributorInfo."BusinessAddressCountry"
        left join "States" as stateInfo on stateInfo."Id" = distributorInfo."BusinessAddressState"
        left join "Provinces" as provinceInfo on provinceInfo."Id" = distributorInfo."BusinessAddressProvince"
        left join "Districts" as districtInfo on districtInfo."Id" = distributorInfo."BusinessAddressDistrict"
        left join "Wards" as wardInfo on wardInfo."Id" = distributorInfo."BusinessAddressWard"
        left join "Citys" as cityInfo on cityInfo."Id" = distributorInfo."BusinessAddressCity"
        join "DistributorShiptos" as shiptoInfo on shiptoInfo."ShiptoCode" = invtransaction."WareHouseCode"
        and shiptoInfo."DistributorId" = distributorInfo."Id"
        left join "Countrys" as shiptoCountryInfo on shiptoCountryInfo."Id" = shiptoInfo."Country"
        left join "States" as shiptoStateInfo on shiptoStateInfo."Id" = shiptoInfo."State"
        left join "Provinces" as shiptoProvinceInfo on shiptoProvinceInfo."Id" = shiptoInfo."Province"
        left join "Districts" as shiptoDistrictInfo on shiptoDistrictInfo."Id" = shiptoInfo."District"
        left join "Wards" as shiptoWardInfo on shiptoWardInfo."Id" = shiptoInfo."Wards"
        left join "Citys" as shiptoCityInfo on shiptoCityInfo."Id" = shiptoInfo."City"
        left join "ItemAttributes" as itemAttribute1 on itemAttribute1."Id" = inventoryItem."Attribute1"
        left join "ItemSettings" as itemSetting1 on itemSetting1."AttributeId" = itemAttribute1."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute2 on itemAttribute2."Id" = inventoryItem."Attribute2"
        left join "ItemSettings" as itemSetting2 on itemSetting2."AttributeId" = itemAttribute2."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute3 on itemAttribute3."Id" = inventoryItem."Attribute3"
        left join "ItemSettings" as itemSetting3 on itemSetting3."AttributeId" = itemAttribute3."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute4 on itemAttribute4."Id" = inventoryItem."Attribute4"
        left join "ItemSettings" as itemSetting4 on itemSetting4."AttributeId" = itemAttribute4."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute5 on itemAttribute5."Id" = inventoryItem."Attribute5"
        left join "ItemSettings" as itemSetting5 on itemSetting5."AttributeId" = itemAttribute5."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute6 on itemAttribute6."Id" = inventoryItem."Attribute6"
        left join "ItemSettings" as itemSetting6 on itemSetting6."AttributeId" = itemAttribute6."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute7 on itemAttribute7."Id" = inventoryItem."Attribute7"
        left join "ItemSettings" as itemSetting7 on itemSetting7."AttributeId" = itemAttribute7."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute8 on itemAttribute8."Id" = inventoryItem."Attribute8"
        left join "ItemSettings" as itemSetting8 on itemSetting8."AttributeId" = itemAttribute8."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute9 on itemAttribute9."Id" = inventoryItem."Attribute9"
        left join "ItemSettings" as itemSetting9 on itemSetting9."AttributeId" = itemAttribute9."ItemAttributeMaster"
        left join "ItemAttributes" as itemAttribute10 on itemAttribute10."Id" = inventoryItem."Attribute10"
        left join "ItemSettings" as itemSetting10 on itemSetting10."AttributeId" = itemAttribute10."ItemAttributeMaster"
        join "DSA_Deliveries" as dsaDistributor on dsaDistributor."DistributorCode" = invtransaction."DistributorCode"
		join "DSA_DistributorSellingAreas" as dsaInfo on dsaInfo."Code" = dsaDistributor."DSACode"
		join "SC_SalesOrganizationStructures" as salesOrgInfo on salesOrgInfo."Code" = dsaInfo."SOStructureCode"
		left join lateral (select * from handleterritoryvalue(dsaInfo."MappingNode")) as branchValue on branchValue."TerritoryLevelCode" = 'TL01'
		left join lateral (select * from handleterritoryvalue(dsaInfo."MappingNode")) as regionValue on regionValue."TerritoryLevelCode" = 'TL02'
		left join lateral (select * from handleterritoryvalue(dsaInfo."MappingNode")) as subRegionValue on subRegionValue."TerritoryLevelCode" = 'TL03'
		left join lateral (select * from handleterritoryvalue(dsaInfo."MappingNode")) as areaValue on areaValue."TerritoryLevelCode" = 'TL04'
		left join lateral (select * from handleterritoryvalue(dsaInfo."MappingNode")) as subAreaValue on subAreaValue."TerritoryLevelCode" = 'TL05'
		left join "RZ_RouteZoneInfomations" as routezoneInfo on routezoneInfo."Id" = (select routezoneInfo1."Id"
																					from "RZ_RouteZoneInfomations" as routezoneInfo1
																					where routezoneInfo1."DSACode" = dsaInfo."Code" 
																					and routezoneInfo1."Status" = 'Active'
																					and (CAST(routezoneInfo1."EffectiveDate" as DATE) <= CAST(baselinedate AS DATE)
																					and CAST(baselinedate AS DATE) <= CASE WHEN routezoneInfo1."ValidUntil" IS NOT NULL 
																						 							THEN CAST(routezoneInfo1."ValidUntil" AS DATE)
																													ELSE CAST(now() AS DATE)
																													END)
																					order by routezoneInfo1."EffectiveDate" desc
																					LIMIT 1)
    where 
        invtransaction."IsDeleted" = false
        and CAST(baselinedate as DATE) = CAST(invtransaction."TransactionDate" as DATE)
        and (invtransaction."TransactionType" = 'INV03' 
        or invtransaction."TransactionType" = 'INV10'
        or invtransaction."TransactionType" = 'INV11'
        or invtransaction."TransactionType" = 'INV05')
;
END $func$;
SELECT
    *
FROM
    collectreceiptinv('2022-10-19', 'BLS1', 'Daily')
LIMIT 100;