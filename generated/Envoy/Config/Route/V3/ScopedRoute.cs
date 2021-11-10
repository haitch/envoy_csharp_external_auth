// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/config/route/v3/scoped_route.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Route.V3 {

  /// <summary>Holder for reflection information generated from envoy/config/route/v3/scoped_route.proto</summary>
  public static partial class ScopedRouteReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/config/route/v3/scoped_route.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ScopedRouteReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihlbnZveS9jb25maWcvcm91dGUvdjMvc2NvcGVkX3JvdXRlLnByb3RvEhVl",
            "bnZveS5jb25maWcucm91dGUudjMaHXVkcGEvYW5ub3RhdGlvbnMvc3RhdHVz",
            "LnByb3RvGiF1ZHBhL2Fubm90YXRpb25zL3ZlcnNpb25pbmcucHJvdG8aF3Zh",
            "bGlkYXRlL3ZhbGlkYXRlLnByb3RvIugDChhTY29wZWRSb3V0ZUNvbmZpZ3Vy",
            "YXRpb24SEQoJb25fZGVtYW5kGAQgASgIEhUKBG5hbWUYASABKAlCB/pCBHIC",
            "EAESKQoYcm91dGVfY29uZmlndXJhdGlvbl9uYW1lGAIgASgJQgf6QgRyAhAB",
            "EkoKA2tleRgDIAEoCzIzLmVudm95LmNvbmZpZy5yb3V0ZS52My5TY29wZWRS",
            "b3V0ZUNvbmZpZ3VyYXRpb24uS2V5Qgj6QgWKAQIQARr8AQoDS2V5ElkKCWZy",
            "YWdtZW50cxgBIAMoCzI8LmVudm95LmNvbmZpZy5yb3V0ZS52My5TY29wZWRS",
            "b3V0ZUNvbmZpZ3VyYXRpb24uS2V5LkZyYWdtZW50Qgj6QgWSAQIIARpoCghG",
            "cmFnbWVudBIUCgpzdHJpbmdfa2V5GAEgASgJSAA6OZrFiB40CjJlbnZveS5h",
            "cGkudjIuU2NvcGVkUm91dGVDb25maWd1cmF0aW9uLktleS5GcmFnbWVudEIL",
            "CgR0eXBlEgP4QgE6MJrFiB4rCillbnZveS5hcGkudjIuU2NvcGVkUm91dGVD",
            "b25maWd1cmF0aW9uLktleTosmsWIHicKJWVudm95LmFwaS52Mi5TY29wZWRS",
            "b3V0ZUNvbmZpZ3VyYXRpb25CQQojaW8uZW52b3lwcm94eS5lbnZveS5jb25m",
            "aWcucm91dGUudjNCEFNjb3BlZFJvdXRlUHJvdG9QAbqAyNEGAhACYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Udpa.Annotations.StatusReflection.Descriptor, global::Udpa.Annotations.VersioningReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Route.V3.ScopedRouteConfiguration), global::Envoy.Config.Route.V3.ScopedRouteConfiguration.Parser, new[]{ "OnDemand", "Name", "RouteConfigurationName", "Key" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Route.V3.ScopedRouteConfiguration.Types.Key), global::Envoy.Config.Route.V3.ScopedRouteConfiguration.Types.Key.Parser, new[]{ "Fragments" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Route.V3.ScopedRouteConfiguration.Types.Key.Types.Fragment), global::Envoy.Config.Route.V3.ScopedRouteConfiguration.Types.Key.Types.Fragment.Parser, new[]{ "StringKey" }, new[]{ "Type" }, null, null, null)})})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Specifies a routing scope, which associates a
  /// :ref:`Key&lt;envoy_v3_api_msg_config.route.v3.ScopedRouteConfiguration.Key>` to a
  /// :ref:`envoy_v3_api_msg_config.route.v3.RouteConfiguration` (identified by its resource name).
  ///
  /// The HTTP connection manager builds up a table consisting of these Key to
  /// RouteConfiguration mappings, and looks up the RouteConfiguration to use per
  /// request according to the algorithm specified in the
  /// :ref:`scope_key_builder&lt;envoy_v3_api_field_extensions.filters.network.http_connection_manager.v3.ScopedRoutes.scope_key_builder>`
  /// assigned to the HttpConnectionManager.
  ///
  /// For example, with the following configurations (in YAML):
  ///
  /// HttpConnectionManager config:
  ///
  /// .. code::
  ///
  ///   ...
  ///   scoped_routes:
  ///     name: foo-scoped-routes
  ///     scope_key_builder:
  ///       fragments:
  ///         - header_value_extractor:
  ///             name: X-Route-Selector
  ///             element_separator: ,
  ///             element:
  ///               separator: =
  ///               key: vip
  ///
  /// ScopedRouteConfiguration resources (specified statically via
  /// :ref:`scoped_route_configurations_list&lt;envoy_v3_api_field_extensions.filters.network.http_connection_manager.v3.ScopedRoutes.scoped_route_configurations_list>`
  /// or obtained dynamically via SRDS):
  ///
  /// .. code::
  ///
  ///  (1)
  ///   name: route-scope1
  ///   route_configuration_name: route-config1
  ///   key:
  ///      fragments:
  ///        - string_key: 172.10.10.20
  ///
  ///  (2)
  ///   name: route-scope2
  ///   route_configuration_name: route-config2
  ///   key:
  ///     fragments:
  ///       - string_key: 172.20.20.30
  ///
  /// A request from a client such as:
  ///
  /// .. code::
  ///
  ///     GET / HTTP/1.1
  ///     Host: foo.com
  ///     X-Route-Selector: vip=172.10.10.20
  ///
  /// would result in the routing table defined by the `route-config1`
  /// RouteConfiguration being assigned to the HTTP request/stream.
  ///
  /// </summary>
  public sealed partial class ScopedRouteConfiguration : pb::IMessage<ScopedRouteConfiguration>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ScopedRouteConfiguration> _parser = new pb::MessageParser<ScopedRouteConfiguration>(() => new ScopedRouteConfiguration());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ScopedRouteConfiguration> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Route.V3.ScopedRouteReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScopedRouteConfiguration() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScopedRouteConfiguration(ScopedRouteConfiguration other) : this() {
      onDemand_ = other.onDemand_;
      name_ = other.name_;
      routeConfigurationName_ = other.routeConfigurationName_;
      key_ = other.key_ != null ? other.key_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScopedRouteConfiguration Clone() {
      return new ScopedRouteConfiguration(this);
    }

    /// <summary>Field number for the "on_demand" field.</summary>
    public const int OnDemandFieldNumber = 4;
    private bool onDemand_;
    /// <summary>
    /// Whether the RouteConfiguration should be loaded on demand.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool OnDemand {
      get { return onDemand_; }
      set {
        onDemand_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The name assigned to the routing scope.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "route_configuration_name" field.</summary>
    public const int RouteConfigurationNameFieldNumber = 2;
    private string routeConfigurationName_ = "";
    /// <summary>
    /// The resource name to use for a :ref:`envoy_v3_api_msg_service.discovery.v3.DiscoveryRequest` to an
    /// RDS server to fetch the :ref:`envoy_v3_api_msg_config.route.v3.RouteConfiguration` associated
    /// with this scope.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RouteConfigurationName {
      get { return routeConfigurationName_; }
      set {
        routeConfigurationName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "key" field.</summary>
    public const int KeyFieldNumber = 3;
    private global::Envoy.Config.Route.V3.ScopedRouteConfiguration.Types.Key key_;
    /// <summary>
    /// The key to match against.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Config.Route.V3.ScopedRouteConfiguration.Types.Key Key {
      get { return key_; }
      set {
        key_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ScopedRouteConfiguration);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ScopedRouteConfiguration other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OnDemand != other.OnDemand) return false;
      if (Name != other.Name) return false;
      if (RouteConfigurationName != other.RouteConfigurationName) return false;
      if (!object.Equals(Key, other.Key)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OnDemand != false) hash ^= OnDemand.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (RouteConfigurationName.Length != 0) hash ^= RouteConfigurationName.GetHashCode();
      if (key_ != null) hash ^= Key.GetHashCode();
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
      if (RouteConfigurationName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RouteConfigurationName);
      }
      if (key_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Key);
      }
      if (OnDemand != false) {
        output.WriteRawTag(32);
        output.WriteBool(OnDemand);
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
      if (RouteConfigurationName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RouteConfigurationName);
      }
      if (key_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Key);
      }
      if (OnDemand != false) {
        output.WriteRawTag(32);
        output.WriteBool(OnDemand);
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
      if (OnDemand != false) {
        size += 1 + 1;
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (RouteConfigurationName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RouteConfigurationName);
      }
      if (key_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Key);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ScopedRouteConfiguration other) {
      if (other == null) {
        return;
      }
      if (other.OnDemand != false) {
        OnDemand = other.OnDemand;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.RouteConfigurationName.Length != 0) {
        RouteConfigurationName = other.RouteConfigurationName;
      }
      if (other.key_ != null) {
        if (key_ == null) {
          Key = new global::Envoy.Config.Route.V3.ScopedRouteConfiguration.Types.Key();
        }
        Key.MergeFrom(other.Key);
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
            RouteConfigurationName = input.ReadString();
            break;
          }
          case 26: {
            if (key_ == null) {
              Key = new global::Envoy.Config.Route.V3.ScopedRouteConfiguration.Types.Key();
            }
            input.ReadMessage(Key);
            break;
          }
          case 32: {
            OnDemand = input.ReadBool();
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
            RouteConfigurationName = input.ReadString();
            break;
          }
          case 26: {
            if (key_ == null) {
              Key = new global::Envoy.Config.Route.V3.ScopedRouteConfiguration.Types.Key();
            }
            input.ReadMessage(Key);
            break;
          }
          case 32: {
            OnDemand = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ScopedRouteConfiguration message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Specifies a key which is matched against the output of the
      /// :ref:`scope_key_builder&lt;envoy_v3_api_field_extensions.filters.network.http_connection_manager.v3.ScopedRoutes.scope_key_builder>`
      /// specified in the HttpConnectionManager. The matching is done per HTTP
      /// request and is dependent on the order of the fragments contained in the
      /// Key.
      /// </summary>
      public sealed partial class Key : pb::IMessage<Key>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<Key> _parser = new pb::MessageParser<Key>(() => new Key());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<Key> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Envoy.Config.Route.V3.ScopedRouteConfiguration.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Key() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Key(Key other) : this() {
          fragments_ = other.fragments_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Key Clone() {
          return new Key(this);
        }

        /// <summary>Field number for the "fragments" field.</summary>
        public const int FragmentsFieldNumber = 1;
        private static readonly pb::FieldCodec<global::Envoy.Config.Route.V3.ScopedRouteConfiguration.Types.Key.Types.Fragment> _repeated_fragments_codec
            = pb::FieldCodec.ForMessage(10, global::Envoy.Config.Route.V3.ScopedRouteConfiguration.Types.Key.Types.Fragment.Parser);
        private readonly pbc::RepeatedField<global::Envoy.Config.Route.V3.ScopedRouteConfiguration.Types.Key.Types.Fragment> fragments_ = new pbc::RepeatedField<global::Envoy.Config.Route.V3.ScopedRouteConfiguration.Types.Key.Types.Fragment>();
        /// <summary>
        /// The ordered set of fragments to match against. The order must match the
        /// fragments in the corresponding
        /// :ref:`scope_key_builder&lt;envoy_v3_api_field_extensions.filters.network.http_connection_manager.v3.ScopedRoutes.scope_key_builder>`.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public pbc::RepeatedField<global::Envoy.Config.Route.V3.ScopedRouteConfiguration.Types.Key.Types.Fragment> Fragments {
          get { return fragments_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as Key);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(Key other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if(!fragments_.Equals(other.fragments_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          hash ^= fragments_.GetHashCode();
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
          fragments_.WriteTo(output, _repeated_fragments_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
          fragments_.WriteTo(ref output, _repeated_fragments_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(ref output);
          }
        }
        #endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int CalculateSize() {
          int size = 0;
          size += fragments_.CalculateSize(_repeated_fragments_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(Key other) {
          if (other == null) {
            return;
          }
          fragments_.Add(other.fragments_);
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
                fragments_.AddEntriesFrom(input, _repeated_fragments_codec);
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
                fragments_.AddEntriesFrom(ref input, _repeated_fragments_codec);
                break;
              }
            }
          }
        }
        #endif

        #region Nested types
        /// <summary>Container for nested types declared in the Key message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static partial class Types {
          public sealed partial class Fragment : pb::IMessage<Fragment>
          #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
              , pb::IBufferMessage
          #endif
          {
            private static readonly pb::MessageParser<Fragment> _parser = new pb::MessageParser<Fragment>(() => new Fragment());
            private pb::UnknownFieldSet _unknownFields;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public static pb::MessageParser<Fragment> Parser { get { return _parser; } }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public static pbr::MessageDescriptor Descriptor {
              get { return global::Envoy.Config.Route.V3.ScopedRouteConfiguration.Types.Key.Descriptor.NestedTypes[0]; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            pbr::MessageDescriptor pb::IMessage.Descriptor {
              get { return Descriptor; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public Fragment() {
              OnConstruction();
            }

            partial void OnConstruction();

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public Fragment(Fragment other) : this() {
              switch (other.TypeCase) {
                case TypeOneofCase.StringKey:
                  StringKey = other.StringKey;
                  break;
              }

              _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public Fragment Clone() {
              return new Fragment(this);
            }

            /// <summary>Field number for the "string_key" field.</summary>
            public const int StringKeyFieldNumber = 1;
            /// <summary>
            /// A string to match against.
            /// </summary>
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public string StringKey {
              get { return typeCase_ == TypeOneofCase.StringKey ? (string) type_ : ""; }
              set {
                type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
                typeCase_ = TypeOneofCase.StringKey;
              }
            }

            private object type_;
            /// <summary>Enum of possible cases for the "type" oneof.</summary>
            public enum TypeOneofCase {
              None = 0,
              StringKey = 1,
            }
            private TypeOneofCase typeCase_ = TypeOneofCase.None;
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public TypeOneofCase TypeCase {
              get { return typeCase_; }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public void ClearType() {
              typeCase_ = TypeOneofCase.None;
              type_ = null;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public override bool Equals(object other) {
              return Equals(other as Fragment);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public bool Equals(Fragment other) {
              if (ReferenceEquals(other, null)) {
                return false;
              }
              if (ReferenceEquals(other, this)) {
                return true;
              }
              if (StringKey != other.StringKey) return false;
              if (TypeCase != other.TypeCase) return false;
              return Equals(_unknownFields, other._unknownFields);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public override int GetHashCode() {
              int hash = 1;
              if (typeCase_ == TypeOneofCase.StringKey) hash ^= StringKey.GetHashCode();
              hash ^= (int) typeCase_;
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
              if (typeCase_ == TypeOneofCase.StringKey) {
                output.WriteRawTag(10);
                output.WriteString(StringKey);
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
              if (typeCase_ == TypeOneofCase.StringKey) {
                output.WriteRawTag(10);
                output.WriteString(StringKey);
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
              if (typeCase_ == TypeOneofCase.StringKey) {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(StringKey);
              }
              if (_unknownFields != null) {
                size += _unknownFields.CalculateSize();
              }
              return size;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
            [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
            public void MergeFrom(Fragment other) {
              if (other == null) {
                return;
              }
              switch (other.TypeCase) {
                case TypeOneofCase.StringKey:
                  StringKey = other.StringKey;
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
                    StringKey = input.ReadString();
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
                    StringKey = input.ReadString();
                    break;
                  }
                }
              }
            }
            #endif

          }

        }
        #endregion

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
