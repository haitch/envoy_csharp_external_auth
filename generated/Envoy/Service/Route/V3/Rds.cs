// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/service/route/v3/rds.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Service.Route.V3 {

  /// <summary>Holder for reflection information generated from envoy/service/route/v3/rds.proto</summary>
  public static partial class RdsReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/service/route/v3/rds.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RdsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBlbnZveS9zZXJ2aWNlL3JvdXRlL3YzL3Jkcy5wcm90bxIWZW52b3kuc2Vy",
            "dmljZS5yb3V0ZS52MxoqZW52b3kvc2VydmljZS9kaXNjb3ZlcnkvdjMvZGlz",
            "Y292ZXJ5LnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvGiBl",
            "bnZveS9hbm5vdGF0aW9ucy9yZXNvdXJjZS5wcm90bxoddWRwYS9hbm5vdGF0",
            "aW9ucy9zdGF0dXMucHJvdG8aIXVkcGEvYW5ub3RhdGlvbnMvdmVyc2lvbmlu",
            "Zy5wcm90byIoCghSZHNEdW1teTocmsWIHhcKFWVudm95LmFwaS52Mi5SZHNE",
            "dW1teTLMAwoVUm91dGVEaXNjb3ZlcnlTZXJ2aWNlEnEKDFN0cmVhbVJvdXRl",
            "cxIsLmVudm95LnNlcnZpY2UuZGlzY292ZXJ5LnYzLkRpc2NvdmVyeVJlcXVl",
            "c3QaLS5lbnZveS5zZXJ2aWNlLmRpc2NvdmVyeS52My5EaXNjb3ZlcnlSZXNw",
            "b25zZSIAKAEwARJ6CgtEZWx0YVJvdXRlcxIxLmVudm95LnNlcnZpY2UuZGlz",
            "Y292ZXJ5LnYzLkRlbHRhRGlzY292ZXJ5UmVxdWVzdBoyLmVudm95LnNlcnZp",
            "Y2UuZGlzY292ZXJ5LnYzLkRlbHRhRGlzY292ZXJ5UmVzcG9uc2UiACgBMAES",
            "kQEKC0ZldGNoUm91dGVzEiwuZW52b3kuc2VydmljZS5kaXNjb3ZlcnkudjMu",
            "RGlzY292ZXJ5UmVxdWVzdBotLmVudm95LnNlcnZpY2UuZGlzY292ZXJ5LnYz",
            "LkRpc2NvdmVyeVJlc3BvbnNlIiWC0+STAhYiFC92My9kaXNjb3Zlcnk6cm91",
            "dGVzgtPkkwIDOgEqGjCKpJbzByoKKGVudm95LmNvbmZpZy5yb3V0ZS52My5S",
            "b3V0ZUNvbmZpZ3VyYXRpb24yywEKG1ZpcnR1YWxIb3N0RGlzY292ZXJ5U2Vy",
            "dmljZRKAAQoRRGVsdGFWaXJ0dWFsSG9zdHMSMS5lbnZveS5zZXJ2aWNlLmRp",
            "c2NvdmVyeS52My5EZWx0YURpc2NvdmVyeVJlcXVlc3QaMi5lbnZveS5zZXJ2",
            "aWNlLmRpc2NvdmVyeS52My5EZWx0YURpc2NvdmVyeVJlc3BvbnNlIgAoATAB",
            "GimKpJbzByMKIWVudm95LmNvbmZpZy5yb3V0ZS52My5WaXJ0dWFsSG9zdEI9",
            "CiRpby5lbnZveXByb3h5LmVudm95LnNlcnZpY2Uucm91dGUudjNCCFJkc1By",
            "b3RvUAGIAQG6gMjRBgIQAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Service.Discovery.V3.DiscoveryReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Envoy.Annotations.ResourceReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Udpa.Annotations.VersioningReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Service.Route.V3.RdsDummy), global::Envoy.Service.Route.V3.RdsDummy.Parser, null, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// [#not-implemented-hide:] Not configuration. Workaround c++ protobuf issue with importing
  /// services: https://github.com/google/protobuf/issues/4221 and protoxform to upgrade the file.
  /// </summary>
  public sealed partial class RdsDummy : pb::IMessage<RdsDummy>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RdsDummy> _parser = new pb::MessageParser<RdsDummy>(() => new RdsDummy());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RdsDummy> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Service.Route.V3.RdsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RdsDummy() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RdsDummy(RdsDummy other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RdsDummy Clone() {
      return new RdsDummy(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RdsDummy);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RdsDummy other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RdsDummy other) {
      if (other == null) {
        return;
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
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
