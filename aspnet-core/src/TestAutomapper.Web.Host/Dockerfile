FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/TestAutomapper.Web.Host/TestAutomapper.Web.Host.csproj", "src/TestAutomapper.Web.Host/"]
COPY ["src/TestAutomapper.Web.Core/TestAutomapper.Web.Core.csproj", "src/TestAutomapper.Web.Core/"]
COPY ["src/TestAutomapper.Application/TestAutomapper.Application.csproj", "src/TestAutomapper.Application/"]
COPY ["src/TestAutomapper.Core/TestAutomapper.Core.csproj", "src/TestAutomapper.Core/"]
COPY ["src/TestAutomapper.EntityFrameworkCore/TestAutomapper.EntityFrameworkCore.csproj", "src/TestAutomapper.EntityFrameworkCore/"]
WORKDIR "/src/src/TestAutomapper.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/TestAutomapper.Web.Host", "src/TestAutomapper.Web.Host"]
COPY ["src/TestAutomapper.Web.Core", "src/TestAutomapper.Web.Core"]
COPY ["src/TestAutomapper.Application", "src/TestAutomapper.Application"]
COPY ["src/TestAutomapper.Core", "src/TestAutomapper.Core"]
COPY ["src/TestAutomapper.EntityFrameworkCore", "src/TestAutomapper.EntityFrameworkCore"]
WORKDIR "/src/src/TestAutomapper.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "TestAutomapper.Web.Host.dll"]
