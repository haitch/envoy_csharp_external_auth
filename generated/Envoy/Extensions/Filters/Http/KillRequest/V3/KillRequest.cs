// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/extensions/filters/http/kill_request/v3/kill_request.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Extensions.Filters.Http.KillRequest.V3 {

  /// <summary>Holder for reflection information generated from envoy/extensions/filters/http/kill_request/v3/kill_request.proto</summary>
  public static partial class KillRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/extensions/filters/http/kill_request/v3/kill_request.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KillRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBlbnZveS9leHRlbnNpb25zL2ZpbHRlcnMvaHR0cC9raWxsX3JlcXVlc3Qv",
            "djMva2lsbF9yZXF1ZXN0LnByb3RvEi1lbnZveS5leHRlbnNpb25zLmZpbHRl",
            "cnMuaHR0cC5raWxsX3JlcXVlc3QudjMaG2Vudm95L3R5cGUvdjMvcGVyY2Vu",
            "dC5wcm90bxoddWRwYS9hbm5vdGF0aW9ucy9zdGF0dXMucHJvdG8aF3ZhbGlk",
            "YXRlL3ZhbGlkYXRlLnByb3RvIvkBCgtLaWxsUmVxdWVzdBI1Cgtwcm9iYWJp",
            "bGl0eRgBIAEoCzIgLmVudm95LnR5cGUudjMuRnJhY3Rpb25hbFBlcmNlbnQS",
            "KAoTa2lsbF9yZXF1ZXN0X2hlYWRlchgCIAEoCUIL+kIIcgbAAQLIAQASYQoJ",
            "ZGlyZWN0aW9uGAMgASgOMkQuZW52b3kuZXh0ZW5zaW9ucy5maWx0ZXJzLmh0",
            "dHAua2lsbF9yZXF1ZXN0LnYzLktpbGxSZXF1ZXN0LkRpcmVjdGlvbkII+kIF",
            "ggECEAEiJgoJRGlyZWN0aW9uEgsKB1JFUVVFU1QQABIMCghSRVNQT05TRRAB",
            "QlkKO2lvLmVudm95cHJveHkuZW52b3kuZXh0ZW5zaW9ucy5maWx0ZXJzLmh0",
            "dHAua2lsbF9yZXF1ZXN0LnYzQhBLaWxsUmVxdWVzdFByb3RvUAG6gMjRBgIQ",
            "AmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Type.V3.PercentReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Extensions.Filters.Http.KillRequest.V3.KillRequest), global::Envoy.Extensions.Filters.Http.KillRequest.V3.KillRequest.Parser, new[]{ "Probability", "KillRequestHeader", "Direction" }, null, new[]{ typeof(global::Envoy.Extensions.Filters.Http.KillRequest.V3.KillRequest.Types.Direction) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Configuration for KillRequest filter.
  /// </summary>
  public sealed partial class KillRequest : pb::IMessage<KillRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<KillRequest> _parser = new pb::MessageParser<KillRequest>(() => new KillRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<KillRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Extensions.Filters.Http.KillRequest.V3.KillRequestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KillRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KillRequest(KillRequest other) : this() {
      probability_ = other.probability_ != null ? other.probability_.Clone() : null;
      killRequestHeader_ = other.killRequestHeader_;
      direction_ = other.direction_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KillRequest Clone() {
      return new KillRequest(this);
    }

    /// <summary>Field number for the "probability" field.</summary>
    public const int ProbabilityFieldNumber = 1;
    private global::Envoy.Type.V3.FractionalPercent probability_;
    /// <summary>
    /// The probability that a Kill request will be triggered.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Type.V3.FractionalPercent Probability {
      get { return probability_; }
      set {
        probability_ = value;
      }
    }

    /// <summary>Field number for the "kill_request_header" field.</summary>
    public const int KillRequestHeaderFieldNumber = 2;
    private string killRequestHeader_ = "";
    /// <summary>
    /// The name of the kill request header. If this field is not empty, it will override the :ref:`default header &lt;config_http_filters_kill_request_http_header>` name. Otherwise the default header name will be used.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string KillRequestHeader {
      get { return killRequestHeader_; }
      set {
        killRequestHeader_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "direction" field.</summary>
    public const int DirectionFieldNumber = 3;
    private global::Envoy.Extensions.Filters.Http.KillRequest.V3.KillRequest.Types.Direction direction_ = global::Envoy.Extensions.Filters.Http.KillRequest.V3.KillRequest.Types.Direction.Request;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Extensions.Filters.Http.KillRequest.V3.KillRequest.Types.Direction Direction {
      get { return direction_; }
      set {
        direction_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as KillRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(KillRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Probability, other.Probability)) return false;
      if (KillRequestHeader != other.KillRequestHeader) return false;
      if (Direction != other.Direction) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (probability_ != null) hash ^= Probability.GetHashCode();
      if (KillRequestHeader.Length != 0) hash ^= KillRequestHeader.GetHashCode();
      if (Direction != global::Envoy.Extensions.Filters.Http.KillRequest.V3.KillRequest.Types.Direction.Request) hash ^= Direction.GetHashCode();
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
      if (probability_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Probability);
      }
      if (KillRequestHeader.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(KillRequestHeader);
      }
      if (Direction != global::Envoy.Extensions.Filters.Http.KillRequest.V3.KillRequest.Types.Direction.Request) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Direction);
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
      if (probability_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Probability);
      }
      if (KillRequestHeader.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(KillRequestHeader);
      }
      if (Direction != global::Envoy.Extensions.Filters.Http.KillRequest.V3.KillRequest.Types.Direction.Request) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Direction);
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
      if (probability_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Probability);
      }
      if (KillRequestHeader.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(KillRequestHeader);
      }
      if (Direction != global::Envoy.Extensions.Filters.Http.KillRequest.V3.KillRequest.Types.Direction.Request) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Direction);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(KillRequest other) {
      if (other == null) {
        return;
      }
      if (other.probability_ != null) {
        if (probability_ == null) {
          Probability = new global::Envoy.Type.V3.FractionalPercent();
        }
        Probability.MergeFrom(other.Probability);
      }
      if (other.KillRequestHeader.Length != 0) {
        KillRequestHeader = other.KillRequestHeader;
      }
      if (other.Direction != global::Envoy.Extensions.Filters.Http.KillRequest.V3.KillRequest.Types.Direction.Request) {
        Direction = other.Direction;
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
            if (probability_ == null) {
              Probability = new global::Envoy.Type.V3.FractionalPercent();
            }
            input.ReadMessage(Probability);
            break;
          }
          case 18: {
            KillRequestHeader = input.ReadString();
            break;
          }
          case 24: {
            Direction = (global::Envoy.Extensions.Filters.Http.KillRequest.V3.KillRequest.Types.Direction) input.ReadEnum();
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
            if (probability_ == null) {
              Probability = new global::Envoy.Type.V3.FractionalPercent();
            }
            input.ReadMessage(Probability);
            break;
          }
          case 18: {
            KillRequestHeader = input.ReadString();
            break;
          }
          case 24: {
            Direction = (global::Envoy.Extensions.Filters.Http.KillRequest.V3.KillRequest.Types.Direction) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the KillRequest message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// On which direction should the filter check for the `kill_request_header`.
      /// Default to `REQUEST` if unspecified.
      /// </summary>
      public enum Direction {
        [pbr::OriginalName("REQUEST")] Request = 0,
        [pbr::OriginalName("RESPONSE")] Response = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code