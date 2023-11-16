# Build stage
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /usr/src/app

COPY . ./

RUN dotnet restore
RUN dotnet publish -c Release -o out


# FROM mcr.microsoft.com/dotnet/sdk:7.0
WORKDIR /usr/src/app/out

COPY docker/api/run-migrations.sh .
# RUN cp /usr/src/app/out .
# RUN cp /usr/src/app/src/ build/
# RUN cp /usr/src/app/docker/api/run-migrations.sh .

# COPY  --from=build-env /usr/src/app/out .
# COPY --from=build-env /usr/src/app/src/ build/
# COPY --from=build-env /usr/src/app/docker/api/run-migrations.sh .

RUN chmod +x run-migrations.sh

ENTRYPOINT ["sh", "run-migrations.sh"]