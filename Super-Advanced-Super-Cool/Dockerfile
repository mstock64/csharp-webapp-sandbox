#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Super-Advanced-Super-Cool/Csharp-Webapp-Sandbox.csproj", "Super-Advanced-Super-Cool/"]
RUN dotnet restore "Super-Advanced-Super-Cool/Csharp-Webapp-Sandbox.csproj"
COPY . .
WORKDIR "/src/Super-Advanced-Super-Cool"
RUN dotnet build "Csharp-Webapp-Sandbox.csproj" -c Release -o /app/build

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Csharp-Webapp-Sandbox.dll"]
