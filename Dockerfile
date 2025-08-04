FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
ENV TZ="America/New_York"
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["MonopoSaver/MonopoSaver.csproj", "MonopoSaver/"]
RUN dotnet restore "MonopoSaver/MonopoSaver.csproj"
COPY . .
WORKDIR "/src/MonopoSaver"
RUN dotnet build "MonopoSaver.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MonopoSaver.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MonopoSaver.dll"]