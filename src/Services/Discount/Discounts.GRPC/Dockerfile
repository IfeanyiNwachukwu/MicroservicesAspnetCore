#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Services/Discount/Discounts.GRPC/Discounts.GRPC.csproj", "Services/Discount/Discounts.GRPC/"]
RUN dotnet restore "Services/Discount/Discounts.GRPC/Discounts.GRPC.csproj"
COPY . .
WORKDIR "/src/Services/Discount/Discounts.GRPC"
RUN dotnet build "Discounts.GRPC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Discounts.GRPC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Discounts.GRPC.dll"]
