DROP FUNCTION collectrunningsales(baselinedate VARCHAR, usename VARCHAR);
CREATE FUNCTION collectrunningsales(baselinedate VARCHAR, usename VARCHAR) RETURNS TABLE (
    "Id" uuid,
    "BaselineDate" timestamp,
    "CreatedDate" timestamp,
    "UpdatedDate" timestamp,
    "CreatedBy" varchar(255),
    "UpdatedBy" varchar(255),
    "IsDeleted" boolean,
    "ItemId" varchar(100),
    "InventoryShortName" varchar(255),
    "InventoryReportName" varchar(255),
    "InventoryDescription" varchar(255),
    "ERPId" varchar(100),
    "RunningSalesByBaseQty" integer,
    "RunningSalesBaseUOM" varchar(255),
    "RunningSalesBySalesQty" integer,
    "RunningSalesSalesUOM" varchar(255),
    "RunningSalesByPurchaseQty" integer,
    "RunningSalesPurchaseUOM" varchar(255),
    "WarehouseId" varchar(100),
    "WarehouseName" varchar(255),
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
    "DistributorLongtiue" text,
    "DistributorLattitue" text,
    "DistributorShiptoId" varchar(100),
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
    "DistributorShipToLongtiue" text,
    "DistributorShipToLattitue" text,
    "Chanels" varchar(255),
    "SubChanels" varchar(255),
    "PrincipalId" varchar(100),
    "PrincipalDesc" varchar(255),
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
    "DSADesc" varchar(255)
) LANGUAGE plpgsql AS $func$ BEGIN
	RETURN QUERY
    Select
        uuid_generate_v4() :: uuid, -- as "Id",
        CAST(baselinedate AS timestamp) :: timestamp,
        now() :: timestamp, --as "CreatedDate",
        NULL :: timestamp, --as "UpdatedDate",
        usename :: varchar(255), --as "CreatedBy",
        NULL :: varchar(255), --as "UpdatedBy",
        false as "IsDeleted",
        rawSOInfo."ItemId" :: varchar(100), --as "ItemId",
        rawSOInfo."InventoryShortName" :: varchar(255), --as "InventoryShortName",
        rawSOInfo."InventoryReportName" :: varchar(255), --as "InventoryReportName",
        rawSOInfo."InventoryDescription" :: varchar(255), --as "InventoryDescription",
        rawSOInfo."ERPId" :: varchar(100), --as "ERPId",
        rawSOInfo."ShippedBaseQuantities" :: integer, --as "RunningSalesByBaseQty",
        rawSOInfo."BaseUnitId" :: varchar(255), --as "RunningSalesBaseUOM",
        (rawSOInfo."ShippedBaseQuantities" / salesconvs."ConversionFactor") :: integer, -- as "RunningSalesBySalesQty",
        salesuom."UomId" :: varchar(255), --as "RunningSalesSalesUOM",
        (rawSOInfo."ShippedBaseQuantities" / purchaseconvs."ConversionFactor") :: integer, -- as "RunningSalesByPurchaseQty",
        purchaseuom."UomId" :: varchar(255), --as "RunningSalesPurchaseUOM",
        rawSOInfo."WarehouseId" :: varchar(100), --as "WarehouseId",
        rawSOInfo."WarehouseName" :: varchar(255), --as "WarehouseName",
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
        distributorInfo."BusinessAddressLong" :: text, --as "DistributorLongtiue",
        distributorInfo."BusinessAddressLat" :: text, --as "DistributorLattitue",
        shiptoInfo."ShiptoCode" :: varchar(100), --as "DistributorShiptoId",
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
        shiptoInfo."Long" :: text, --as "DistributorShipToLongtiue",
        shiptoInfo."Lat" :: text, --as "DistributorShipToLattitue",
        chanelAttribute."Code" :: varchar(255), --as "Chanels",
        subChanelAttribute."Code" :: varchar(255), --as "SubChanels",
        rawSOInfo."PrincipalId" :: varchar(100), --as "PrincipalId",
        rawSOInfo."PrincipalDesc" :: varchar(255), --as "PrincipalDesc",
        rawSOInfo."SalesOrgId" :: varchar(100), --as "SalesOrgId",
        rawSOInfo."SalesOrgDesc" :: varchar(255), --as "SalesOrgDesc",
        rawSOInfo."BranchId" :: varchar(100), --as "BranchId",
        rawSOInfo."BranchName" :: varchar(255), --as "BranchName",
        rawSOInfo."RegionId" :: varchar(100), --as "RegionId",
        rawSOInfo."RegionName" :: varchar(255), --as "RegionName",
        rawSOInfo."SubRegionId" :: varchar(100), --as "SubRegionId",
        rawSOInfo."SubRegionName" :: varchar(255), --as "SubRegionName",
        rawSOInfo."AreaId" :: varchar(100), --as "AreaId",
        rawSOInfo."AreaName" :: varchar(255), --as "AreaName",
        rawSOInfo."SubAreaId" :: varchar(100), --as "SubAreaId",
        rawSOInfo."SubAreaName" :: varchar(255), --as "SubAreaName",
        rawSOInfo."DSAId" :: varchar(100), --as "DSAId",
        rawSOInfo."DSADesc" :: varchar(255) --as "DSADesc"
    From 
        "BL_RawSOs" as rawSOInfo
        join "InventoryItems" as inventoryItem on inventoryItem."InventoryItemId" = rawSOInfo."ItemId"
        left join "ItemsUOMConversions" as salesconvs on salesconvs."ItemID" = inventoryItem."Id"
        and salesconvs."FromUnit" = inventoryItem."SalesUnit" 
        and salesconvs."ToUnit" = inventoryItem."BaseUnit"
        Join "Uoms" as salesuom on salesuom."Id" = inventoryItem."SalesUnit"
        Join "Uoms" as purchaseuom on purchaseuom."Id" = inventoryItem."PurchaseUnit"
        Join "Uoms" as baseuom on baseuom."Id" = inventoryItem."BaseUnit"
        left join "ItemsUOMConversions" as purchaseconvs on purchaseconvs."ItemID" = inventoryItem."Id"
        and purchaseconvs."FromUnit" = inventoryItem."PurchaseUnit" 
        and purchaseconvs."ToUnit" = inventoryItem."BaseUnit"
        join "Distributors" as distributorInfo on distributorInfo."Code" = rawSOInfo."DistributorId"
        left join "Countrys" as countryInfo on countryInfo."Id" = distributorInfo."BusinessAddressCountry"
        left join "States" as stateInfo on stateInfo."Id" = distributorInfo."BusinessAddressState"
        left join "Provinces" as provinceInfo on provinceInfo."Id" = distributorInfo."BusinessAddressProvince"
        left join "Districts" as districtInfo on districtInfo."Id" = distributorInfo."BusinessAddressDistrict"
        left join "Wards" as wardInfo on wardInfo."Id" = distributorInfo."BusinessAddressWard"
        left join "Citys" as cityInfo on cityInfo."Id" = distributorInfo."BusinessAddressCity"
        join "DistributorShiptos" as shiptoInfo on shiptoInfo."ShiptoCode" = rawSOInfo."WarehouseId"
        and shiptoInfo."DistributorId" = distributorInfo."Id"
        left join "CustomerAttributes" as chanelAttribute on chanelAttribute."Id" = shiptoInfo."Chanels"
        left join "CustomerAttributes" as subChanelAttribute on subChanelAttribute."Id" = shiptoInfo."SubChanels"
        left join "Countrys" as shiptoCountryInfo on shiptoCountryInfo."Id" = shiptoInfo."Country"
        left join "States" as shiptoStateInfo on shiptoStateInfo."Id" = shiptoInfo."State"
        left join "Provinces" as shiptoProvinceInfo on shiptoProvinceInfo."Id" = shiptoInfo."Province"
        left join "Districts" as shiptoDistrictInfo on shiptoDistrictInfo."Id" = shiptoInfo."District"
        left join "Wards" as shiptoWardInfo on shiptoWardInfo."Id" = shiptoInfo."Wards"
        left join "Citys" as shiptoCityInfo on shiptoCityInfo."Id" = shiptoInfo."City"
        Where
        CAST(baselinedate AS DATE) = CAST(rawSOInfo."BaselineDate" AS DATE)
        and (rawSOInfo."Status" = 'SO_ST_DELIVERED'
        or rawSOInfo."Status" = 'SO_ST_PARTIALDELIVERED')
;
END $func$;
SELECT
    *
FROM
    collectrunningsales('2022-11-14', 'admin')
LIMIT 100;