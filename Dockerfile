FROM mcr.microsoft.com/dotnet/sdk:5.0 as build

ADD . /src/
WORKDIR /src
RUN dotnet publish -c Release -o published


from mcr.microsoft.com/dotnet/aspnet:5.0

COPY --from=build /src/published/ /app/
WORKDIR /app
CMD ["dotnet", "envoy_proto_api.dll"]