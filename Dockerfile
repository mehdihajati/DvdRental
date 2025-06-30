# مرحله build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# کپی پروژه‌ها و restore
COPY UI/UI.csproj UI/
COPY DataLayer/DataLayer.csproj DataLayer/
COPY DomainLayer/DomainLayer.csproj DomainLayer/
RUN dotnet restore UI/UI.csproj

# کپی کل سورس و build
COPY . .
WORKDIR /app/UI
RUN dotnet publish -c Release -o /out

# مرحله runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /out .
ENV ASPNETCORE_URLS=http://+:80
EXPOSE 80
ENTRYPOINT ["dotnet", "UI.dll"]