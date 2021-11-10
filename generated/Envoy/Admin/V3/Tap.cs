// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/admin/v3/tap.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Admin.V3 {

  /// <summary>Holder for reflection information generated from envoy/admin/v3/tap.proto</summary>
  public static partial class TapReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/admin/v3/tap.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TapReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhlbnZveS9hZG1pbi92My90YXAucHJvdG8SDmVudm95LmFkbWluLnYzGiBl",
            "bnZveS9jb25maWcvdGFwL3YzL2NvbW1vbi5wcm90bxoddWRwYS9hbm5vdGF0",
            "aW9ucy9zdGF0dXMucHJvdG8aIXVkcGEvYW5ub3RhdGlvbnMvdmVyc2lvbmlu",
            "Zy5wcm90bxoXdmFsaWRhdGUvdmFsaWRhdGUucHJvdG8ijQEKClRhcFJlcXVl",
            "c3QSGgoJY29uZmlnX2lkGAEgASgJQgf6QgRyAhABEjwKCnRhcF9jb25maWcY",
            "AiABKAsyHi5lbnZveS5jb25maWcudGFwLnYzLlRhcENvbmZpZ0II+kIFigEC",
            "EAE6JZrFiB4gCh5lbnZveS5hZG1pbi52MmFscGhhLlRhcFJlcXVlc3RCMgoc",
            "aW8uZW52b3lwcm94eS5lbnZveS5hZG1pbi52M0IIVGFwUHJvdG9QAbqAyNEG",
            "AhACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Config.Tap.V3.CommonReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Udpa.Annotations.VersioningReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Admin.V3.TapRequest), global::Envoy.Admin.V3.TapRequest.Parser, new[]{ "ConfigId", "TapConfig" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The /tap admin request body that is used to configure an active tap session.
  /// </summary>
  public sealed partial class TapRequest : pb::IMessage<TapRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TapRequest> _parser = new pb::MessageParser<TapRequest>(() => new TapRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TapRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Admin.V3.TapReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TapRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TapRequest(TapRequest other) : this() {
      configId_ = other.configId_;
      tapConfig_ = other.tapConfig_ != null ? other.tapConfig_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TapRequest Clone() {
      return new TapRequest(this);
    }

    /// <summary>Field number for the "config_id" field.</summary>
    public const int ConfigIdFieldNumber = 1;
    private string configId_ = "";
    /// <summary>
    /// The opaque configuration ID used to match the configuration to a loaded extension.
    /// A tap extension configures a similar opaque ID that is used to match.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ConfigId {
      get { return configId_; }
      set {
        configId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "tap_config" field.</summary>
    public const int TapConfigFieldNumber = 2;
    private global::Envoy.Config.Tap.V3.TapConfig tapConfig_;
    /// <summary>
    /// The tap configuration to load.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Config.Tap.V3.TapConfig TapConfig {
      get { return tapConfig_; }
      set {
        tapConfig_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TapRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TapRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ConfigId != other.ConfigId) return false;
      if (!object.Equals(TapConfig, other.TapConfig)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ConfigId.Length != 0) hash ^= ConfigId.GetHashCode();
      if (tapConfig_ != null) hash ^= TapConfig.GetHashCode();
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
      if (tapConfig_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(TapConfig);
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
      if (tapConfig_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(TapConfig);
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
      if (tapConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TapConfig);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TapRequest other) {
      if (other == null) {
        return;
      }
      if (other.ConfigId.Length != 0) {
        ConfigId = other.ConfigId;
      }
      if (other.tapConfig_ != null) {
        if (tapConfig_ == null) {
          TapConfig = new global::Envoy.Config.Tap.V3.TapConfig();
        }
        TapConfig.MergeFrom(other.TapConfig);
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
          case 18: {
            if (tapConfig_ == null) {
              TapConfig = new global::Envoy.Config.Tap.V3.TapConfig();
            }
            input.ReadMessage(TapConfig);
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
          case 18: {
            if (tapConfig_ == null) {
              TapConfig = new global::Envoy.Config.Tap.V3.TapConfig();
            }
            input.ReadMessage(TapConfig);
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
