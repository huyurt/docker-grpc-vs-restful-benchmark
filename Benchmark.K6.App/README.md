### Docker

````bash
docker compose up -d influxdb grafana
````



````bash
docker compose run -rm k6 run /dist/???.js
````



#### InfluxDB

````bash
influx
show databases
use k6

````



### Webpack

````bash
npm run bundle
````



### Request Types

* Restful

* gRPC

* gRPC Stream



### Metrics

* Request
  * Total
* Data Received
  * Total
  * Average



### Dataset

~~Input~~ / Output:

* Tekrar eden string
  * Message: "TestDeneme"
    * x1
    * x10
    * x100
    * x1000
    * x10000

* Tekrar eden array string
  * Message: ["TestDeneme"]
    * x1
    * x10
    * x100
    * x1000
    * x10000

* Tekrar etmeyen string
  * Message: "" // tekrar etmeyen string
    * ~1KB
    * ~10KB
    * ~50KB
    * ~100KB
    * ~150KB
    * ~250KB
    * ~500KB
    * ~750KB
    * ~1MB
    * ~1.5MB
    * ~2MB
    * ~2.5MB
    * ~5MB
    * ~7.5MB
    * ~10MB
* Int array
  * Message: []
    * x10
    * x100
    * x1000
    * x10000
* Binary data
  * Message: byte[]
    * ~10KB
    * ~100KB
    * ~250KB
    * ~500KB
    * ~1MB
    * ~2.5MB
    * ~5MB
    * ~10MB
* Model
  * { "Id": long, "ReferenceKey": guid, "Name": string, "MiddleName": string, "Surname": string, "BirthDate": Date, "RegistrationTime": DateTime, "Email": string, "Phone": string, "Address": string, "TaxNo": long }
    * x1
    * x10
    * x50
    * x100
    * x250
    * x500
    * x750
    * x1000
    * x2500
    * x5000
    * x10000
