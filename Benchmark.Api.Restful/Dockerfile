#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Benchmark.Api.Restful/Benchmark.Api.Restful.csproj", "Benchmark.Api.Restful/"]
RUN dotnet restore "Benchmark.Api.Restful/Benchmark.Api.Restful.csproj"
COPY . .
WORKDIR "/src/Benchmark.Api.Restful"
RUN dotnet build "Benchmark.Api.Restful.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Benchmark.Api.Restful.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Benchmark.Api.Restful.dll"]