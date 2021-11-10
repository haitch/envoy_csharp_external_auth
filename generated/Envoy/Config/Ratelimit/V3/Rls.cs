// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/config/ratelimit/v3/rls.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Ratelimit.V3 {

  /// <summary>Holder for reflection information generated from envoy/config/ratelimit/v3/rls.proto</summary>
  public static partial class RlsReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/config/ratelimit/v3/rls.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RlsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNlbnZveS9jb25maWcvcmF0ZWxpbWl0L3YzL3Jscy5wcm90bxIZZW52b3ku",
            "Y29uZmlnLnJhdGVsaW1pdC52MxooZW52b3kvY29uZmlnL2NvcmUvdjMvY29u",
            "ZmlnX3NvdXJjZS5wcm90bxonZW52b3kvY29uZmlnL2NvcmUvdjMvZ3JwY19z",
            "ZXJ2aWNlLnByb3RvGh11ZHBhL2Fubm90YXRpb25zL3N0YXR1cy5wcm90bxoh",
            "dWRwYS9hbm5vdGF0aW9ucy92ZXJzaW9uaW5nLnByb3RvGhd2YWxpZGF0ZS92",
            "YWxpZGF0ZS5wcm90byLrAQoWUmF0ZUxpbWl0U2VydmljZUNvbmZpZxJBCgxn",
            "cnBjX3NlcnZpY2UYAiABKAsyIS5lbnZveS5jb25maWcuY29yZS52My5HcnBj",
            "U2VydmljZUII+kIFigECEAESSQoVdHJhbnNwb3J0X2FwaV92ZXJzaW9uGAQg",
            "ASgOMiAuZW52b3kuY29uZmlnLmNvcmUudjMuQXBpVmVyc2lvbkII+kIFggEC",
            "EAE6N5rFiB4yCjBlbnZveS5jb25maWcucmF0ZWxpbWl0LnYyLlJhdGVMaW1p",
            "dFNlcnZpY2VDb25maWdKBAgBEAJKBAgDEARCPQonaW8uZW52b3lwcm94eS5l",
            "bnZveS5jb25maWcucmF0ZWxpbWl0LnYzQghSbHNQcm90b1ABuoDI0QYCEAJi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Config.Core.V3.ConfigSourceReflection.Descriptor, global::Envoy.Config.Core.V3.GrpcServiceReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Udpa.Annotations.VersioningReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Ratelimit.V3.RateLimitServiceConfig), global::Envoy.Config.Ratelimit.V3.RateLimitServiceConfig.Parser, new[]{ "GrpcService", "TransportApiVersion" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Rate limit :ref:`configuration overview &lt;config_rate_limit_service>`.
  /// </summary>
  public sealed partial class RateLimitServiceConfig : pb::IMessage<RateLimitServiceConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RateLimitServiceConfig> _parser = new pb::MessageParser<RateLimitServiceConfig>(() => new RateLimitServiceConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RateLimitServiceConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Ratelimit.V3.RlsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RateLimitServiceConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RateLimitServiceConfig(RateLimitServiceConfig other) : this() {
      grpcService_ = other.grpcService_ != null ? other.grpcService_.Clone() : null;
      transportApiVersion_ = other.transportApiVersion_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RateLimitServiceConfig Clone() {
      return new RateLimitServiceConfig(this);
    }

    /// <summary>Field number for the "grpc_service" field.</summary>
    public const int GrpcServiceFieldNumber = 2;
    private global::Envoy.Config.Core.V3.GrpcService grpcService_;
    /// <summary>
    /// Specifies the gRPC service that hosts the rate limit service. The client
    /// will connect to this cluster when it needs to make rate limit service
    /// requests.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Config.Core.V3.GrpcService GrpcService {
      get { return grpcService_; }
      set {
        grpcService_ = value;
      }
    }

    /// <summary>Field number for the "transport_api_version" field.</summary>
    public const int TransportApiVersionFieldNumber = 4;
    private global::Envoy.Config.Core.V3.ApiVersion transportApiVersion_ = global::Envoy.Config.Core.V3.ApiVersion.Auto;
    /// <summary>
    /// API version for rate limit transport protocol. This describes the rate limit gRPC endpoint and
    /// version of messages used on the wire.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Config.Core.V3.ApiVersion TransportApiVersion {
      get { return transportApiVersion_; }
      set {
        transportApiVersion_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RateLimitServiceConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RateLimitServiceConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(GrpcService, other.GrpcService)) return false;
      if (TransportApiVersion != other.TransportApiVersion) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (grpcService_ != null) hash ^= GrpcService.GetHashCode();
      if (TransportApiVersion != global::Envoy.Config.Core.V3.ApiVersion.Auto) hash ^= TransportApiVersion.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (grpcService_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(GrpcService);
      }
      if (TransportApiVersion != global::Envoy.Config.Core.V3.ApiVersion.Auto) {
        output.WriteRawTag(32);
        output.WriteEnum((int) TransportApiVersion);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (grpcService_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(GrpcService);
      }
      if (TransportApiVersion != global::Envoy.Config.Core.V3.ApiVersion.Auto) {
        output.WriteRawTag(32);
        output.WriteEnum((int) TransportApiVersion);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (grpcService_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GrpcService);
      }
      if (TransportApiVersion != global::Envoy.Config.Core.V3.ApiVersion.Auto) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) TransportApiVersion);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RateLimitServiceConfig other) {
      if (other == null) {
        return;
      }
      if (other.grpcService_ != null) {
        if (grpcService_ == null) {
          GrpcService = new global::Envoy.Config.Core.V3.GrpcService();
        }
        GrpcService.MergeFrom(other.GrpcService);
      }
      if (other.TransportApiVersion != global::Envoy.Config.Core.V3.ApiVersion.Auto) {
        TransportApiVersion = other.TransportApiVersion;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 18: {
            if (grpcService_ == null) {
              GrpcService = new global::Envoy.Config.Core.V3.GrpcService();
            }
            input.ReadMessage(GrpcService);
            break;
          }
          case 32: {
            TransportApiVersion = (global::Envoy.Config.Core.V3.ApiVersion) input.ReadEnum();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 18: {
            if (grpcService_ == null) {
              GrpcService = new global::Envoy.Config.Core.V3.GrpcService();
            }
            input.ReadMessage(GrpcService);
            break;
          }
          case 32: {
            TransportApiVersion = (global::Envoy.Config.Core.V3.ApiVersion) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code