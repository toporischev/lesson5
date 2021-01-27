FROM mcr.microsoft.com/dotnet/sdk:5.0 as build
WORKDIR /app

COPY *.csproj .
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0 as publish
EXPOSE 8000
ENV ASPNETCORE_URLS=http://*:8000
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "FirstService.dll"]
