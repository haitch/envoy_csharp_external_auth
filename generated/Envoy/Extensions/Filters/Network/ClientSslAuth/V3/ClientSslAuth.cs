// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/extensions/filters/network/client_ssl_auth/v3/client_ssl_auth.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Extensions.Filters.Network.ClientSslAuth.V3 {

  /// <summary>Holder for reflection information generated from envoy/extensions/filters/network/client_ssl_auth/v3/client_ssl_auth.proto</summary>
  public static partial class ClientSslAuthReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/extensions/filters/network/client_ssl_auth/v3/client_ssl_auth.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientSslAuthReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkllbnZveS9leHRlbnNpb25zL2ZpbHRlcnMvbmV0d29yay9jbGllbnRfc3Ns",
            "X2F1dGgvdjMvY2xpZW50X3NzbF9hdXRoLnByb3RvEjNlbnZveS5leHRlbnNp",
            "b25zLmZpbHRlcnMubmV0d29yay5jbGllbnRfc3NsX2F1dGgudjMaImVudm95",
            "L2NvbmZpZy9jb3JlL3YzL2FkZHJlc3MucHJvdG8aHmdvb2dsZS9wcm90b2J1",
            "Zi9kdXJhdGlvbi5wcm90bxoedWRwYS9hbm5vdGF0aW9ucy9taWdyYXRlLnBy",
            "b3RvGh11ZHBhL2Fubm90YXRpb25zL3N0YXR1cy5wcm90bxohdWRwYS9hbm5v",
            "dGF0aW9ucy92ZXJzaW9uaW5nLnByb3RvGhd2YWxpZGF0ZS92YWxpZGF0ZS5w",
            "cm90byKbAgoNQ2xpZW50U1NMQXV0aBInChBhdXRoX2FwaV9jbHVzdGVyGAEg",
            "ASgJQg36QgpyCBABwAECyAEAEhwKC3N0YXRfcHJlZml4GAIgASgJQgf6QgRy",
            "AhABEjAKDXJlZnJlc2hfZGVsYXkYAyABKAsyGS5nb29nbGUucHJvdG9idWYu",
            "RHVyYXRpb24STAoNaXBfd2hpdGVfbGlzdBgEIAMoCzIfLmVudm95LmNvbmZp",
            "Zy5jb3JlLnYzLkNpZHJSYW5nZUIU8pj+jwUOCgxpcF9hbGxvd2xpc3Q6Q5rF",
            "iB4+CjxlbnZveS5jb25maWcuZmlsdGVyLm5ldHdvcmsuY2xpZW50X3NzbF9h",
            "dXRoLnYyLkNsaWVudFNTTEF1dGhCYQpBaW8uZW52b3lwcm94eS5lbnZveS5l",
            "eHRlbnNpb25zLmZpbHRlcnMubmV0d29yay5jbGllbnRfc3NsX2F1dGgudjNC",
            "EkNsaWVudFNzbEF1dGhQcm90b1ABuoDI0QYCEAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Config.Core.V3.AddressReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Udpa.Annotations.MigrateReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Udpa.Annotations.VersioningReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Extensions.Filters.Network.ClientSslAuth.V3.ClientSSLAuth), global::Envoy.Extensions.Filters.Network.ClientSslAuth.V3.ClientSSLAuth.Parser, new[]{ "AuthApiCluster", "StatPrefix", "RefreshDelay", "IpWhiteList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientSSLAuth : pb::IMessage<ClientSSLAuth>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ClientSSLAuth> _parser = new pb::MessageParser<ClientSSLAuth>(() => new ClientSSLAuth());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ClientSSLAuth> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Extensions.Filters.Network.ClientSslAuth.V3.ClientSslAuthReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientSSLAuth() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientSSLAuth(ClientSSLAuth other) : this() {
      authApiCluster_ = other.authApiCluster_;
      statPrefix_ = other.statPrefix_;
      refreshDelay_ = other.refreshDelay_ != null ? other.refreshDelay_.Clone() : null;
      ipWhiteList_ = other.ipWhiteList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientSSLAuth Clone() {
      return new ClientSSLAuth(this);
    }

    /// <summary>Field number for the "auth_api_cluster" field.</summary>
    public const int AuthApiClusterFieldNumber = 1;
    private string authApiCluster_ = "";
    /// <summary>
    /// The :ref:`cluster manager &lt;arch_overview_cluster_manager>` cluster that runs
    /// the authentication service. The filter will connect to the service every 60s to fetch the list
    /// of principals. The service must support the expected :ref:`REST API
    /// &lt;config_network_filters_client_ssl_auth_rest_api>`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AuthApiCluster {
      get { return authApiCluster_; }
      set {
        authApiCluster_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "stat_prefix" field.</summary>
    public const int StatPrefixFieldNumber = 2;
    private string statPrefix_ = "";
    /// <summary>
    /// The prefix to use when emitting :ref:`statistics
    /// &lt;config_network_filters_client_ssl_auth_stats>`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StatPrefix {
      get { return statPrefix_; }
      set {
        statPrefix_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "refresh_delay" field.</summary>
    public const int RefreshDelayFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Duration refreshDelay_;
    /// <summary>
    /// Time in milliseconds between principal refreshes from the
    /// authentication service. Default is 60000 (60s). The actual fetch time
    /// will be this value plus a random jittered value between
    /// 0-refresh_delay_ms milliseconds.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Duration RefreshDelay {
      get { return refreshDelay_; }
      set {
        refreshDelay_ = value;
      }
    }

    /// <summary>Field number for the "ip_white_list" field.</summary>
    public const int IpWhiteListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Envoy.Config.Core.V3.CidrRange> _repeated_ipWhiteList_codec
        = pb::FieldCodec.ForMessage(34, global::Envoy.Config.Core.V3.CidrRange.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Config.Core.V3.CidrRange> ipWhiteList_ = new pbc::RepeatedField<global::Envoy.Config.Core.V3.CidrRange>();
    /// <summary>
    /// An optional list of IP address and subnet masks that should be white
    /// listed for access by the filter. If no list is provided, there is no
    /// IP allowlist.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Envoy.Config.Core.V3.CidrRange> IpWhiteList {
      get { return ipWhiteList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ClientSSLAuth);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ClientSSLAuth other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AuthApiCluster != other.AuthApiCluster) return false;
      if (StatPrefix != other.StatPrefix) return false;
      if (!object.Equals(RefreshDelay, other.RefreshDelay)) return false;
      if(!ipWhiteList_.Equals(other.ipWhiteList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AuthApiCluster.Length != 0) hash ^= AuthApiCluster.GetHashCode();
      if (StatPrefix.Length != 0) hash ^= StatPrefix.GetHashCode();
      if (refreshDelay_ != null) hash ^= RefreshDelay.GetHashCode();
      hash ^= ipWhiteList_.GetHashCode();
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
      if (AuthApiCluster.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AuthApiCluster);
      }
      if (StatPrefix.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(StatPrefix);
      }
      if (refreshDelay_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RefreshDelay);
      }
      ipWhiteList_.WriteTo(output, _repeated_ipWhiteList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (AuthApiCluster.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AuthApiCluster);
      }
      if (StatPrefix.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(StatPrefix);
      }
      if (refreshDelay_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RefreshDelay);
      }
      ipWhiteList_.WriteTo(ref output, _repeated_ipWhiteList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (AuthApiCluster.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AuthApiCluster);
      }
      if (StatPrefix.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StatPrefix);
      }
      if (refreshDelay_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RefreshDelay);
      }
      size += ipWhiteList_.CalculateSize(_repeated_ipWhiteList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ClientSSLAuth other) {
      if (other == null) {
        return;
      }
      if (other.AuthApiCluster.Length != 0) {
        AuthApiCluster = other.AuthApiCluster;
      }
      if (other.StatPrefix.Length != 0) {
        StatPrefix = other.StatPrefix;
      }
      if (other.refreshDelay_ != null) {
        if (refreshDelay_ == null) {
          RefreshDelay = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        RefreshDelay.MergeFrom(other.RefreshDelay);
      }
      ipWhiteList_.Add(other.ipWhiteList_);
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
            AuthApiCluster = input.ReadString();
            break;
          }
          case 18: {
            StatPrefix = input.ReadString();
            break;
          }
          case 26: {
            if (refreshDelay_ == null) {
              RefreshDelay = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(RefreshDelay);
            break;
          }
          case 34: {
            ipWhiteList_.AddEntriesFrom(input, _repeated_ipWhiteList_codec);
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
            AuthApiCluster = input.ReadString();
            break;
          }
          case 18: {
            StatPrefix = input.ReadString();
            break;
          }
          case 26: {
            if (refreshDelay_ == null) {
              RefreshDelay = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(RefreshDelay);
            break;
          }
          case 34: {
            ipWhiteList_.AddEntriesFrom(ref input, _repeated_ipWhiteList_codec);
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
