// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/config/filter/http/cache/v2alpha/cache.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Filter.Http.Cache.V2Alpha {

  /// <summary>Holder for reflection information generated from envoy/config/filter/http/cache/v2alpha/cache.proto</summary>
  public static partial class CacheReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/config/filter/http/cache/v2alpha/cache.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CacheReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJlbnZveS9jb25maWcvZmlsdGVyL2h0dHAvY2FjaGUvdjJhbHBoYS9jYWNo",
            "ZS5wcm90bxImZW52b3kuY29uZmlnLmZpbHRlci5odHRwLmNhY2hlLnYyYWxw",
            "aGEaKWVudm95L2FwaS92Mi9yb3V0ZS9yb3V0ZV9jb21wb25lbnRzLnByb3Rv",
            "Gh9lbnZveS90eXBlL21hdGNoZXIvc3RyaW5nLnByb3RvGhlnb29nbGUvcHJv",
            "dG9idWYvYW55LnByb3RvGh51ZHBhL2Fubm90YXRpb25zL21pZ3JhdGUucHJv",
            "dG8aHXVkcGEvYW5ub3RhdGlvbnMvc3RhdHVzLnByb3RvGhd2YWxpZGF0ZS92",
            "YWxpZGF0ZS5wcm90byLdAwoLQ2FjaGVDb25maWcSNAoMdHlwZWRfY29uZmln",
            "GAEgASgLMhQuZ29vZ2xlLnByb3RvYnVmLkFueUII+kIFogECCAESPwoUYWxs",
            "b3dlZF92YXJ5X2hlYWRlcnMYAiADKAsyIS5lbnZveS50eXBlLm1hdGNoZXIu",
            "U3RyaW5nTWF0Y2hlchJgChJrZXlfY3JlYXRvcl9wYXJhbXMYAyABKAsyRC5l",
            "bnZveS5jb25maWcuZmlsdGVyLmh0dHAuY2FjaGUudjJhbHBoYS5DYWNoZUNv",
            "bmZpZy5LZXlDcmVhdG9yUGFyYW1zEhYKDm1heF9ib2R5X2J5dGVzGAQgASgN",
            "GtwBChBLZXlDcmVhdG9yUGFyYW1zEhYKDmV4Y2x1ZGVfc2NoZW1lGAEgASgI",
            "EhQKDGV4Y2x1ZGVfaG9zdBgCIAEoCBJMChlxdWVyeV9wYXJhbWV0ZXJzX2lu",
            "Y2x1ZGVkGAMgAygLMikuZW52b3kuYXBpLnYyLnJvdXRlLlF1ZXJ5UGFyYW1l",
            "dGVyTWF0Y2hlchJMChlxdWVyeV9wYXJhbWV0ZXJzX2V4Y2x1ZGVkGAQgAygL",
            "MikuZW52b3kuYXBpLnYyLnJvdXRlLlF1ZXJ5UGFyYW1ldGVyTWF0Y2hlckKH",
            "AQo0aW8uZW52b3lwcm94eS5lbnZveS5jb25maWcuZmlsdGVyLmh0dHAuY2Fj",
            "aGUudjJhbHBoYUIKQ2FjaGVQcm90b1AB8pj+jwUtEitlbnZveS5leHRlbnNp",
            "b25zLmZpbHRlcnMuaHR0cC5jYWNoZS52M2FscGhhuoDI0QYCCAG6gMjRBgIQ",
            "AWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Api.V2.Route.RouteComponentsReflection.Descriptor, global::Envoy.Type.Matcher.StringReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, global::Udpa.Annotations.MigrateReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Filter.Http.Cache.V2Alpha.CacheConfig), global::Envoy.Config.Filter.Http.Cache.V2Alpha.CacheConfig.Parser, new[]{ "TypedConfig", "AllowedVaryHeaders", "KeyCreatorParams", "MaxBodyBytes" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Filter.Http.Cache.V2Alpha.CacheConfig.Types.KeyCreatorParams), global::Envoy.Config.Filter.Http.Cache.V2Alpha.CacheConfig.Types.KeyCreatorParams.Parser, new[]{ "ExcludeScheme", "ExcludeHost", "QueryParametersIncluded", "QueryParametersExcluded" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CacheConfig : pb::IMessage<CacheConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CacheConfig> _parser = new pb::MessageParser<CacheConfig>(() => new CacheConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CacheConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Filter.Http.Cache.V2Alpha.CacheReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CacheConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CacheConfig(CacheConfig other) : this() {
      typedConfig_ = other.typedConfig_ != null ? other.typedConfig_.Clone() : null;
      allowedVaryHeaders_ = other.allowedVaryHeaders_.Clone();
      keyCreatorParams_ = other.keyCreatorParams_ != null ? other.keyCreatorParams_.Clone() : null;
      maxBodyBytes_ = other.maxBodyBytes_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CacheConfig Clone() {
      return new CacheConfig(this);
    }

    /// <summary>Field number for the "typed_config" field.</summary>
    public const int TypedConfigFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Any typedConfig_;
    /// <summary>
    /// Config specific to the cache storage implementation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Any TypedConfig {
      get { return typedConfig_; }
      set {
        typedConfig_ = value;
      }
    }

    /// <summary>Field number for the "allowed_vary_headers" field.</summary>
    public const int AllowedVaryHeadersFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Envoy.Type.Matcher.StringMatcher> _repeated_allowedVaryHeaders_codec
        = pb::FieldCodec.ForMessage(18, global::Envoy.Type.Matcher.StringMatcher.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Type.Matcher.StringMatcher> allowedVaryHeaders_ = new pbc::RepeatedField<global::Envoy.Type.Matcher.StringMatcher>();
    /// <summary>
    /// List of matching rules that defines allowed *Vary* headers.
    ///
    /// The *vary* response header holds a list of header names that affect the
    /// contents of a response, as described by
    /// https://httpwg.org/specs/rfc7234.html#caching.negotiated.responses.
    ///
    /// During insertion, *allowed_vary_headers* acts as a allowlist: if a
    /// response's *vary* header mentions any header names that aren't matched by any rules in
    /// *allowed_vary_headers*, that response will not be cached.
    ///
    /// During lookup, *allowed_vary_headers* controls what request headers will be
    /// sent to the cache storage implementation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Envoy.Type.Matcher.StringMatcher> AllowedVaryHeaders {
      get { return allowedVaryHeaders_; }
    }

    /// <summary>Field number for the "key_creator_params" field.</summary>
    public const int KeyCreatorParamsFieldNumber = 3;
    private global::Envoy.Config.Filter.Http.Cache.V2Alpha.CacheConfig.Types.KeyCreatorParams keyCreatorParams_;
    /// <summary>
    /// [#not-implemented-hide:]
    /// &lt;TODO(toddmgreer) implement key customization>
    ///
    /// Modifies cache key creation by restricting which parts of the URL are included.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Config.Filter.Http.Cache.V2Alpha.CacheConfig.Types.KeyCreatorParams KeyCreatorParams {
      get { return keyCreatorParams_; }
      set {
        keyCreatorParams_ = value;
      }
    }

    /// <summary>Field number for the "max_body_bytes" field.</summary>
    public const int MaxBodyBytesFieldNumber = 4;
    private uint maxBodyBytes_;
    /// <summary>
    /// [#not-implemented-hide:]
    /// &lt;TODO(toddmgreer) implement size limit>
    ///
    /// Max body size the cache filter will insert into a cache. 0 means unlimited (though the cache
    /// storage implementation may have its own limit beyond which it will reject insertions).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxBodyBytes {
      get { return maxBodyBytes_; }
      set {
        maxBodyBytes_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CacheConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CacheConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(TypedConfig, other.TypedConfig)) return false;
      if(!allowedVaryHeaders_.Equals(other.allowedVaryHeaders_)) return false;
      if (!object.Equals(KeyCreatorParams, other.KeyCreatorParams)) return false;
      if (MaxBodyBytes != other.MaxBodyBytes) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (typedConfig_ != null) hash ^= TypedConfig.GetHashCode();
      hash ^= allowedVaryHeaders_.GetHashCode();
      if (keyCreatorParams_ != null) hash ^= KeyCreatorParams.GetHashCode();
      if (MaxBodyBytes != 0) hash ^= MaxBodyBytes.GetHashCode();
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
      if (typedConfig_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(TypedConfig);
      }
      allowedVaryHeaders_.WriteTo(output, _repeated_allowedVaryHeaders_codec);
      if (keyCreatorParams_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(KeyCreatorParams);
      }
      if (MaxBodyBytes != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MaxBodyBytes);
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
      if (typedConfig_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(TypedConfig);
      }
      allowedVaryHeaders_.WriteTo(ref output, _repeated_allowedVaryHeaders_codec);
      if (keyCreatorParams_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(KeyCreatorParams);
      }
      if (MaxBodyBytes != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MaxBodyBytes);
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
      if (typedConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TypedConfig);
      }
      size += allowedVaryHeaders_.CalculateSize(_repeated_allowedVaryHeaders_codec);
      if (keyCreatorParams_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(KeyCreatorParams);
      }
      if (MaxBodyBytes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxBodyBytes);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CacheConfig other) {
      if (other == null) {
        return;
      }
      if (other.typedConfig_ != null) {
        if (typedConfig_ == null) {
          TypedConfig = new global::Google.Protobuf.WellKnownTypes.Any();
        }
        TypedConfig.MergeFrom(other.TypedConfig);
      }
      allowedVaryHeaders_.Add(other.allowedVaryHeaders_);
      if (other.keyCreatorParams_ != null) {
        if (keyCreatorParams_ == null) {
          KeyCreatorParams = new global::Envoy.Config.Filter.Http.Cache.V2Alpha.CacheConfig.Types.KeyCreatorParams();
        }
        KeyCreatorParams.MergeFrom(other.KeyCreatorParams);
      }
      if (other.MaxBodyBytes != 0) {
        MaxBodyBytes = other.MaxBodyBytes;
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
            if (typedConfig_ == null) {
              TypedConfig = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(TypedConfig);
            break;
          }
          case 18: {
            allowedVaryHeaders_.AddEntriesFrom(input, _repeated_allowedVaryHeaders_codec);
            break;
          }
          case 26: {
            if (keyCreatorParams_ == null) {
              KeyCreatorParams = new global::Envoy.Config.Filter.Http.Cache.V2Alpha.CacheConfig.Types.KeyCreatorParams();
            }
            input.ReadMessage(KeyCreatorParams);
            break;
          }
          case 32: {
            MaxBodyBytes = input.ReadUInt32();
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
            if (typedConfig_ == null) {
              TypedConfig = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(TypedConfig);
            break;
          }
          case 18: {
            allowedVaryHeaders_.AddEntriesFrom(ref input, _repeated_allowedVaryHeaders_codec);
            break;
          }
          case 26: {
            if (keyCreatorParams_ == null) {
              KeyCreatorParams = new global::Envoy.Config.Filter.Http.Cache.V2Alpha.CacheConfig.Types.KeyCreatorParams();
            }
            input.ReadMessage(KeyCreatorParams);
            break;
          }
          case 32: {
            MaxBodyBytes = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the CacheConfig message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// [#not-implemented-hide:]
      /// Modifies cache key creation by restricting which parts of the URL are included.
      /// </summary>
      public sealed partial class KeyCreatorParams : pb::IMessage<KeyCreatorParams>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<KeyCreatorParams> _parser = new pb::MessageParser<KeyCreatorParams>(() => new KeyCreatorParams());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<KeyCreatorParams> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Envoy.Config.Filter.Http.Cache.V2Alpha.CacheConfig.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public KeyCreatorParams() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public KeyCreatorParams(KeyCreatorParams other) : this() {
          excludeScheme_ = other.excludeScheme_;
          excludeHost_ = other.excludeHost_;
          queryParametersIncluded_ = other.queryParametersIncluded_.Clone();
          queryParametersExcluded_ = other.queryParametersExcluded_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public KeyCreatorParams Clone() {
          return new KeyCreatorParams(this);
        }

        /// <summary>Field number for the "exclude_scheme" field.</summary>
        public const int ExcludeSchemeFieldNumber = 1;
        private bool excludeScheme_;
        /// <summary>
        /// If true, exclude the URL scheme from the cache key. Set to true if your origins always
        /// produce the same response for http and https requests.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool ExcludeScheme {
          get { return excludeScheme_; }
          set {
            excludeScheme_ = value;
          }
        }

        /// <summary>Field number for the "exclude_host" field.</summary>
        public const int ExcludeHostFieldNumber = 2;
        private bool excludeHost_;
        /// <summary>
        /// If true, exclude the host from the cache key. Set to true if your origins' responses don't
        /// ever depend on host.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool ExcludeHost {
          get { return excludeHost_; }
          set {
            excludeHost_ = value;
          }
        }

        /// <summary>Field number for the "query_parameters_included" field.</summary>
        public const int QueryParametersIncludedFieldNumber = 3;
        private static readonly pb::FieldCodec<global::Envoy.Api.V2.Route.QueryParameterMatcher> _repeated_queryParametersIncluded_codec
            = pb::FieldCodec.ForMessage(26, global::Envoy.Api.V2.Route.QueryParameterMatcher.Parser);
        private readonly pbc::RepeatedField<global::Envoy.Api.V2.Route.QueryParameterMatcher> queryParametersIncluded_ = new pbc::RepeatedField<global::Envoy.Api.V2.Route.QueryParameterMatcher>();
        /// <summary>
        /// If *query_parameters_included* is nonempty, only query parameters matched
        /// by one or more of its matchers are included in the cache key. Any other
        /// query params will not affect cache lookup.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public pbc::RepeatedField<global::Envoy.Api.V2.Route.QueryParameterMatcher> QueryParametersIncluded {
          get { return queryParametersIncluded_; }
        }

        /// <summary>Field number for the "query_parameters_excluded" field.</summary>
        public const int QueryParametersExcludedFieldNumber = 4;
        private static readonly pb::FieldCodec<global::Envoy.Api.V2.Route.QueryParameterMatcher> _repeated_queryParametersExcluded_codec
            = pb::FieldCodec.ForMessage(34, global::Envoy.Api.V2.Route.QueryParameterMatcher.Parser);
        private readonly pbc::RepeatedField<global::Envoy.Api.V2.Route.QueryParameterMatcher> queryParametersExcluded_ = new pbc::RepeatedField<global::Envoy.Api.V2.Route.QueryParameterMatcher>();
        /// <summary>
        /// If *query_parameters_excluded* is nonempty, query parameters matched by one
        /// or more of its matchers are excluded from the cache key (even if also
        /// matched by *query_parameters_included*), and will not affect cache lookup.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public pbc::RepeatedField<global::Envoy.Api.V2.Route.QueryParameterMatcher> QueryParametersExcluded {
          get { return queryParametersExcluded_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as KeyCreatorParams);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(KeyCreatorParams other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (ExcludeScheme != other.ExcludeScheme) return false;
          if (ExcludeHost != other.ExcludeHost) return false;
          if(!queryParametersIncluded_.Equals(other.queryParametersIncluded_)) return false;
          if(!queryParametersExcluded_.Equals(other.queryParametersExcluded_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (ExcludeScheme != false) hash ^= ExcludeScheme.GetHashCode();
          if (ExcludeHost != false) hash ^= ExcludeHost.GetHashCode();
          hash ^= queryParametersIncluded_.GetHashCode();
          hash ^= queryParametersExcluded_.GetHashCode();
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
          if (ExcludeScheme != false) {
            output.WriteRawTag(8);
            output.WriteBool(ExcludeScheme);
          }
          if (ExcludeHost != false) {
            output.WriteRawTag(16);
            output.WriteBool(ExcludeHost);
          }
          queryParametersIncluded_.WriteTo(output, _repeated_queryParametersIncluded_codec);
          queryParametersExcluded_.WriteTo(output, _repeated_queryParametersExcluded_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
          if (ExcludeScheme != false) {
            output.WriteRawTag(8);
            output.WriteBool(ExcludeScheme);
          }
          if (ExcludeHost != false) {
            output.WriteRawTag(16);
            output.WriteBool(ExcludeHost);
          }
          queryParametersIncluded_.WriteTo(ref output, _repeated_queryParametersIncluded_codec);
          queryParametersExcluded_.WriteTo(ref output, _repeated_queryParametersExcluded_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(ref output);
          }
        }
        #endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int CalculateSize() {
          int size = 0;
          if (ExcludeScheme != false) {
            size += 1 + 1;
          }
          if (ExcludeHost != false) {
            size += 1 + 1;
          }
          size += queryParametersIncluded_.CalculateSize(_repeated_queryParametersIncluded_codec);
          size += queryParametersExcluded_.CalculateSize(_repeated_queryParametersExcluded_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(KeyCreatorParams other) {
          if (other == null) {
            return;
          }
          if (other.ExcludeScheme != false) {
            ExcludeScheme = other.ExcludeScheme;
          }
          if (other.ExcludeHost != false) {
            ExcludeHost = other.ExcludeHost;
          }
          queryParametersIncluded_.Add(other.queryParametersIncluded_);
          queryParametersExcluded_.Add(other.queryParametersExcluded_);
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
              case 8: {
                ExcludeScheme = input.ReadBool();
                break;
              }
              case 16: {
                ExcludeHost = input.ReadBool();
                break;
              }
              case 26: {
                queryParametersIncluded_.AddEntriesFrom(input, _repeated_queryParametersIncluded_codec);
                break;
              }
              case 34: {
                queryParametersExcluded_.AddEntriesFrom(input, _repeated_queryParametersExcluded_codec);
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
              case 8: {
                ExcludeScheme = input.ReadBool();
                break;
              }
              case 16: {
                ExcludeHost = input.ReadBool();
                break;
              }
              case 26: {
                queryParametersIncluded_.AddEntriesFrom(ref input, _repeated_queryParametersIncluded_codec);
                break;
              }
              case 34: {
                queryParametersExcluded_.AddEntriesFrom(ref input, _repeated_queryParametersExcluded_codec);
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

  #endregion

}

#endregion Designer generated code
