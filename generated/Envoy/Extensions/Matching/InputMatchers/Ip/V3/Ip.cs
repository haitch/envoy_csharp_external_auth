// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/extensions/matching/input_matchers/ip/v3/ip.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Extensions.Matching.InputMatchers.Ip.V3 {

  /// <summary>Holder for reflection information generated from envoy/extensions/matching/input_matchers/ip/v3/ip.proto</summary>
  public static partial class IpReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/extensions/matching/input_matchers/ip/v3/ip.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IpReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjdlbnZveS9leHRlbnNpb25zL21hdGNoaW5nL2lucHV0X21hdGNoZXJzL2lw",
            "L3YzL2lwLnByb3RvEi5lbnZveS5leHRlbnNpb25zLm1hdGNoaW5nLmlucHV0",
            "X21hdGNoZXJzLmlwLnYzGiJlbnZveS9jb25maWcvY29yZS92My9hZGRyZXNz",
            "LnByb3RvGh11ZHBhL2Fubm90YXRpb25zL3N0YXR1cy5wcm90bxoXdmFsaWRh",
            "dGUvdmFsaWRhdGUucHJvdG8iYgoCSXASPgoLY2lkcl9yYW5nZXMYASADKAsy",
            "Hy5lbnZveS5jb25maWcuY29yZS52My5DaWRyUmFuZ2VCCPpCBZIBAggBEhwK",
            "C3N0YXRfcHJlZml4GAIgASgJQgf6QgRyAhABQlEKPGlvLmVudm95cHJveHku",
            "ZW52b3kuZXh0ZW5zaW9ucy5tYXRjaGluZy5pbnB1dF9tYXRjaGVycy5pcC52",
            "M0IHSXBQcm90b1ABuoDI0QYCEAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Config.Core.V3.AddressReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Extensions.Matching.InputMatchers.Ip.V3.Ip), global::Envoy.Extensions.Matching.InputMatchers.Ip.V3.Ip.Parser, new[]{ "CidrRanges", "StatPrefix" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// This input matcher matches IPv4 or IPv6 addresses against a list of CIDR
  /// ranges. It returns true if and only if the input IP belongs to at least one
  /// of these CIDR ranges. Internally, it uses a Level-Compressed trie, as
  /// described in the paper `IP-address lookup using LC-tries
  /// &lt;https://www.nada.kth.se/~snilsson/publications/IP-address-lookup-using-LC-tries/>`_
  /// by S. Nilsson and G. Karlsson. For "big" lists of IPs, this matcher is more
  /// efficient than multiple single IP matcher, that would have a linear cost.
  /// </summary>
  public sealed partial class Ip : pb::IMessage<Ip>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Ip> _parser = new pb::MessageParser<Ip>(() => new Ip());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Ip> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Extensions.Matching.InputMatchers.Ip.V3.IpReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Ip() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Ip(Ip other) : this() {
      cidrRanges_ = other.cidrRanges_.Clone();
      statPrefix_ = other.statPrefix_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Ip Clone() {
      return new Ip(this);
    }

    /// <summary>Field number for the "cidr_ranges" field.</summary>
    public const int CidrRangesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Envoy.Config.Core.V3.CidrRange> _repeated_cidrRanges_codec
        = pb::FieldCodec.ForMessage(10, global::Envoy.Config.Core.V3.CidrRange.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Config.Core.V3.CidrRange> cidrRanges_ = new pbc::RepeatedField<global::Envoy.Config.Core.V3.CidrRange>();
    /// <summary>
    /// Match if the IP belongs to any of these CIDR ranges.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Envoy.Config.Core.V3.CidrRange> CidrRanges {
      get { return cidrRanges_; }
    }

    /// <summary>Field number for the "stat_prefix" field.</summary>
    public const int StatPrefixFieldNumber = 2;
    private string statPrefix_ = "";
    /// <summary>
    /// The human readable prefix to use when emitting statistics for the IP input
    /// matcher. Names in the table below are concatenated to this prefix.
    ///
    /// .. csv-table::
    ///    :header: Name, Type, Description
    ///    :widths: 1, 1, 2
    ///
    ///    ip_parsing_failed, Counter, Total number of IP addresses the matcher was unable to parse
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StatPrefix {
      get { return statPrefix_; }
      set {
        statPrefix_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Ip);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Ip other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!cidrRanges_.Equals(other.cidrRanges_)) return false;
      if (StatPrefix != other.StatPrefix) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= cidrRanges_.GetHashCode();
      if (StatPrefix.Length != 0) hash ^= StatPrefix.GetHashCode();
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
      cidrRanges_.WriteTo(output, _repeated_cidrRanges_codec);
      if (StatPrefix.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(StatPrefix);
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
      cidrRanges_.WriteTo(ref output, _repeated_cidrRanges_codec);
      if (StatPrefix.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(StatPrefix);
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
      size += cidrRanges_.CalculateSize(_repeated_cidrRanges_codec);
      if (StatPrefix.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StatPrefix);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Ip other) {
      if (other == null) {
        return;
      }
      cidrRanges_.Add(other.cidrRanges_);
      if (other.StatPrefix.Length != 0) {
        StatPrefix = other.StatPrefix;
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
            cidrRanges_.AddEntriesFrom(input, _repeated_cidrRanges_codec);
            break;
          }
          case 18: {
            StatPrefix = input.ReadString();
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
            cidrRanges_.AddEntriesFrom(ref input, _repeated_cidrRanges_codec);
            break;
          }
          case 18: {
            StatPrefix = input.ReadString();
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
