// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/extensions/filters/network/thrift_proxy/filters/ratelimit/v3/rate_limit.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Extensions.Filters.Network.ThriftProxy.Filters.Ratelimit.V3 {

  /// <summary>Holder for reflection information generated from envoy/extensions/filters/network/thrift_proxy/filters/ratelimit/v3/rate_limit.proto</summary>
  public static partial class RateLimitReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/extensions/filters/network/thrift_proxy/filters/ratelimit/v3/rate_limit.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RateLimitReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ClNlbnZveS9leHRlbnNpb25zL2ZpbHRlcnMvbmV0d29yay90aHJpZnRfcHJv",
            "eHkvZmlsdGVycy9yYXRlbGltaXQvdjMvcmF0ZV9saW1pdC5wcm90bxJCZW52",
            "b3kuZXh0ZW5zaW9ucy5maWx0ZXJzLm5ldHdvcmsudGhyaWZ0X3Byb3h5LmZp",
            "bHRlcnMucmF0ZWxpbWl0LnYzGiNlbnZveS9jb25maWcvcmF0ZWxpbWl0L3Yz",
            "L3Jscy5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL2R1cmF0aW9uLnByb3RvGh11",
            "ZHBhL2Fubm90YXRpb25zL3N0YXR1cy5wcm90bxohdWRwYS9hbm5vdGF0aW9u",
            "cy92ZXJzaW9uaW5nLnByb3RvGhd2YWxpZGF0ZS92YWxpZGF0ZS5wcm90byKd",
            "AgoJUmF0ZUxpbWl0EhcKBmRvbWFpbhgBIAEoCUIH+kIEcgIQARIWCgVzdGFn",
            "ZRgCIAEoDUIH+kIEKgIYChIqCgd0aW1lb3V0GAMgASgLMhkuZ29vZ2xlLnBy",
            "b3RvYnVmLkR1cmF0aW9uEhkKEWZhaWx1cmVfbW9kZV9kZW55GAQgASgIElcK",
            "EnJhdGVfbGltaXRfc2VydmljZRgFIAEoCzIxLmVudm95LmNvbmZpZy5yYXRl",
            "bGltaXQudjMuUmF0ZUxpbWl0U2VydmljZUNvbmZpZ0II+kIFigECEAE6P5rF",
            "iB46CjhlbnZveS5jb25maWcuZmlsdGVyLnRocmlmdC5yYXRlX2xpbWl0LnYy",
            "YWxwaGExLlJhdGVMaW1pdEJsClBpby5lbnZveXByb3h5LmVudm95LmV4dGVu",
            "c2lvbnMuZmlsdGVycy5uZXR3b3JrLnRocmlmdF9wcm94eS5maWx0ZXJzLnJh",
            "dGVsaW1pdC52M0IOUmF0ZUxpbWl0UHJvdG9QAbqAyNEGAhACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Config.Ratelimit.V3.RlsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Udpa.Annotations.VersioningReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Extensions.Filters.Network.ThriftProxy.Filters.Ratelimit.V3.RateLimit), global::Envoy.Extensions.Filters.Network.ThriftProxy.Filters.Ratelimit.V3.RateLimit.Parser, new[]{ "Domain", "Stage", "Timeout", "FailureModeDeny", "RateLimitService" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// [#next-free-field: 6]
  /// </summary>
  public sealed partial class RateLimit : pb::IMessage<RateLimit>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RateLimit> _parser = new pb::MessageParser<RateLimit>(() => new RateLimit());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RateLimit> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Extensions.Filters.Network.ThriftProxy.Filters.Ratelimit.V3.RateLimitReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RateLimit() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RateLimit(RateLimit other) : this() {
      domain_ = other.domain_;
      stage_ = other.stage_;
      timeout_ = other.timeout_ != null ? other.timeout_.Clone() : null;
      failureModeDeny_ = other.failureModeDeny_;
      rateLimitService_ = other.rateLimitService_ != null ? other.rateLimitService_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RateLimit Clone() {
      return new RateLimit(this);
    }

    /// <summary>Field number for the "domain" field.</summary>
    public const int DomainFieldNumber = 1;
    private string domain_ = "";
    /// <summary>
    /// The rate limit domain to use in the rate limit service request.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Domain {
      get { return domain_; }
      set {
        domain_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "stage" field.</summary>
    public const int StageFieldNumber = 2;
    private uint stage_;
    /// <summary>
    /// Specifies the rate limit configuration stage. Each configured rate limit filter performs a
    /// rate limit check using descriptors configured in the
    /// :ref:`envoy_v3_api_msg_extensions.filters.network.thrift_proxy.v3.RouteAction` for the request.
    /// Only those entries with a matching stage number are used for a given filter. If not set, the
    /// default stage number is 0.
    ///
    /// .. note::
    ///
    ///  The filter supports a range of 0 - 10 inclusively for stage numbers.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Stage {
      get { return stage_; }
      set {
        stage_ = value;
      }
    }

    /// <summary>Field number for the "timeout" field.</summary>
    public const int TimeoutFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Duration timeout_;
    /// <summary>
    /// The timeout in milliseconds for the rate limit service RPC. If not
    /// set, this defaults to 20ms.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Duration Timeout {
      get { return timeout_; }
      set {
        timeout_ = value;
      }
    }

    /// <summary>Field number for the "failure_mode_deny" field.</summary>
    public const int FailureModeDenyFieldNumber = 4;
    private bool failureModeDeny_;
    /// <summary>
    /// The filter's behaviour in case the rate limiting service does
    /// not respond back. When it is set to true, Envoy will not allow traffic in case of
    /// communication failure between rate limiting service and the proxy.
    /// Defaults to false.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool FailureModeDeny {
      get { return failureModeDeny_; }
      set {
        failureModeDeny_ = value;
      }
    }

    /// <summary>Field number for the "rate_limit_service" field.</summary>
    public const int RateLimitServiceFieldNumber = 5;
    private global::Envoy.Config.Ratelimit.V3.RateLimitServiceConfig rateLimitService_;
    /// <summary>
    /// Configuration for an external rate limit service provider. If not
    /// specified, any calls to the rate limit service will immediately return
    /// success.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Config.Ratelimit.V3.RateLimitServiceConfig RateLimitService {
      get { return rateLimitService_; }
      set {
        rateLimitService_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RateLimit);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RateLimit other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Domain != other.Domain) return false;
      if (Stage != other.Stage) return false;
      if (!object.Equals(Timeout, other.Timeout)) return false;
      if (FailureModeDeny != other.FailureModeDeny) return false;
      if (!object.Equals(RateLimitService, other.RateLimitService)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Domain.Length != 0) hash ^= Domain.GetHashCode();
      if (Stage != 0) hash ^= Stage.GetHashCode();
      if (timeout_ != null) hash ^= Timeout.GetHashCode();
      if (FailureModeDeny != false) hash ^= FailureModeDeny.GetHashCode();
      if (rateLimitService_ != null) hash ^= RateLimitService.GetHashCode();
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
      if (Domain.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Domain);
      }
      if (Stage != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Stage);
      }
      if (timeout_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Timeout);
      }
      if (FailureModeDeny != false) {
        output.WriteRawTag(32);
        output.WriteBool(FailureModeDeny);
      }
      if (rateLimitService_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(RateLimitService);
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
      if (Domain.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Domain);
      }
      if (Stage != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Stage);
      }
      if (timeout_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Timeout);
      }
      if (FailureModeDeny != false) {
        output.WriteRawTag(32);
        output.WriteBool(FailureModeDeny);
      }
      if (rateLimitService_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(RateLimitService);
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
      if (Domain.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Domain);
      }
      if (Stage != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Stage);
      }
      if (timeout_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Timeout);
      }
      if (FailureModeDeny != false) {
        size += 1 + 1;
      }
      if (rateLimitService_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RateLimitService);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RateLimit other) {
      if (other == null) {
        return;
      }
      if (other.Domain.Length != 0) {
        Domain = other.Domain;
      }
      if (other.Stage != 0) {
        Stage = other.Stage;
      }
      if (other.timeout_ != null) {
        if (timeout_ == null) {
          Timeout = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        Timeout.MergeFrom(other.Timeout);
      }
      if (other.FailureModeDeny != false) {
        FailureModeDeny = other.FailureModeDeny;
      }
      if (other.rateLimitService_ != null) {
        if (rateLimitService_ == null) {
          RateLimitService = new global::Envoy.Config.Ratelimit.V3.RateLimitServiceConfig();
        }
        RateLimitService.MergeFrom(other.RateLimitService);
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
          case 10: {
            Domain = input.ReadString();
            break;
          }
          case 16: {
            Stage = input.ReadUInt32();
            break;
          }
          case 26: {
            if (timeout_ == null) {
              Timeout = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(Timeout);
            break;
          }
          case 32: {
            FailureModeDeny = input.ReadBool();
            break;
          }
          case 42: {
            if (rateLimitService_ == null) {
              RateLimitService = new global::Envoy.Config.Ratelimit.V3.RateLimitServiceConfig();
            }
            input.ReadMessage(RateLimitService);
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
          case 10: {
            Domain = input.ReadString();
            break;
          }
          case 16: {
            Stage = input.ReadUInt32();
            break;
          }
          case 26: {
            if (timeout_ == null) {
              Timeout = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(Timeout);
            break;
          }
          case 32: {
            FailureModeDeny = input.ReadBool();
            break;
          }
          case 42: {
            if (rateLimitService_ == null) {
              RateLimitService = new global::Envoy.Config.Ratelimit.V3.RateLimitServiceConfig();
            }
            input.ReadMessage(RateLimitService);
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
