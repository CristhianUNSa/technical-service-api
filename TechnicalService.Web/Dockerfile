FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["TechnicalService.Web/TechnicalService.Web.csproj", "TechnicalService.Web/"]
RUN dotnet restore "TechnicalService.Web/TechnicalService.Web.csproj"
COPY . .
WORKDIR "/src/TechnicalService.Web"
RUN dotnet build "TechnicalService.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "TechnicalService.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TechnicalService.Web.dll"]