// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/type/matcher/number.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Type.Matcher {

  /// <summary>Holder for reflection information generated from envoy/type/matcher/number.proto</summary>
  public static partial class NumberReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/type/matcher/number.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NumberReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9lbnZveS90eXBlL21hdGNoZXIvbnVtYmVyLnByb3RvEhJlbnZveS50eXBl",
            "Lm1hdGNoZXIaFmVudm95L3R5cGUvcmFuZ2UucHJvdG8aHXVkcGEvYW5ub3Rh",
            "dGlvbnMvc3RhdHVzLnByb3RvGhd2YWxpZGF0ZS92YWxpZGF0ZS5wcm90byJg",
            "Cg1Eb3VibGVNYXRjaGVyEigKBXJhbmdlGAEgASgLMhcuZW52b3kudHlwZS5E",
            "b3VibGVSYW5nZUgAEg8KBWV4YWN0GAIgASgBSABCFAoNbWF0Y2hfcGF0dGVy",
            "bhID+EIBQjkKIGlvLmVudm95cHJveHkuZW52b3kudHlwZS5tYXRjaGVyQgtO",
            "dW1iZXJQcm90b1ABuoDI0QYCEAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Type.RangeReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Type.Matcher.DoubleMatcher), global::Envoy.Type.Matcher.DoubleMatcher.Parser, new[]{ "Range", "Exact" }, new[]{ "MatchPattern" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Specifies the way to match a double value.
  /// </summary>
  public sealed partial class DoubleMatcher : pb::IMessage<DoubleMatcher>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DoubleMatcher> _parser = new pb::MessageParser<DoubleMatcher>(() => new DoubleMatcher());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DoubleMatcher> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Type.Matcher.NumberReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DoubleMatcher() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DoubleMatcher(DoubleMatcher other) : this() {
      switch (other.MatchPatternCase) {
        case MatchPatternOneofCase.Range:
          Range = other.Range.Clone();
          break;
        case MatchPatternOneofCase.Exact:
          Exact = other.Exact;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DoubleMatcher Clone() {
      return new DoubleMatcher(this);
    }

    /// <summary>Field number for the "range" field.</summary>
    public const int RangeFieldNumber = 1;
    /// <summary>
    /// If specified, the input double value must be in the range specified here.
    /// Note: The range is using half-open interval semantics [start, end).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Type.DoubleRange Range {
      get { return matchPatternCase_ == MatchPatternOneofCase.Range ? (global::Envoy.Type.DoubleRange) matchPattern_ : null; }
      set {
        matchPattern_ = value;
        matchPatternCase_ = value == null ? MatchPatternOneofCase.None : MatchPatternOneofCase.Range;
      }
    }

    /// <summary>Field number for the "exact" field.</summary>
    public const int ExactFieldNumber = 2;
    /// <summary>
    /// If specified, the input double value must be equal to the value specified here.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Exact {
      get { return matchPatternCase_ == MatchPatternOneofCase.Exact ? (double) matchPattern_ : 0D; }
      set {
        matchPattern_ = value;
        matchPatternCase_ = MatchPatternOneofCase.Exact;
      }
    }

    private object matchPattern_;
    /// <summary>Enum of possible cases for the "match_pattern" oneof.</summary>
    public enum MatchPatternOneofCase {
      None = 0,
      Range = 1,
      Exact = 2,
    }
    private MatchPatternOneofCase matchPatternCase_ = MatchPatternOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MatchPatternOneofCase MatchPatternCase {
      get { return matchPatternCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearMatchPattern() {
      matchPatternCase_ = MatchPatternOneofCase.None;
      matchPattern_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DoubleMatcher);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DoubleMatcher other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Range, other.Range)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Exact, other.Exact)) return false;
      if (MatchPatternCase != other.MatchPatternCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (matchPatternCase_ == MatchPatternOneofCase.Range) hash ^= Range.GetHashCode();
      if (matchPatternCase_ == MatchPatternOneofCase.Exact) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Exact);
      hash ^= (int) matchPatternCase_;
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
      if (matchPatternCase_ == MatchPatternOneofCase.Range) {
        output.WriteRawTag(10);
        output.WriteMessage(Range);
      }
      if (matchPatternCase_ == MatchPatternOneofCase.Exact) {
        output.WriteRawTag(17);
        output.WriteDouble(Exact);
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
      if (matchPatternCase_ == MatchPatternOneofCase.Range) {
        output.WriteRawTag(10);
        output.WriteMessage(Range);
      }
      if (matchPatternCase_ == MatchPatternOneofCase.Exact) {
        output.WriteRawTag(17);
        output.WriteDouble(Exact);
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
      if (matchPatternCase_ == MatchPatternOneofCase.Range) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Range);
      }
      if (matchPatternCase_ == MatchPatternOneofCase.Exact) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DoubleMatcher other) {
      if (other == null) {
        return;
      }
      switch (other.MatchPatternCase) {
        case MatchPatternOneofCase.Range:
          if (Range == null) {
            Range = new global::Envoy.Type.DoubleRange();
          }
          Range.MergeFrom(other.Range);
          break;
        case MatchPatternOneofCase.Exact:
          Exact = other.Exact;
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
            global::Envoy.Type.DoubleRange subBuilder = new global::Envoy.Type.DoubleRange();
            if (matchPatternCase_ == MatchPatternOneofCase.Range) {
              subBuilder.MergeFrom(Range);
            }
            input.ReadMessage(subBuilder);
            Range = subBuilder;
            break;
          }
          case 17: {
            Exact = input.ReadDouble();
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
            global::Envoy.Type.DoubleRange subBuilder = new global::Envoy.Type.DoubleRange();
            if (matchPatternCase_ == MatchPatternOneofCase.Range) {
              subBuilder.MergeFrom(Range);
            }
            input.ReadMessage(subBuilder);
            Range = subBuilder;
            break;
          }
          case 17: {
            Exact = input.ReadDouble();
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
