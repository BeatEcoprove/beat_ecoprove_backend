FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /usr/src/app

COPY . ./

RUN dotnet restore
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /usr/src/app
COPY --from=build-env /usr/src/app/out .

ENTRYPOINT ["dotnet", "BeatEcoprove.Api.dll"]