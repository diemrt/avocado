FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

ENV ASPNETCORE_URLS=http://*:80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Avocado.API/Avocado.API.csproj", "Avocado.API/"]
RUN dotnet restore "Avocado.API/Avocado.API.csproj"
COPY . .
WORKDIR "/src/Avocado.API"
RUN dotnet build "Avocado.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Avocado.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Avocado.API.dll"]
#CMD ASPNETCORE_URLS=http://*:$PORT dotnet Avocado.API.dll