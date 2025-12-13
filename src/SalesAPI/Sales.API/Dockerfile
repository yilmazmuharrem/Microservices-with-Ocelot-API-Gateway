#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/SalesAPI/Sales.API/Sales.API.csproj", "src/SalesAPI/Sales.API/"]
COPY ["src/SalesAPI/Sales.API.Application/Sales.API.Application.csproj", "src/SalesAPI/Sales.API.Application/"]
COPY ["src/SalesAPI/Sales.API.Infrastructure/Sales.API.Infrastructure.csproj", "src/SalesAPI/Sales.API.Infrastructure/"]
COPY ["src/SalesAPI/Sales.API.Domain/Sales.API.Domain.csproj", "src/SalesAPI/Sales.API.Domain/"]
RUN dotnet restore "./src/SalesAPI/Sales.API/Sales.API.csproj"
COPY . .
WORKDIR "/src/src/SalesAPI/Sales.API"
RUN dotnet build "./Sales.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Sales.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Sales.API.dll"]