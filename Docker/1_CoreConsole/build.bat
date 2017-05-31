dotnet restore
dotnet build
dotnet publish -o:out
docker build -t be_blog_first:0.1 .