// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: udpa/type/v1/typed_struct.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Udpa.Type.V1 {

  /// <summary>Holder for reflection information generated from udpa/type/v1/typed_struct.proto</summary>
  public static partial class TypedStructReflection {

    #region Descriptor
    /// <summary>File descriptor for udpa/type/v1/typed_struct.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TypedStructReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch91ZHBhL3R5cGUvdjEvdHlwZWRfc3RydWN0LnByb3RvEgx1ZHBhLnR5cGUu",
            "djEaF3ZhbGlkYXRlL3ZhbGlkYXRlLnByb3RvGhxnb29nbGUvcHJvdG9idWYv",
            "c3RydWN0LnByb3RvIkcKC1R5cGVkU3RydWN0EhAKCHR5cGVfdXJsGAEgASgJ",
            "EiYKBXZhbHVlGAIgASgLMhcuZ29vZ2xlLnByb3RvYnVmLlN0cnVjdEIyChxj",
            "b20uZ2l0aHViLnVkcGEudWRwYS50eXBlLnYxQhBUeXBlZFN0cnVjdFByb3Rv",
            "UAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Validate.ValidateReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Udpa.Type.V1.TypedStruct), global::Udpa.Type.V1.TypedStruct.Parser, new[]{ "TypeUrl", "Value" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A TypedStruct contains an arbitrary JSON serialized protocol buffer message with a URL that
  /// describes the type of the serialized message. This is very similar to google.protobuf.Any,
  /// instead of having protocol buffer binary, this employs google.protobuf.Struct as value.
  ///
  /// This message is intended to be embedded inside Any, so it shouldn't be directly referred
  /// from other UDPA messages.
  ///
  /// When packing an opaque extension config, packing the expected type into Any is preferred
  /// wherever possible for its efficiency. TypedStruct should be used only if a proto descriptor
  /// is not available, for example if:
  /// - A control plane sends opaque message that is originally from external source in human readable
  ///   format such as JSON or YAML.
  /// - The control plane doesn't have the knowledge of the protocol buffer schema hence it cannot
  ///   serialize the message in protocol buffer binary format.
  /// - The DPLB doesn't have have the knowledge of the protocol buffer schema its plugin or extension
  ///   uses. This has to be indicated in the DPLB capability negotiation.
  ///
  /// When a DPLB receives a TypedStruct in Any, it should:
  /// - Check if the type_url of the TypedStruct matches the type the extension expects.
  /// - Convert value to the type described in type_url and perform validation.
  /// TODO(lizan): Figure out how TypeStruct should be used with DPLB extensions that doesn't link
  /// protobuf descriptor with DPLB itself, (e.g. gRPC LB Plugin, Envoy WASM extensions).
  /// </summary>
  public sealed partial class TypedStruct : pb::IMessage<TypedStruct>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TypedStruct> _parser = new pb::MessageParser<TypedStruct>(() => new TypedStruct());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TypedStruct> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Udpa.Type.V1.TypedStructReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TypedStruct() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TypedStruct(TypedStruct other) : this() {
      typeUrl_ = other.typeUrl_;
      value_ = other.value_ != null ? other.value_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TypedStruct Clone() {
      return new TypedStruct(this);
    }

    /// <summary>Field number for the "type_url" field.</summary>
    public const int TypeUrlFieldNumber = 1;
    private string typeUrl_ = "";
    /// <summary>
    /// A URL that uniquely identifies the type of the serialize protocol buffer message.
    /// This has same semantics and format described in google.protobuf.Any:
    /// https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/any.proto
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TypeUrl {
      get { return typeUrl_; }
      set {
        typeUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Struct value_;
    /// <summary>
    /// A JSON representation of the above specified type.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Struct Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TypedStruct);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TypedStruct other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TypeUrl != other.TypeUrl) return false;
      if (!object.Equals(Value, other.Value)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TypeUrl.Length != 0) hash ^= TypeUrl.GetHashCode();
      if (value_ != null) hash ^= Value.GetHashCode();
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
      if (TypeUrl.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(TypeUrl);
      }
      if (value_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Value);
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
      if (TypeUrl.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(TypeUrl);
      }
      if (value_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Value);
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
      if (TypeUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TypeUrl);
      }
      if (value_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Value);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TypedStruct other) {
      if (other == null) {
        return;
      }
      if (other.TypeUrl.Length != 0) {
        TypeUrl = other.TypeUrl;
      }
      if (other.value_ != null) {
        if (value_ == null) {
          Value = new global::Google.Protobuf.WellKnownTypes.Struct();
        }
        Value.MergeFrom(other.Value);
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
            TypeUrl = input.ReadString();
            break;
          }
          case 18: {
            if (value_ == null) {
              Value = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(Value);
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
            TypeUrl = input.ReadString();
            break;
          }
          case 18: {
            if (value_ == null) {
              Value = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(Value);
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
