#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/CompanyAPI/Company.API/Company.API.csproj", "src/CompanyAPI/Company.API/"]
COPY ["src/CompanyAPI/Company.API.Application/Company.API.Application.csproj", "src/CompanyAPI/Company.API.Application/"]
COPY ["src/CompanyAPI/Company.API.Infrastructure/Company.API.Infrastructure.csproj", "src/CompanyAPI/Company.API.Infrastructure/"]
COPY ["src/CompanyAPI/Company.API.Domain/Company.API.Domain.csproj", "src/CompanyAPI/Company.API.Domain/"]
RUN dotnet restore "./src/CompanyAPI/Company.API/Company.API.csproj"
COPY . .
WORKDIR "/src/src/CompanyAPI/Company.API"
RUN dotnet build "./Company.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Company.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Company.API.dll"]