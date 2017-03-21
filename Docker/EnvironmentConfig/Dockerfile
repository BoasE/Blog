FROM microsoft/dotnet:1.1-runtime
WORKDIR /app
COPY out .
ENV mydb localhost
ENTRYPOINT ["dotnet", "DockerConsole.dll"]