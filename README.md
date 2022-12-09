## Update entity from database server

`dotnet ef dbcontext scaffold "Server=db.rdos.online;Port=5494;Database=onesdev_system;User Id=postgresrdos;Password=PAssword65464" Npgsql.EntityFrameworkCore.PostgreSQL -o Infratructure -c RDOSContext -f `



## Scaffold for RO
`dotnet ef dbcontext scaffold "Server=103.98.160.114;Port=9092;Database=onesuat_system;User Id=postgresrdos;Password=RDOSGolive2022" Npgsql.EntityFrameworkCore.PostgreSQL -o RDOSInfratructure -c RDOSContext -f `
