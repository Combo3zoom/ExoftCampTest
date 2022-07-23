FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ExoftCamp.Game/ExoftCamp.Game.csproj", "ExoftCamp.Game/"]
RUN dotnet restore "ExoftCamp.Game/ExoftCamp.Game.csproj"
COPY . .
WORKDIR "/src/ExoftCamp.Game"
RUN dotnet build "ExoftCamp.Game.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ExoftCamp.Game.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExoftCamp.Game.dll"]
