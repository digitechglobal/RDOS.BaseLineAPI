DROP FUNCTION collectsafetystock(baselinedate VARCHAR);
CREATE FUNCTION collectsafetystock(baselinedate VARCHAR) RETURNS TABLE (
    "Id" uuId, 
    "AssessmentDate" timestamp, 
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
    "CloseQuantityByBaseUOM" integer, 
    "CloseQuantityBaseUOM" varchar(100), 
    "CloseQuantityByPurchaseUOM" integer, 
    "CloseQuantityPurchaseUOM" varchar(100), 
    "RunningSalesByBaseQty" integer, 
    "RunningSalesBaseUOM" varchar(100), 
    "RunningSalesByPurchaseQty" integer, 
    "RunningSalesPurchaseUOM" varchar(100), 
    "SSKDayQtyByBaseUOM" integer, 
    "SSKDayBaseUOM" varchar(100), 
    "SSKDayQtyByPruchaseUOM" integer, 
    "SSKDayPurchaseUOM" varchar(100), 
    "Result" boolean, 
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
    "DSADesc" varchar(255), 
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
    "Hierarchy" uuid
) LANGUAGE plpgsql AS $func$ BEGIN
	RETURN QUERY
    Select
        uuid_generate_v4() :: uuId, 
        CAST(baselinedate AS timestamp) :: timestamp, --"AssessmentDate"
        NOW() :: timestamp, --"CreatedDate"
        NULL :: timestamp, --"UpdatedDate"
        runningSalesInfo."CreatedBy" :: varchar(255), --"CreatedBy"
        NULL :: varchar(255), --"UpdatedBy"
        false :: boolean, --"IsDeleted"
        runningSalesInfo."ItemId" :: varchar(100), --"ItemId"
        runningSalesInfo."InventoryShortName" :: varchar(255), --"InventoryShortName"
        runningSalesInfo."InventoryReportName" :: varchar(255), --"InventoryReportName"
        runningSalesInfo."InventoryDescription" :: varchar(255), --"InventoryDescription"
        runningSalesInfo."ERPId" :: varchar(100), --"ERPId"
        0 :: integer, --"CloseQuantityByBaseUOM"
        runningSalesInfo."RunningSalesBaseUOM" :: varchar(100), --"CloseQuantityBaseUOM"
        0 :: integer, --"CloseQuantityByPurchaseUOM"
        runningSalesInfo."RunningSalesPurchaseUOM" :: varchar(100), --"CloseQuantityPurchaseUOM"
        runningSalesInfo."RunningSalesByBaseQty" :: integer, --"RunningSalesByBaseQty"
        runningSalesInfo."RunningSalesBaseUOM" :: varchar(100), --"RunningSalesBaseUOM"
        runningSalesInfo."RunningSalesByPurchaseQty" :: integer, --"RunningSalesByPurchaseQty"
        runningSalesInfo."RunningSalesPurchaseUOM" :: varchar(100), --"RunningSalesPurchaseUOM"
        0 :: integer, --"SSKDayQtyByBaseUOM"
        runningSalesInfo."RunningSalesBaseUOM" :: varchar(100), --"SSKDayBaseUOM"
        0 :: integer, --"SSKDayQtyByPruchaseUOM"
        runningSalesInfo."RunningSalesPurchaseUOM" :: varchar(100), --"SSKDayPurchaseUOM"
        false :: boolean, --"Result"
        runningSalesInfo."WarehouseId" :: varchar(100), --"WarehouseId"
        runningSalesInfo."WarehouseName" :: varchar(255), --"WarehouseName"
        runningSalesInfo."DistributorId" :: varchar(100), --"DistributorId"
        runningSalesInfo."DistributorName" :: varchar(255), --"DistributorName"
        runningSalesInfo."DMSCode" :: varchar(100), --"DMSCode"
        runningSalesInfo."PrincipalLinkedCode" :: varchar(100),--"PrincipalLinkedCode"
        runningSalesInfo."DistributorCountrysId" :: varchar(100),--"DistributorCountrysId"
        runningSalesInfo."DistributorCountrysDesc" :: varchar(255), --"DistributorCountrysDesc"
        runningSalesInfo."DistributorCountrysShortName" :: varchar(255), --"DistributorCountrysShortName"
        runningSalesInfo."DistributorStatesId" :: varchar(100), --"DistributorStatesId"
        runningSalesInfo."DistributorStatesDesc" :: varchar(255), --"DistributorStatesDesc"
        runningSalesInfo."DistributorStatesShortName" :: varchar(255), --"DistributorStatesShortName"
        runningSalesInfo."DistributorProvincesId" :: varchar(100), --"DistributorProvincesId"
        runningSalesInfo."DistributorProvincesDesc" :: varchar(255), --"DistributorProvincesDesc"
        runningSalesInfo."DistributorProvincesShortName" :: varchar(255), --"DistributorProvincesShortName"
        runningSalesInfo."DistributorCitysId" :: varchar(100), --"DistributorCitysId"
        runningSalesInfo."DistributorCitysDesc" :: varchar(255), --"DistributorCitysDesc"
        runningSalesInfo."DistributorCitysShortName" :: varchar(255), --"DistributorCitysShortName"
        runningSalesInfo."DistributorDistrictsId" :: varchar(100), --"DistributorDistrictsId"
        runningSalesInfo."DistributorDistrictsDesc" :: varchar(255), --"DistributorDistrictsDesc"
        runningSalesInfo."DistributorDistrictsShortName" :: varchar(255), --"DistributorDistrictsShortName"
        runningSalesInfo."DistributorWardsId" :: varchar(100), --"DistributorWardsId"
        runningSalesInfo."DistributorWardsDesc" :: varchar(255), --"DistributorWardsDesc"
        runningSalesInfo."DistributorWardsShortName" :: varchar(255), --"DistributorWardsShortName"
        runningSalesInfo."DistributorStreet" :: varchar(255), --"DistributorStreet"
        runningSalesInfo."DistributorDeptNo" :: varchar(255), --"DistributorDeptNo"
        runningSalesInfo."DistributorLongtiue" :: text, --"DistributorLongtiue"
        runningSalesInfo."DistributorLattitue" :: text, --"DistributorLattitue"
        runningSalesInfo."DistributorShiptoId" :: varchar(100), --"DistributorShiptoId"
        runningSalesInfo."ShiptoName" :: varchar(255), --"ShiptoName"
        runningSalesInfo."ShiptoCodeOnERP" :: varchar(100), --"ShiptoCodeOnERP"
        runningSalesInfo."DistributorShipToFullName" :: varchar(255), --"DistributorShipToFullName"
        runningSalesInfo."DistributorShipToCountrysId" :: varchar(100), --"DistributorShipToCountrysId"
        runningSalesInfo."DistributorShipToCountrysDesc" :: varchar(255), --"DistributorShipToCountrysDesc"
        runningSalesInfo."DistributorShipToCountrysShortName" :: varchar(255), --"DistributorShipToCountrysShortName"
        runningSalesInfo."DistributorShipToStatesId" :: varchar(100), --"DistributorShipToStatesId"
        runningSalesInfo."DistributorShipToStatesDesc" :: varchar(255), --"DistributorShipToStatesDesc"
        runningSalesInfo."DistributorShipToStatesShortName" :: varchar(255), --"DistributorShipToStatesShortName"
        runningSalesInfo."DistributorShipToProvincesId" :: varchar(100), --"DistributorShipToProvincesId"
        runningSalesInfo."DistributorShipToProvincesDesc" :: varchar(255), --"DistributorShipToProvincesDesc"
        runningSalesInfo."DistributorShipToProvincesShortName" :: varchar(255), --"DistributorShipToProvincesShortName"
        runningSalesInfo."DistributorShipToCitysId" :: varchar(100), --"DistributorShipToCitysId"
        runningSalesInfo."DistributorShipToCitysDesc" :: varchar(255), --"DistributorShipToCitysDesc"
        runningSalesInfo."DistributorShipToCitysShortName" :: varchar(255), --"DistributorShipToCitysShortName"
        runningSalesInfo."DistributorShipToDistrictsId" :: varchar(100), --"DistributorShipToDistrictsId"
        runningSalesInfo."DistributorShipToDistrictsDesc" :: varchar(255), --"DistributorShipToDistrictsDesc"
        runningSalesInfo."DistributorShipToDistrictsShortName" :: varchar(255), --"DistributorShipToDistrictsShortName"
        runningSalesInfo."DistributorShipToWardsId" :: varchar(100), --"DistributorShipToWardsId"
        runningSalesInfo."DistributorShipToWardsDesc" :: varchar(255), --"DistributorShipToWardsDesc"
        runningSalesInfo."DistributorShipToWardsShortName" :: varchar(255), --"DistributorShipToWardsShortName"
        runningSalesInfo."DistributorShipToStreet" :: varchar(255), --"DistributorShipToStreet"
        runningSalesInfo."DistributorShipToDeptNo" :: varchar(255), --"DistributorShipToDeptNo"
        runningSalesInfo."DistributorShipToLongtiue" :: text, --"DistributorShipToLongtiue"
        runningSalesInfo."DistributorShipToLattitue" :: text, --"DistributorShipToLattitue"
        runningSalesInfo."Chanels" :: varchar(255), --"Chanels"
        runningSalesInfo."SubChanels" :: varchar(255), --"SubChanels"
        runningSalesInfo."PrincipalId" :: varchar(100), --"PrincipalId"
        runningSalesInfo."PrincipalDesc" :: varchar(255), --"PrincipalDesc"
        runningSalesInfo."SalesOrgId" :: varchar(100), --"SalesOrgId"
        runningSalesInfo."SalesOrgDesc" :: varchar(255), --"SalesOrgDesc"
        runningSalesInfo."BranchId" :: varchar(100), --"BranchId"
        runningSalesInfo."BranchName" :: varchar(255), --"BranchName"
        runningSalesInfo."RegionId" :: varchar(100), --"RegionId"
        runningSalesInfo."RegionName" :: varchar(255), --"RegionName"
        runningSalesInfo."SubRegionId" :: varchar(100), --"SubRegionId"
        runningSalesInfo."SubRegionName" :: varchar(255), --"SubRegionName"
        runningSalesInfo."AreaId" :: varchar(100), --"AreaId"
        runningSalesInfo."AreaName" :: varchar(255), --"AreaName"
        runningSalesInfo."SubAreaId" :: varchar(100), --"SubAreaId"
        runningSalesInfo."SubAreaName" :: varchar(255), --"SubAreaName"
        runningSalesInfo."DSAId" :: varchar(100), --"DSAId"
        runningSalesInfo."DSADesc" :: varchar(255), --"DSADesc"
        itemSetting1."AttributeId" :: varchar(100), --"InventoryAttributeId1"
        itemSetting1."AttributeName" :: varchar(255), --"InventoryAttributeName1"
        itemSetting1."Description" :: varchar(255), --"InventoryAttributeDesc1"
        itemAttribute1."ItemAttributeCode" :: varchar(100), --"InventoryAttributeValueId1"
        itemAttribute1."Description" :: varchar(255), --"InventoryAttributeValueDesc1"
        itemSetting2."AttributeId" :: varchar(100), --"InventoryAttributeId2"
        itemSetting2."AttributeName" :: varchar(255), --"InventoryAttributeName2"
        itemSetting2."Description" :: varchar(255), --"InventoryAttributeDesc2"
        itemAttribute2."ItemAttributeCode" :: varchar(100), --"InventoryAttributeValueId2"
        itemAttribute2."Description" :: varchar(255), --"InventoryAttributeValueDesc2"
        itemSetting3."AttributeId" :: varchar(100), --"InventoryAttributeId3"
        itemSetting3."AttributeName" :: varchar(255), --"InventoryAttributeName3"
        itemSetting3."Description" :: varchar(255), --"InventoryAttributeDesc3"
        itemAttribute3."ItemAttributeCode" :: varchar(100), --"InventoryAttributeValueId3"
        itemAttribute3."Description" :: varchar(255), --"InventoryAttributeValueDesc3"
        itemSetting4."AttributeId" :: varchar(100), --"InventoryAttributeId4"
        itemSetting4."AttributeName" :: varchar(255), --"InventoryAttributeName4"
        itemSetting4."Description" :: varchar(255), --"InventoryAttributeDesc4"
        itemAttribute4."ItemAttributeCode" :: varchar(100), --"InventoryAttributeValueId4"
        itemAttribute4."Description" :: varchar(255), --"InventoryAttributeValueDesc4"
        itemSetting5."AttributeId" :: varchar(100), --"InventoryAttributeId5"
        itemSetting5."AttributeName" :: varchar(255), --"InventoryAttributeName5"
        itemSetting5."Description" :: varchar(255), --"InventoryAttributeDesc5"
        itemAttribute5."ItemAttributeCode" :: varchar(100), --"InventoryAttributeValueId5"
        itemAttribute5."Description" :: varchar(255), --"InventoryAttributeValueDesc5"
        itemSetting6."AttributeId" :: varchar(100), --"InventoryAttributeId6"
        itemSetting6."AttributeName" :: varchar(255), --"InventoryAttributeName6"
        itemSetting6."Description" :: varchar(255), --"InventoryAttributeDesc6"
        itemAttribute6."ItemAttributeCode" :: varchar(100), --"InventoryAttributeValueId6"
        itemAttribute6."Description" :: varchar(255), --"InventoryAttributeValueDesc6"
        itemSetting7."AttributeId" :: varchar(100), --"InventoryAttributeId7"
        itemSetting7."AttributeName" :: varchar(255), --"InventoryAttributeName7"
        itemSetting7."Description" :: varchar(255), --"InventoryAttributeDesc7"
        itemAttribute7."ItemAttributeCode" :: varchar(100), --"InventoryAttributeValueId7"
        itemAttribute7."Description" :: varchar(255), --"InventoryAttributeValueDesc7"
        itemSetting8."AttributeId" :: varchar(100), --"InventoryAttributeId8"
        itemSetting8."AttributeName" :: varchar(255), --"InventoryAttributeName8"
        itemSetting8."Description" :: varchar(255), --"InventoryAttributeDesc8"
        itemAttribute8."ItemAttributeCode" :: varchar(100), --"InventoryAttributeValueId8"
        itemAttribute8."Description" :: varchar(255), --"InventoryAttributeValueDesc8"
        itemSetting9."AttributeId" :: varchar(100), --"InventoryAttributeId9"
        itemSetting9."AttributeName" :: varchar(255), --"InventoryAttributeName9"
        itemSetting9."Description" :: varchar(255), --"InventoryAttributeDesc9"
        itemAttribute9."ItemAttributeCode" :: varchar(100), --"InventoryAttributeValueId9"
        itemAttribute9."Description" :: varchar(255), --"InventoryAttributeValueDesc9"
        itemSetting10."AttributeId" :: varchar(100), --"InventoryAttributeId10"
        itemSetting10."AttributeName" :: varchar(255), --"InventoryAttributeName10"
        itemSetting10."Description" :: varchar(255), --"InventoryAttributeDesc10"
        itemAttribute10."ItemAttributeCode" :: varchar(100), --"InventoryAttributeValueId10"
        itemAttribute10."Description" :: varchar(255), --"InventoryAttributeValueDesc10"
        inventoryItem."Hierarchy" :: uuid
    From 
        "BL_RunningSales" as runningSalesInfo
        join "InventoryItems" as inventoryItem on inventoryItem."InventoryItemId" = runningSalesInfo."ItemId"
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
        Where
        CAST(baselinedate AS DATE) = CAST(runningSalesInfo."BaselineDate" AS DATE)
;
END $func$;
SELECT
    *
FROM
    collectsafetystock('2022-11-14')
LIMIT 100;