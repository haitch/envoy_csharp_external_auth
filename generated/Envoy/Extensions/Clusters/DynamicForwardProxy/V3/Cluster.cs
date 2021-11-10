// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/extensions/clusters/dynamic_forward_proxy/v3/cluster.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Extensions.Clusters.DynamicForwardProxy.V3 {

  /// <summary>Holder for reflection information generated from envoy/extensions/clusters/dynamic_forward_proxy/v3/cluster.proto</summary>
  public static partial class ClusterReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/extensions/clusters/dynamic_forward_proxy/v3/cluster.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClusterReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBlbnZveS9leHRlbnNpb25zL2NsdXN0ZXJzL2R5bmFtaWNfZm9yd2FyZF9w",
            "cm94eS92My9jbHVzdGVyLnByb3RvEjJlbnZveS5leHRlbnNpb25zLmNsdXN0",
            "ZXJzLmR5bmFtaWNfZm9yd2FyZF9wcm94eS52MxpAZW52b3kvZXh0ZW5zaW9u",
            "cy9jb21tb24vZHluYW1pY19mb3J3YXJkX3Byb3h5L3YzL2Ruc19jYWNoZS5w",
            "cm90bxoddWRwYS9hbm5vdGF0aW9ucy9zdGF0dXMucHJvdG8aIXVkcGEvYW5u",
            "b3RhdGlvbnMvdmVyc2lvbmluZy5wcm90bxoXdmFsaWRhdGUvdmFsaWRhdGUu",
            "cHJvdG8i5gEKDUNsdXN0ZXJDb25maWcSZAoQZG5zX2NhY2hlX2NvbmZpZxgB",
            "IAEoCzJALmVudm95LmV4dGVuc2lvbnMuY29tbW9uLmR5bmFtaWNfZm9yd2Fy",
            "ZF9wcm94eS52My5EbnNDYWNoZUNvbmZpZ0II+kIFigECEAESJgoeYWxsb3df",
            "aW5zZWN1cmVfY2x1c3Rlcl9vcHRpb25zGAIgASgIOkeaxYgeQgpAZW52b3ku",
            "Y29uZmlnLmNsdXN0ZXIuZHluYW1pY19mb3J3YXJkX3Byb3h5LnYyYWxwaGEu",
            "Q2x1c3RlckNvbmZpZ0JaCkBpby5lbnZveXByb3h5LmVudm95LmV4dGVuc2lv",
            "bnMuY2x1c3RlcnMuZHluYW1pY19mb3J3YXJkX3Byb3h5LnYzQgxDbHVzdGVy",
            "UHJvdG9QAbqAyNEGAhACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Extensions.Common.DynamicForwardProxy.V3.DnsCacheReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Udpa.Annotations.VersioningReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Extensions.Clusters.DynamicForwardProxy.V3.ClusterConfig), global::Envoy.Extensions.Clusters.DynamicForwardProxy.V3.ClusterConfig.Parser, new[]{ "DnsCacheConfig", "AllowInsecureClusterOptions" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Configuration for the dynamic forward proxy cluster. See the :ref:`architecture overview
  /// &lt;arch_overview_http_dynamic_forward_proxy>` for more information.
  /// [#extension: envoy.clusters.dynamic_forward_proxy]
  /// </summary>
  public sealed partial class ClusterConfig : pb::IMessage<ClusterConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ClusterConfig> _parser = new pb::MessageParser<ClusterConfig>(() => new ClusterConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ClusterConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Extensions.Clusters.DynamicForwardProxy.V3.ClusterReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClusterConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClusterConfig(ClusterConfig other) : this() {
      dnsCacheConfig_ = other.dnsCacheConfig_ != null ? other.dnsCacheConfig_.Clone() : null;
      allowInsecureClusterOptions_ = other.allowInsecureClusterOptions_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClusterConfig Clone() {
      return new ClusterConfig(this);
    }

    /// <summary>Field number for the "dns_cache_config" field.</summary>
    public const int DnsCacheConfigFieldNumber = 1;
    private global::Envoy.Extensions.Common.DynamicForwardProxy.V3.DnsCacheConfig dnsCacheConfig_;
    /// <summary>
    /// The DNS cache configuration that the cluster will attach to. Note this configuration must
    /// match that of associated :ref:`dynamic forward proxy HTTP filter configuration
    /// &lt;envoy_v3_api_field_extensions.filters.http.dynamic_forward_proxy.v3.FilterConfig.dns_cache_config>`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Extensions.Common.DynamicForwardProxy.V3.DnsCacheConfig DnsCacheConfig {
      get { return dnsCacheConfig_; }
      set {
        dnsCacheConfig_ = value;
      }
    }

    /// <summary>Field number for the "allow_insecure_cluster_options" field.</summary>
    public const int AllowInsecureClusterOptionsFieldNumber = 2;
    private bool allowInsecureClusterOptions_;
    /// <summary>
    /// If true allow the cluster configuration to disable the auto_sni and auto_san_validation options
    /// in the :ref:`cluster's upstream_http_protocol_options
    /// &lt;envoy_v3_api_field_config.cluster.v3.Cluster.upstream_http_protocol_options>`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool AllowInsecureClusterOptions {
      get { return allowInsecureClusterOptions_; }
      set {
        allowInsecureClusterOptions_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ClusterConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ClusterConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(DnsCacheConfig, other.DnsCacheConfig)) return false;
      if (AllowInsecureClusterOptions != other.AllowInsecureClusterOptions) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (dnsCacheConfig_ != null) hash ^= DnsCacheConfig.GetHashCode();
      if (AllowInsecureClusterOptions != false) hash ^= AllowInsecureClusterOptions.GetHashCode();
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
      if (dnsCacheConfig_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(DnsCacheConfig);
      }
      if (AllowInsecureClusterOptions != false) {
        output.WriteRawTag(16);
        output.WriteBool(AllowInsecureClusterOptions);
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
      if (dnsCacheConfig_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(DnsCacheConfig);
      }
      if (AllowInsecureClusterOptions != false) {
        output.WriteRawTag(16);
        output.WriteBool(AllowInsecureClusterOptions);
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
      if (dnsCacheConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DnsCacheConfig);
      }
      if (AllowInsecureClusterOptions != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ClusterConfig other) {
      if (other == null) {
        return;
      }
      if (other.dnsCacheConfig_ != null) {
        if (dnsCacheConfig_ == null) {
          DnsCacheConfig = new global::Envoy.Extensions.Common.DynamicForwardProxy.V3.DnsCacheConfig();
        }
        DnsCacheConfig.MergeFrom(other.DnsCacheConfig);
      }
      if (other.AllowInsecureClusterOptions != false) {
        AllowInsecureClusterOptions = other.AllowInsecureClusterOptions;
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
            if (dnsCacheConfig_ == null) {
              DnsCacheConfig = new global::Envoy.Extensions.Common.DynamicForwardProxy.V3.DnsCacheConfig();
            }
            input.ReadMessage(DnsCacheConfig);
            break;
          }
          case 16: {
            AllowInsecureClusterOptions = input.ReadBool();
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
            if (dnsCacheConfig_ == null) {
              DnsCacheConfig = new global::Envoy.Extensions.Common.DynamicForwardProxy.V3.DnsCacheConfig();
            }
            input.ReadMessage(DnsCacheConfig);
            break;
          }
          case 16: {
            AllowInsecureClusterOptions = input.ReadBool();
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
