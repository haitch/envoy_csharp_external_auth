# Envoy External Authorization CSharp GRPC example

CSharp implementation of Envoy External Authorization with GRPC.

## Prepare ProtoBuf files
Main goal here is to generate C# version of Envoy proto files: https://github.com/envoyproxy/envoy /api/envoy/service/auth/v3/external_auth.proto

But! it has external dependencies, you will need to collect all protobuf definition from following locations
- https://github.com/prometheus/client_model/blob/master/io/prometheus/client/metrics.proto
- https://github.com/open-telemetry/opentelemetry-proto/tree/main/opentelemetry/proto
- https://github.com/googleapis/googleapis/tree/master/google/api 
- https://github.com/cncf/xds/tree/main/xds
- https://github.com/cncf/udpa/tree/main/udpa 
- https://github.com/envoyproxy/protoc-gen-validate/blob/main/validate/validate.proto 

## Pre-Compile Dependencies
```
protoc  --proto_path=./Protos --csharp_out=./gen/Envoy --csharp_opt=base_namespace=Envoy ./Protos/envoy/**/*.proto
protoc  --proto_path=./Protos --csharp_out=./gen/Udpa --csharp_opt=base_namespace=Udpa ./Protos/udpa/**/*.proto
protoc  --proto_path=./Protos --csharp_out=./gen/Opencensus --csharp_opt=base_namespace=Opencensus ./Protos/opencensus/**/*.proto
protoc  --proto_path=./Protos --csharp_out=./gen/Xds --csharp_opt=base_namespace=Xds ./Protos/xds/**/*.proto
protoc  --proto_path=./Protos --csharp_out=./gen/Io --csharp_opt=base_namespace=Io ./Protos/io/**/*.proto
protoc  --proto_path=./Protos --csharp_out=./gen/Opentelemetry --csharp_opt=base_namespace=Opentelemetry ./Protos/opentelemetry/**/*.proto
protoc  --proto_path=./Protos --csharp_out=./gen/Google --csharp_opt=base_namespace=Google ./Protos/google/**/*.proto

protoc --plugin=protoc-gen-grpc=grpc_csharp_plugin --csharp_out=./gen/Greeter/Types --grpc_out=./gen/Greeter/Services --grpc_opt=lite_client,no_server -I ./Protos --csharp_opt=base_namespace=Greeter ./Protos/greet.proto
protoc --proto_path=./Protos --csharp_out=./gen/Greeter --csharp_opt=base_namespace=Greeter ./Protos/greet.proto
```

## GRPC Service 
protobuf compile gives you most of the type definition (message in protobuf files) required, while GRPC service compile service contract (service in protobuf files).
```
dotnet-grpc add-file -i ./Protos -s Server Protos\envoy\service\auth\v3\external_auth.proto
```

## Testing

- Start Nginx as envoy upstream at port 8000
```
docker run --rm -d -p 8000:80 nginx
```

- Start external auth at port 6000, by press F5 (based on your IDE)

- Start Envoy with config
```
docker run --rm -p 8080:80 -v /Users/xxxx/code/envoy_proto_api/test/envoy.config.yaml:/etc/envoy.config.yaml envoy-frontend
```

! update test/envoy.config.yaml if you changed any ports.