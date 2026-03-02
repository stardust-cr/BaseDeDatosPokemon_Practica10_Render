FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Practica_10/Practica_10.csproj", "Practica_10/"]
RUN dotnet restore "Practica_10/Practica_10.csproj"
COPY . .
WORKDIR "/src/Practica_10"
RUN dotnet publish -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Practica_10.dll"]