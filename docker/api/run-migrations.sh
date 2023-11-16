dotnet tool install --global dotnet-ef --version 7.0.11
PATH="${PATH}:/root/.dotnet/tools"

dotnet ef database update InitialMigration --startup-project ./build/BeatEcoprove.Api/ --project ./build/BeatEcoprove.Infrastructure/

dotnet BeatEcoprove.Api.dll