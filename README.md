# Play.Common 
Common libraries used by PLay Economy Services.

## Create and publish package
```powershell
$version="1.0.10"
$owner="DotNetMicroService-Organization"
$ph_pat="[PAT HERE]"

dotnet pack src\Play.Common\ --configuration Release -p:PackageVersion=$version -p:RepositoryUrl=https://github.com/$owner/play.common -o ..\packages

dotnet nuget push ..\packages\Play.Common.$version.nupkg --api-key $ph_pat --source "github"
```