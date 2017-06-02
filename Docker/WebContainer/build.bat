dotnet restore
dotnet build
dotnet publish -o:out
docker build -t webcontainer:0.1 .