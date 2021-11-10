// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/config/filter/http/aws_request_signing/v2alpha/aws_request_signing.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Filter.Http.AwsRequestSigning.V2Alpha {

  /// <summary>Holder for reflection information generated from envoy/config/filter/http/aws_request_signing/v2alpha/aws_request_signing.proto</summary>
  public static partial class AwsRequestSigningReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/config/filter/http/aws_request_signing/v2alpha/aws_request_signing.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AwsRequestSigningReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ck5lbnZveS9jb25maWcvZmlsdGVyL2h0dHAvYXdzX3JlcXVlc3Rfc2lnbmlu",
            "Zy92MmFscGhhL2F3c19yZXF1ZXN0X3NpZ25pbmcucHJvdG8SNGVudm95LmNv",
            "bmZpZy5maWx0ZXIuaHR0cC5hd3NfcmVxdWVzdF9zaWduaW5nLnYyYWxwaGEa",
            "HnVkcGEvYW5ub3RhdGlvbnMvbWlncmF0ZS5wcm90bxoddWRwYS9hbm5vdGF0",
            "aW9ucy9zdGF0dXMucHJvdG8aF3ZhbGlkYXRlL3ZhbGlkYXRlLnByb3RvImEK",
            "EUF3c1JlcXVlc3RTaWduaW5nEh0KDHNlcnZpY2VfbmFtZRgBIAEoCUIH+kIE",
            "cgIgARIXCgZyZWdpb24YAiABKAlCB/pCBHICIAESFAoMaG9zdF9yZXdyaXRl",
            "GAMgASgJQqIBCkJpby5lbnZveXByb3h5LmVudm95LmNvbmZpZy5maWx0ZXIu",
            "aHR0cC5hd3NfcmVxdWVzdF9zaWduaW5nLnYyYWxwaGFCFkF3c1JlcXVlc3RT",
            "aWduaW5nUHJvdG9QAfKY/o8FNhI0ZW52b3kuZXh0ZW5zaW9ucy5maWx0ZXJz",
            "Lmh0dHAuYXdzX3JlcXVlc3Rfc2lnbmluZy52M7qAyNEGAhABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Udpa.Annotations.MigrateReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Filter.Http.AwsRequestSigning.V2Alpha.AwsRequestSigning), global::Envoy.Config.Filter.Http.AwsRequestSigning.V2Alpha.AwsRequestSigning.Parser, new[]{ "ServiceName", "Region", "HostRewrite" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Top level configuration for the AWS request signing filter.
  /// </summary>
  public sealed partial class AwsRequestSigning : pb::IMessage<AwsRequestSigning>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AwsRequestSigning> _parser = new pb::MessageParser<AwsRequestSigning>(() => new AwsRequestSigning());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AwsRequestSigning> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Filter.Http.AwsRequestSigning.V2Alpha.AwsRequestSigningReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AwsRequestSigning() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AwsRequestSigning(AwsRequestSigning other) : this() {
      serviceName_ = other.serviceName_;
      region_ = other.region_;
      hostRewrite_ = other.hostRewrite_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AwsRequestSigning Clone() {
      return new AwsRequestSigning(this);
    }

    /// <summary>Field number for the "service_name" field.</summary>
    public const int ServiceNameFieldNumber = 1;
    private string serviceName_ = "";
    /// <summary>
    /// The `service namespace
    /// &lt;https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#genref-aws-service-namespaces>`_
    /// of the HTTP endpoint.
    ///
    /// Example: s3
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ServiceName {
      get { return serviceName_; }
      set {
        serviceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "region" field.</summary>
    public const int RegionFieldNumber = 2;
    private string region_ = "";
    /// <summary>
    /// The `region &lt;https://docs.aws.amazon.com/general/latest/gr/rande.html>`_ hosting the HTTP
    /// endpoint.
    ///
    /// Example: us-west-2
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Region {
      get { return region_; }
      set {
        region_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "host_rewrite" field.</summary>
    public const int HostRewriteFieldNumber = 3;
    private string hostRewrite_ = "";
    /// <summary>
    /// Indicates that before signing headers, the host header will be swapped with
    /// this value. If not set or empty, the original host header value
    /// will be used and no rewrite will happen.
    ///
    /// Note: this rewrite affects both signing and host header forwarding. However, this
    /// option shouldn't be used with
    /// :ref:`HCM host rewrite &lt;envoy_api_field_route.RouteAction.host_rewrite>` given that the
    /// value set here would be used for signing whereas the value set in the HCM would be used
    /// for host header forwarding which is not the desired outcome.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string HostRewrite {
      get { return hostRewrite_; }
      set {
        hostRewrite_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AwsRequestSigning);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AwsRequestSigning other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ServiceName != other.ServiceName) return false;
      if (Region != other.Region) return false;
      if (HostRewrite != other.HostRewrite) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ServiceName.Length != 0) hash ^= ServiceName.GetHashCode();
      if (Region.Length != 0) hash ^= Region.GetHashCode();
      if (HostRewrite.Length != 0) hash ^= HostRewrite.GetHashCode();
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
      if (ServiceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ServiceName);
      }
      if (Region.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Region);
      }
      if (HostRewrite.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(HostRewrite);
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
      if (ServiceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ServiceName);
      }
      if (Region.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Region);
      }
      if (HostRewrite.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(HostRewrite);
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
      if (ServiceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ServiceName);
      }
      if (Region.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Region);
      }
      if (HostRewrite.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(HostRewrite);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AwsRequestSigning other) {
      if (other == null) {
        return;
      }
      if (other.ServiceName.Length != 0) {
        ServiceName = other.ServiceName;
      }
      if (other.Region.Length != 0) {
        Region = other.Region;
      }
      if (other.HostRewrite.Length != 0) {
        HostRewrite = other.HostRewrite;
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
            ServiceName = input.ReadString();
            break;
          }
          case 18: {
            Region = input.ReadString();
            break;
          }
          case 26: {
            HostRewrite = input.ReadString();
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
            ServiceName = input.ReadString();
            break;
          }
          case 18: {
            Region = input.ReadString();
            break;
          }
          case 26: {
            HostRewrite = input.ReadString();
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
