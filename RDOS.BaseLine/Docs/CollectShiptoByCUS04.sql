-- DROP FUNCTION collectshiptobycus04(salesperiod VARCHAR);
CREATE FUNCTION collectshiptobycus04(salesperiod VARCHAR) RETURNS TABLE (
  "Code" varchar(255),
  "ShiptoCode" varchar(255),
  "CustomerCode" varchar(255),
  "RawSoId" uuid
) LANGUAGE plpgsql AS $func$ BEGIN RETURN QUERY
select

  att."Code"::varchar(255),
  shipto."ShiptoCode"::varchar(255),
  cusInfo."CustomerCode"::varchar(255),
  rawSo."Id"::uuid
from
  "CustomerSettings" as cusSetting
  join "CustomerAttributes" as att on cusSetting."Id" = att."CustomerSettingId"
  and att."EffectiveDate" < now()
  and (
    att."ValidUntil" IS NULL
    or att."ValidUntil" >= now()
  )
  join "CustomerDmsAttribute" as dms on dms."CustomerAttributeId" = att."Id"
  join "CustomerShiptos" as shipto on shipto."Id" = dms."CustomerShiptoId"
  join "CustomerInformations" as cusInfo on cusInfo."Id" = shipto."CustomerInfomationId"
  left join "BL_RawSOs" as rawSo on rawSo."CustomerId" = cusInfo."CustomerCode"
  and rawSo."CustomerShiptoId" = shipto."ShiptoCode"
where
  cusSetting."AttributeID" = 'CUS04';

END $func$;

SELECT
  *
FROM
  collectshiptobycus04('SPBUHBuhBUH')
LIMIT
  100;