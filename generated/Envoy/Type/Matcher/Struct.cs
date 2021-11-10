// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/type/matcher/struct.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Type.Matcher {

  /// <summary>Holder for reflection information generated from envoy/type/matcher/struct.proto</summary>
  public static partial class StructReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/type/matcher/struct.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StructReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9lbnZveS90eXBlL21hdGNoZXIvc3RydWN0LnByb3RvEhJlbnZveS50eXBl",
            "Lm1hdGNoZXIaHmVudm95L3R5cGUvbWF0Y2hlci92YWx1ZS5wcm90bxoddWRw",
            "YS9hbm5vdGF0aW9ucy9zdGF0dXMucHJvdG8aF3ZhbGlkYXRlL3ZhbGlkYXRl",
            "LnByb3RvIsgBCg1TdHJ1Y3RNYXRjaGVyEkUKBHBhdGgYAiADKAsyLS5lbnZv",
            "eS50eXBlLm1hdGNoZXIuU3RydWN0TWF0Y2hlci5QYXRoU2VnbWVudEII+kIF",
            "kgECCAESOQoFdmFsdWUYAyABKAsyIC5lbnZveS50eXBlLm1hdGNoZXIuVmFs",
            "dWVNYXRjaGVyQgj6QgWKAQIQARo1CgtQYXRoU2VnbWVudBIWCgNrZXkYASAB",
            "KAlCB/pCBHICEAFIAEIOCgdzZWdtZW50EgP4QgFCOQogaW8uZW52b3lwcm94",
            "eS5lbnZveS50eXBlLm1hdGNoZXJCC1N0cnVjdFByb3RvUAG6gMjRBgIQAWIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Type.Matcher.ValueReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Type.Matcher.StructMatcher), global::Envoy.Type.Matcher.StructMatcher.Parser, new[]{ "Path", "Value" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Type.Matcher.StructMatcher.Types.PathSegment), global::Envoy.Type.Matcher.StructMatcher.Types.PathSegment.Parser, new[]{ "Key" }, new[]{ "Segment" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// StructMatcher provides a general interface to check if a given value is matched in
  /// google.protobuf.Struct. It uses `path` to retrieve the value
  /// from the struct and then check if it's matched to the specified value.
  ///
  /// For example, for the following Struct:
  ///
  /// .. code-block:: yaml
  ///
  ///        fields:
  ///          a:
  ///            struct_value:
  ///              fields:
  ///                b:
  ///                  struct_value:
  ///                    fields:
  ///                      c:
  ///                        string_value: pro
  ///                t:
  ///                  list_value:
  ///                    values:
  ///                      - string_value: m
  ///                      - string_value: n
  ///
  /// The following MetadataMatcher is matched as the path [a, b, c] will retrieve a string value "pro"
  /// from the Metadata which is matched to the specified prefix match.
  ///
  /// .. code-block:: yaml
  ///
  ///    path:
  ///    - key: a
  ///    - key: b
  ///    - key: c
  ///    value:
  ///      string_match:
  ///        prefix: pr
  ///
  /// The following StructMatcher is matched as the code will match one of the string values in the
  /// list at the path [a, t].
  ///
  /// .. code-block:: yaml
  ///
  ///    path:
  ///    - key: a
  ///    - key: t
  ///    value:
  ///      list_match:
  ///        one_of:
  ///          string_match:
  ///            exact: m
  ///
  /// An example use of StructMatcher is to match metadata in envoy.v*.core.Node.
  /// </summary>
  public sealed partial class StructMatcher : pb::IMessage<StructMatcher>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StructMatcher> _parser = new pb::MessageParser<StructMatcher>(() => new StructMatcher());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StructMatcher> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Type.Matcher.StructReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StructMatcher() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StructMatcher(StructMatcher other) : this() {
      path_ = other.path_.Clone();
      value_ = other.value_ != null ? other.value_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StructMatcher Clone() {
      return new StructMatcher(this);
    }

    /// <summary>Field number for the "path" field.</summary>
    public const int PathFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Envoy.Type.Matcher.StructMatcher.Types.PathSegment> _repeated_path_codec
        = pb::FieldCodec.ForMessage(18, global::Envoy.Type.Matcher.StructMatcher.Types.PathSegment.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Type.Matcher.StructMatcher.Types.PathSegment> path_ = new pbc::RepeatedField<global::Envoy.Type.Matcher.StructMatcher.Types.PathSegment>();
    /// <summary>
    /// The path to retrieve the Value from the Struct.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Envoy.Type.Matcher.StructMatcher.Types.PathSegment> Path {
      get { return path_; }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 3;
    private global::Envoy.Type.Matcher.ValueMatcher value_;
    /// <summary>
    /// The StructMatcher is matched if the value retrieved by path is matched to this value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Type.Matcher.ValueMatcher Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StructMatcher);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StructMatcher other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!path_.Equals(other.path_)) return false;
      if (!object.Equals(Value, other.Value)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= path_.GetHashCode();
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
      path_.WriteTo(output, _repeated_path_codec);
      if (value_ != null) {
        output.WriteRawTag(26);
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
      path_.WriteTo(ref output, _repeated_path_codec);
      if (value_ != null) {
        output.WriteRawTag(26);
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
      size += path_.CalculateSize(_repeated_path_codec);
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
    public void MergeFrom(StructMatcher other) {
      if (other == null) {
        return;
      }
      path_.Add(other.path_);
      if (other.value_ != null) {
        if (value_ == null) {
          Value = new global::Envoy.Type.Matcher.ValueMatcher();
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
          case 18: {
            path_.AddEntriesFrom(input, _repeated_path_codec);
            break;
          }
          case 26: {
            if (value_ == null) {
              Value = new global::Envoy.Type.Matcher.ValueMatcher();
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
          case 18: {
            path_.AddEntriesFrom(ref input, _repeated_path_codec);
            break;
          }
          case 26: {
            if (value_ == null) {
              Value = new global::Envoy.Type.Matcher.ValueMatcher();
            }
            input.ReadMessage(Value);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the StructMatcher message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Specifies the segment in a path to retrieve value from Struct.
      /// </summary>
      public sealed partial class PathSegment : pb::IMessage<PathSegment>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<PathSegment> _parser = new pb::MessageParser<PathSegment>(() => new PathSegment());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<PathSegment> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Envoy.Type.Matcher.StructMatcher.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PathSegment() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PathSegment(PathSegment other) : this() {
          switch (other.SegmentCase) {
            case SegmentOneofCase.Key:
              Key = other.Key;
              break;
          }

          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PathSegment Clone() {
          return new PathSegment(this);
        }

        /// <summary>Field number for the "key" field.</summary>
        public const int KeyFieldNumber = 1;
        /// <summary>
        /// If specified, use the key to retrieve the value in a Struct.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string Key {
          get { return segmentCase_ == SegmentOneofCase.Key ? (string) segment_ : ""; }
          set {
            segment_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            segmentCase_ = SegmentOneofCase.Key;
          }
        }

        private object segment_;
        /// <summary>Enum of possible cases for the "segment" oneof.</summary>
        public enum SegmentOneofCase {
          None = 0,
          Key = 1,
        }
        private SegmentOneofCase segmentCase_ = SegmentOneofCase.None;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public SegmentOneofCase SegmentCase {
          get { return segmentCase_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearSegment() {
          segmentCase_ = SegmentOneofCase.None;
          segment_ = null;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as PathSegment);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(PathSegment other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Key != other.Key) return false;
          if (SegmentCase != other.SegmentCase) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (segmentCase_ == SegmentOneofCase.Key) hash ^= Key.GetHashCode();
          hash ^= (int) segmentCase_;
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
          if (segmentCase_ == SegmentOneofCase.Key) {
            output.WriteRawTag(10);
            output.WriteString(Key);
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
          if (segmentCase_ == SegmentOneofCase.Key) {
            output.WriteRawTag(10);
            output.WriteString(Key);
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
          if (segmentCase_ == SegmentOneofCase.Key) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(PathSegment other) {
          if (other == null) {
            return;
          }
          switch (other.SegmentCase) {
            case SegmentOneofCase.Key:
              Key = other.Key;
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
                Key = input.ReadString();
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
                Key = input.ReadString();
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