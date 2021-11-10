// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/extensions/filters/http/tap/v3/tap.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Extensions.Filters.Http.Tap.V3 {

  /// <summary>Holder for reflection information generated from envoy/extensions/filters/http/tap/v3/tap.proto</summary>
  public static partial class TapReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/extensions/filters/http/tap/v3/tap.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TapReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5lbnZveS9leHRlbnNpb25zL2ZpbHRlcnMvaHR0cC90YXAvdjMvdGFwLnBy",
            "b3RvEiRlbnZveS5leHRlbnNpb25zLmZpbHRlcnMuaHR0cC50YXAudjMaK2Vu",
            "dm95L2V4dGVuc2lvbnMvY29tbW9uL3RhcC92My9jb21tb24ucHJvdG8aHXVk",
            "cGEvYW5ub3RhdGlvbnMvc3RhdHVzLnByb3RvGiF1ZHBhL2Fubm90YXRpb25z",
            "L3ZlcnNpb25pbmcucHJvdG8aF3ZhbGlkYXRlL3ZhbGlkYXRlLnByb3RvIo4B",
            "CgNUYXASVgoNY29tbW9uX2NvbmZpZxgBIAEoCzI1LmVudm95LmV4dGVuc2lv",
            "bnMuY29tbW9uLnRhcC52My5Db21tb25FeHRlbnNpb25Db25maWdCCPpCBYoB",
            "AhABOi+axYgeKgooZW52b3kuY29uZmlnLmZpbHRlci5odHRwLnRhcC52MmFs",
            "cGhhLlRhcEJICjJpby5lbnZveXByb3h5LmVudm95LmV4dGVuc2lvbnMuZmls",
            "dGVycy5odHRwLnRhcC52M0IIVGFwUHJvdG9QAbqAyNEGAhACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Extensions.Common.Tap.V3.CommonReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Udpa.Annotations.VersioningReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Extensions.Filters.Http.Tap.V3.Tap), global::Envoy.Extensions.Filters.Http.Tap.V3.Tap.Parser, new[]{ "CommonConfig" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Top level configuration for the tap filter.
  /// </summary>
  public sealed partial class Tap : pb::IMessage<Tap>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Tap> _parser = new pb::MessageParser<Tap>(() => new Tap());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Tap> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Extensions.Filters.Http.Tap.V3.TapReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Tap() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Tap(Tap other) : this() {
      commonConfig_ = other.commonConfig_ != null ? other.commonConfig_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Tap Clone() {
      return new Tap(this);
    }

    /// <summary>Field number for the "common_config" field.</summary>
    public const int CommonConfigFieldNumber = 1;
    private global::Envoy.Extensions.Common.Tap.V3.CommonExtensionConfig commonConfig_;
    /// <summary>
    /// Common configuration for the HTTP tap filter.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Extensions.Common.Tap.V3.CommonExtensionConfig CommonConfig {
      get { return commonConfig_; }
      set {
        commonConfig_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Tap);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Tap other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CommonConfig, other.CommonConfig)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (commonConfig_ != null) hash ^= CommonConfig.GetHashCode();
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
      if (commonConfig_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CommonConfig);
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
      if (commonConfig_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CommonConfig);
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
      if (commonConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CommonConfig);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Tap other) {
      if (other == null) {
        return;
      }
      if (other.commonConfig_ != null) {
        if (commonConfig_ == null) {
          CommonConfig = new global::Envoy.Extensions.Common.Tap.V3.CommonExtensionConfig();
        }
        CommonConfig.MergeFrom(other.CommonConfig);
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
            if (commonConfig_ == null) {
              CommonConfig = new global::Envoy.Extensions.Common.Tap.V3.CommonExtensionConfig();
            }
            input.ReadMessage(CommonConfig);
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
            if (commonConfig_ == null) {
              CommonConfig = new global::Envoy.Extensions.Common.Tap.V3.CommonExtensionConfig();
            }
            input.ReadMessage(CommonConfig);
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
