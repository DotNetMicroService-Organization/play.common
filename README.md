# Play.Common 
Common libraries used by PLay Economy Services.

## Create and publish package
```powershell
$version="1.0.7"
$owner="DotNetMicroService-Organization"
dotnet pack src\Play.Common\ --configuration Release -p:PackageVersion=$version -p:RepositoryUrl=https://github.com/$owner/play.common -o ..\packages
```