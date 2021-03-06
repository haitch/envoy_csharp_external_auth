// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/api/expr/v1beta1/source.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Api.Expr.V1Beta1 {

  /// <summary>Holder for reflection information generated from google/api/expr/v1beta1/source.proto</summary>
  public static partial class SourceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/api/expr/v1beta1/source.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SourceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRnb29nbGUvYXBpL2V4cHIvdjFiZXRhMS9zb3VyY2UucHJvdG8SF2dvb2ds",
            "ZS5hcGkuZXhwci52MWJldGExIq0BCgpTb3VyY2VJbmZvEhAKCGxvY2F0aW9u",
            "GAIgASgJEhQKDGxpbmVfb2Zmc2V0cxgDIAMoBRJFCglwb3NpdGlvbnMYBCAD",
            "KAsyMi5nb29nbGUuYXBpLmV4cHIudjFiZXRhMS5Tb3VyY2VJbmZvLlBvc2l0",
            "aW9uc0VudHJ5GjAKDlBvc2l0aW9uc0VudHJ5EgsKA2tleRgBIAEoBRINCgV2",
            "YWx1ZRgCIAEoBToCOAEiUAoOU291cmNlUG9zaXRpb24SEAoIbG9jYXRpb24Y",
            "ASABKAkSDgoGb2Zmc2V0GAIgASgFEgwKBGxpbmUYAyABKAUSDgoGY29sdW1u",
            "GAQgASgFQmwKG2NvbS5nb29nbGUuYXBpLmV4cHIudjFiZXRhMUILU291cmNl",
            "UHJvdG9QAVo7Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBp",
            "cy9hcGkvZXhwci92MWJldGExO2V4cHL4AQFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.Expr.V1Beta1.SourceInfo), global::Google.Api.Expr.V1Beta1.SourceInfo.Parser, new[]{ "Location", "LineOffsets", "Positions" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Api.Expr.V1Beta1.SourcePosition), global::Google.Api.Expr.V1Beta1.SourcePosition.Parser, new[]{ "Location", "Offset", "Line", "Column" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Source information collected at parse time.
  /// </summary>
  public sealed partial class SourceInfo : pb::IMessage<SourceInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SourceInfo> _parser = new pb::MessageParser<SourceInfo>(() => new SourceInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SourceInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Api.Expr.V1Beta1.SourceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SourceInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SourceInfo(SourceInfo other) : this() {
      location_ = other.location_;
      lineOffsets_ = other.lineOffsets_.Clone();
      positions_ = other.positions_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SourceInfo Clone() {
      return new SourceInfo(this);
    }

    /// <summary>Field number for the "location" field.</summary>
    public const int LocationFieldNumber = 2;
    private string location_ = "";
    /// <summary>
    /// The location name. All position information attached to an expression is
    /// relative to this location.
    ///
    /// The location could be a file, UI element, or similar. For example,
    /// `acme/app/AnvilPolicy.cel`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Location {
      get { return location_; }
      set {
        location_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "line_offsets" field.</summary>
    public const int LineOffsetsFieldNumber = 3;
    private static readonly pb::FieldCodec<int> _repeated_lineOffsets_codec
        = pb::FieldCodec.ForInt32(26);
    private readonly pbc::RepeatedField<int> lineOffsets_ = new pbc::RepeatedField<int>();
    /// <summary>
    /// Monotonically increasing list of character offsets where newlines appear.
    ///
    /// The line number of a given position is the index `i` where for a given
    /// `id` the `line_offsets[i] &lt; id_positions[id] &lt; line_offsets[i+1]`. The
    /// column may be derivd from `id_positions[id] - line_offsets[i]`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> LineOffsets {
      get { return lineOffsets_; }
    }

    /// <summary>Field number for the "positions" field.</summary>
    public const int PositionsFieldNumber = 4;
    private static readonly pbc::MapField<int, int>.Codec _map_positions_codec
        = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForInt32(16, 0), 34);
    private readonly pbc::MapField<int, int> positions_ = new pbc::MapField<int, int>();
    /// <summary>
    /// A map from the parse node id (e.g. `Expr.id`) to the character offset
    /// within source.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<int, int> Positions {
      get { return positions_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SourceInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SourceInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Location != other.Location) return false;
      if(!lineOffsets_.Equals(other.lineOffsets_)) return false;
      if (!Positions.Equals(other.Positions)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Location.Length != 0) hash ^= Location.GetHashCode();
      hash ^= lineOffsets_.GetHashCode();
      hash ^= Positions.GetHashCode();
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
      if (Location.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Location);
      }
      lineOffsets_.WriteTo(output, _repeated_lineOffsets_codec);
      positions_.WriteTo(output, _map_positions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Location.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Location);
      }
      lineOffsets_.WriteTo(ref output, _repeated_lineOffsets_codec);
      positions_.WriteTo(ref output, _map_positions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Location.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Location);
      }
      size += lineOffsets_.CalculateSize(_repeated_lineOffsets_codec);
      size += positions_.CalculateSize(_map_positions_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SourceInfo other) {
      if (other == null) {
        return;
      }
      if (other.Location.Length != 0) {
        Location = other.Location;
      }
      lineOffsets_.Add(other.lineOffsets_);
      positions_.Add(other.positions_);
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
            Location = input.ReadString();
            break;
          }
          case 26:
          case 24: {
            lineOffsets_.AddEntriesFrom(input, _repeated_lineOffsets_codec);
            break;
          }
          case 34: {
            positions_.AddEntriesFrom(input, _map_positions_codec);
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
            Location = input.ReadString();
            break;
          }
          case 26:
          case 24: {
            lineOffsets_.AddEntriesFrom(ref input, _repeated_lineOffsets_codec);
            break;
          }
          case 34: {
            positions_.AddEntriesFrom(ref input, _map_positions_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// A specific position in source.
  /// </summary>
  public sealed partial class SourcePosition : pb::IMessage<SourcePosition>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SourcePosition> _parser = new pb::MessageParser<SourcePosition>(() => new SourcePosition());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SourcePosition> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Api.Expr.V1Beta1.SourceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SourcePosition() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SourcePosition(SourcePosition other) : this() {
      location_ = other.location_;
      offset_ = other.offset_;
      line_ = other.line_;
      column_ = other.column_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SourcePosition Clone() {
      return new SourcePosition(this);
    }

    /// <summary>Field number for the "location" field.</summary>
    public const int LocationFieldNumber = 1;
    private string location_ = "";
    /// <summary>
    /// The soucre location name (e.g. file name).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Location {
      get { return location_; }
      set {
        location_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "offset" field.</summary>
    public const int OffsetFieldNumber = 2;
    private int offset_;
    /// <summary>
    /// The character offset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Offset {
      get { return offset_; }
      set {
        offset_ = value;
      }
    }

    /// <summary>Field number for the "line" field.</summary>
    public const int LineFieldNumber = 3;
    private int line_;
    /// <summary>
    /// The 1-based index of the starting line in the source text
    /// where the issue occurs, or 0 if unknown.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Line {
      get { return line_; }
      set {
        line_ = value;
      }
    }

    /// <summary>Field number for the "column" field.</summary>
    public const int ColumnFieldNumber = 4;
    private int column_;
    /// <summary>
    /// The 0-based index of the starting position within the line of source text
    /// where the issue occurs.  Only meaningful if line is nonzer..
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Column {
      get { return column_; }
      set {
        column_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SourcePosition);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SourcePosition other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Location != other.Location) return false;
      if (Offset != other.Offset) return false;
      if (Line != other.Line) return false;
      if (Column != other.Column) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Location.Length != 0) hash ^= Location.GetHashCode();
      if (Offset != 0) hash ^= Offset.GetHashCode();
      if (Line != 0) hash ^= Line.GetHashCode();
      if (Column != 0) hash ^= Column.GetHashCode();
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
      if (Location.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Location);
      }
      if (Offset != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Offset);
      }
      if (Line != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Line);
      }
      if (Column != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Column);
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
      if (Location.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Location);
      }
      if (Offset != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Offset);
      }
      if (Line != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Line);
      }
      if (Column != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Column);
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
      if (Location.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Location);
      }
      if (Offset != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Offset);
      }
      if (Line != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Line);
      }
      if (Column != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Column);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SourcePosition other) {
      if (other == null) {
        return;
      }
      if (other.Location.Length != 0) {
        Location = other.Location;
      }
      if (other.Offset != 0) {
        Offset = other.Offset;
      }
      if (other.Line != 0) {
        Line = other.Line;
      }
      if (other.Column != 0) {
        Column = other.Column;
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
            Location = input.ReadString();
            break;
          }
          case 16: {
            Offset = input.ReadInt32();
            break;
          }
          case 24: {
            Line = input.ReadInt32();
            break;
          }
          case 32: {
            Column = input.ReadInt32();
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
            Location = input.ReadString();
            break;
          }
          case 16: {
            Offset = input.ReadInt32();
            break;
          }
          case 24: {
            Line = input.ReadInt32();
            break;
          }
          case 32: {
            Column = input.ReadInt32();
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
