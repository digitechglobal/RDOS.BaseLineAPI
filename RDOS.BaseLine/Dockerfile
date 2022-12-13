#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
RUN apt-get update && apt-get install -y libgdiplus
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["RDOS.BaseLine/RDOS.BaseLine.csproj", "RDOS.BaseLine/"]
RUN dotnet nuget add source "https://gitlab.com:443/api/v4/projects/38158014/packages/nuget/index.json" --name nProx --username hothanhnam --password "glpat-vzJiVqEPYKLKUMfyzWv9" --store-password-in-clear-text 
RUN dotnet restore "RDOS.BaseLine/RDOS.BaseLine.csproj"
COPY . .
WORKDIR "/src/RDOS.BaseLine"
RUN dotnet build "RDOS.BaseLine.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RDOS.BaseLine.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RDOS.BaseLine.dll"]