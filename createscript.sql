DROP TABLE IF EXISTS "BL_PnM";
CREATE TABLE "public"."BL_PnM" (
"Id" uuid NOT NULL, --uuId
"SalesPeriod" varchar(255),
"CustomerId" varchar(255),
"CustomerName" varchar(255),
"CustomerShiptoId" varchar(255),
"CustomerShiptoName" varchar(255),
"ValueType" varchar(255),
"Value" numeric,
"CreatedDate" timestamp NOT NULL, --datetime
"UpdatedDate" timestamp , --datetime
"CreatedBy" varchar(255) , --varchar(255)
"UpdatedBy" varchar(255) , --varchar(255)
    CONSTRAINT "PK_BL_PnM" PRIMARY KEY ("Id")
) WITH (oids = false);



select *
from "SO_OrderItems" as item
where 

item."OrderRefNumber" = '23100031' or
item."OrderRefNumber" = '23100047' or
item."OrderRefNumber" = '23100048' or
item."OrderRefNumber" = '23100046' or
item."OrderRefNumber" = '23100059' or
item."OrderRefNumber" = '23100052' or
item."OrderRefNumber" = '23100035' or
item."OrderRefNumber" = '23100038' or
item."OrderRefNumber" = '23100053' or
item."OrderRefNumber" = '23100045' or
item."OrderRefNumber" = '23100036' or
item."OrderRefNumber" = '23100043' or
item."OrderRefNumber" = '23100033' or
item."OrderRefNumber" = '23100050' or
item."OrderRefNumber" = '23100058' or
item."OrderRefNumber" = '23100049' or
item."OrderRefNumber" = '23100056' or
item."OrderRefNumber" = '23100042' or
item."OrderRefNumber" = '23100028' or
item."OrderRefNumber" = '23100040' or
item."OrderRefNumber" = '23100039' or
item."OrderRefNumber" = '23100051' or
item."OrderRefNumber" = '23100041' or
item."OrderRefNumber" = '23100037' or
item."OrderRefNumber" = '23100032' or
item."OrderRefNumber" = '23100054' or
item."OrderRefNumber" = '23100034' or
item."OrderRefNumber" = '23100044' or
item."OrderRefNumber" = '23100029' or
item."OrderRefNumber" = '23100030'
