// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/config/trace/v3/lightstep.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Trace.V3 {

  /// <summary>Holder for reflection information generated from envoy/config/trace/v3/lightstep.proto</summary>
  public static partial class LightstepReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/config/trace/v3/lightstep.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LightstepReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVlbnZveS9jb25maWcvdHJhY2UvdjMvbGlnaHRzdGVwLnByb3RvEhVlbnZv",
            "eS5jb25maWcudHJhY2UudjMaH2Vudm95L2NvbmZpZy9jb3JlL3YzL2Jhc2Uu",
            "cHJvdG8aI2Vudm95L2Fubm90YXRpb25zL2RlcHJlY2F0aW9uLnByb3RvGh51",
            "ZHBhL2Fubm90YXRpb25zL21pZ3JhdGUucHJvdG8aHXVkcGEvYW5ub3RhdGlv",
            "bnMvc3RhdHVzLnByb3RvGiF1ZHBhL2Fubm90YXRpb25zL3ZlcnNpb25pbmcu",
            "cHJvdG8aF3ZhbGlkYXRlL3ZhbGlkYXRlLnByb3RvIu0CCg9MaWdodHN0ZXBD",
            "b25maWcSIgoRY29sbGVjdG9yX2NsdXN0ZXIYASABKAlCB/pCBHICEAESJgoR",
            "YWNjZXNzX3Rva2VuX2ZpbGUYAiABKAlCCxgBkseG2AQDMy4wEjYKDGFjY2Vz",
            "c190b2tlbhgEIAEoCzIgLmVudm95LmNvbmZpZy5jb3JlLnYzLkRhdGFTb3Vy",
            "Y2USYAoRcHJvcGFnYXRpb25fbW9kZXMYAyADKA4yNi5lbnZveS5jb25maWcu",
            "dHJhY2UudjMuTGlnaHRzdGVwQ29uZmlnLlByb3BhZ2F0aW9uTW9kZUIN+kIK",
            "kgEHIgWCAQIQASJGCg9Qcm9wYWdhdGlvbk1vZGUSCQoFRU5WT1kQABINCglM",
            "SUdIVFNURVAQARIGCgJCMxACEhEKDVRSQUNFX0NPTlRFWFQQAzosmsWIHicK",
            "JWVudm95LmNvbmZpZy50cmFjZS52Mi5MaWdodHN0ZXBDb25maWdCcQojaW8u",
            "ZW52b3lwcm94eS5lbnZveS5jb25maWcudHJhY2UudjNCDkxpZ2h0c3RlcFBy",
            "b3RvUAHymP6PBSwSKmVudm95LmV4dGVuc2lvbnMudHJhY2Vycy5saWdodHN0",
            "ZXAudjRhbHBoYbqAyNEGAhACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Config.Core.V3.BaseReflection.Descriptor, global::Envoy.Annotations.DeprecationReflection.Descriptor, global::Udpa.Annotations.MigrateReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Udpa.Annotations.VersioningReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Trace.V3.LightstepConfig), global::Envoy.Config.Trace.V3.LightstepConfig.Parser, new[]{ "CollectorCluster", "AccessTokenFile", "AccessToken", "PropagationModes" }, null, new[]{ typeof(global::Envoy.Config.Trace.V3.LightstepConfig.Types.PropagationMode) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Configuration for the LightStep tracer.
  /// [#extension: envoy.tracers.lightstep]
  /// </summary>
  public sealed partial class LightstepConfig : pb::IMessage<LightstepConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LightstepConfig> _parser = new pb::MessageParser<LightstepConfig>(() => new LightstepConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LightstepConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Trace.V3.LightstepReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LightstepConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LightstepConfig(LightstepConfig other) : this() {
      collectorCluster_ = other.collectorCluster_;
      accessTokenFile_ = other.accessTokenFile_;
      accessToken_ = other.accessToken_ != null ? other.accessToken_.Clone() : null;
      propagationModes_ = other.propagationModes_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LightstepConfig Clone() {
      return new LightstepConfig(this);
    }

    /// <summary>Field number for the "collector_cluster" field.</summary>
    public const int CollectorClusterFieldNumber = 1;
    private string collectorCluster_ = "";
    /// <summary>
    /// The cluster manager cluster that hosts the LightStep collectors.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CollectorCluster {
      get { return collectorCluster_; }
      set {
        collectorCluster_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "access_token_file" field.</summary>
    public const int AccessTokenFileFieldNumber = 2;
    private string accessTokenFile_ = "";
    /// <summary>
    /// File containing the access token to the `LightStep
    /// &lt;https://lightstep.com/>`_ API.
    /// </summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AccessTokenFile {
      get { return accessTokenFile_; }
      set {
        accessTokenFile_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "access_token" field.</summary>
    public const int AccessTokenFieldNumber = 4;
    private global::Envoy.Config.Core.V3.DataSource accessToken_;
    /// <summary>
    /// Access token to the `LightStep &lt;https://lightstep.com/>`_ API.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Config.Core.V3.DataSource AccessToken {
      get { return accessToken_; }
      set {
        accessToken_ = value;
      }
    }

    /// <summary>Field number for the "propagation_modes" field.</summary>
    public const int PropagationModesFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Envoy.Config.Trace.V3.LightstepConfig.Types.PropagationMode> _repeated_propagationModes_codec
        = pb::FieldCodec.ForEnum(26, x => (int) x, x => (global::Envoy.Config.Trace.V3.LightstepConfig.Types.PropagationMode) x);
    private readonly pbc::RepeatedField<global::Envoy.Config.Trace.V3.LightstepConfig.Types.PropagationMode> propagationModes_ = new pbc::RepeatedField<global::Envoy.Config.Trace.V3.LightstepConfig.Types.PropagationMode>();
    /// <summary>
    /// Propagation modes to use by LightStep's tracer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Envoy.Config.Trace.V3.LightstepConfig.Types.PropagationMode> PropagationModes {
      get { return propagationModes_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LightstepConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LightstepConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CollectorCluster != other.CollectorCluster) return false;
      if (AccessTokenFile != other.AccessTokenFile) return false;
      if (!object.Equals(AccessToken, other.AccessToken)) return false;
      if(!propagationModes_.Equals(other.propagationModes_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CollectorCluster.Length != 0) hash ^= CollectorCluster.GetHashCode();
      if (AccessTokenFile.Length != 0) hash ^= AccessTokenFile.GetHashCode();
      if (accessToken_ != null) hash ^= AccessToken.GetHashCode();
      hash ^= propagationModes_.GetHashCode();
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
      if (CollectorCluster.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CollectorCluster);
      }
      if (AccessTokenFile.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AccessTokenFile);
      }
      propagationModes_.WriteTo(output, _repeated_propagationModes_codec);
      if (accessToken_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(AccessToken);
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
      if (CollectorCluster.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CollectorCluster);
      }
      if (AccessTokenFile.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AccessTokenFile);
      }
      propagationModes_.WriteTo(ref output, _repeated_propagationModes_codec);
      if (accessToken_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(AccessToken);
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
      if (CollectorCluster.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CollectorCluster);
      }
      if (AccessTokenFile.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AccessTokenFile);
      }
      if (accessToken_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AccessToken);
      }
      size += propagationModes_.CalculateSize(_repeated_propagationModes_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LightstepConfig other) {
      if (other == null) {
        return;
      }
      if (other.CollectorCluster.Length != 0) {
        CollectorCluster = other.CollectorCluster;
      }
      if (other.AccessTokenFile.Length != 0) {
        AccessTokenFile = other.AccessTokenFile;
      }
      if (other.accessToken_ != null) {
        if (accessToken_ == null) {
          AccessToken = new global::Envoy.Config.Core.V3.DataSource();
        }
        AccessToken.MergeFrom(other.AccessToken);
      }
      propagationModes_.Add(other.propagationModes_);
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
            CollectorCluster = input.ReadString();
            break;
          }
          case 18: {
            AccessTokenFile = input.ReadString();
            break;
          }
          case 26:
          case 24: {
            propagationModes_.AddEntriesFrom(input, _repeated_propagationModes_codec);
            break;
          }
          case 34: {
            if (accessToken_ == null) {
              AccessToken = new global::Envoy.Config.Core.V3.DataSource();
            }
            input.ReadMessage(AccessToken);
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
            CollectorCluster = input.ReadString();
            break;
          }
          case 18: {
            AccessTokenFile = input.ReadString();
            break;
          }
          case 26:
          case 24: {
            propagationModes_.AddEntriesFrom(ref input, _repeated_propagationModes_codec);
            break;
          }
          case 34: {
            if (accessToken_ == null) {
              AccessToken = new global::Envoy.Config.Core.V3.DataSource();
            }
            input.ReadMessage(AccessToken);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the LightstepConfig message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Available propagation modes
      /// </summary>
      public enum PropagationMode {
        /// <summary>
        /// Propagate trace context in the single header x-ot-span-context.
        /// </summary>
        [pbr::OriginalName("ENVOY")] Envoy = 0,
        /// <summary>
        /// Propagate trace context using LightStep's native format.
        /// </summary>
        [pbr::OriginalName("LIGHTSTEP")] Lightstep = 1,
        /// <summary>
        /// Propagate trace context using the b3 format.
        /// </summary>
        [pbr::OriginalName("B3")] B3 = 2,
        /// <summary>
        /// Propagation trace context using the w3 trace-context standard.
        /// </summary>
        [pbr::OriginalName("TRACE_CONTEXT")] TraceContext = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code