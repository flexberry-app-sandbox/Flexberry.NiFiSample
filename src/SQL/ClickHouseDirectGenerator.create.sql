



CREATE TABLE "Brand" (

 "primaryKey" UUID,

 "Name" String

) ENGINE = MergeTree() ORDER BY ("primaryKey");

CREATE TABLE "BrandBuffer" as "Brand" ENGINE = Buffer(currentDatabase(), "Brand", 16, 0.1, 2, 10, 10000, 100000, 1000000);


CREATE TABLE "CarData" (

 "primaryKey" UUID,

 "BrandName" String,

 "CarNumber" String,

 "CarBody" String,

 "CarDate" DateTime,

 "SparePartName" String,

 "SparePartQuantity" Int32,

 "SparePartUsed" UInt8,

 "SparePartProducingCountryName" String

) ENGINE = MergeTree() ORDER BY ("primaryKey");

CREATE TABLE "CarDataBuffer" as "CarData" ENGINE = Buffer(currentDatabase(), "CarData", 16, 0.1, 2, 10, 10000, 100000, 1000000);


CREATE TABLE "ProducingCountry" (

 "primaryKey" UUID,

 "Name" String

) ENGINE = MergeTree() ORDER BY ("primaryKey");

CREATE TABLE "ProducingCountryBuffer" as "ProducingCountry" ENGINE = Buffer(currentDatabase(), "ProducingCountry", 16, 0.1, 2, 10, 10000, 100000, 1000000);


CREATE TABLE "SparePart" (

 "primaryKey" UUID,

 "Name" String,

 "Quantity" Int32,

 "Used" UInt8,

 "ProducingCountry_m0" UUID,

 "Car_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");

CREATE TABLE "SparePartBuffer" as "SparePart" ENGINE = Buffer(currentDatabase(), "SparePart", 16, 0.1, 2, 10, 10000, 100000, 1000000);


CREATE TABLE "Car" (

 "primaryKey" UUID,

 "CarNumber" String,

 "CarBody" String,

 "CarDate" DateTime,

 "Brand_m0" UUID

) ENGINE = MergeTree() ORDER BY ("primaryKey");

CREATE TABLE "CarBuffer" as "Car" ENGINE = Buffer(currentDatabase(), "Car", 16, 0.1, 2, 10, 10000, 100000, 1000000);




