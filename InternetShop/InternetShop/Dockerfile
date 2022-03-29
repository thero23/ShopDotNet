#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["InternetShop/InternetShop.csproj", "InternetShop/"]
COPY ["IS.BLL/IS.BLL.csproj", "IS.BLL/"]
COPY ["IS.DAL/IS.DAL.csproj", "IS.DAL/"]
RUN dotnet restore "InternetShop/InternetShop.csproj"
COPY . .
WORKDIR "/src/InternetShop"
RUN dotnet build "InternetShop.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "InternetShop.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "InternetShop.dll"]