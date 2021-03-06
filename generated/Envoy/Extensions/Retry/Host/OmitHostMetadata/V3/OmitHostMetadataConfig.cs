// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/extensions/retry/host/omit_host_metadata/v3/omit_host_metadata_config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Extensions.Retry.Host.OmitHostMetadata.V3 {

  /// <summary>Holder for reflection information generated from envoy/extensions/retry/host/omit_host_metadata/v3/omit_host_metadata_config.proto</summary>
  public static partial class OmitHostMetadataConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/extensions/retry/host/omit_host_metadata/v3/omit_host_metadata_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OmitHostMetadataConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ClFlbnZveS9leHRlbnNpb25zL3JldHJ5L2hvc3Qvb21pdF9ob3N0X21ldGFk",
            "YXRhL3YzL29taXRfaG9zdF9tZXRhZGF0YV9jb25maWcucHJvdG8SMWVudm95",
            "LmV4dGVuc2lvbnMucmV0cnkuaG9zdC5vbWl0X2hvc3RfbWV0YWRhdGEudjMa",
            "H2Vudm95L2NvbmZpZy9jb3JlL3YzL2Jhc2UucHJvdG8aHXVkcGEvYW5ub3Rh",
            "dGlvbnMvc3RhdHVzLnByb3RvGiF1ZHBhL2Fubm90YXRpb25zL3ZlcnNpb25p",
            "bmcucHJvdG8imAEKFk9taXRIb3N0TWV0YWRhdGFDb25maWcSNgoObWV0YWRh",
            "dGFfbWF0Y2gYASABKAsyHi5lbnZveS5jb25maWcuY29yZS52My5NZXRhZGF0",
            "YTpGmsWIHkEKP2Vudm95LmNvbmZpZy5yZXRyeS5vbWl0X2hvc3RfbWV0YWRh",
            "dGEudjIuT21pdEhvc3RNZXRhZGF0YUNvbmZpZ0JoCj9pby5lbnZveXByb3h5",
            "LmVudm95LmV4dGVuc2lvbnMucmV0cnkuaG9zdC5vbWl0X2hvc3RfbWV0YWRh",
            "dGEudjNCG09taXRIb3N0TWV0YWRhdGFDb25maWdQcm90b1ABuoDI0QYCEAJi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Config.Core.V3.BaseReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Udpa.Annotations.VersioningReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Extensions.Retry.Host.OmitHostMetadata.V3.OmitHostMetadataConfig), global::Envoy.Extensions.Retry.Host.OmitHostMetadata.V3.OmitHostMetadataConfig.Parser, new[]{ "MetadataMatch" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A retry host predicate that can be used to reject a host based on
  /// predefined metadata match criteria.
  /// [#extension: envoy.retry_host_predicates.omit_host_metadata]
  /// </summary>
  public sealed partial class OmitHostMetadataConfig : pb::IMessage<OmitHostMetadataConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OmitHostMetadataConfig> _parser = new pb::MessageParser<OmitHostMetadataConfig>(() => new OmitHostMetadataConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OmitHostMetadataConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Extensions.Retry.Host.OmitHostMetadata.V3.OmitHostMetadataConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OmitHostMetadataConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OmitHostMetadataConfig(OmitHostMetadataConfig other) : this() {
      metadataMatch_ = other.metadataMatch_ != null ? other.metadataMatch_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OmitHostMetadataConfig Clone() {
      return new OmitHostMetadataConfig(this);
    }

    /// <summary>Field number for the "metadata_match" field.</summary>
    public const int MetadataMatchFieldNumber = 1;
    private global::Envoy.Config.Core.V3.Metadata metadataMatch_;
    /// <summary>
    /// Retry host predicate metadata match criteria. The hosts in
    /// the upstream cluster with matching metadata will be omitted while
    /// attempting a retry of a failed request. The metadata should be specified
    /// under the *envoy.lb* key.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Config.Core.V3.Metadata MetadataMatch {
      get { return metadataMatch_; }
      set {
        metadataMatch_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OmitHostMetadataConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OmitHostMetadataConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(MetadataMatch, other.MetadataMatch)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (metadataMatch_ != null) hash ^= MetadataMatch.GetHashCode();
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
      if (metadataMatch_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(MetadataMatch);
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
      if (metadataMatch_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(MetadataMatch);
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
      if (metadataMatch_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MetadataMatch);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OmitHostMetadataConfig other) {
      if (other == null) {
        return;
      }
      if (other.metadataMatch_ != null) {
        if (metadataMatch_ == null) {
          MetadataMatch = new global::Envoy.Config.Core.V3.Metadata();
        }
        MetadataMatch.MergeFrom(other.MetadataMatch);
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
            if (metadataMatch_ == null) {
              MetadataMatch = new global::Envoy.Config.Core.V3.Metadata();
            }
            input.ReadMessage(MetadataMatch);
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
            if (metadataMatch_ == null) {
              MetadataMatch = new global::Envoy.Config.Core.V3.Metadata();
            }
            input.ReadMessage(MetadataMatch);
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
