FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY hello-dotnet-ms.csproj hello-dotnet-ms/
RUN dotnet restore hello-dotnet-ms/hello-dotnet-ms.csproj
WORKDIR /src/hello-dotnet-ms
COPY . .
RUN dotnet build hello-dotnet-ms.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish hello-dotnet-ms.csproj -c Release -o /app

FROM base AS final
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "hello-dotnet-ms.dll"]