FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ExoftCamp.LINQ/ExoftCamp.LINQ.csproj", "ExoftCamp.LINQ/"]
RUN dotnet restore "ExoftCamp.LINQ/ExoftCamp.LINQ.csproj"
COPY . .
WORKDIR "/src/ExoftCamp.LINQ"
RUN dotnet build "ExoftCamp.LINQ.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ExoftCamp.LINQ.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExoftCamp.LINQ.dll"]
