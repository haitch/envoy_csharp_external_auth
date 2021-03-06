// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/config/cluster/redis/redis_cluster.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Cluster.Redis {

  /// <summary>Holder for reflection information generated from envoy/config/cluster/redis/redis_cluster.proto</summary>
  public static partial class RedisClusterReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/config/cluster/redis/redis_cluster.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RedisClusterReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5lbnZveS9jb25maWcvY2x1c3Rlci9yZWRpcy9yZWRpc19jbHVzdGVyLnBy",
            "b3RvEhplbnZveS5jb25maWcuY2x1c3Rlci5yZWRpcxoeZ29vZ2xlL3Byb3Rv",
            "YnVmL2R1cmF0aW9uLnByb3RvGh5nb29nbGUvcHJvdG9idWYvd3JhcHBlcnMu",
            "cHJvdG8aHXVkcGEvYW5ub3RhdGlvbnMvc3RhdHVzLnByb3RvGhd2YWxpZGF0",
            "ZS92YWxpZGF0ZS5wcm90byLpAgoSUmVkaXNDbHVzdGVyQ29uZmlnEkEKFGNs",
            "dXN0ZXJfcmVmcmVzaF9yYXRlGAEgASgLMhkuZ29vZ2xlLnByb3RvYnVmLkR1",
            "cmF0aW9uQgj6QgWqAQIqABJEChdjbHVzdGVyX3JlZnJlc2hfdGltZW91dBgC",
            "IAEoCzIZLmdvb2dsZS5wcm90b2J1Zi5EdXJhdGlvbkII+kIFqgECKgASPAoZ",
            "cmVkaXJlY3RfcmVmcmVzaF9pbnRlcnZhbBgDIAEoCzIZLmdvb2dsZS5wcm90",
            "b2J1Zi5EdXJhdGlvbhJAChpyZWRpcmVjdF9yZWZyZXNoX3RocmVzaG9sZBgE",
            "IAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5VSW50MzJWYWx1ZRIhChlmYWlsdXJl",
            "X3JlZnJlc2hfdGhyZXNob2xkGAUgASgNEicKH2hvc3RfZGVncmFkZWRfcmVm",
            "cmVzaF90aHJlc2hvbGQYBiABKA1CRwooaW8uZW52b3lwcm94eS5lbnZveS5j",
            "b25maWcuY2x1c3Rlci5yZWRpc0IRUmVkaXNDbHVzdGVyUHJvdG9QAbqAyNEG",
            "AhABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Cluster.Redis.RedisClusterConfig), global::Envoy.Config.Cluster.Redis.RedisClusterConfig.Parser, new[]{ "ClusterRefreshRate", "ClusterRefreshTimeout", "RedirectRefreshInterval", "RedirectRefreshThreshold", "FailureRefreshThreshold", "HostDegradedRefreshThreshold" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// [#next-free-field: 7]
  /// </summary>
  public sealed partial class RedisClusterConfig : pb::IMessage<RedisClusterConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RedisClusterConfig> _parser = new pb::MessageParser<RedisClusterConfig>(() => new RedisClusterConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RedisClusterConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Cluster.Redis.RedisClusterReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RedisClusterConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RedisClusterConfig(RedisClusterConfig other) : this() {
      clusterRefreshRate_ = other.clusterRefreshRate_ != null ? other.clusterRefreshRate_.Clone() : null;
      clusterRefreshTimeout_ = other.clusterRefreshTimeout_ != null ? other.clusterRefreshTimeout_.Clone() : null;
      redirectRefreshInterval_ = other.redirectRefreshInterval_ != null ? other.redirectRefreshInterval_.Clone() : null;
      RedirectRefreshThreshold = other.RedirectRefreshThreshold;
      failureRefreshThreshold_ = other.failureRefreshThreshold_;
      hostDegradedRefreshThreshold_ = other.hostDegradedRefreshThreshold_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RedisClusterConfig Clone() {
      return new RedisClusterConfig(this);
    }

    /// <summary>Field number for the "cluster_refresh_rate" field.</summary>
    public const int ClusterRefreshRateFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Duration clusterRefreshRate_;
    /// <summary>
    /// Interval between successive topology refresh requests. If not set, this defaults to 5s.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Duration ClusterRefreshRate {
      get { return clusterRefreshRate_; }
      set {
        clusterRefreshRate_ = value;
      }
    }

    /// <summary>Field number for the "cluster_refresh_timeout" field.</summary>
    public const int ClusterRefreshTimeoutFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Duration clusterRefreshTimeout_;
    /// <summary>
    /// Timeout for topology refresh request. If not set, this defaults to 3s.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Duration ClusterRefreshTimeout {
      get { return clusterRefreshTimeout_; }
      set {
        clusterRefreshTimeout_ = value;
      }
    }

    /// <summary>Field number for the "redirect_refresh_interval" field.</summary>
    public const int RedirectRefreshIntervalFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Duration redirectRefreshInterval_;
    /// <summary>
    /// The minimum interval that must pass after triggering a topology refresh request before a new
    /// request can possibly be triggered again. Any errors received during one of these
    /// time intervals are ignored. If not set, this defaults to 5s.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Duration RedirectRefreshInterval {
      get { return redirectRefreshInterval_; }
      set {
        redirectRefreshInterval_ = value;
      }
    }

    /// <summary>Field number for the "redirect_refresh_threshold" field.</summary>
    public const int RedirectRefreshThresholdFieldNumber = 4;
    private static readonly pb::FieldCodec<uint?> _single_redirectRefreshThreshold_codec = pb::FieldCodec.ForStructWrapper<uint>(34);
    private uint? redirectRefreshThreshold_;
    /// <summary>
    /// The number of redirection errors that must be received before
    /// triggering a topology refresh request. If not set, this defaults to 5.
    /// If this is set to 0, topology refresh after redirect is disabled.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint? RedirectRefreshThreshold {
      get { return redirectRefreshThreshold_; }
      set {
        redirectRefreshThreshold_ = value;
      }
    }


    /// <summary>Field number for the "failure_refresh_threshold" field.</summary>
    public const int FailureRefreshThresholdFieldNumber = 5;
    private uint failureRefreshThreshold_;
    /// <summary>
    /// The number of failures that must be received before triggering a topology refresh request.
    /// If not set, this defaults to 0, which disables the topology refresh due to failure.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FailureRefreshThreshold {
      get { return failureRefreshThreshold_; }
      set {
        failureRefreshThreshold_ = value;
      }
    }

    /// <summary>Field number for the "host_degraded_refresh_threshold" field.</summary>
    public const int HostDegradedRefreshThresholdFieldNumber = 6;
    private uint hostDegradedRefreshThreshold_;
    /// <summary>
    /// The number of hosts became degraded or unhealthy before triggering a topology refresh request.
    /// If not set, this defaults to 0, which disables the topology refresh due to degraded or
    /// unhealthy host.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HostDegradedRefreshThreshold {
      get { return hostDegradedRefreshThreshold_; }
      set {
        hostDegradedRefreshThreshold_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RedisClusterConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RedisClusterConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ClusterRefreshRate, other.ClusterRefreshRate)) return false;
      if (!object.Equals(ClusterRefreshTimeout, other.ClusterRefreshTimeout)) return false;
      if (!object.Equals(RedirectRefreshInterval, other.RedirectRefreshInterval)) return false;
      if (RedirectRefreshThreshold != other.RedirectRefreshThreshold) return false;
      if (FailureRefreshThreshold != other.FailureRefreshThreshold) return false;
      if (HostDegradedRefreshThreshold != other.HostDegradedRefreshThreshold) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (clusterRefreshRate_ != null) hash ^= ClusterRefreshRate.GetHashCode();
      if (clusterRefreshTimeout_ != null) hash ^= ClusterRefreshTimeout.GetHashCode();
      if (redirectRefreshInterval_ != null) hash ^= RedirectRefreshInterval.GetHashCode();
      if (redirectRefreshThreshold_ != null) hash ^= RedirectRefreshThreshold.GetHashCode();
      if (FailureRefreshThreshold != 0) hash ^= FailureRefreshThreshold.GetHashCode();
      if (HostDegradedRefreshThreshold != 0) hash ^= HostDegradedRefreshThreshold.GetHashCode();
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
      if (clusterRefreshRate_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ClusterRefreshRate);
      }
      if (clusterRefreshTimeout_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ClusterRefreshTimeout);
      }
      if (redirectRefreshInterval_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RedirectRefreshInterval);
      }
      if (redirectRefreshThreshold_ != null) {
        _single_redirectRefreshThreshold_codec.WriteTagAndValue(output, RedirectRefreshThreshold);
      }
      if (FailureRefreshThreshold != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(FailureRefreshThreshold);
      }
      if (HostDegradedRefreshThreshold != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(HostDegradedRefreshThreshold);
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
      if (clusterRefreshRate_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ClusterRefreshRate);
      }
      if (clusterRefreshTimeout_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ClusterRefreshTimeout);
      }
      if (redirectRefreshInterval_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RedirectRefreshInterval);
      }
      if (redirectRefreshThreshold_ != null) {
        _single_redirectRefreshThreshold_codec.WriteTagAndValue(ref output, RedirectRefreshThreshold);
      }
      if (FailureRefreshThreshold != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(FailureRefreshThreshold);
      }
      if (HostDegradedRefreshThreshold != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(HostDegradedRefreshThreshold);
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
      if (clusterRefreshRate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ClusterRefreshRate);
      }
      if (clusterRefreshTimeout_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ClusterRefreshTimeout);
      }
      if (redirectRefreshInterval_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RedirectRefreshInterval);
      }
      if (redirectRefreshThreshold_ != null) {
        size += _single_redirectRefreshThreshold_codec.CalculateSizeWithTag(RedirectRefreshThreshold);
      }
      if (FailureRefreshThreshold != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FailureRefreshThreshold);
      }
      if (HostDegradedRefreshThreshold != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HostDegradedRefreshThreshold);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RedisClusterConfig other) {
      if (other == null) {
        return;
      }
      if (other.clusterRefreshRate_ != null) {
        if (clusterRefreshRate_ == null) {
          ClusterRefreshRate = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        ClusterRefreshRate.MergeFrom(other.ClusterRefreshRate);
      }
      if (other.clusterRefreshTimeout_ != null) {
        if (clusterRefreshTimeout_ == null) {
          ClusterRefreshTimeout = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        ClusterRefreshTimeout.MergeFrom(other.ClusterRefreshTimeout);
      }
      if (other.redirectRefreshInterval_ != null) {
        if (redirectRefreshInterval_ == null) {
          RedirectRefreshInterval = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        RedirectRefreshInterval.MergeFrom(other.RedirectRefreshInterval);
      }
      if (other.redirectRefreshThreshold_ != null) {
        if (redirectRefreshThreshold_ == null || other.RedirectRefreshThreshold != 0) {
          RedirectRefreshThreshold = other.RedirectRefreshThreshold;
        }
      }
      if (other.FailureRefreshThreshold != 0) {
        FailureRefreshThreshold = other.FailureRefreshThreshold;
      }
      if (other.HostDegradedRefreshThreshold != 0) {
        HostDegradedRefreshThreshold = other.HostDegradedRefreshThreshold;
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
            if (clusterRefreshRate_ == null) {
              ClusterRefreshRate = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(ClusterRefreshRate);
            break;
          }
          case 18: {
            if (clusterRefreshTimeout_ == null) {
              ClusterRefreshTimeout = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(ClusterRefreshTimeout);
            break;
          }
          case 26: {
            if (redirectRefreshInterval_ == null) {
              RedirectRefreshInterval = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(RedirectRefreshInterval);
            break;
          }
          case 34: {
            uint? value = _single_redirectRefreshThreshold_codec.Read(input);
            if (redirectRefreshThreshold_ == null || value != 0) {
              RedirectRefreshThreshold = value;
            }
            break;
          }
          case 40: {
            FailureRefreshThreshold = input.ReadUInt32();
            break;
          }
          case 48: {
            HostDegradedRefreshThreshold = input.ReadUInt32();
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
            if (clusterRefreshRate_ == null) {
              ClusterRefreshRate = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(ClusterRefreshRate);
            break;
          }
          case 18: {
            if (clusterRefreshTimeout_ == null) {
              ClusterRefreshTimeout = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(ClusterRefreshTimeout);
            break;
          }
          case 26: {
            if (redirectRefreshInterval_ == null) {
              RedirectRefreshInterval = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(RedirectRefreshInterval);
            break;
          }
          case 34: {
            uint? value = _single_redirectRefreshThreshold_codec.Read(ref input);
            if (redirectRefreshThreshold_ == null || value != 0) {
              RedirectRefreshThreshold = value;
            }
            break;
          }
          case 40: {
            FailureRefreshThreshold = input.ReadUInt32();
            break;
          }
          case 48: {
            HostDegradedRefreshThreshold = input.ReadUInt32();
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
