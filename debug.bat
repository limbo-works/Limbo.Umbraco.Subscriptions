@echo off
dotnet build src/Limbo.MailSystem --configuration Debug /t:rebuild /t:pack -p:BuildTools=1 -p:PackageOutputPath=../../debug/nuget
dotnet build src/Limbo.MailSystem.Persisence --configuration Debug /t:rebuild /t:pack -p:BuildTools=1 -p:PackageOutputPath=../../debug/nuget
dotnet build src/Limbo.Subscriptions.Persistence --configuration Debug /t:rebuild /t:pack -p:BuildTools=1 -p:PackageOutputPath=../../debug/nuget
dotnet build src/Limbo.Subscriptions --configuration Debug /t:rebuild /t:pack -p:BuildTools=1 -p:PackageOutputPath=../../debug/nuget
dotnet build src/Limbo.Umbraco.Subscriptions --configuration Debug /t:rebuild /t:pack -p:BuildTools=1 -p:PackageOutputPath=../../debug/nuget