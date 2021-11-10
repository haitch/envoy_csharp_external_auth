// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/extensions/common/tap/v3/common.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Extensions.Common.Tap.V3 {

  /// <summary>Holder for reflection information generated from envoy/extensions/common/tap/v3/common.proto</summary>
  public static partial class CommonReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/extensions/common/tap/v3/common.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitlbnZveS9leHRlbnNpb25zL2NvbW1vbi90YXAvdjMvY29tbW9uLnByb3Rv",
            "Eh5lbnZveS5leHRlbnNpb25zLmNvbW1vbi50YXAudjMaIGVudm95L2NvbmZp",
            "Zy90YXAvdjMvY29tbW9uLnByb3RvGh11ZHBhL2Fubm90YXRpb25zL3N0YXR1",
            "cy5wcm90bxohdWRwYS9hbm5vdGF0aW9ucy92ZXJzaW9uaW5nLnByb3RvGhd2",
            "YWxpZGF0ZS92YWxpZGF0ZS5wcm90byLnAQoVQ29tbW9uRXh0ZW5zaW9uQ29u",
            "ZmlnEkMKDGFkbWluX2NvbmZpZxgBIAEoCzIrLmVudm95LmV4dGVuc2lvbnMu",
            "Y29tbW9uLnRhcC52My5BZG1pbkNvbmZpZ0gAEjcKDXN0YXRpY19jb25maWcY",
            "AiABKAsyHi5lbnZveS5jb25maWcudGFwLnYzLlRhcENvbmZpZ0gAOjyaxYge",
            "Nwo1ZW52b3kuY29uZmlnLmNvbW1vbi50YXAudjJhbHBoYS5Db21tb25FeHRl",
            "bnNpb25Db25maWdCEgoLY29uZmlnX3R5cGUSA/hCASJdCgtBZG1pbkNvbmZp",
            "ZxIaCgljb25maWdfaWQYASABKAlCB/pCBHICEAE6MprFiB4tCitlbnZveS5j",
            "b25maWcuY29tbW9uLnRhcC52MmFscGhhLkFkbWluQ29uZmlnQkUKLGlvLmVu",
            "dm95cHJveHkuZW52b3kuZXh0ZW5zaW9ucy5jb21tb24udGFwLnYzQgtDb21t",
            "b25Qcm90b1ABuoDI0QYCEAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Config.Tap.V3.CommonReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Udpa.Annotations.VersioningReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Extensions.Common.Tap.V3.CommonExtensionConfig), global::Envoy.Extensions.Common.Tap.V3.CommonExtensionConfig.Parser, new[]{ "AdminConfig", "StaticConfig" }, new[]{ "ConfigType" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Extensions.Common.Tap.V3.AdminConfig), global::Envoy.Extensions.Common.Tap.V3.AdminConfig.Parser, new[]{ "ConfigId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Common configuration for all tap extensions.
  /// </summary>
  public sealed partial class CommonExtensionConfig : pb::IMessage<CommonExtensionConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CommonExtensionConfig> _parser = new pb::MessageParser<CommonExtensionConfig>(() => new CommonExtensionConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CommonExtensionConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Extensions.Common.Tap.V3.CommonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CommonExtensionConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CommonExtensionConfig(CommonExtensionConfig other) : this() {
      switch (other.ConfigTypeCase) {
        case ConfigTypeOneofCase.AdminConfig:
          AdminConfig = other.AdminConfig.Clone();
          break;
        case ConfigTypeOneofCase.StaticConfig:
          StaticConfig = other.StaticConfig.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CommonExtensionConfig Clone() {
      return new CommonExtensionConfig(this);
    }

    /// <summary>Field number for the "admin_config" field.</summary>
    public const int AdminConfigFieldNumber = 1;
    /// <summary>
    /// If specified, the tap filter will be configured via an admin handler.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Extensions.Common.Tap.V3.AdminConfig AdminConfig {
      get { return configTypeCase_ == ConfigTypeOneofCase.AdminConfig ? (global::Envoy.Extensions.Common.Tap.V3.AdminConfig) configType_ : null; }
      set {
        configType_ = value;
        configTypeCase_ = value == null ? ConfigTypeOneofCase.None : ConfigTypeOneofCase.AdminConfig;
      }
    }

    /// <summary>Field number for the "static_config" field.</summary>
    public const int StaticConfigFieldNumber = 2;
    /// <summary>
    /// If specified, the tap filter will be configured via a static configuration that cannot be
    /// changed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Config.Tap.V3.TapConfig StaticConfig {
      get { return configTypeCase_ == ConfigTypeOneofCase.StaticConfig ? (global::Envoy.Config.Tap.V3.TapConfig) configType_ : null; }
      set {
        configType_ = value;
        configTypeCase_ = value == null ? ConfigTypeOneofCase.None : ConfigTypeOneofCase.StaticConfig;
      }
    }

    private object configType_;
    /// <summary>Enum of possible cases for the "config_type" oneof.</summary>
    public enum ConfigTypeOneofCase {
      None = 0,
      AdminConfig = 1,
      StaticConfig = 2,
    }
    private ConfigTypeOneofCase configTypeCase_ = ConfigTypeOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConfigTypeOneofCase ConfigTypeCase {
      get { return configTypeCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearConfigType() {
      configTypeCase_ = ConfigTypeOneofCase.None;
      configType_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CommonExtensionConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CommonExtensionConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AdminConfig, other.AdminConfig)) return false;
      if (!object.Equals(StaticConfig, other.StaticConfig)) return false;
      if (ConfigTypeCase != other.ConfigTypeCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (configTypeCase_ == ConfigTypeOneofCase.AdminConfig) hash ^= AdminConfig.GetHashCode();
      if (configTypeCase_ == ConfigTypeOneofCase.StaticConfig) hash ^= StaticConfig.GetHashCode();
      hash ^= (int) configTypeCase_;
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
      if (configTypeCase_ == ConfigTypeOneofCase.AdminConfig) {
        output.WriteRawTag(10);
        output.WriteMessage(AdminConfig);
      }
      if (configTypeCase_ == ConfigTypeOneofCase.StaticConfig) {
        output.WriteRawTag(18);
        output.WriteMessage(StaticConfig);
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
      if (configTypeCase_ == ConfigTypeOneofCase.AdminConfig) {
        output.WriteRawTag(10);
        output.WriteMessage(AdminConfig);
      }
      if (configTypeCase_ == ConfigTypeOneofCase.StaticConfig) {
        output.WriteRawTag(18);
        output.WriteMessage(StaticConfig);
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
      if (configTypeCase_ == ConfigTypeOneofCase.AdminConfig) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AdminConfig);
      }
      if (configTypeCase_ == ConfigTypeOneofCase.StaticConfig) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StaticConfig);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CommonExtensionConfig other) {
      if (other == null) {
        return;
      }
      switch (other.ConfigTypeCase) {
        case ConfigTypeOneofCase.AdminConfig:
          if (AdminConfig == null) {
            AdminConfig = new global::Envoy.Extensions.Common.Tap.V3.AdminConfig();
          }
          AdminConfig.MergeFrom(other.AdminConfig);
          break;
        case ConfigTypeOneofCase.StaticConfig:
          if (StaticConfig == null) {
            StaticConfig = new global::Envoy.Config.Tap.V3.TapConfig();
          }
          StaticConfig.MergeFrom(other.StaticConfig);
          break;
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
            global::Envoy.Extensions.Common.Tap.V3.AdminConfig subBuilder = new global::Envoy.Extensions.Common.Tap.V3.AdminConfig();
            if (configTypeCase_ == ConfigTypeOneofCase.AdminConfig) {
              subBuilder.MergeFrom(AdminConfig);
            }
            input.ReadMessage(subBuilder);
            AdminConfig = subBuilder;
            break;
          }
          case 18: {
            global::Envoy.Config.Tap.V3.TapConfig subBuilder = new global::Envoy.Config.Tap.V3.TapConfig();
            if (configTypeCase_ == ConfigTypeOneofCase.StaticConfig) {
              subBuilder.MergeFrom(StaticConfig);
            }
            input.ReadMessage(subBuilder);
            StaticConfig = subBuilder;
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
            global::Envoy.Extensions.Common.Tap.V3.AdminConfig subBuilder = new global::Envoy.Extensions.Common.Tap.V3.AdminConfig();
            if (configTypeCase_ == ConfigTypeOneofCase.AdminConfig) {
              subBuilder.MergeFrom(AdminConfig);
            }
            input.ReadMessage(subBuilder);
            AdminConfig = subBuilder;
            break;
          }
          case 18: {
            global::Envoy.Config.Tap.V3.TapConfig subBuilder = new global::Envoy.Config.Tap.V3.TapConfig();
            if (configTypeCase_ == ConfigTypeOneofCase.StaticConfig) {
              subBuilder.MergeFrom(StaticConfig);
            }
            input.ReadMessage(subBuilder);
            StaticConfig = subBuilder;
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Configuration for the admin handler. See :ref:`here &lt;config_http_filters_tap_admin_handler>` for
  /// more information.
  /// </summary>
  public sealed partial class AdminConfig : pb::IMessage<AdminConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdminConfig> _parser = new pb::MessageParser<AdminConfig>(() => new AdminConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdminConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Extensions.Common.Tap.V3.CommonReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdminConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdminConfig(AdminConfig other) : this() {
      configId_ = other.configId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdminConfig Clone() {
      return new AdminConfig(this);
    }

    /// <summary>Field number for the "config_id" field.</summary>
    public const int ConfigIdFieldNumber = 1;
    private string configId_ = "";
    /// <summary>
    /// Opaque configuration ID. When requests are made to the admin handler, the passed opaque ID is
    /// matched to the configured filter opaque ID to determine which filter to configure.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ConfigId {
      get { return configId_; }
      set {
        configId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdminConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdminConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ConfigId != other.ConfigId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ConfigId.Length != 0) hash ^= ConfigId.GetHashCode();
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
      if (ConfigId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ConfigId);
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
      if (ConfigId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ConfigId);
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
      if (ConfigId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ConfigId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AdminConfig other) {
      if (other == null) {
        return;
      }
      if (other.ConfigId.Length != 0) {
        ConfigId = other.ConfigId;
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
            ConfigId = input.ReadString();
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
            ConfigId = input.ReadString();
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