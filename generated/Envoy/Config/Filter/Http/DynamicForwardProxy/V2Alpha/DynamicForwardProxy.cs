// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/config/filter/http/dynamic_forward_proxy/v2alpha/dynamic_forward_proxy.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Filter.Http.DynamicForwardProxy.V2Alpha {

  /// <summary>Holder for reflection information generated from envoy/config/filter/http/dynamic_forward_proxy/v2alpha/dynamic_forward_proxy.proto</summary>
  public static partial class DynamicForwardProxyReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/config/filter/http/dynamic_forward_proxy/v2alpha/dynamic_forward_proxy.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DynamicForwardProxyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ClJlbnZveS9jb25maWcvZmlsdGVyL2h0dHAvZHluYW1pY19mb3J3YXJkX3By",
            "b3h5L3YyYWxwaGEvZHluYW1pY19mb3J3YXJkX3Byb3h5LnByb3RvEjZlbnZv",
            "eS5jb25maWcuZmlsdGVyLmh0dHAuZHluYW1pY19mb3J3YXJkX3Byb3h5LnYy",
            "YWxwaGEaQWVudm95L2NvbmZpZy9jb21tb24vZHluYW1pY19mb3J3YXJkX3By",
            "b3h5L3YyYWxwaGEvZG5zX2NhY2hlLnByb3RvGh51ZHBhL2Fubm90YXRpb25z",
            "L21pZ3JhdGUucHJvdG8aHXVkcGEvYW5ub3RhdGlvbnMvc3RhdHVzLnByb3Rv",
            "Ghd2YWxpZGF0ZS92YWxpZGF0ZS5wcm90byJ1CgxGaWx0ZXJDb25maWcSZQoQ",
            "ZG5zX2NhY2hlX2NvbmZpZxgBIAEoCzJBLmVudm95LmNvbmZpZy5jb21tb24u",
            "ZHluYW1pY19mb3J3YXJkX3Byb3h5LnYyYWxwaGEuRG5zQ2FjaGVDb25maWdC",
            "CPpCBYoBAhABIqEBCg5QZXJSb3V0ZUNvbmZpZxI0Cgxob3N0X3Jld3JpdGUY",
            "ASABKAlCHPKY/o8FFgoUaG9zdF9yZXdyaXRlX2xpdGVyYWxIABI/ChhhdXRv",
            "X2hvc3RfcmV3cml0ZV9oZWFkZXIYAiABKAlCG/KY/o8FFQoTaG9zdF9yZXdy",
            "aXRlX2hlYWRlckgAQhgKFmhvc3RfcmV3cml0ZV9zcGVjaWZpZXJCqAEKRGlv",
            "LmVudm95cHJveHkuZW52b3kuY29uZmlnLmZpbHRlci5odHRwLmR5bmFtaWNf",
            "Zm9yd2FyZF9wcm94eS52MmFscGhhQhhEeW5hbWljRm9yd2FyZFByb3h5UHJv",
            "dG9QAfKY/o8FOBI2ZW52b3kuZXh0ZW5zaW9ucy5maWx0ZXJzLmh0dHAuZHlu",
            "YW1pY19mb3J3YXJkX3Byb3h5LnYzuoDI0QYCEAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Config.Common.DynamicForwardProxy.V2Alpha.DnsCacheReflection.Descriptor, global::Udpa.Annotations.MigrateReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Filter.Http.DynamicForwardProxy.V2Alpha.FilterConfig), global::Envoy.Config.Filter.Http.DynamicForwardProxy.V2Alpha.FilterConfig.Parser, new[]{ "DnsCacheConfig" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Filter.Http.DynamicForwardProxy.V2Alpha.PerRouteConfig), global::Envoy.Config.Filter.Http.DynamicForwardProxy.V2Alpha.PerRouteConfig.Parser, new[]{ "HostRewrite", "AutoHostRewriteHeader" }, new[]{ "HostRewriteSpecifier" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Configuration for the dynamic forward proxy HTTP filter. See the :ref:`architecture overview
  /// &lt;arch_overview_http_dynamic_forward_proxy>` for more information.
  /// [#extension: envoy.filters.http.dynamic_forward_proxy]
  /// </summary>
  public sealed partial class FilterConfig : pb::IMessage<FilterConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FilterConfig> _parser = new pb::MessageParser<FilterConfig>(() => new FilterConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FilterConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Filter.Http.DynamicForwardProxy.V2Alpha.DynamicForwardProxyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FilterConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FilterConfig(FilterConfig other) : this() {
      dnsCacheConfig_ = other.dnsCacheConfig_ != null ? other.dnsCacheConfig_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FilterConfig Clone() {
      return new FilterConfig(this);
    }

    /// <summary>Field number for the "dns_cache_config" field.</summary>
    public const int DnsCacheConfigFieldNumber = 1;
    private global::Envoy.Config.Common.DynamicForwardProxy.V2Alpha.DnsCacheConfig dnsCacheConfig_;
    /// <summary>
    /// The DNS cache configuration that the filter will attach to. Note this configuration must
    /// match that of associated :ref:`dynamic forward proxy cluster configuration
    /// &lt;envoy_api_field_config.cluster.dynamic_forward_proxy.v2alpha.ClusterConfig.dns_cache_config>`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Config.Common.DynamicForwardProxy.V2Alpha.DnsCacheConfig DnsCacheConfig {
      get { return dnsCacheConfig_; }
      set {
        dnsCacheConfig_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FilterConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FilterConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(DnsCacheConfig, other.DnsCacheConfig)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (dnsCacheConfig_ != null) hash ^= DnsCacheConfig.GetHashCode();
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
      if (dnsCacheConfig_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(DnsCacheConfig);
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
      if (dnsCacheConfig_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(DnsCacheConfig);
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
      if (dnsCacheConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DnsCacheConfig);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FilterConfig other) {
      if (other == null) {
        return;
      }
      if (other.dnsCacheConfig_ != null) {
        if (dnsCacheConfig_ == null) {
          DnsCacheConfig = new global::Envoy.Config.Common.DynamicForwardProxy.V2Alpha.DnsCacheConfig();
        }
        DnsCacheConfig.MergeFrom(other.DnsCacheConfig);
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
            if (dnsCacheConfig_ == null) {
              DnsCacheConfig = new global::Envoy.Config.Common.DynamicForwardProxy.V2Alpha.DnsCacheConfig();
            }
            input.ReadMessage(DnsCacheConfig);
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
            if (dnsCacheConfig_ == null) {
              DnsCacheConfig = new global::Envoy.Config.Common.DynamicForwardProxy.V2Alpha.DnsCacheConfig();
            }
            input.ReadMessage(DnsCacheConfig);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Per route Configuration for the dynamic forward proxy HTTP filter.
  /// </summary>
  public sealed partial class PerRouteConfig : pb::IMessage<PerRouteConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PerRouteConfig> _parser = new pb::MessageParser<PerRouteConfig>(() => new PerRouteConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PerRouteConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Filter.Http.DynamicForwardProxy.V2Alpha.DynamicForwardProxyReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PerRouteConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PerRouteConfig(PerRouteConfig other) : this() {
      switch (other.HostRewriteSpecifierCase) {
        case HostRewriteSpecifierOneofCase.HostRewrite:
          HostRewrite = other.HostRewrite;
          break;
        case HostRewriteSpecifierOneofCase.AutoHostRewriteHeader:
          AutoHostRewriteHeader = other.AutoHostRewriteHeader;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PerRouteConfig Clone() {
      return new PerRouteConfig(this);
    }

    /// <summary>Field number for the "host_rewrite" field.</summary>
    public const int HostRewriteFieldNumber = 1;
    /// <summary>
    /// Indicates that before DNS lookup, the host header will be swapped with
    /// this value. If not set or empty, the original host header value
    /// will be used and no rewrite will happen.
    ///
    /// Note: this rewrite affects both DNS lookup and host header forwarding. However, this
    /// option shouldn't be used with
    /// :ref:`HCM host rewrite &lt;envoy_api_field_route.RouteAction.host_rewrite>` given that the
    /// value set here would be used for DNS lookups whereas the value set in the HCM would be used
    /// for host header forwarding which is not the desired outcome.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string HostRewrite {
      get { return hostRewriteSpecifierCase_ == HostRewriteSpecifierOneofCase.HostRewrite ? (string) hostRewriteSpecifier_ : ""; }
      set {
        hostRewriteSpecifier_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        hostRewriteSpecifierCase_ = HostRewriteSpecifierOneofCase.HostRewrite;
      }
    }

    /// <summary>Field number for the "auto_host_rewrite_header" field.</summary>
    public const int AutoHostRewriteHeaderFieldNumber = 2;
    /// <summary>
    /// Indicates that before DNS lookup, the host header will be swapped with
    /// the value of this header. If not set or empty, the original host header
    /// value will be used and no rewrite will happen.
    ///
    /// Note: this rewrite affects both DNS lookup and host header forwarding. However, this
    /// option shouldn't be used with
    /// :ref:`HCM host rewrite header &lt;envoy_api_field_route.RouteAction.auto_host_rewrite_header>`
    /// given that the value set here would be used for DNS lookups whereas the value set in the HCM
    /// would be used for host header forwarding which is not the desired outcome.
    ///
    /// .. note::
    ///
    ///   If the header appears multiple times only the first value is used.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AutoHostRewriteHeader {
      get { return hostRewriteSpecifierCase_ == HostRewriteSpecifierOneofCase.AutoHostRewriteHeader ? (string) hostRewriteSpecifier_ : ""; }
      set {
        hostRewriteSpecifier_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        hostRewriteSpecifierCase_ = HostRewriteSpecifierOneofCase.AutoHostRewriteHeader;
      }
    }

    private object hostRewriteSpecifier_;
    /// <summary>Enum of possible cases for the "host_rewrite_specifier" oneof.</summary>
    public enum HostRewriteSpecifierOneofCase {
      None = 0,
      HostRewrite = 1,
      AutoHostRewriteHeader = 2,
    }
    private HostRewriteSpecifierOneofCase hostRewriteSpecifierCase_ = HostRewriteSpecifierOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HostRewriteSpecifierOneofCase HostRewriteSpecifierCase {
      get { return hostRewriteSpecifierCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearHostRewriteSpecifier() {
      hostRewriteSpecifierCase_ = HostRewriteSpecifierOneofCase.None;
      hostRewriteSpecifier_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PerRouteConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PerRouteConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HostRewrite != other.HostRewrite) return false;
      if (AutoHostRewriteHeader != other.AutoHostRewriteHeader) return false;
      if (HostRewriteSpecifierCase != other.HostRewriteSpecifierCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (hostRewriteSpecifierCase_ == HostRewriteSpecifierOneofCase.HostRewrite) hash ^= HostRewrite.GetHashCode();
      if (hostRewriteSpecifierCase_ == HostRewriteSpecifierOneofCase.AutoHostRewriteHeader) hash ^= AutoHostRewriteHeader.GetHashCode();
      hash ^= (int) hostRewriteSpecifierCase_;
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
      if (hostRewriteSpecifierCase_ == HostRewriteSpecifierOneofCase.HostRewrite) {
        output.WriteRawTag(10);
        output.WriteString(HostRewrite);
      }
      if (hostRewriteSpecifierCase_ == HostRewriteSpecifierOneofCase.AutoHostRewriteHeader) {
        output.WriteRawTag(18);
        output.WriteString(AutoHostRewriteHeader);
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
      if (hostRewriteSpecifierCase_ == HostRewriteSpecifierOneofCase.HostRewrite) {
        output.WriteRawTag(10);
        output.WriteString(HostRewrite);
      }
      if (hostRewriteSpecifierCase_ == HostRewriteSpecifierOneofCase.AutoHostRewriteHeader) {
        output.WriteRawTag(18);
        output.WriteString(AutoHostRewriteHeader);
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
      if (hostRewriteSpecifierCase_ == HostRewriteSpecifierOneofCase.HostRewrite) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(HostRewrite);
      }
      if (hostRewriteSpecifierCase_ == HostRewriteSpecifierOneofCase.AutoHostRewriteHeader) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AutoHostRewriteHeader);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PerRouteConfig other) {
      if (other == null) {
        return;
      }
      switch (other.HostRewriteSpecifierCase) {
        case HostRewriteSpecifierOneofCase.HostRewrite:
          HostRewrite = other.HostRewrite;
          break;
        case HostRewriteSpecifierOneofCase.AutoHostRewriteHeader:
          AutoHostRewriteHeader = other.AutoHostRewriteHeader;
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
            HostRewrite = input.ReadString();
            break;
          }
          case 18: {
            AutoHostRewriteHeader = input.ReadString();
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
            HostRewrite = input.ReadString();
            break;
          }
          case 18: {
            AutoHostRewriteHeader = input.ReadString();
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
