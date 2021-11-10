// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/config/trace/v2/opencensus.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Trace.V2 {

  /// <summary>Holder for reflection information generated from envoy/config/trace/v2/opencensus.proto</summary>
  public static partial class OpencensusReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/config/trace/v2/opencensus.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OpencensusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZlbnZveS9jb25maWcvdHJhY2UvdjIvb3BlbmNlbnN1cy5wcm90bxIVZW52",
            "b3kuY29uZmlnLnRyYWNlLnYyGiRlbnZveS9hcGkvdjIvY29yZS9ncnBjX3Nl",
            "cnZpY2UucHJvdG8aLG9wZW5jZW5zdXMvcHJvdG8vdHJhY2UvdjEvdHJhY2Vf",
            "Y29uZmlnLnByb3RvGh11ZHBhL2Fubm90YXRpb25zL3N0YXR1cy5wcm90byLY",
            "BQoQT3BlbkNlbnN1c0NvbmZpZxI8Cgx0cmFjZV9jb25maWcYASABKAsyJi5v",
            "cGVuY2Vuc3VzLnByb3RvLnRyYWNlLnYxLlRyYWNlQ29uZmlnEh8KF3N0ZG91",
            "dF9leHBvcnRlcl9lbmFibGVkGAIgASgIEiQKHHN0YWNrZHJpdmVyX2V4cG9y",
            "dGVyX2VuYWJsZWQYAyABKAgSHgoWc3RhY2tkcml2ZXJfcHJvamVjdF9pZBgE",
            "IAEoCRIbChNzdGFja2RyaXZlcl9hZGRyZXNzGAogASgJEkAKGHN0YWNrZHJp",
            "dmVyX2dycGNfc2VydmljZRgNIAEoCzIeLmVudm95LmFwaS52Mi5jb3JlLkdy",
            "cGNTZXJ2aWNlEh8KF3ppcGtpbl9leHBvcnRlcl9lbmFibGVkGAUgASgIEhIK",
            "CnppcGtpbl91cmwYBiABKAkSIAoYb2NhZ2VudF9leHBvcnRlcl9lbmFibGVk",
            "GAsgASgIEhcKD29jYWdlbnRfYWRkcmVzcxgMIAEoCRI8ChRvY2FnZW50X2dy",
            "cGNfc2VydmljZRgOIAEoCzIeLmVudm95LmFwaS52Mi5jb3JlLkdycGNTZXJ2",
            "aWNlElQKFmluY29taW5nX3RyYWNlX2NvbnRleHQYCCADKA4yNC5lbnZveS5j",
            "b25maWcudHJhY2UudjIuT3BlbkNlbnN1c0NvbmZpZy5UcmFjZUNvbnRleHQS",
            "VAoWb3V0Z29pbmdfdHJhY2VfY29udGV4dBgJIAMoDjI0LmVudm95LmNvbmZp",
            "Zy50cmFjZS52Mi5PcGVuQ2Vuc3VzQ29uZmlnLlRyYWNlQ29udGV4dCJgCgxU",
            "cmFjZUNvbnRleHQSCAoETk9ORRAAEhEKDVRSQUNFX0NPTlRFWFQQARISCg5H",
            "UlBDX1RSQUNFX0JJThACEhcKE0NMT1VEX1RSQUNFX0NPTlRFWFQQAxIGCgJC",
            "MxAESgQIBxAIQkAKI2lvLmVudm95cHJveHkuZW52b3kuY29uZmlnLnRyYWNl",
            "LnYyQg9PcGVuY2Vuc3VzUHJvdG9QAbqAyNEGAhABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Api.V2.Core.GrpcServiceReflection.Descriptor, global::Opencensus.Proto.Trace.V1.TraceConfigReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Trace.V2.OpenCensusConfig), global::Envoy.Config.Trace.V2.OpenCensusConfig.Parser, new[]{ "TraceConfig", "StdoutExporterEnabled", "StackdriverExporterEnabled", "StackdriverProjectId", "StackdriverAddress", "StackdriverGrpcService", "ZipkinExporterEnabled", "ZipkinUrl", "OcagentExporterEnabled", "OcagentAddress", "OcagentGrpcService", "IncomingTraceContext", "OutgoingTraceContext" }, null, new[]{ typeof(global::Envoy.Config.Trace.V2.OpenCensusConfig.Types.TraceContext) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Configuration for the OpenCensus tracer.
  /// [#next-free-field: 15]
  /// [#extension: envoy.tracers.opencensus]
  /// </summary>
  public sealed partial class OpenCensusConfig : pb::IMessage<OpenCensusConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OpenCensusConfig> _parser = new pb::MessageParser<OpenCensusConfig>(() => new OpenCensusConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OpenCensusConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Trace.V2.OpencensusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OpenCensusConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OpenCensusConfig(OpenCensusConfig other) : this() {
      traceConfig_ = other.traceConfig_ != null ? other.traceConfig_.Clone() : null;
      stdoutExporterEnabled_ = other.stdoutExporterEnabled_;
      stackdriverExporterEnabled_ = other.stackdriverExporterEnabled_;
      stackdriverProjectId_ = other.stackdriverProjectId_;
      stackdriverAddress_ = other.stackdriverAddress_;
      stackdriverGrpcService_ = other.stackdriverGrpcService_ != null ? other.stackdriverGrpcService_.Clone() : null;
      zipkinExporterEnabled_ = other.zipkinExporterEnabled_;
      zipkinUrl_ = other.zipkinUrl_;
      ocagentExporterEnabled_ = other.ocagentExporterEnabled_;
      ocagentAddress_ = other.ocagentAddress_;
      ocagentGrpcService_ = other.ocagentGrpcService_ != null ? other.ocagentGrpcService_.Clone() : null;
      incomingTraceContext_ = other.incomingTraceContext_.Clone();
      outgoingTraceContext_ = other.outgoingTraceContext_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OpenCensusConfig Clone() {
      return new OpenCensusConfig(this);
    }

    /// <summary>Field number for the "trace_config" field.</summary>
    public const int TraceConfigFieldNumber = 1;
    private global::Opencensus.Proto.Trace.V1.TraceConfig traceConfig_;
    /// <summary>
    /// Configures tracing, e.g. the sampler, max number of annotations, etc.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Opencensus.Proto.Trace.V1.TraceConfig TraceConfig {
      get { return traceConfig_; }
      set {
        traceConfig_ = value;
      }
    }

    /// <summary>Field number for the "stdout_exporter_enabled" field.</summary>
    public const int StdoutExporterEnabledFieldNumber = 2;
    private bool stdoutExporterEnabled_;
    /// <summary>
    /// Enables the stdout exporter if set to true. This is intended for debugging
    /// purposes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool StdoutExporterEnabled {
      get { return stdoutExporterEnabled_; }
      set {
        stdoutExporterEnabled_ = value;
      }
    }

    /// <summary>Field number for the "stackdriver_exporter_enabled" field.</summary>
    public const int StackdriverExporterEnabledFieldNumber = 3;
    private bool stackdriverExporterEnabled_;
    /// <summary>
    /// Enables the Stackdriver exporter if set to true. The project_id must also
    /// be set.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool StackdriverExporterEnabled {
      get { return stackdriverExporterEnabled_; }
      set {
        stackdriverExporterEnabled_ = value;
      }
    }

    /// <summary>Field number for the "stackdriver_project_id" field.</summary>
    public const int StackdriverProjectIdFieldNumber = 4;
    private string stackdriverProjectId_ = "";
    /// <summary>
    /// The Cloud project_id to use for Stackdriver tracing.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StackdriverProjectId {
      get { return stackdriverProjectId_; }
      set {
        stackdriverProjectId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "stackdriver_address" field.</summary>
    public const int StackdriverAddressFieldNumber = 10;
    private string stackdriverAddress_ = "";
    /// <summary>
    /// (optional) By default, the Stackdriver exporter will connect to production
    /// Stackdriver. If stackdriver_address is non-empty, it will instead connect
    /// to this address, which is in the gRPC format:
    /// https://github.com/grpc/grpc/blob/master/doc/naming.md
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StackdriverAddress {
      get { return stackdriverAddress_; }
      set {
        stackdriverAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "stackdriver_grpc_service" field.</summary>
    public const int StackdriverGrpcServiceFieldNumber = 13;
    private global::Envoy.Api.V2.Core.GrpcService stackdriverGrpcService_;
    /// <summary>
    /// (optional) The gRPC server that hosts Stackdriver tracing service. Only
    /// Google gRPC is supported. If :ref:`target_uri &lt;envoy_v3_api_field_config.core.v3.GrpcService.GoogleGrpc.target_uri>`
    /// is not provided, the default production Stackdriver address will be used.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Api.V2.Core.GrpcService StackdriverGrpcService {
      get { return stackdriverGrpcService_; }
      set {
        stackdriverGrpcService_ = value;
      }
    }

    /// <summary>Field number for the "zipkin_exporter_enabled" field.</summary>
    public const int ZipkinExporterEnabledFieldNumber = 5;
    private bool zipkinExporterEnabled_;
    /// <summary>
    /// Enables the Zipkin exporter if set to true. The url and service name must
    /// also be set.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ZipkinExporterEnabled {
      get { return zipkinExporterEnabled_; }
      set {
        zipkinExporterEnabled_ = value;
      }
    }

    /// <summary>Field number for the "zipkin_url" field.</summary>
    public const int ZipkinUrlFieldNumber = 6;
    private string zipkinUrl_ = "";
    /// <summary>
    /// The URL to Zipkin, e.g. "http://127.0.0.1:9411/api/v2/spans"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ZipkinUrl {
      get { return zipkinUrl_; }
      set {
        zipkinUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ocagent_exporter_enabled" field.</summary>
    public const int OcagentExporterEnabledFieldNumber = 11;
    private bool ocagentExporterEnabled_;
    /// <summary>
    /// Enables the OpenCensus Agent exporter if set to true. The ocagent_address or
    /// ocagent_grpc_service must also be set.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool OcagentExporterEnabled {
      get { return ocagentExporterEnabled_; }
      set {
        ocagentExporterEnabled_ = value;
      }
    }

    /// <summary>Field number for the "ocagent_address" field.</summary>
    public const int OcagentAddressFieldNumber = 12;
    private string ocagentAddress_ = "";
    /// <summary>
    /// The address of the OpenCensus Agent, if its exporter is enabled, in gRPC
    /// format: https://github.com/grpc/grpc/blob/master/doc/naming.md
    /// [#comment:TODO: deprecate this field]
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OcagentAddress {
      get { return ocagentAddress_; }
      set {
        ocagentAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ocagent_grpc_service" field.</summary>
    public const int OcagentGrpcServiceFieldNumber = 14;
    private global::Envoy.Api.V2.Core.GrpcService ocagentGrpcService_;
    /// <summary>
    /// (optional) The gRPC server hosted by the OpenCensus Agent. Only Google gRPC is supported.
    /// This is only used if the ocagent_address is left empty.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Api.V2.Core.GrpcService OcagentGrpcService {
      get { return ocagentGrpcService_; }
      set {
        ocagentGrpcService_ = value;
      }
    }

    /// <summary>Field number for the "incoming_trace_context" field.</summary>
    public const int IncomingTraceContextFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Envoy.Config.Trace.V2.OpenCensusConfig.Types.TraceContext> _repeated_incomingTraceContext_codec
        = pb::FieldCodec.ForEnum(66, x => (int) x, x => (global::Envoy.Config.Trace.V2.OpenCensusConfig.Types.TraceContext) x);
    private readonly pbc::RepeatedField<global::Envoy.Config.Trace.V2.OpenCensusConfig.Types.TraceContext> incomingTraceContext_ = new pbc::RepeatedField<global::Envoy.Config.Trace.V2.OpenCensusConfig.Types.TraceContext>();
    /// <summary>
    /// List of incoming trace context headers we will accept. First one found
    /// wins.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Envoy.Config.Trace.V2.OpenCensusConfig.Types.TraceContext> IncomingTraceContext {
      get { return incomingTraceContext_; }
    }

    /// <summary>Field number for the "outgoing_trace_context" field.</summary>
    public const int OutgoingTraceContextFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Envoy.Config.Trace.V2.OpenCensusConfig.Types.TraceContext> _repeated_outgoingTraceContext_codec
        = pb::FieldCodec.ForEnum(74, x => (int) x, x => (global::Envoy.Config.Trace.V2.OpenCensusConfig.Types.TraceContext) x);
    private readonly pbc::RepeatedField<global::Envoy.Config.Trace.V2.OpenCensusConfig.Types.TraceContext> outgoingTraceContext_ = new pbc::RepeatedField<global::Envoy.Config.Trace.V2.OpenCensusConfig.Types.TraceContext>();
    /// <summary>
    /// List of outgoing trace context headers we will produce.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Envoy.Config.Trace.V2.OpenCensusConfig.Types.TraceContext> OutgoingTraceContext {
      get { return outgoingTraceContext_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OpenCensusConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OpenCensusConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(TraceConfig, other.TraceConfig)) return false;
      if (StdoutExporterEnabled != other.StdoutExporterEnabled) return false;
      if (StackdriverExporterEnabled != other.StackdriverExporterEnabled) return false;
      if (StackdriverProjectId != other.StackdriverProjectId) return false;
      if (StackdriverAddress != other.StackdriverAddress) return false;
      if (!object.Equals(StackdriverGrpcService, other.StackdriverGrpcService)) return false;
      if (ZipkinExporterEnabled != other.ZipkinExporterEnabled) return false;
      if (ZipkinUrl != other.ZipkinUrl) return false;
      if (OcagentExporterEnabled != other.OcagentExporterEnabled) return false;
      if (OcagentAddress != other.OcagentAddress) return false;
      if (!object.Equals(OcagentGrpcService, other.OcagentGrpcService)) return false;
      if(!incomingTraceContext_.Equals(other.incomingTraceContext_)) return false;
      if(!outgoingTraceContext_.Equals(other.outgoingTraceContext_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (traceConfig_ != null) hash ^= TraceConfig.GetHashCode();
      if (StdoutExporterEnabled != false) hash ^= StdoutExporterEnabled.GetHashCode();
      if (StackdriverExporterEnabled != false) hash ^= StackdriverExporterEnabled.GetHashCode();
      if (StackdriverProjectId.Length != 0) hash ^= StackdriverProjectId.GetHashCode();
      if (StackdriverAddress.Length != 0) hash ^= StackdriverAddress.GetHashCode();
      if (stackdriverGrpcService_ != null) hash ^= StackdriverGrpcService.GetHashCode();
      if (ZipkinExporterEnabled != false) hash ^= ZipkinExporterEnabled.GetHashCode();
      if (ZipkinUrl.Length != 0) hash ^= ZipkinUrl.GetHashCode();
      if (OcagentExporterEnabled != false) hash ^= OcagentExporterEnabled.GetHashCode();
      if (OcagentAddress.Length != 0) hash ^= OcagentAddress.GetHashCode();
      if (ocagentGrpcService_ != null) hash ^= OcagentGrpcService.GetHashCode();
      hash ^= incomingTraceContext_.GetHashCode();
      hash ^= outgoingTraceContext_.GetHashCode();
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
      if (traceConfig_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(TraceConfig);
      }
      if (StdoutExporterEnabled != false) {
        output.WriteRawTag(16);
        output.WriteBool(StdoutExporterEnabled);
      }
      if (StackdriverExporterEnabled != false) {
        output.WriteRawTag(24);
        output.WriteBool(StackdriverExporterEnabled);
      }
      if (StackdriverProjectId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(StackdriverProjectId);
      }
      if (ZipkinExporterEnabled != false) {
        output.WriteRawTag(40);
        output.WriteBool(ZipkinExporterEnabled);
      }
      if (ZipkinUrl.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(ZipkinUrl);
      }
      incomingTraceContext_.WriteTo(output, _repeated_incomingTraceContext_codec);
      outgoingTraceContext_.WriteTo(output, _repeated_outgoingTraceContext_codec);
      if (StackdriverAddress.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(StackdriverAddress);
      }
      if (OcagentExporterEnabled != false) {
        output.WriteRawTag(88);
        output.WriteBool(OcagentExporterEnabled);
      }
      if (OcagentAddress.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(OcagentAddress);
      }
      if (stackdriverGrpcService_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(StackdriverGrpcService);
      }
      if (ocagentGrpcService_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(OcagentGrpcService);
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
      if (traceConfig_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(TraceConfig);
      }
      if (StdoutExporterEnabled != false) {
        output.WriteRawTag(16);
        output.WriteBool(StdoutExporterEnabled);
      }
      if (StackdriverExporterEnabled != false) {
        output.WriteRawTag(24);
        output.WriteBool(StackdriverExporterEnabled);
      }
      if (StackdriverProjectId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(StackdriverProjectId);
      }
      if (ZipkinExporterEnabled != false) {
        output.WriteRawTag(40);
        output.WriteBool(ZipkinExporterEnabled);
      }
      if (ZipkinUrl.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(ZipkinUrl);
      }
      incomingTraceContext_.WriteTo(ref output, _repeated_incomingTraceContext_codec);
      outgoingTraceContext_.WriteTo(ref output, _repeated_outgoingTraceContext_codec);
      if (StackdriverAddress.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(StackdriverAddress);
      }
      if (OcagentExporterEnabled != false) {
        output.WriteRawTag(88);
        output.WriteBool(OcagentExporterEnabled);
      }
      if (OcagentAddress.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(OcagentAddress);
      }
      if (stackdriverGrpcService_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(StackdriverGrpcService);
      }
      if (ocagentGrpcService_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(OcagentGrpcService);
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
      if (traceConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TraceConfig);
      }
      if (StdoutExporterEnabled != false) {
        size += 1 + 1;
      }
      if (StackdriverExporterEnabled != false) {
        size += 1 + 1;
      }
      if (StackdriverProjectId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StackdriverProjectId);
      }
      if (StackdriverAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StackdriverAddress);
      }
      if (stackdriverGrpcService_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StackdriverGrpcService);
      }
      if (ZipkinExporterEnabled != false) {
        size += 1 + 1;
      }
      if (ZipkinUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ZipkinUrl);
      }
      if (OcagentExporterEnabled != false) {
        size += 1 + 1;
      }
      if (OcagentAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OcagentAddress);
      }
      if (ocagentGrpcService_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OcagentGrpcService);
      }
      size += incomingTraceContext_.CalculateSize(_repeated_incomingTraceContext_codec);
      size += outgoingTraceContext_.CalculateSize(_repeated_outgoingTraceContext_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OpenCensusConfig other) {
      if (other == null) {
        return;
      }
      if (other.traceConfig_ != null) {
        if (traceConfig_ == null) {
          TraceConfig = new global::Opencensus.Proto.Trace.V1.TraceConfig();
        }
        TraceConfig.MergeFrom(other.TraceConfig);
      }
      if (other.StdoutExporterEnabled != false) {
        StdoutExporterEnabled = other.StdoutExporterEnabled;
      }
      if (other.StackdriverExporterEnabled != false) {
        StackdriverExporterEnabled = other.StackdriverExporterEnabled;
      }
      if (other.StackdriverProjectId.Length != 0) {
        StackdriverProjectId = other.StackdriverProjectId;
      }
      if (other.StackdriverAddress.Length != 0) {
        StackdriverAddress = other.StackdriverAddress;
      }
      if (other.stackdriverGrpcService_ != null) {
        if (stackdriverGrpcService_ == null) {
          StackdriverGrpcService = new global::Envoy.Api.V2.Core.GrpcService();
        }
        StackdriverGrpcService.MergeFrom(other.StackdriverGrpcService);
      }
      if (other.ZipkinExporterEnabled != false) {
        ZipkinExporterEnabled = other.ZipkinExporterEnabled;
      }
      if (other.ZipkinUrl.Length != 0) {
        ZipkinUrl = other.ZipkinUrl;
      }
      if (other.OcagentExporterEnabled != false) {
        OcagentExporterEnabled = other.OcagentExporterEnabled;
      }
      if (other.OcagentAddress.Length != 0) {
        OcagentAddress = other.OcagentAddress;
      }
      if (other.ocagentGrpcService_ != null) {
        if (ocagentGrpcService_ == null) {
          OcagentGrpcService = new global::Envoy.Api.V2.Core.GrpcService();
        }
        OcagentGrpcService.MergeFrom(other.OcagentGrpcService);
      }
      incomingTraceContext_.Add(other.incomingTraceContext_);
      outgoingTraceContext_.Add(other.outgoingTraceContext_);
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
            if (traceConfig_ == null) {
              TraceConfig = new global::Opencensus.Proto.Trace.V1.TraceConfig();
            }
            input.ReadMessage(TraceConfig);
            break;
          }
          case 16: {
            StdoutExporterEnabled = input.ReadBool();
            break;
          }
          case 24: {
            StackdriverExporterEnabled = input.ReadBool();
            break;
          }
          case 34: {
            StackdriverProjectId = input.ReadString();
            break;
          }
          case 40: {
            ZipkinExporterEnabled = input.ReadBool();
            break;
          }
          case 50: {
            ZipkinUrl = input.ReadString();
            break;
          }
          case 66:
          case 64: {
            incomingTraceContext_.AddEntriesFrom(input, _repeated_incomingTraceContext_codec);
            break;
          }
          case 74:
          case 72: {
            outgoingTraceContext_.AddEntriesFrom(input, _repeated_outgoingTraceContext_codec);
            break;
          }
          case 82: {
            StackdriverAddress = input.ReadString();
            break;
          }
          case 88: {
            OcagentExporterEnabled = input.ReadBool();
            break;
          }
          case 98: {
            OcagentAddress = input.ReadString();
            break;
          }
          case 106: {
            if (stackdriverGrpcService_ == null) {
              StackdriverGrpcService = new global::Envoy.Api.V2.Core.GrpcService();
            }
            input.ReadMessage(StackdriverGrpcService);
            break;
          }
          case 114: {
            if (ocagentGrpcService_ == null) {
              OcagentGrpcService = new global::Envoy.Api.V2.Core.GrpcService();
            }
            input.ReadMessage(OcagentGrpcService);
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
            if (traceConfig_ == null) {
              TraceConfig = new global::Opencensus.Proto.Trace.V1.TraceConfig();
            }
            input.ReadMessage(TraceConfig);
            break;
          }
          case 16: {
            StdoutExporterEnabled = input.ReadBool();
            break;
          }
          case 24: {
            StackdriverExporterEnabled = input.ReadBool();
            break;
          }
          case 34: {
            StackdriverProjectId = input.ReadString();
            break;
          }
          case 40: {
            ZipkinExporterEnabled = input.ReadBool();
            break;
          }
          case 50: {
            ZipkinUrl = input.ReadString();
            break;
          }
          case 66:
          case 64: {
            incomingTraceContext_.AddEntriesFrom(ref input, _repeated_incomingTraceContext_codec);
            break;
          }
          case 74:
          case 72: {
            outgoingTraceContext_.AddEntriesFrom(ref input, _repeated_outgoingTraceContext_codec);
            break;
          }
          case 82: {
            StackdriverAddress = input.ReadString();
            break;
          }
          case 88: {
            OcagentExporterEnabled = input.ReadBool();
            break;
          }
          case 98: {
            OcagentAddress = input.ReadString();
            break;
          }
          case 106: {
            if (stackdriverGrpcService_ == null) {
              StackdriverGrpcService = new global::Envoy.Api.V2.Core.GrpcService();
            }
            input.ReadMessage(StackdriverGrpcService);
            break;
          }
          case 114: {
            if (ocagentGrpcService_ == null) {
              OcagentGrpcService = new global::Envoy.Api.V2.Core.GrpcService();
            }
            input.ReadMessage(OcagentGrpcService);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the OpenCensusConfig message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum TraceContext {
        /// <summary>
        /// No-op default, no trace context is utilized.
        /// </summary>
        [pbr::OriginalName("NONE")] None = 0,
        /// <summary>
        /// W3C Trace-Context format "traceparent:" header.
        /// </summary>
        [pbr::OriginalName("TRACE_CONTEXT")] TraceContext = 1,
        /// <summary>
        /// Binary "grpc-trace-bin:" header.
        /// </summary>
        [pbr::OriginalName("GRPC_TRACE_BIN")] GrpcTraceBin = 2,
        /// <summary>
        /// "X-Cloud-Trace-Context:" header.
        /// </summary>
        [pbr::OriginalName("CLOUD_TRACE_CONTEXT")] CloudTraceContext = 3,
        /// <summary>
        /// X-B3-* headers.
        /// </summary>
        [pbr::OriginalName("B3")] B3 = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code