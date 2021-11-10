// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/extensions/filters/network/ext_authz/v3/ext_authz.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Extensions.Filters.Network.ExtAuthz.V3 {

  /// <summary>Holder for reflection information generated from envoy/extensions/filters/network/ext_authz/v3/ext_authz.proto</summary>
  public static partial class ExtAuthzReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/extensions/filters/network/ext_authz/v3/ext_authz.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExtAuthzReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1lbnZveS9leHRlbnNpb25zL2ZpbHRlcnMvbmV0d29yay9leHRfYXV0aHov",
            "djMvZXh0X2F1dGh6LnByb3RvEi1lbnZveS5leHRlbnNpb25zLmZpbHRlcnMu",
            "bmV0d29yay5leHRfYXV0aHoudjMaKGVudm95L2NvbmZpZy9jb3JlL3YzL2Nv",
            "bmZpZ19zb3VyY2UucHJvdG8aJ2Vudm95L2NvbmZpZy9jb3JlL3YzL2dycGNf",
            "c2VydmljZS5wcm90bxokZW52b3kvdHlwZS9tYXRjaGVyL3YzL21ldGFkYXRh",
            "LnByb3RvGh11ZHBhL2Fubm90YXRpb25zL3N0YXR1cy5wcm90bxohdWRwYS9h",
            "bm5vdGF0aW9ucy92ZXJzaW9uaW5nLnByb3RvGhd2YWxpZGF0ZS92YWxpZGF0",
            "ZS5wcm90byKUAwoIRXh0QXV0aHoSHAoLc3RhdF9wcmVmaXgYASABKAlCB/pC",
            "BHICEAESNwoMZ3JwY19zZXJ2aWNlGAIgASgLMiEuZW52b3kuY29uZmlnLmNv",
            "cmUudjMuR3JwY1NlcnZpY2USGgoSZmFpbHVyZV9tb2RlX2FsbG93GAMgASgI",
            "EiAKGGluY2x1ZGVfcGVlcl9jZXJ0aWZpY2F0ZRgEIAEoCBJJChV0cmFuc3Bv",
            "cnRfYXBpX3ZlcnNpb24YBSABKA4yIC5lbnZveS5jb25maWcuY29yZS52My5B",
            "cGlWZXJzaW9uQgj6QgWCAQIQARJHChdmaWx0ZXJfZW5hYmxlZF9tZXRhZGF0",
            "YRgGIAEoCzImLmVudm95LnR5cGUubWF0Y2hlci52My5NZXRhZGF0YU1hdGNo",
            "ZXISJQodYm9vdHN0cmFwX21ldGFkYXRhX2xhYmVsc19rZXkYByABKAk6OJrF",
            "iB4zCjFlbnZveS5jb25maWcuZmlsdGVyLm5ldHdvcmsuZXh0X2F1dGh6LnYy",
            "LkV4dEF1dGh6QlYKO2lvLmVudm95cHJveHkuZW52b3kuZXh0ZW5zaW9ucy5m",
            "aWx0ZXJzLm5ldHdvcmsuZXh0X2F1dGh6LnYzQg1FeHRBdXRoelByb3RvUAG6",
            "gMjRBgIQAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Config.Core.V3.ConfigSourceReflection.Descriptor, global::Envoy.Config.Core.V3.GrpcServiceReflection.Descriptor, global::Envoy.Type.Matcher.V3.MetadataReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Udpa.Annotations.VersioningReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Extensions.Filters.Network.ExtAuthz.V3.ExtAuthz), global::Envoy.Extensions.Filters.Network.ExtAuthz.V3.ExtAuthz.Parser, new[]{ "StatPrefix", "GrpcService", "FailureModeAllow", "IncludePeerCertificate", "TransportApiVersion", "FilterEnabledMetadata", "BootstrapMetadataLabelsKey" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// External Authorization filter calls out to an external service over the
  /// gRPC Authorization API defined by
  /// :ref:`CheckRequest &lt;envoy_v3_api_msg_service.auth.v3.CheckRequest>`.
  /// A failed check will cause this filter to close the TCP connection.
  /// [#next-free-field: 8]
  /// </summary>
  public sealed partial class ExtAuthz : pb::IMessage<ExtAuthz>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ExtAuthz> _parser = new pb::MessageParser<ExtAuthz>(() => new ExtAuthz());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ExtAuthz> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Extensions.Filters.Network.ExtAuthz.V3.ExtAuthzReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExtAuthz() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExtAuthz(ExtAuthz other) : this() {
      statPrefix_ = other.statPrefix_;
      grpcService_ = other.grpcService_ != null ? other.grpcService_.Clone() : null;
      failureModeAllow_ = other.failureModeAllow_;
      includePeerCertificate_ = other.includePeerCertificate_;
      transportApiVersion_ = other.transportApiVersion_;
      filterEnabledMetadata_ = other.filterEnabledMetadata_ != null ? other.filterEnabledMetadata_.Clone() : null;
      bootstrapMetadataLabelsKey_ = other.bootstrapMetadataLabelsKey_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExtAuthz Clone() {
      return new ExtAuthz(this);
    }

    /// <summary>Field number for the "stat_prefix" field.</summary>
    public const int StatPrefixFieldNumber = 1;
    private string statPrefix_ = "";
    /// <summary>
    /// The prefix to use when emitting statistics.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StatPrefix {
      get { return statPrefix_; }
      set {
        statPrefix_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "grpc_service" field.</summary>
    public const int GrpcServiceFieldNumber = 2;
    private global::Envoy.Config.Core.V3.GrpcService grpcService_;
    /// <summary>
    /// The external authorization gRPC service configuration.
    /// The default timeout is set to 200ms by this filter.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Config.Core.V3.GrpcService GrpcService {
      get { return grpcService_; }
      set {
        grpcService_ = value;
      }
    }

    /// <summary>Field number for the "failure_mode_allow" field.</summary>
    public const int FailureModeAllowFieldNumber = 3;
    private bool failureModeAllow_;
    /// <summary>
    /// The filter's behaviour in case the external authorization service does
    /// not respond back. When it is set to true, Envoy will also allow traffic in case of
    /// communication failure between authorization service and the proxy.
    /// Defaults to false.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool FailureModeAllow {
      get { return failureModeAllow_; }
      set {
        failureModeAllow_ = value;
      }
    }

    /// <summary>Field number for the "include_peer_certificate" field.</summary>
    public const int IncludePeerCertificateFieldNumber = 4;
    private bool includePeerCertificate_;
    /// <summary>
    /// Specifies if the peer certificate is sent to the external service.
    ///
    /// When this field is true, Envoy will include the peer X.509 certificate, if available, in the
    /// :ref:`certificate&lt;envoy_v3_api_field_service.auth.v3.AttributeContext.Peer.certificate>`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IncludePeerCertificate {
      get { return includePeerCertificate_; }
      set {
        includePeerCertificate_ = value;
      }
    }

    /// <summary>Field number for the "transport_api_version" field.</summary>
    public const int TransportApiVersionFieldNumber = 5;
    private global::Envoy.Config.Core.V3.ApiVersion transportApiVersion_ = global::Envoy.Config.Core.V3.ApiVersion.Auto;
    /// <summary>
    /// API version for ext_authz transport protocol. This describes the ext_authz gRPC endpoint and
    /// version of Check{Request,Response} used on the wire.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Config.Core.V3.ApiVersion TransportApiVersion {
      get { return transportApiVersion_; }
      set {
        transportApiVersion_ = value;
      }
    }

    /// <summary>Field number for the "filter_enabled_metadata" field.</summary>
    public const int FilterEnabledMetadataFieldNumber = 6;
    private global::Envoy.Type.Matcher.V3.MetadataMatcher filterEnabledMetadata_;
    /// <summary>
    /// Specifies if the filter is enabled with metadata matcher.
    /// If this field is not specified, the filter will be enabled for all requests.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Type.Matcher.V3.MetadataMatcher FilterEnabledMetadata {
      get { return filterEnabledMetadata_; }
      set {
        filterEnabledMetadata_ = value;
      }
    }

    /// <summary>Field number for the "bootstrap_metadata_labels_key" field.</summary>
    public const int BootstrapMetadataLabelsKeyFieldNumber = 7;
    private string bootstrapMetadataLabelsKey_ = "";
    /// <summary>
    /// Optional labels that will be passed to :ref:`labels&lt;envoy_v3_api_field_service.auth.v3.AttributeContext.Peer.labels>` in
    /// :ref:`destination&lt;envoy_v3_api_field_service.auth.v3.AttributeContext.destination>`.
    /// The labels will be read from :ref:`metadata&lt;envoy_v3_api_msg_config.core.v3.Node>` with the specified key.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string BootstrapMetadataLabelsKey {
      get { return bootstrapMetadataLabelsKey_; }
      set {
        bootstrapMetadataLabelsKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ExtAuthz);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ExtAuthz other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StatPrefix != other.StatPrefix) return false;
      if (!object.Equals(GrpcService, other.GrpcService)) return false;
      if (FailureModeAllow != other.FailureModeAllow) return false;
      if (IncludePeerCertificate != other.IncludePeerCertificate) return false;
      if (TransportApiVersion != other.TransportApiVersion) return false;
      if (!object.Equals(FilterEnabledMetadata, other.FilterEnabledMetadata)) return false;
      if (BootstrapMetadataLabelsKey != other.BootstrapMetadataLabelsKey) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StatPrefix.Length != 0) hash ^= StatPrefix.GetHashCode();
      if (grpcService_ != null) hash ^= GrpcService.GetHashCode();
      if (FailureModeAllow != false) hash ^= FailureModeAllow.GetHashCode();
      if (IncludePeerCertificate != false) hash ^= IncludePeerCertificate.GetHashCode();
      if (TransportApiVersion != global::Envoy.Config.Core.V3.ApiVersion.Auto) hash ^= TransportApiVersion.GetHashCode();
      if (filterEnabledMetadata_ != null) hash ^= FilterEnabledMetadata.GetHashCode();
      if (BootstrapMetadataLabelsKey.Length != 0) hash ^= BootstrapMetadataLabelsKey.GetHashCode();
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
      if (StatPrefix.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(StatPrefix);
      }
      if (grpcService_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(GrpcService);
      }
      if (FailureModeAllow != false) {
        output.WriteRawTag(24);
        output.WriteBool(FailureModeAllow);
      }
      if (IncludePeerCertificate != false) {
        output.WriteRawTag(32);
        output.WriteBool(IncludePeerCertificate);
      }
      if (TransportApiVersion != global::Envoy.Config.Core.V3.ApiVersion.Auto) {
        output.WriteRawTag(40);
        output.WriteEnum((int) TransportApiVersion);
      }
      if (filterEnabledMetadata_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(FilterEnabledMetadata);
      }
      if (BootstrapMetadataLabelsKey.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(BootstrapMetadataLabelsKey);
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
      if (StatPrefix.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(StatPrefix);
      }
      if (grpcService_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(GrpcService);
      }
      if (FailureModeAllow != false) {
        output.WriteRawTag(24);
        output.WriteBool(FailureModeAllow);
      }
      if (IncludePeerCertificate != false) {
        output.WriteRawTag(32);
        output.WriteBool(IncludePeerCertificate);
      }
      if (TransportApiVersion != global::Envoy.Config.Core.V3.ApiVersion.Auto) {
        output.WriteRawTag(40);
        output.WriteEnum((int) TransportApiVersion);
      }
      if (filterEnabledMetadata_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(FilterEnabledMetadata);
      }
      if (BootstrapMetadataLabelsKey.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(BootstrapMetadataLabelsKey);
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
      if (StatPrefix.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StatPrefix);
      }
      if (grpcService_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GrpcService);
      }
      if (FailureModeAllow != false) {
        size += 1 + 1;
      }
      if (IncludePeerCertificate != false) {
        size += 1 + 1;
      }
      if (TransportApiVersion != global::Envoy.Config.Core.V3.ApiVersion.Auto) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) TransportApiVersion);
      }
      if (filterEnabledMetadata_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FilterEnabledMetadata);
      }
      if (BootstrapMetadataLabelsKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BootstrapMetadataLabelsKey);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ExtAuthz other) {
      if (other == null) {
        return;
      }
      if (other.StatPrefix.Length != 0) {
        StatPrefix = other.StatPrefix;
      }
      if (other.grpcService_ != null) {
        if (grpcService_ == null) {
          GrpcService = new global::Envoy.Config.Core.V3.GrpcService();
        }
        GrpcService.MergeFrom(other.GrpcService);
      }
      if (other.FailureModeAllow != false) {
        FailureModeAllow = other.FailureModeAllow;
      }
      if (other.IncludePeerCertificate != false) {
        IncludePeerCertificate = other.IncludePeerCertificate;
      }
      if (other.TransportApiVersion != global::Envoy.Config.Core.V3.ApiVersion.Auto) {
        TransportApiVersion = other.TransportApiVersion;
      }
      if (other.filterEnabledMetadata_ != null) {
        if (filterEnabledMetadata_ == null) {
          FilterEnabledMetadata = new global::Envoy.Type.Matcher.V3.MetadataMatcher();
        }
        FilterEnabledMetadata.MergeFrom(other.FilterEnabledMetadata);
      }
      if (other.BootstrapMetadataLabelsKey.Length != 0) {
        BootstrapMetadataLabelsKey = other.BootstrapMetadataLabelsKey;
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
            StatPrefix = input.ReadString();
            break;
          }
          case 18: {
            if (grpcService_ == null) {
              GrpcService = new global::Envoy.Config.Core.V3.GrpcService();
            }
            input.ReadMessage(GrpcService);
            break;
          }
          case 24: {
            FailureModeAllow = input.ReadBool();
            break;
          }
          case 32: {
            IncludePeerCertificate = input.ReadBool();
            break;
          }
          case 40: {
            TransportApiVersion = (global::Envoy.Config.Core.V3.ApiVersion) input.ReadEnum();
            break;
          }
          case 50: {
            if (filterEnabledMetadata_ == null) {
              FilterEnabledMetadata = new global::Envoy.Type.Matcher.V3.MetadataMatcher();
            }
            input.ReadMessage(FilterEnabledMetadata);
            break;
          }
          case 58: {
            BootstrapMetadataLabelsKey = input.ReadString();
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
            StatPrefix = input.ReadString();
            break;
          }
          case 18: {
            if (grpcService_ == null) {
              GrpcService = new global::Envoy.Config.Core.V3.GrpcService();
            }
            input.ReadMessage(GrpcService);
            break;
          }
          case 24: {
            FailureModeAllow = input.ReadBool();
            break;
          }
          case 32: {
            IncludePeerCertificate = input.ReadBool();
            break;
          }
          case 40: {
            TransportApiVersion = (global::Envoy.Config.Core.V3.ApiVersion) input.ReadEnum();
            break;
          }
          case 50: {
            if (filterEnabledMetadata_ == null) {
              FilterEnabledMetadata = new global::Envoy.Type.Matcher.V3.MetadataMatcher();
            }
            input.ReadMessage(FilterEnabledMetadata);
            break;
          }
          case 58: {
            BootstrapMetadataLabelsKey = input.ReadString();
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
