FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

RUN dotnet tool install -g Microsoft.Web.LibraryManager.Cli
RUN ln -s ~/.dotnet/tools/libman /usr/local/bin/libman

WORKDIR /src
COPY ["src/TestAutomapper.Web.Mvc/TestAutomapper.Web.Mvc.csproj", "src/TestAutomapper.Web.Mvc/"]
COPY ["src/TestAutomapper.Web.Core/TestAutomapper.Web.Core.csproj", "src/TestAutomapper.Web.Core/"]
COPY ["src/TestAutomapper.Application/TestAutomapper.Application.csproj", "src/TestAutomapper.Application/"]
COPY ["src/TestAutomapper.Core/TestAutomapper.Core.csproj", "src/TestAutomapper.Core/"]
COPY ["src/TestAutomapper.EntityFrameworkCore/TestAutomapper.EntityFrameworkCore.csproj", "src/TestAutomapper.EntityFrameworkCore/"]
WORKDIR "/src/src/TestAutomapper.Web.Mvc"
RUN dotnet restore 

WORKDIR /src
COPY ["src/TestAutomapper.Web.Mvc", "src/TestAutomapper.Web.Mvc"]
COPY ["src/TestAutomapper.Web.Core", "src/TestAutomapper.Web.Core"]
COPY ["src/TestAutomapper.Application", "src/TestAutomapper.Application"]
COPY ["src/TestAutomapper.Core", "src/TestAutomapper.Core"]
COPY ["src/TestAutomapper.EntityFrameworkCore", "src/TestAutomapper.EntityFrameworkCore"]
WORKDIR "/src/src/TestAutomapper.Web.Mvc"
RUN libman restore
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "TestAutomapper.Web.Mvc.dll"]
