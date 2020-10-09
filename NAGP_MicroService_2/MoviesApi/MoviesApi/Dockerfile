FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["MoviesApi/MoviesApi.csproj", "MoviesApi/"]
RUN dotnet restore "MoviesApi/MoviesApi.csproj"
COPY . .
WORKDIR "/src/MoviesApi"
RUN dotnet build "MoviesApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MoviesApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MoviesApi.dll"]