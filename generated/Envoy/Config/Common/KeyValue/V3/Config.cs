// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/config/common/key_value/v3/config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Common.KeyValue.V3 {

  /// <summary>Holder for reflection information generated from envoy/config/common/key_value/v3/config.proto</summary>
  public static partial class ConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/config/common/key_value/v3/config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1lbnZveS9jb25maWcvY29tbW9uL2tleV92YWx1ZS92My9jb25maWcucHJv",
            "dG8SIGVudm95LmNvbmZpZy5jb21tb24ua2V5X3ZhbHVlLnYzGiRlbnZveS9j",
            "b25maWcvY29yZS92My9leHRlbnNpb24ucHJvdG8aH3hkcy9hbm5vdGF0aW9u",
            "cy92My9zdGF0dXMucHJvdG8aHXVkcGEvYW5ub3RhdGlvbnMvc3RhdHVzLnBy",
            "b3RvGhd2YWxpZGF0ZS92YWxpZGF0ZS5wcm90byJlChNLZXlWYWx1ZVN0b3Jl",
            "Q29uZmlnEkQKBmNvbmZpZxgBIAEoCzIqLmVudm95LmNvbmZpZy5jb3JlLnYz",
            "LlR5cGVkRXh0ZW5zaW9uQ29uZmlnQgj6QgWKAQIQAToI0sak4QYCCAFCRwou",
            "aW8uZW52b3lwcm94eS5lbnZveS5jb25maWcuY29tbW9uLmtleV92YWx1ZS52",
            "M0ILQ29uZmlnUHJvdG9QAbqAyNEGAhACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Config.Core.V3.ExtensionReflection.Descriptor, global::Xds.Annotations.V3.StatusReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Common.KeyValue.V3.KeyValueStoreConfig), global::Envoy.Config.Common.KeyValue.V3.KeyValueStoreConfig.Parser, new[]{ "Config" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// This shared configuration for Envoy key value stores.
  /// </summary>
  public sealed partial class KeyValueStoreConfig : pb::IMessage<KeyValueStoreConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<KeyValueStoreConfig> _parser = new pb::MessageParser<KeyValueStoreConfig>(() => new KeyValueStoreConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<KeyValueStoreConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Common.KeyValue.V3.ConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeyValueStoreConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeyValueStoreConfig(KeyValueStoreConfig other) : this() {
      config_ = other.config_ != null ? other.config_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeyValueStoreConfig Clone() {
      return new KeyValueStoreConfig(this);
    }

    /// <summary>Field number for the "config" field.</summary>
    public const int ConfigFieldNumber = 1;
    private global::Envoy.Config.Core.V3.TypedExtensionConfig config_;
    /// <summary>
    /// [#extension-category: envoy.common.key_value]
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Config.Core.V3.TypedExtensionConfig Config {
      get { return config_; }
      set {
        config_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as KeyValueStoreConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(KeyValueStoreConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Config, other.Config)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (config_ != null) hash ^= Config.GetHashCode();
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
      if (config_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Config);
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
      if (config_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Config);
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
      if (config_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Config);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(KeyValueStoreConfig other) {
      if (other == null) {
        return;
      }
      if (other.config_ != null) {
        if (config_ == null) {
          Config = new global::Envoy.Config.Core.V3.TypedExtensionConfig();
        }
        Config.MergeFrom(other.Config);
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
            if (config_ == null) {
              Config = new global::Envoy.Config.Core.V3.TypedExtensionConfig();
            }
            input.ReadMessage(Config);
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
            if (config_ == null) {
              Config = new global::Envoy.Config.Core.V3.TypedExtensionConfig();
            }
            input.ReadMessage(Config);
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
