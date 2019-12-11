# DAWA Replication.OData

A C# ASP.NET Web API project that exposes all data from project [DAWA-Replication](https://github.com/JO-Informatik-ApS/DAWA-Replication) as OData V4 RESTful APIs. More about OData: https://www.odata.org/

Get municipality Helsingør (kommunekode=217) example: http://xyz/odata/Kommune?$filter=Kode eq '0217'

NOTE: All files in folder JOInformatik.DawaReplication.DataAccess is a copy of same folder in [DAWA-Replication](https://github.com/JO-Informatik-ApS/DAWA-Replication).

## Introduction

Danmarks Adressers Web API (DAWA) is a project that exposes Danish address, street, city name, municipality, various geometry, and other data for everyone to search in and download to have their own copy of. DAWA has a couple of API's, one where you can do search queries, and another to replicate data. You can visit their website and read more about them and what kinds of data you have access to via their API's at [http://dawa.aws.dk/](http://dawa.aws.dk/ "Danmarks Adressers Web API").

You can also find DAWA's own client to replicate data via their API, using a Postgres database. You can read more about their implementation at [http://dawa.aws.dk/dok/guide/replikeringsklient](http://dawa.aws.dk/dok/guide/replikeringsklient).

## Getting Started

This instruction will guide you on how to setup and get the webservice running.

### Prerequisites

Get and install project [DAWA-Replication](https://github.com/JO-Informatik-ApS/DAWA-Replication) first. Fill your database with DAWA data. Then get this project.
You will at the minimum need an SQL Server version 12 paired with the latest security updates running on your system.
You will also need the .NET CORE 2.1 and .NET Framework 4.5 or higher to run this webservice.

```
SQL Server 12 or higher.
.NET Framework 4.5 or higher.
```

## Running the program

Open the Visual Studio projectfile DawaReplication.OData.sln and hit F5. See OData examples in file ReadMe.txt.

## Releases

You can find the latest source code over in [the release section](https://github.com/JakobLindekilde/DawaReplication.OData/releases)

## Issues

GeoJson: Not supported yet! The spatial support in ASP.NET Web API is limited. The problem is Microsoft.SqlServer.Types.SqlGeometry which is not serialized correct into json.

If you have any problems or difficulties running the client, feel free to [create a new issue here](https://github.com/JakobLindekilde/DawaReplication.OData/issues "Create an issue").

## Authors

* **Jakob Lindekilde**

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
