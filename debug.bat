@echo off
dotnet build src/Limbo.Umbraco.Subscriptions --configuration Debug /t:rebuild /t:pack -p:BuildTools=1 -p:PackageOutputPath=../../debug/nuget