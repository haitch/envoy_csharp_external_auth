// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/type/v3/percent.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Type.V3 {

  /// <summary>Holder for reflection information generated from envoy/type/v3/percent.proto</summary>
  public static partial class PercentReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/type/v3/percent.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PercentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtlbnZveS90eXBlL3YzL3BlcmNlbnQucHJvdG8SDWVudm95LnR5cGUudjMa",
            "HXVkcGEvYW5ub3RhdGlvbnMvc3RhdHVzLnByb3RvGiF1ZHBhL2Fubm90YXRp",
            "b25zL3ZlcnNpb25pbmcucHJvdG8aF3ZhbGlkYXRlL3ZhbGlkYXRlLnByb3Rv",
            "IkwKB1BlcmNlbnQSJgoFdmFsdWUYASABKAFCF/pCFBISGQAAAAAAAFlAKQAA",
            "AAAAAAAAOhmaxYgeFAoSZW52b3kudHlwZS5QZXJjZW50ItsBChFGcmFjdGlv",
            "bmFsUGVyY2VudBIRCgludW1lcmF0b3IYASABKA0STwoLZGVub21pbmF0b3IY",
            "AiABKA4yMC5lbnZveS50eXBlLnYzLkZyYWN0aW9uYWxQZXJjZW50LkRlbm9t",
            "aW5hdG9yVHlwZUII+kIFggECEAEiPQoPRGVub21pbmF0b3JUeXBlEgsKB0hV",
            "TkRSRUQQABIQCgxURU5fVEhPVVNBTkQQARILCgdNSUxMSU9OEAI6I5rFiB4e",
            "ChxlbnZveS50eXBlLkZyYWN0aW9uYWxQZXJjZW50QjUKG2lvLmVudm95cHJv",
            "eHkuZW52b3kudHlwZS52M0IMUGVyY2VudFByb3RvUAG6gMjRBgIQAmIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Udpa.Annotations.StatusReflection.Descriptor, global::Udpa.Annotations.VersioningReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Type.V3.Percent), global::Envoy.Type.V3.Percent.Parser, new[]{ "Value" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Type.V3.FractionalPercent), global::Envoy.Type.V3.FractionalPercent.Parser, new[]{ "Numerator", "Denominator" }, null, new[]{ typeof(global::Envoy.Type.V3.FractionalPercent.Types.DenominatorType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Identifies a percentage, in the range [0.0, 100.0].
  /// </summary>
  public sealed partial class Percent : pb::IMessage<Percent>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Percent> _parser = new pb::MessageParser<Percent>(() => new Percent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Percent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Type.V3.PercentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Percent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Percent(Percent other) : this() {
      value_ = other.value_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Percent Clone() {
      return new Percent(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 1;
    private double value_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Percent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Percent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Value, other.Value)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Value != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Value);
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
      if (Value != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(Value);
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
      if (Value != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(Value);
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
      if (Value != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Percent other) {
      if (other == null) {
        return;
      }
      if (other.Value != 0D) {
        Value = other.Value;
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
          case 9: {
            Value = input.ReadDouble();
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
          case 9: {
            Value = input.ReadDouble();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// A fractional percentage is used in cases in which for performance reasons performing floating
  /// point to integer conversions during randomness calculations is undesirable. The message includes
  /// both a numerator and denominator that together determine the final fractional value.
  ///
  /// * **Example**: 1/100 = 1%.
  /// * **Example**: 3/10000 = 0.03%.
  /// </summary>
  public sealed partial class FractionalPercent : pb::IMessage<FractionalPercent>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FractionalPercent> _parser = new pb::MessageParser<FractionalPercent>(() => new FractionalPercent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FractionalPercent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Type.V3.PercentReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FractionalPercent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FractionalPercent(FractionalPercent other) : this() {
      numerator_ = other.numerator_;
      denominator_ = other.denominator_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FractionalPercent Clone() {
      return new FractionalPercent(this);
    }

    /// <summary>Field number for the "numerator" field.</summary>
    public const int NumeratorFieldNumber = 1;
    private uint numerator_;
    /// <summary>
    /// Specifies the numerator. Defaults to 0.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Numerator {
      get { return numerator_; }
      set {
        numerator_ = value;
      }
    }

    /// <summary>Field number for the "denominator" field.</summary>
    public const int DenominatorFieldNumber = 2;
    private global::Envoy.Type.V3.FractionalPercent.Types.DenominatorType denominator_ = global::Envoy.Type.V3.FractionalPercent.Types.DenominatorType.Hundred;
    /// <summary>
    /// Specifies the denominator. If the denominator specified is less than the numerator, the final
    /// fractional percentage is capped at 1 (100%).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Type.V3.FractionalPercent.Types.DenominatorType Denominator {
      get { return denominator_; }
      set {
        denominator_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FractionalPercent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FractionalPercent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Numerator != other.Numerator) return false;
      if (Denominator != other.Denominator) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Numerator != 0) hash ^= Numerator.GetHashCode();
      if (Denominator != global::Envoy.Type.V3.FractionalPercent.Types.DenominatorType.Hundred) hash ^= Denominator.GetHashCode();
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
      if (Numerator != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Numerator);
      }
      if (Denominator != global::Envoy.Type.V3.FractionalPercent.Types.DenominatorType.Hundred) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Denominator);
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
      if (Numerator != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Numerator);
      }
      if (Denominator != global::Envoy.Type.V3.FractionalPercent.Types.DenominatorType.Hundred) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Denominator);
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
      if (Numerator != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Numerator);
      }
      if (Denominator != global::Envoy.Type.V3.FractionalPercent.Types.DenominatorType.Hundred) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Denominator);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FractionalPercent other) {
      if (other == null) {
        return;
      }
      if (other.Numerator != 0) {
        Numerator = other.Numerator;
      }
      if (other.Denominator != global::Envoy.Type.V3.FractionalPercent.Types.DenominatorType.Hundred) {
        Denominator = other.Denominator;
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
          case 8: {
            Numerator = input.ReadUInt32();
            break;
          }
          case 16: {
            Denominator = (global::Envoy.Type.V3.FractionalPercent.Types.DenominatorType) input.ReadEnum();
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
          case 8: {
            Numerator = input.ReadUInt32();
            break;
          }
          case 16: {
            Denominator = (global::Envoy.Type.V3.FractionalPercent.Types.DenominatorType) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the FractionalPercent message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Fraction percentages support several fixed denominator values.
      /// </summary>
      public enum DenominatorType {
        /// <summary>
        /// 100.
        ///
        /// **Example**: 1/100 = 1%.
        /// </summary>
        [pbr::OriginalName("HUNDRED")] Hundred = 0,
        /// <summary>
        /// 10,000.
        ///
        /// **Example**: 1/10000 = 0.01%.
        /// </summary>
        [pbr::OriginalName("TEN_THOUSAND")] TenThousand = 1,
        /// <summary>
        /// 1,000,000.
        ///
        /// **Example**: 1/1000000 = 0.0001%.
        /// </summary>
        [pbr::OriginalName("MILLION")] Million = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
