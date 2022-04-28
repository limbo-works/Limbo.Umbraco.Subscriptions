@echo off
dotnet build src/Limbo.MailSystem --configuration Release /t:rebuild /t:pack -p:BuildTools=1 -p:PackageOutputPath=../../releases/nuget
dotnet build src/Limbo.MailSystem.Persisence --configuration Release /t:rebuild /t:pack -p:BuildTools=1 -p:PackageOutputPath=../../releases/nuget
dotnet build src/Limbo.Subscriptions.Persistence --configuration Release /t:rebuild /t:pack -p:BuildTools=1 -p:PackageOutputPath=../../releases/nuget
dotnet build src/Limbo.Subscriptions --configuration Release /t:rebuild /t:pack -p:BuildTools=1 -p:PackageOutputPath=../../releases/nuget
dotnet build src/Limbo.Umbraco.Subscriptions --configuration Release /t:rebuild /t:pack -p:BuildTools=1 -p:PackageOutputPath=../../releases/nuget