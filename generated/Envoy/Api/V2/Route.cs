// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/api/v2/route.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Api.V2 {

  /// <summary>Holder for reflection information generated from envoy/api/v2/route.proto</summary>
  public static partial class RouteReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/api/v2/route.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RouteReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhlbnZveS9hcGkvdjIvcm91dGUucHJvdG8SDGVudm95LmFwaS52MhocZW52",
            "b3kvYXBpL3YyL2NvcmUvYmFzZS5wcm90bxolZW52b3kvYXBpL3YyL2NvcmUv",
            "Y29uZmlnX3NvdXJjZS5wcm90bxopZW52b3kvYXBpL3YyL3JvdXRlL3JvdXRl",
            "X2NvbXBvbmVudHMucHJvdG8aHmdvb2dsZS9wcm90b2J1Zi93cmFwcGVycy5w",
            "cm90bxoedWRwYS9hbm5vdGF0aW9ucy9taWdyYXRlLnByb3RvGh11ZHBhL2Fu",
            "bm90YXRpb25zL3N0YXR1cy5wcm90bxoXdmFsaWRhdGUvdmFsaWRhdGUucHJv",
            "dG8inwQKElJvdXRlQ29uZmlndXJhdGlvbhIMCgRuYW1lGAEgASgJEjYKDXZp",
            "cnR1YWxfaG9zdHMYAiADKAsyHy5lbnZveS5hcGkudjIucm91dGUuVmlydHVh",
            "bEhvc3QSIAoEdmhkcxgJIAEoCzISLmVudm95LmFwaS52Mi5WaGRzEi8KFWlu",
            "dGVybmFsX29ubHlfaGVhZGVycxgDIAMoCUIQ+kINkgEKIghyBsABAcgBABJQ",
            "ChdyZXNwb25zZV9oZWFkZXJzX3RvX2FkZBgEIAMoCzIkLmVudm95LmFwaS52",
            "Mi5jb3JlLkhlYWRlclZhbHVlT3B0aW9uQgn6QgaSAQMQ6AcSNAoacmVzcG9u",
            "c2VfaGVhZGVyc190b19yZW1vdmUYBSADKAlCEPpCDZIBCiIIcgbAAQHIAQAS",
            "TwoWcmVxdWVzdF9oZWFkZXJzX3RvX2FkZBgGIAMoCzIkLmVudm95LmFwaS52",
            "Mi5jb3JlLkhlYWRlclZhbHVlT3B0aW9uQgn6QgaSAQMQ6AcSMwoZcmVxdWVz",
            "dF9oZWFkZXJzX3RvX3JlbW92ZRgIIAMoCUIQ+kINkgEKIghyBsABAcgBABIr",
            "CiNtb3N0X3NwZWNpZmljX2hlYWRlcl9tdXRhdGlvbnNfd2lucxgKIAEoCBI1",
            "ChF2YWxpZGF0ZV9jbHVzdGVycxgHIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5C",
            "b29sVmFsdWUiSAoEVmhkcxJACg1jb25maWdfc291cmNlGAEgASgLMh8uZW52",
            "b3kuYXBpLnYyLmNvcmUuQ29uZmlnU291cmNlQgj6QgWKAQIQAUJPChppby5l",
            "bnZveXByb3h5LmVudm95LmFwaS52MkIKUm91dGVQcm90b1AB8pj+jwUXEhVl",
            "bnZveS5jb25maWcucm91dGUudjO6gMjRBgIQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Api.V2.Core.BaseReflection.Descriptor, global::Envoy.Api.V2.Core.ConfigSourceReflection.Descriptor, global::Envoy.Api.V2.Route.RouteComponentsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Udpa.Annotations.MigrateReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Api.V2.RouteConfiguration), global::Envoy.Api.V2.RouteConfiguration.Parser, new[]{ "Name", "VirtualHosts", "Vhds", "InternalOnlyHeaders", "ResponseHeadersToAdd", "ResponseHeadersToRemove", "RequestHeadersToAdd", "RequestHeadersToRemove", "MostSpecificHeaderMutationsWins", "ValidateClusters" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Api.V2.Vhds), global::Envoy.Api.V2.Vhds.Parser, new[]{ "ConfigSource" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// [#next-free-field: 11]
  /// </summary>
  public sealed partial class RouteConfiguration : pb::IMessage<RouteConfiguration>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RouteConfiguration> _parser = new pb::MessageParser<RouteConfiguration>(() => new RouteConfiguration());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RouteConfiguration> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Api.V2.RouteReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RouteConfiguration() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RouteConfiguration(RouteConfiguration other) : this() {
      name_ = other.name_;
      virtualHosts_ = other.virtualHosts_.Clone();
      vhds_ = other.vhds_ != null ? other.vhds_.Clone() : null;
      internalOnlyHeaders_ = other.internalOnlyHeaders_.Clone();
      responseHeadersToAdd_ = other.responseHeadersToAdd_.Clone();
      responseHeadersToRemove_ = other.responseHeadersToRemove_.Clone();
      requestHeadersToAdd_ = other.requestHeadersToAdd_.Clone();
      requestHeadersToRemove_ = other.requestHeadersToRemove_.Clone();
      mostSpecificHeaderMutationsWins_ = other.mostSpecificHeaderMutationsWins_;
      ValidateClusters = other.ValidateClusters;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RouteConfiguration Clone() {
      return new RouteConfiguration(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The name of the route configuration. For example, it might match
    /// :ref:`route_config_name
    /// &lt;envoy_api_field_config.filter.network.http_connection_manager.v2.Rds.route_config_name>` in
    /// :ref:`envoy_api_msg_config.filter.network.http_connection_manager.v2.Rds`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "virtual_hosts" field.</summary>
    public const int VirtualHostsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Envoy.Api.V2.Route.VirtualHost> _repeated_virtualHosts_codec
        = pb::FieldCodec.ForMessage(18, global::Envoy.Api.V2.Route.VirtualHost.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Api.V2.Route.VirtualHost> virtualHosts_ = new pbc::RepeatedField<global::Envoy.Api.V2.Route.VirtualHost>();
    /// <summary>
    /// An array of virtual hosts that make up the route table.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Envoy.Api.V2.Route.VirtualHost> VirtualHosts {
      get { return virtualHosts_; }
    }

    /// <summary>Field number for the "vhds" field.</summary>
    public const int VhdsFieldNumber = 9;
    private global::Envoy.Api.V2.Vhds vhds_;
    /// <summary>
    /// An array of virtual hosts will be dynamically loaded via the VHDS API.
    /// Both *virtual_hosts* and *vhds* fields will be used when present. *virtual_hosts* can be used
    /// for a base routing table or for infrequently changing virtual hosts. *vhds* is used for
    /// on-demand discovery of virtual hosts. The contents of these two fields will be merged to
    /// generate a routing table for a given RouteConfiguration, with *vhds* derived configuration
    /// taking precedence.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Api.V2.Vhds Vhds {
      get { return vhds_; }
      set {
        vhds_ = value;
      }
    }

    /// <summary>Field number for the "internal_only_headers" field.</summary>
    public const int InternalOnlyHeadersFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_internalOnlyHeaders_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> internalOnlyHeaders_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Optionally specifies a list of HTTP headers that the connection manager
    /// will consider to be internal only. If they are found on external requests they will be cleaned
    /// prior to filter invocation. See :ref:`config_http_conn_man_headers_x-envoy-internal` for more
    /// information.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> InternalOnlyHeaders {
      get { return internalOnlyHeaders_; }
    }

    /// <summary>Field number for the "response_headers_to_add" field.</summary>
    public const int ResponseHeadersToAddFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Envoy.Api.V2.Core.HeaderValueOption> _repeated_responseHeadersToAdd_codec
        = pb::FieldCodec.ForMessage(34, global::Envoy.Api.V2.Core.HeaderValueOption.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Api.V2.Core.HeaderValueOption> responseHeadersToAdd_ = new pbc::RepeatedField<global::Envoy.Api.V2.Core.HeaderValueOption>();
    /// <summary>
    /// Specifies a list of HTTP headers that should be added to each response that
    /// the connection manager encodes. Headers specified at this level are applied
    /// after headers from any enclosed :ref:`envoy_api_msg_route.VirtualHost` or
    /// :ref:`envoy_api_msg_route.RouteAction`. For more information, including details on
    /// header value syntax, see the documentation on :ref:`custom request headers
    /// &lt;config_http_conn_man_headers_custom_request_headers>`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Envoy.Api.V2.Core.HeaderValueOption> ResponseHeadersToAdd {
      get { return responseHeadersToAdd_; }
    }

    /// <summary>Field number for the "response_headers_to_remove" field.</summary>
    public const int ResponseHeadersToRemoveFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_responseHeadersToRemove_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> responseHeadersToRemove_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Specifies a list of HTTP headers that should be removed from each response
    /// that the connection manager encodes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> ResponseHeadersToRemove {
      get { return responseHeadersToRemove_; }
    }

    /// <summary>Field number for the "request_headers_to_add" field.</summary>
    public const int RequestHeadersToAddFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Envoy.Api.V2.Core.HeaderValueOption> _repeated_requestHeadersToAdd_codec
        = pb::FieldCodec.ForMessage(50, global::Envoy.Api.V2.Core.HeaderValueOption.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Api.V2.Core.HeaderValueOption> requestHeadersToAdd_ = new pbc::RepeatedField<global::Envoy.Api.V2.Core.HeaderValueOption>();
    /// <summary>
    /// Specifies a list of HTTP headers that should be added to each request
    /// routed by the HTTP connection manager. Headers specified at this level are
    /// applied after headers from any enclosed :ref:`envoy_api_msg_route.VirtualHost` or
    /// :ref:`envoy_api_msg_route.RouteAction`. For more information, including details on
    /// header value syntax, see the documentation on :ref:`custom request headers
    /// &lt;config_http_conn_man_headers_custom_request_headers>`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Envoy.Api.V2.Core.HeaderValueOption> RequestHeadersToAdd {
      get { return requestHeadersToAdd_; }
    }

    /// <summary>Field number for the "request_headers_to_remove" field.</summary>
    public const int RequestHeadersToRemoveFieldNumber = 8;
    private static readonly pb::FieldCodec<string> _repeated_requestHeadersToRemove_codec
        = pb::FieldCodec.ForString(66);
    private readonly pbc::RepeatedField<string> requestHeadersToRemove_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Specifies a list of HTTP headers that should be removed from each request
    /// routed by the HTTP connection manager.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> RequestHeadersToRemove {
      get { return requestHeadersToRemove_; }
    }

    /// <summary>Field number for the "most_specific_header_mutations_wins" field.</summary>
    public const int MostSpecificHeaderMutationsWinsFieldNumber = 10;
    private bool mostSpecificHeaderMutationsWins_;
    /// <summary>
    /// By default, headers that should be added/removed are evaluated from most to least specific:
    ///
    /// * route level
    /// * virtual host level
    /// * connection manager level
    ///
    /// To allow setting overrides at the route or virtual host level, this order can be reversed
    /// by setting this option to true. Defaults to false.
    ///
    /// [#next-major-version: In the v3 API, this will default to true.]
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool MostSpecificHeaderMutationsWins {
      get { return mostSpecificHeaderMutationsWins_; }
      set {
        mostSpecificHeaderMutationsWins_ = value;
      }
    }

    /// <summary>Field number for the "validate_clusters" field.</summary>
    public const int ValidateClustersFieldNumber = 7;
    private static readonly pb::FieldCodec<bool?> _single_validateClusters_codec = pb::FieldCodec.ForStructWrapper<bool>(58);
    private bool? validateClusters_;
    /// <summary>
    /// An optional boolean that specifies whether the clusters that the route
    /// table refers to will be validated by the cluster manager. If set to true
    /// and a route refers to a non-existent cluster, the route table will not
    /// load. If set to false and a route refers to a non-existent cluster, the
    /// route table will load and the router filter will return a 404 if the route
    /// is selected at runtime. This setting defaults to true if the route table
    /// is statically defined via the :ref:`route_config
    /// &lt;envoy_api_field_config.filter.network.http_connection_manager.v2.HttpConnectionManager.route_config>`
    /// option. This setting default to false if the route table is loaded dynamically via the
    /// :ref:`rds
    /// &lt;envoy_api_field_config.filter.network.http_connection_manager.v2.HttpConnectionManager.rds>`
    /// option. Users may wish to override the default behavior in certain cases (for example when
    /// using CDS with a static route table).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool? ValidateClusters {
      get { return validateClusters_; }
      set {
        validateClusters_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RouteConfiguration);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RouteConfiguration other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if(!virtualHosts_.Equals(other.virtualHosts_)) return false;
      if (!object.Equals(Vhds, other.Vhds)) return false;
      if(!internalOnlyHeaders_.Equals(other.internalOnlyHeaders_)) return false;
      if(!responseHeadersToAdd_.Equals(other.responseHeadersToAdd_)) return false;
      if(!responseHeadersToRemove_.Equals(other.responseHeadersToRemove_)) return false;
      if(!requestHeadersToAdd_.Equals(other.requestHeadersToAdd_)) return false;
      if(!requestHeadersToRemove_.Equals(other.requestHeadersToRemove_)) return false;
      if (MostSpecificHeaderMutationsWins != other.MostSpecificHeaderMutationsWins) return false;
      if (ValidateClusters != other.ValidateClusters) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= virtualHosts_.GetHashCode();
      if (vhds_ != null) hash ^= Vhds.GetHashCode();
      hash ^= internalOnlyHeaders_.GetHashCode();
      hash ^= responseHeadersToAdd_.GetHashCode();
      hash ^= responseHeadersToRemove_.GetHashCode();
      hash ^= requestHeadersToAdd_.GetHashCode();
      hash ^= requestHeadersToRemove_.GetHashCode();
      if (MostSpecificHeaderMutationsWins != false) hash ^= MostSpecificHeaderMutationsWins.GetHashCode();
      if (validateClusters_ != null) hash ^= ValidateClusters.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      virtualHosts_.WriteTo(output, _repeated_virtualHosts_codec);
      internalOnlyHeaders_.WriteTo(output, _repeated_internalOnlyHeaders_codec);
      responseHeadersToAdd_.WriteTo(output, _repeated_responseHeadersToAdd_codec);
      responseHeadersToRemove_.WriteTo(output, _repeated_responseHeadersToRemove_codec);
      requestHeadersToAdd_.WriteTo(output, _repeated_requestHeadersToAdd_codec);
      if (validateClusters_ != null) {
        _single_validateClusters_codec.WriteTagAndValue(output, ValidateClusters);
      }
      requestHeadersToRemove_.WriteTo(output, _repeated_requestHeadersToRemove_codec);
      if (vhds_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Vhds);
      }
      if (MostSpecificHeaderMutationsWins != false) {
        output.WriteRawTag(80);
        output.WriteBool(MostSpecificHeaderMutationsWins);
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      virtualHosts_.WriteTo(ref output, _repeated_virtualHosts_codec);
      internalOnlyHeaders_.WriteTo(ref output, _repeated_internalOnlyHeaders_codec);
      responseHeadersToAdd_.WriteTo(ref output, _repeated_responseHeadersToAdd_codec);
      responseHeadersToRemove_.WriteTo(ref output, _repeated_responseHeadersToRemove_codec);
      requestHeadersToAdd_.WriteTo(ref output, _repeated_requestHeadersToAdd_codec);
      if (validateClusters_ != null) {
        _single_validateClusters_codec.WriteTagAndValue(ref output, ValidateClusters);
      }
      requestHeadersToRemove_.WriteTo(ref output, _repeated_requestHeadersToRemove_codec);
      if (vhds_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Vhds);
      }
      if (MostSpecificHeaderMutationsWins != false) {
        output.WriteRawTag(80);
        output.WriteBool(MostSpecificHeaderMutationsWins);
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
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += virtualHosts_.CalculateSize(_repeated_virtualHosts_codec);
      if (vhds_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Vhds);
      }
      size += internalOnlyHeaders_.CalculateSize(_repeated_internalOnlyHeaders_codec);
      size += responseHeadersToAdd_.CalculateSize(_repeated_responseHeadersToAdd_codec);
      size += responseHeadersToRemove_.CalculateSize(_repeated_responseHeadersToRemove_codec);
      size += requestHeadersToAdd_.CalculateSize(_repeated_requestHeadersToAdd_codec);
      size += requestHeadersToRemove_.CalculateSize(_repeated_requestHeadersToRemove_codec);
      if (MostSpecificHeaderMutationsWins != false) {
        size += 1 + 1;
      }
      if (validateClusters_ != null) {
        size += _single_validateClusters_codec.CalculateSizeWithTag(ValidateClusters);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RouteConfiguration other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      virtualHosts_.Add(other.virtualHosts_);
      if (other.vhds_ != null) {
        if (vhds_ == null) {
          Vhds = new global::Envoy.Api.V2.Vhds();
        }
        Vhds.MergeFrom(other.Vhds);
      }
      internalOnlyHeaders_.Add(other.internalOnlyHeaders_);
      responseHeadersToAdd_.Add(other.responseHeadersToAdd_);
      responseHeadersToRemove_.Add(other.responseHeadersToRemove_);
      requestHeadersToAdd_.Add(other.requestHeadersToAdd_);
      requestHeadersToRemove_.Add(other.requestHeadersToRemove_);
      if (other.MostSpecificHeaderMutationsWins != false) {
        MostSpecificHeaderMutationsWins = other.MostSpecificHeaderMutationsWins;
      }
      if (other.validateClusters_ != null) {
        if (validateClusters_ == null || other.ValidateClusters != false) {
          ValidateClusters = other.ValidateClusters;
        }
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            virtualHosts_.AddEntriesFrom(input, _repeated_virtualHosts_codec);
            break;
          }
          case 26: {
            internalOnlyHeaders_.AddEntriesFrom(input, _repeated_internalOnlyHeaders_codec);
            break;
          }
          case 34: {
            responseHeadersToAdd_.AddEntriesFrom(input, _repeated_responseHeadersToAdd_codec);
            break;
          }
          case 42: {
            responseHeadersToRemove_.AddEntriesFrom(input, _repeated_responseHeadersToRemove_codec);
            break;
          }
          case 50: {
            requestHeadersToAdd_.AddEntriesFrom(input, _repeated_requestHeadersToAdd_codec);
            break;
          }
          case 58: {
            bool? value = _single_validateClusters_codec.Read(input);
            if (validateClusters_ == null || value != false) {
              ValidateClusters = value;
            }
            break;
          }
          case 66: {
            requestHeadersToRemove_.AddEntriesFrom(input, _repeated_requestHeadersToRemove_codec);
            break;
          }
          case 74: {
            if (vhds_ == null) {
              Vhds = new global::Envoy.Api.V2.Vhds();
            }
            input.ReadMessage(Vhds);
            break;
          }
          case 80: {
            MostSpecificHeaderMutationsWins = input.ReadBool();
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            virtualHosts_.AddEntriesFrom(ref input, _repeated_virtualHosts_codec);
            break;
          }
          case 26: {
            internalOnlyHeaders_.AddEntriesFrom(ref input, _repeated_internalOnlyHeaders_codec);
            break;
          }
          case 34: {
            responseHeadersToAdd_.AddEntriesFrom(ref input, _repeated_responseHeadersToAdd_codec);
            break;
          }
          case 42: {
            responseHeadersToRemove_.AddEntriesFrom(ref input, _repeated_responseHeadersToRemove_codec);
            break;
          }
          case 50: {
            requestHeadersToAdd_.AddEntriesFrom(ref input, _repeated_requestHeadersToAdd_codec);
            break;
          }
          case 58: {
            bool? value = _single_validateClusters_codec.Read(ref input);
            if (validateClusters_ == null || value != false) {
              ValidateClusters = value;
            }
            break;
          }
          case 66: {
            requestHeadersToRemove_.AddEntriesFrom(ref input, _repeated_requestHeadersToRemove_codec);
            break;
          }
          case 74: {
            if (vhds_ == null) {
              Vhds = new global::Envoy.Api.V2.Vhds();
            }
            input.ReadMessage(Vhds);
            break;
          }
          case 80: {
            MostSpecificHeaderMutationsWins = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class Vhds : pb::IMessage<Vhds>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Vhds> _parser = new pb::MessageParser<Vhds>(() => new Vhds());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Vhds> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Api.V2.RouteReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Vhds() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Vhds(Vhds other) : this() {
      configSource_ = other.configSource_ != null ? other.configSource_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Vhds Clone() {
      return new Vhds(this);
    }

    /// <summary>Field number for the "config_source" field.</summary>
    public const int ConfigSourceFieldNumber = 1;
    private global::Envoy.Api.V2.Core.ConfigSource configSource_;
    /// <summary>
    /// Configuration source specifier for VHDS.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Api.V2.Core.ConfigSource ConfigSource {
      get { return configSource_; }
      set {
        configSource_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Vhds);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Vhds other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ConfigSource, other.ConfigSource)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (configSource_ != null) hash ^= ConfigSource.GetHashCode();
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
      if (configSource_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ConfigSource);
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
      if (configSource_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ConfigSource);
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
      if (configSource_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ConfigSource);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Vhds other) {
      if (other == null) {
        return;
      }
      if (other.configSource_ != null) {
        if (configSource_ == null) {
          ConfigSource = new global::Envoy.Api.V2.Core.ConfigSource();
        }
        ConfigSource.MergeFrom(other.ConfigSource);
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
            if (configSource_ == null) {
              ConfigSource = new global::Envoy.Api.V2.Core.ConfigSource();
            }
            input.ReadMessage(ConfigSource);
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
            if (configSource_ == null) {
              ConfigSource = new global::Envoy.Api.V2.Core.ConfigSource();
            }
            input.ReadMessage(ConfigSource);
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
