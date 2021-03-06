// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/service/extension/v3/config_discovery.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Service.Extension.V3 {

  /// <summary>Holder for reflection information generated from envoy/service/extension/v3/config_discovery.proto</summary>
  public static partial class ConfigDiscoveryReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/service/extension/v3/config_discovery.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConfigDiscoveryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFlbnZveS9zZXJ2aWNlL2V4dGVuc2lvbi92My9jb25maWdfZGlzY292ZXJ5",
            "LnByb3RvEhplbnZveS5zZXJ2aWNlLmV4dGVuc2lvbi52MxoqZW52b3kvc2Vy",
            "dmljZS9kaXNjb3ZlcnkvdjMvZGlzY292ZXJ5LnByb3RvGhxnb29nbGUvYXBp",
            "L2Fubm90YXRpb25zLnByb3RvGiBlbnZveS9hbm5vdGF0aW9ucy9yZXNvdXJj",
            "ZS5wcm90bxoddWRwYS9hbm5vdGF0aW9ucy9zdGF0dXMucHJvdG8iCwoJRWNk",
            "c0R1bW15MoEECh9FeHRlbnNpb25Db25maWdEaXNjb3ZlcnlTZXJ2aWNlEnsK",
            "FlN0cmVhbUV4dGVuc2lvbkNvbmZpZ3MSLC5lbnZveS5zZXJ2aWNlLmRpc2Nv",
            "dmVyeS52My5EaXNjb3ZlcnlSZXF1ZXN0Gi0uZW52b3kuc2VydmljZS5kaXNj",
            "b3ZlcnkudjMuRGlzY292ZXJ5UmVzcG9uc2UiACgBMAEShAEKFURlbHRhRXh0",
            "ZW5zaW9uQ29uZmlncxIxLmVudm95LnNlcnZpY2UuZGlzY292ZXJ5LnYzLkRl",
            "bHRhRGlzY292ZXJ5UmVxdWVzdBoyLmVudm95LnNlcnZpY2UuZGlzY292ZXJ5",
            "LnYzLkRlbHRhRGlzY292ZXJ5UmVzcG9uc2UiACgBMAESpgEKFUZldGNoRXh0",
            "ZW5zaW9uQ29uZmlncxIsLmVudm95LnNlcnZpY2UuZGlzY292ZXJ5LnYzLkRp",
            "c2NvdmVyeVJlcXVlc3QaLS5lbnZveS5zZXJ2aWNlLmRpc2NvdmVyeS52My5E",
            "aXNjb3ZlcnlSZXNwb25zZSIwgtPkkwIhIh8vdjMvZGlzY292ZXJ5OmV4dGVu",
            "c2lvbl9jb25maWdzgtPkkwIDOgEqGjGKpJbzBysKKWVudm95LmNvbmZpZy5j",
            "b3JlLnYzLlR5cGVkRXh0ZW5zaW9uQ29uZmlnQk0KKGlvLmVudm95cHJveHku",
            "ZW52b3kuc2VydmljZS5leHRlbnNpb24udjNCFENvbmZpZ0Rpc2NvdmVyeVBy",
            "b3RvUAGIAQG6gMjRBgIQAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Service.Discovery.V3.DiscoveryReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Envoy.Annotations.ResourceReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Service.Extension.V3.EcdsDummy), global::Envoy.Service.Extension.V3.EcdsDummy.Parser, null, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// [#not-implemented-hide:] Not configuration. Workaround c++ protobuf issue
  /// with importing services: https://github.com/google/protobuf/issues/4221 and
  /// protoxform to upgrade the file.
  /// </summary>
  public sealed partial class EcdsDummy : pb::IMessage<EcdsDummy>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EcdsDummy> _parser = new pb::MessageParser<EcdsDummy>(() => new EcdsDummy());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EcdsDummy> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Service.Extension.V3.ConfigDiscoveryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EcdsDummy() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EcdsDummy(EcdsDummy other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EcdsDummy Clone() {
      return new EcdsDummy(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EcdsDummy);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EcdsDummy other) {
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
    public void MergeFrom(EcdsDummy other) {
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
