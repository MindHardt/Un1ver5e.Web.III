#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Un1ver5e.Web.III/Server/Un1ver5e.Web.III.Server.csproj", "Un1ver5e.Web.III/Server/"]
COPY ["Un1ver5e.Web.III/Client/Un1ver5e.Web.III.Client.csproj", "Un1ver5e.Web.III/Client/"]
COPY ["Un1ver5e.Web.III/Shared/Un1ver5e.Web.III.Shared.csproj", "Un1ver5e.Web.III/Shared/"]
RUN dotnet restore "Un1ver5e.Web.III/Server/Un1ver5e.Web.III.Server.csproj"
COPY . .
WORKDIR "/src/Un1ver5e.Web.III/Server"
RUN dotnet build "Un1ver5e.Web.III.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Un1ver5e.Web.III.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Un1ver5e.Web.III.Server.dll"]