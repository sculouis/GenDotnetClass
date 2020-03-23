now=$(date +"%Y%m%d%H%M%S")
migrationTag="Create${now}"
echo $migrationTag
dotnet ef migrations add $migrationTag
dotnet ef database update