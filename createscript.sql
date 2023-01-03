DROP TABLE IF EXISTS "BL_OutletAccumulates";
CREATE TABLE "public"."BL_OutletAccumulates" (
"Id" uuid NOT NULL , --uuId
"BaselineDate"  timestamp not null, --datetime
"CustomerId"  varchar(100) , --varchar(100)
"CustomerName"  varchar(255) , --varchar(255)
"CustomerShiptoId" varchar(100) , --varchar(100)
"CustomerShiptoName" varchar(255) , --varchar(255)
"TMKProgramType" varchar(100) , --varchar(100)
"TMKProgramId" varchar(100) , --varchar(100)
"TMKProgramDesc" varchar(255) , --varchar(255)
"FrequencyType" varchar(100) , --varchar(100)
"FrequnecyValue" varchar(255) , --varchar(255)
"TMKProgramLevelId" varchar(100) , --varchar(100)
"TMKProgramLevelDesc" varchar(255) , --varchar(255)
"AccumulateType" varchar(100) , --varchar(100)
"AccuByProgTarget"  integer not null, --interger
"AccuByProgActual"  integer not null, --interger
"AccuByProgProgress"  integer not null, --interger
"ProductType" varchar(100) , --varchar(100)
"AccuProductId" varchar(100) , --varchar(100)
"AccuProductDesc" varchar(255) , --varchar(255)
"AccuByProdTarget" varchar(255) , --varchar(255)
"AccuByProdTargetUOM" varchar(255) , --varchar(255)
"AccuByProdActual"  integer not null, --interger
"AccuByProdActualUOM" varchar(255) , --varchar(255)
"AccuByProdProgress"  integer not null, --interger
"AccuWeightType" varchar(100) , --varchar(100)
"AccuWeighProductId" varchar(100) , --varchar(100)
"AccuWeighProductDesc" varchar(255) , --varchar(255)
"AccuWeightByProgTarget"  integer not null, --interger
"AccuWeightByProgTargetUOM" varchar(255) , --varchar(255)
"AccuWeightByProgActual"  integer not null, --interger
"AccuWeightByProgActualUOM" varchar(255) , --varchar(255)
"AccuWeightByProgProgress"  integer not null, --interger
"CreatedDate"  timestamp not null, --datetime
"UpdatedDate"  timestamp, --datetime
"CreatedBy" varchar(255) , --varchar(255)
"UpdatedBy" varchar(255) , --varchar(255)
"IsDeleted"  boolean, --boolean
    CONSTRAINT "PK_BL_OutletAccumulates" PRIMARY KEY ("Id")
) WITH (oids = false);



DROP TABLE IF EXISTS "BL_Histories";
CREATE TABLE "public"."BL_Histories" (
"Id" uuid NOT NULL, --uuId
"BaselineSettingRef" varchar(50) , --varchar(50)
"BaselineDate" timestamp NOT NULL, --datetime
"SalesPeriod" varchar(100) , --varchar(100)
"StartTimeDate" timestamp NOT NULL, --datetime
"EndTimeDate" timestamp NOT NULL, --datetime
"IsCompleted" boolean NOT NULL, --boolean
"Type" varchar(255) , --TypeBaseLine
"Scope" varchar(50) , --varchar(50)
"CreatedDate" timestamp NOT NULL, --datetime
"UpdatedDate" timestamp , --datetime
"CreatedBy" varchar(255) , --varchar(255)
"UpdatedBy" varchar(255) , --varchar(255)
    CONSTRAINT "PK_BL_Histories" PRIMARY KEY ("Id")
) WITH (oids = false);