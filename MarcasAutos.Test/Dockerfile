#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER app
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["MarcasAutos.Test/MarcasAutos.Test.csproj", "MarcasAutos.Test/"]
COPY ["MarcasAutos.Api/MarcasAutos.Api.csproj", "MarcasAutos.Api/"]
COPY ["MarcasAutos.Infrastructure/MarcasAutos.Infrastructure.csproj", "MarcasAutos.Infrastructure/"]
RUN dotnet restore "./MarcasAutos.Test/MarcasAutos.Test.csproj"
COPY . .
WORKDIR "/src/MarcasAutos.Test"
RUN dotnet build "./MarcasAutos.Test.csproj" -c $BUILD_CONFIGURATION -o /app/build


RUN ls -la /app/build
ENTRYPOINT ["dotnet", "test", "/src/MarcasAutos.Test/MarcasAutos.Test.csproj", "--logger", "console;verbosity=minimal"]