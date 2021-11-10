// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/config/filter/network/rate_limit/v2/rate_limit.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Filter.Network.RateLimit.V2 {

  /// <summary>Holder for reflection information generated from envoy/config/filter/network/rate_limit/v2/rate_limit.proto</summary>
  public static partial class RateLimitReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/config/filter/network/rate_limit/v2/rate_limit.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RateLimitReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjplbnZveS9jb25maWcvZmlsdGVyL25ldHdvcmsvcmF0ZV9saW1pdC92Mi9y",
            "YXRlX2xpbWl0LnByb3RvEillbnZveS5jb25maWcuZmlsdGVyLm5ldHdvcmsu",
            "cmF0ZV9saW1pdC52MhomZW52b3kvYXBpL3YyL3JhdGVsaW1pdC9yYXRlbGlt",
            "aXQucHJvdG8aI2Vudm95L2NvbmZpZy9yYXRlbGltaXQvdjIvcmxzLnByb3Rv",
            "Gh5nb29nbGUvcHJvdG9idWYvZHVyYXRpb24ucHJvdG8aHnVkcGEvYW5ub3Rh",
            "dGlvbnMvbWlncmF0ZS5wcm90bxoddWRwYS9hbm5vdGF0aW9ucy9zdGF0dXMu",
            "cHJvdG8aF3ZhbGlkYXRlL3ZhbGlkYXRlLnByb3RvIq4CCglSYXRlTGltaXQS",
            "HAoLc3RhdF9wcmVmaXgYASABKAlCB/pCBHICIAESFwoGZG9tYWluGAIgASgJ",
            "Qgf6QgRyAiABEkoKC2Rlc2NyaXB0b3JzGAMgAygLMisuZW52b3kuYXBpLnYy",
            "LnJhdGVsaW1pdC5SYXRlTGltaXREZXNjcmlwdG9yQgj6QgWSAQIIARIqCgd0",
            "aW1lb3V0GAQgASgLMhkuZ29vZ2xlLnByb3RvYnVmLkR1cmF0aW9uEhkKEWZh",
            "aWx1cmVfbW9kZV9kZW55GAUgASgIElcKEnJhdGVfbGltaXRfc2VydmljZRgG",
            "IAEoCzIxLmVudm95LmNvbmZpZy5yYXRlbGltaXQudjIuUmF0ZUxpbWl0U2Vy",
            "dmljZUNvbmZpZ0II+kIFigECEAFCiAEKN2lvLmVudm95cHJveHkuZW52b3ku",
            "Y29uZmlnLmZpbHRlci5uZXR3b3JrLnJhdGVfbGltaXQudjJCDlJhdGVMaW1p",
            "dFByb3RvUAHymP6PBS8SLWVudm95LmV4dGVuc2lvbnMuZmlsdGVycy5uZXR3",
            "b3JrLnJhdGVsaW1pdC52M7qAyNEGAhABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Api.V2.Ratelimit.RatelimitReflection.Descriptor, global::Envoy.Config.Ratelimit.V2.RlsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Udpa.Annotations.MigrateReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Filter.Network.RateLimit.V2.RateLimit), global::Envoy.Config.Filter.Network.RateLimit.V2.RateLimit.Parser, new[]{ "StatPrefix", "Domain", "Descriptors", "Timeout", "FailureModeDeny", "RateLimitService" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// [#next-free-field: 7]
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
      get { return global::Envoy.Config.Filter.Network.RateLimit.V2.RateLimitReflection.Descriptor.MessageTypes[0]; }
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
      statPrefix_ = other.statPrefix_;
      domain_ = other.domain_;
      descriptors_ = other.descriptors_.Clone();
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

    /// <summary>Field number for the "stat_prefix" field.</summary>
    public const int StatPrefixFieldNumber = 1;
    private string statPrefix_ = "";
    /// <summary>
    /// The prefix to use when emitting :ref:`statistics &lt;config_network_filters_rate_limit_stats>`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StatPrefix {
      get { return statPrefix_; }
      set {
        statPrefix_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "domain" field.</summary>
    public const int DomainFieldNumber = 2;
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

    /// <summary>Field number for the "descriptors" field.</summary>
    public const int DescriptorsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Envoy.Api.V2.Ratelimit.RateLimitDescriptor> _repeated_descriptors_codec
        = pb::FieldCodec.ForMessage(26, global::Envoy.Api.V2.Ratelimit.RateLimitDescriptor.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Api.V2.Ratelimit.RateLimitDescriptor> descriptors_ = new pbc::RepeatedField<global::Envoy.Api.V2.Ratelimit.RateLimitDescriptor>();
    /// <summary>
    /// The rate limit descriptor list to use in the rate limit service request.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Envoy.Api.V2.Ratelimit.RateLimitDescriptor> Descriptors {
      get { return descriptors_; }
    }

    /// <summary>Field number for the "timeout" field.</summary>
    public const int TimeoutFieldNumber = 4;
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
    public const int FailureModeDenyFieldNumber = 5;
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
    public const int RateLimitServiceFieldNumber = 6;
    private global::Envoy.Config.Ratelimit.V2.RateLimitServiceConfig rateLimitService_;
    /// <summary>
    /// Configuration for an external rate limit service provider. If not
    /// specified, any calls to the rate limit service will immediately return
    /// success.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Config.Ratelimit.V2.RateLimitServiceConfig RateLimitService {
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
      if (StatPrefix != other.StatPrefix) return false;
      if (Domain != other.Domain) return false;
      if(!descriptors_.Equals(other.descriptors_)) return false;
      if (!object.Equals(Timeout, other.Timeout)) return false;
      if (FailureModeDeny != other.FailureModeDeny) return false;
      if (!object.Equals(RateLimitService, other.RateLimitService)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StatPrefix.Length != 0) hash ^= StatPrefix.GetHashCode();
      if (Domain.Length != 0) hash ^= Domain.GetHashCode();
      hash ^= descriptors_.GetHashCode();
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
      if (StatPrefix.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(StatPrefix);
      }
      if (Domain.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Domain);
      }
      descriptors_.WriteTo(output, _repeated_descriptors_codec);
      if (timeout_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Timeout);
      }
      if (FailureModeDeny != false) {
        output.WriteRawTag(40);
        output.WriteBool(FailureModeDeny);
      }
      if (rateLimitService_ != null) {
        output.WriteRawTag(50);
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
      if (StatPrefix.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(StatPrefix);
      }
      if (Domain.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Domain);
      }
      descriptors_.WriteTo(ref output, _repeated_descriptors_codec);
      if (timeout_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Timeout);
      }
      if (FailureModeDeny != false) {
        output.WriteRawTag(40);
        output.WriteBool(FailureModeDeny);
      }
      if (rateLimitService_ != null) {
        output.WriteRawTag(50);
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
      if (StatPrefix.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StatPrefix);
      }
      if (Domain.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Domain);
      }
      size += descriptors_.CalculateSize(_repeated_descriptors_codec);
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
      if (other.StatPrefix.Length != 0) {
        StatPrefix = other.StatPrefix;
      }
      if (other.Domain.Length != 0) {
        Domain = other.Domain;
      }
      descriptors_.Add(other.descriptors_);
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
          RateLimitService = new global::Envoy.Config.Ratelimit.V2.RateLimitServiceConfig();
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
            StatPrefix = input.ReadString();
            break;
          }
          case 18: {
            Domain = input.ReadString();
            break;
          }
          case 26: {
            descriptors_.AddEntriesFrom(input, _repeated_descriptors_codec);
            break;
          }
          case 34: {
            if (timeout_ == null) {
              Timeout = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(Timeout);
            break;
          }
          case 40: {
            FailureModeDeny = input.ReadBool();
            break;
          }
          case 50: {
            if (rateLimitService_ == null) {
              RateLimitService = new global::Envoy.Config.Ratelimit.V2.RateLimitServiceConfig();
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
            StatPrefix = input.ReadString();
            break;
          }
          case 18: {
            Domain = input.ReadString();
            break;
          }
          case 26: {
            descriptors_.AddEntriesFrom(ref input, _repeated_descriptors_codec);
            break;
          }
          case 34: {
            if (timeout_ == null) {
              Timeout = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(Timeout);
            break;
          }
          case 40: {
            FailureModeDeny = input.ReadBool();
            break;
          }
          case 50: {
            if (rateLimitService_ == null) {
              RateLimitService = new global::Envoy.Config.Ratelimit.V2.RateLimitServiceConfig();
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