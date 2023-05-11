FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/HRSystem.Web.Host/HRSystem.Web.Host.csproj", "src/HRSystem.Web.Host/"]
COPY ["src/HRSystem.Web.Core/HRSystem.Web.Core.csproj", "src/HRSystem.Web.Core/"]
COPY ["src/HRSystem.Application/HRSystem.Application.csproj", "src/HRSystem.Application/"]
COPY ["src/HRSystem.Core/HRSystem.Core.csproj", "src/HRSystem.Core/"]
COPY ["src/HRSystem.EntityFrameworkCore/HRSystem.EntityFrameworkCore.csproj", "src/HRSystem.EntityFrameworkCore/"]
WORKDIR "/src/src/HRSystem.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/HRSystem.Web.Host", "src/HRSystem.Web.Host"]
COPY ["src/HRSystem.Web.Core", "src/HRSystem.Web.Core"]
COPY ["src/HRSystem.Application", "src/HRSystem.Application"]
COPY ["src/HRSystem.Core", "src/HRSystem.Core"]
COPY ["src/HRSystem.EntityFrameworkCore", "src/HRSystem.EntityFrameworkCore"]
WORKDIR "/src/src/HRSystem.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "HRSystem.Web.Host.dll"]
