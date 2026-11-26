
# ETAPA 1: COMPILACION Y PUBLICACION
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

WORKDIR /src

COPY AlertaEscolar.Shared/AlertaEscolar.Shared.csproj AlertaEscolar.Shared/
COPY AlertaEscolar.Api/AlertaEscolar.Api.csproj AlertaEscolar.Api/

RUN dotnet restore AlertaEscolar.Api/AlertaEscolar.Api.csproj

COPY AlertaEscolar.Shared/ AlertaEscolar.Shared/
COPY AlertaEscolar.Api/ AlertaEscolar.Api/

RUN dotnet publish AlertaEscolar.Api/AlertaEscolar.Api.csproj \
    -c Release \
    -o /app/publish \
    --no-restore \
    /p:UseAppHost=false

# ETAPA 2: EJECUCION DE LA API
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final

WORKDIR /app

COPY --from=build /app/publish .

ENV ASPNETCORE_ENVIRONMENT=Production
ENV ASPNETCORE_HTTP_PORTS=10000

EXPOSE 10000

USER $APP_UID

ENTRYPOINT ["dotnet", "AlertaEscolar.Api.dll"]
