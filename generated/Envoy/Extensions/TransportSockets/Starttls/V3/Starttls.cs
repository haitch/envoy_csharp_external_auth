// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/extensions/transport_sockets/starttls/v3/starttls.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Extensions.TransportSockets.Starttls.V3 {

  /// <summary>Holder for reflection information generated from envoy/extensions/transport_sockets/starttls/v3/starttls.proto</summary>
  public static partial class StarttlsReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/extensions/transport_sockets/starttls/v3/starttls.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StarttlsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1lbnZveS9leHRlbnNpb25zL3RyYW5zcG9ydF9zb2NrZXRzL3N0YXJ0dGxz",
            "L3YzL3N0YXJ0dGxzLnByb3RvEi5lbnZveS5leHRlbnNpb25zLnRyYW5zcG9y",
            "dF9zb2NrZXRzLnN0YXJ0dGxzLnYzGkFlbnZveS9leHRlbnNpb25zL3RyYW5z",
            "cG9ydF9zb2NrZXRzL3Jhd19idWZmZXIvdjMvcmF3X2J1ZmZlci5wcm90bxoz",
            "ZW52b3kvZXh0ZW5zaW9ucy90cmFuc3BvcnRfc29ja2V0cy90bHMvdjMvdGxz",
            "LnByb3RvGh11ZHBhL2Fubm90YXRpb25zL3N0YXR1cy5wcm90bxoXdmFsaWRh",
            "dGUvdmFsaWRhdGUucHJvdG8i1AEKDlN0YXJ0VGxzQ29uZmlnElwKF2NsZWFy",
            "dGV4dF9zb2NrZXRfY29uZmlnGAEgASgLMjsuZW52b3kuZXh0ZW5zaW9ucy50",
            "cmFuc3BvcnRfc29ja2V0cy5yYXdfYnVmZmVyLnYzLlJhd0J1ZmZlchJkChF0",
            "bHNfc29ja2V0X2NvbmZpZxgCIAEoCzI/LmVudm95LmV4dGVuc2lvbnMudHJh",
            "bnNwb3J0X3NvY2tldHMudGxzLnYzLkRvd25zdHJlYW1UbHNDb250ZXh0Qgj6",
            "QgWKAQIQASLaAQoWVXBzdHJlYW1TdGFydFRsc0NvbmZpZxJcChdjbGVhcnRl",
            "eHRfc29ja2V0X2NvbmZpZxgBIAEoCzI7LmVudm95LmV4dGVuc2lvbnMudHJh",
            "bnNwb3J0X3NvY2tldHMucmF3X2J1ZmZlci52My5SYXdCdWZmZXISYgoRdGxz",
            "X3NvY2tldF9jb25maWcYAiABKAsyPS5lbnZveS5leHRlbnNpb25zLnRyYW5z",
            "cG9ydF9zb2NrZXRzLnRscy52My5VcHN0cmVhbVRsc0NvbnRleHRCCPpCBYoB",
            "AhABQlcKPGlvLmVudm95cHJveHkuZW52b3kuZXh0ZW5zaW9ucy50cmFuc3Bv",
            "cnRfc29ja2V0cy5zdGFydHRscy52M0INU3RhcnR0bHNQcm90b1ABuoDI0QYC",
            "EAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Extensions.TransportSockets.RawBuffer.V3.RawBufferReflection.Descriptor, global::Envoy.Extensions.TransportSockets.Tls.V3.TlsReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Extensions.TransportSockets.Starttls.V3.StartTlsConfig), global::Envoy.Extensions.TransportSockets.Starttls.V3.StartTlsConfig.Parser, new[]{ "CleartextSocketConfig", "TlsSocketConfig" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Extensions.TransportSockets.Starttls.V3.UpstreamStartTlsConfig), global::Envoy.Extensions.TransportSockets.Starttls.V3.UpstreamStartTlsConfig.Parser, new[]{ "CleartextSocketConfig", "TlsSocketConfig" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Configuration for a downstream StartTls transport socket.
  /// StartTls transport socket wraps two sockets:
  /// * raw_buffer socket which is used at the beginning of the session
  /// * TLS socket used when a protocol negotiates a switch to encrypted traffic.
  /// </summary>
  public sealed partial class StartTlsConfig : pb::IMessage<StartTlsConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StartTlsConfig> _parser = new pb::MessageParser<StartTlsConfig>(() => new StartTlsConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StartTlsConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Extensions.TransportSockets.Starttls.V3.StarttlsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartTlsConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartTlsConfig(StartTlsConfig other) : this() {
      cleartextSocketConfig_ = other.cleartextSocketConfig_ != null ? other.cleartextSocketConfig_.Clone() : null;
      tlsSocketConfig_ = other.tlsSocketConfig_ != null ? other.tlsSocketConfig_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartTlsConfig Clone() {
      return new StartTlsConfig(this);
    }

    /// <summary>Field number for the "cleartext_socket_config" field.</summary>
    public const int CleartextSocketConfigFieldNumber = 1;
    private global::Envoy.Extensions.TransportSockets.RawBuffer.V3.RawBuffer cleartextSocketConfig_;
    /// <summary>
    /// (optional) Configuration for clear-text socket used at the beginning of the session.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Extensions.TransportSockets.RawBuffer.V3.RawBuffer CleartextSocketConfig {
      get { return cleartextSocketConfig_; }
      set {
        cleartextSocketConfig_ = value;
      }
    }

    /// <summary>Field number for the "tls_socket_config" field.</summary>
    public const int TlsSocketConfigFieldNumber = 2;
    private global::Envoy.Extensions.TransportSockets.Tls.V3.DownstreamTlsContext tlsSocketConfig_;
    /// <summary>
    /// Configuration for a downstream TLS socket.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Extensions.TransportSockets.Tls.V3.DownstreamTlsContext TlsSocketConfig {
      get { return tlsSocketConfig_; }
      set {
        tlsSocketConfig_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StartTlsConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StartTlsConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CleartextSocketConfig, other.CleartextSocketConfig)) return false;
      if (!object.Equals(TlsSocketConfig, other.TlsSocketConfig)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (cleartextSocketConfig_ != null) hash ^= CleartextSocketConfig.GetHashCode();
      if (tlsSocketConfig_ != null) hash ^= TlsSocketConfig.GetHashCode();
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
      if (cleartextSocketConfig_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CleartextSocketConfig);
      }
      if (tlsSocketConfig_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(TlsSocketConfig);
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
      if (cleartextSocketConfig_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CleartextSocketConfig);
      }
      if (tlsSocketConfig_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(TlsSocketConfig);
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
      if (cleartextSocketConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CleartextSocketConfig);
      }
      if (tlsSocketConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TlsSocketConfig);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StartTlsConfig other) {
      if (other == null) {
        return;
      }
      if (other.cleartextSocketConfig_ != null) {
        if (cleartextSocketConfig_ == null) {
          CleartextSocketConfig = new global::Envoy.Extensions.TransportSockets.RawBuffer.V3.RawBuffer();
        }
        CleartextSocketConfig.MergeFrom(other.CleartextSocketConfig);
      }
      if (other.tlsSocketConfig_ != null) {
        if (tlsSocketConfig_ == null) {
          TlsSocketConfig = new global::Envoy.Extensions.TransportSockets.Tls.V3.DownstreamTlsContext();
        }
        TlsSocketConfig.MergeFrom(other.TlsSocketConfig);
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
            if (cleartextSocketConfig_ == null) {
              CleartextSocketConfig = new global::Envoy.Extensions.TransportSockets.RawBuffer.V3.RawBuffer();
            }
            input.ReadMessage(CleartextSocketConfig);
            break;
          }
          case 18: {
            if (tlsSocketConfig_ == null) {
              TlsSocketConfig = new global::Envoy.Extensions.TransportSockets.Tls.V3.DownstreamTlsContext();
            }
            input.ReadMessage(TlsSocketConfig);
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
            if (cleartextSocketConfig_ == null) {
              CleartextSocketConfig = new global::Envoy.Extensions.TransportSockets.RawBuffer.V3.RawBuffer();
            }
            input.ReadMessage(CleartextSocketConfig);
            break;
          }
          case 18: {
            if (tlsSocketConfig_ == null) {
              TlsSocketConfig = new global::Envoy.Extensions.TransportSockets.Tls.V3.DownstreamTlsContext();
            }
            input.ReadMessage(TlsSocketConfig);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Configuration for an upstream StartTls transport socket.
  /// StartTls transport socket wraps two sockets:
  /// * raw_buffer socket which is used at the beginning of the session
  /// * TLS socket used when a protocol negotiates a switch to encrypted traffic.
  /// </summary>
  public sealed partial class UpstreamStartTlsConfig : pb::IMessage<UpstreamStartTlsConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UpstreamStartTlsConfig> _parser = new pb::MessageParser<UpstreamStartTlsConfig>(() => new UpstreamStartTlsConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UpstreamStartTlsConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Extensions.TransportSockets.Starttls.V3.StarttlsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpstreamStartTlsConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpstreamStartTlsConfig(UpstreamStartTlsConfig other) : this() {
      cleartextSocketConfig_ = other.cleartextSocketConfig_ != null ? other.cleartextSocketConfig_.Clone() : null;
      tlsSocketConfig_ = other.tlsSocketConfig_ != null ? other.tlsSocketConfig_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpstreamStartTlsConfig Clone() {
      return new UpstreamStartTlsConfig(this);
    }

    /// <summary>Field number for the "cleartext_socket_config" field.</summary>
    public const int CleartextSocketConfigFieldNumber = 1;
    private global::Envoy.Extensions.TransportSockets.RawBuffer.V3.RawBuffer cleartextSocketConfig_;
    /// <summary>
    /// (optional) Configuration for clear-text socket used at the beginning of the session.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Extensions.TransportSockets.RawBuffer.V3.RawBuffer CleartextSocketConfig {
      get { return cleartextSocketConfig_; }
      set {
        cleartextSocketConfig_ = value;
      }
    }

    /// <summary>Field number for the "tls_socket_config" field.</summary>
    public const int TlsSocketConfigFieldNumber = 2;
    private global::Envoy.Extensions.TransportSockets.Tls.V3.UpstreamTlsContext tlsSocketConfig_;
    /// <summary>
    /// Configuration for an upstream TLS socket.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Extensions.TransportSockets.Tls.V3.UpstreamTlsContext TlsSocketConfig {
      get { return tlsSocketConfig_; }
      set {
        tlsSocketConfig_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UpstreamStartTlsConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UpstreamStartTlsConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CleartextSocketConfig, other.CleartextSocketConfig)) return false;
      if (!object.Equals(TlsSocketConfig, other.TlsSocketConfig)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (cleartextSocketConfig_ != null) hash ^= CleartextSocketConfig.GetHashCode();
      if (tlsSocketConfig_ != null) hash ^= TlsSocketConfig.GetHashCode();
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
      if (cleartextSocketConfig_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CleartextSocketConfig);
      }
      if (tlsSocketConfig_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(TlsSocketConfig);
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
      if (cleartextSocketConfig_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CleartextSocketConfig);
      }
      if (tlsSocketConfig_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(TlsSocketConfig);
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
      if (cleartextSocketConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CleartextSocketConfig);
      }
      if (tlsSocketConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TlsSocketConfig);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UpstreamStartTlsConfig other) {
      if (other == null) {
        return;
      }
      if (other.cleartextSocketConfig_ != null) {
        if (cleartextSocketConfig_ == null) {
          CleartextSocketConfig = new global::Envoy.Extensions.TransportSockets.RawBuffer.V3.RawBuffer();
        }
        CleartextSocketConfig.MergeFrom(other.CleartextSocketConfig);
      }
      if (other.tlsSocketConfig_ != null) {
        if (tlsSocketConfig_ == null) {
          TlsSocketConfig = new global::Envoy.Extensions.TransportSockets.Tls.V3.UpstreamTlsContext();
        }
        TlsSocketConfig.MergeFrom(other.TlsSocketConfig);
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
            if (cleartextSocketConfig_ == null) {
              CleartextSocketConfig = new global::Envoy.Extensions.TransportSockets.RawBuffer.V3.RawBuffer();
            }
            input.ReadMessage(CleartextSocketConfig);
            break;
          }
          case 18: {
            if (tlsSocketConfig_ == null) {
              TlsSocketConfig = new global::Envoy.Extensions.TransportSockets.Tls.V3.UpstreamTlsContext();
            }
            input.ReadMessage(TlsSocketConfig);
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
            if (cleartextSocketConfig_ == null) {
              CleartextSocketConfig = new global::Envoy.Extensions.TransportSockets.RawBuffer.V3.RawBuffer();
            }
            input.ReadMessage(CleartextSocketConfig);
            break;
          }
          case 18: {
            if (tlsSocketConfig_ == null) {
              TlsSocketConfig = new global::Envoy.Extensions.TransportSockets.Tls.V3.UpstreamTlsContext();
            }
            input.ReadMessage(TlsSocketConfig);
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
