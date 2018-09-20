FROM microsoft/dotnet:2.1-sdk-alpine3.7 AS build
WORKDIR /app

# Copy everything else and build
COPY ./ ./
RUN dotnet restore

# Build the specific project and output it into /app/out for KintoHub to process
WORKDIR /app/sample
RUN dotnet publish -c Release -o ../out

# Runtime image
FROM microsoft/dotnet:2.1-runtime-alpine
WORKDIR /app
COPY --from=build /app/out .

EXPOSE 80

ENTRYPOINT ["dotnet", "sample.dll"]
