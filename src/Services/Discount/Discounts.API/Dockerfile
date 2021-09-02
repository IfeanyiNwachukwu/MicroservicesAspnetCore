#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Services/Discount/Discounts.API/Discounts.API.csproj", "Services/Discount/Discounts.API/"]
RUN dotnet restore "Services/Discount/Discounts.API/Discounts.API.csproj"
COPY . .
WORKDIR "/src/Services/Discount/Discounts.API"
RUN dotnet build "Discounts.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Discounts.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Discounts.API.dll"]
