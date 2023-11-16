FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /usr/src/app

COPY src src
COPY tests tests
COPY BeatEcoprove.sln .

RUN dotnet restore
RUN dotnet publish -c Release -o out

WORKDIR /usr/src/app/out

COPY docker/api/run-migrations.sh .

RUN chmod +x run-migrations.sh

ENTRYPOINT ["sh", "run-migrations.sh"]