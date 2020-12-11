#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["src/MeterReading.Web/MeterReading.Web.csproj", "src/MeterReading.Web/"]
COPY ["src/MeterReading.Application/MeterReading.Application.csproj", "src/MeterReading.Application/"]
COPY ["src/MeterReading.Domain/MeterReading.Domain.csproj", "src/MeterReading.Domain/"]
COPY ["src/MeterReading.Domain.Shared/MeterReading.Domain.Shared.csproj", "src/MeterReading.Domain.Shared/"]
COPY ["src/MeterReading.Application.Contracts/MeterReading.Application.Contracts.csproj", "src/MeterReading.Application.Contracts/"]
COPY ["src/MeterReading.HttpApi/MeterReading.HttpApi.csproj", "src/MeterReading.HttpApi/"]
COPY ["src/MeterReading.EntityFrameworkCore.DbMigrations/MeterReading.EntityFrameworkCore.DbMigrations.csproj", "src/MeterReading.EntityFrameworkCore.DbMigrations/"]
COPY ["src/MeterReading.EntityFrameworkCore/MeterReading.EntityFrameworkCore.csproj", "src/MeterReading.EntityFrameworkCore/"]
RUN dotnet restore "src/MeterReading.Web/MeterReading.Web.csproj"
COPY . .
WORKDIR "/src/src/MeterReading.Web"
RUN dotnet build "MeterReading.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MeterReading.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
RUN /bin/cp /usr/share/zoneinfo/Asia/Shanghai /etc/localtime && echo 'Asia/Shanghai' >/etc/timezone

ENTRYPOINT ["dotnet", "MeterReading.Web.dll"]