FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY ["HealthNest/HealthNest.csproj", "HealthNest/"]
RUN dotnet restore "HealthNest/HealthNest.csproj"

COPY . .
WORKDIR /src/HealthNest
RUN dotnet publish "HealthNest.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app
ENV DOTNET_RUNNING_IN_CONTAINER=true

ENV PORT=8080
COPY --from=build /app/publish ./
EXPOSE 8080
ENTRYPOINT ["dotnet", "HealthNest.dll"]
