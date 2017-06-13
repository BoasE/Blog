dotnet restore
dotnet build
dotnet publish -o:out
docker build -t webcontainer:0.1 -t boasbls/corehelloworld:0.1 -t eu.gcr.io/gpkubernetes/kubercore:0.1 .

