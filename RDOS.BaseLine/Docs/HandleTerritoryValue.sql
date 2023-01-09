DROP FUNCTION handleterritoryvalue(mappingnode VARCHAR);
CREATE FUNCTION handleterritoryvalue(mappingnode VARCHAR) RETURNS TABLE (
    "ParentMappingNode" varchar(100),
    "TerritoryValueKey" varchar(100),
    "TerritoryValueCode" varchar(100),
    "Name" varchar(255),
    "TerritoryLevelCode" varchar(100)
) LANGUAGE plpgsql AS $func$ BEGIN
    RETURN QUERY
    with RECURSIVE territoryValueInfo as (select terr."ParentMappingNode", terr."TerritoryValueKey", territoryValue."Code", territoryValue."Name", territoryValue."TerritoryLevelCode"
			  from "SC_TerritoryMappings" as terr
			  join "SC_TerritoryValues" as territoryValue on territoryValue."Key" = terr."TerritoryValueKey"
			  where terr."MappingNode" = mappingnode
			  UNION ALL
			  SELECT terr."ParentMappingNode", terr."TerritoryValueKey", territoryValue."Code", territoryValue."Name", territoryValue."TerritoryLevelCode"
			  FROM territoryValueInfo, "SC_TerritoryMappings" as terr
			  join "SC_TerritoryValues" as territoryValue on territoryValue."Key" = terr."TerritoryValueKey"
			  WHERE territoryValueInfo."ParentMappingNode" = terr."MappingNode"
			 )
    Select
        territoryValueInfo."ParentMappingNode" :: varchar(100),
        territoryValueInfo."TerritoryValueKey" :: varchar(100),
        territoryValueInfo."Code" :: varchar(100),
        territoryValueInfo."Name" :: varchar(100),
        territoryValueInfo."TerritoryLevelCode" :: varchar(100)
    From 
        territoryValueInfo
;
END $func$;

SELECT
    *
FROM
    handleterritoryvalue('MH0WY1BDZL7K56E8QBN8')
LIMIT 100;