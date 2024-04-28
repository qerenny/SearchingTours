FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/SearchingTours/SearchingTours.csproj", "src/SearchingTours/"]
COPY ["src/Application/SearchingTours.Application/SearchingTours.Application.csproj", "src/Application/SearchingTours.Application/"]
COPY ["src/Infrastructure/SearchingTours.Infrastructure.Persistence/SearchingTours.Infrastructure.Persistence.csproj", "src/Infrastructure/SearchingTours.Infrastructure.Persistence/"]
COPY ["src/Application/SearchingTours.Application.Abstractions/SearchingTours.Application.Abstractions.csproj", "src/Application/SearchingTours.Application.Abstractions/"]
COPY ["src/Application/SearchingTours.Application.Models/SearchingTours.Application.Models.csproj", "src/Application/SearchingTours.Application.Models/"]
COPY ["src/Application/SearchingTours.Application.Contracts/SearchingTours.Application.Contracts.csproj", "src/Application/SearchingTours.Application.Contracts/"]
COPY ["src/Presentation/SearchingTours.Presentation.Http/SearchingTours.Presentation.Http.csproj", "src/Presentation/SearchingTours.Presentation.Http/"]
RUN dotnet restore "src/SearchingTours/SearchingTours.csproj"
COPY . .
WORKDIR "/src/src/SearchingTours"
RUN dotnet build "SearchingTours.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "SearchingTours.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SearchingTours.dll"]
