// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/type/matcher/regex.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Type.Matcher {

  /// <summary>Holder for reflection information generated from envoy/type/matcher/regex.proto</summary>
  public static partial class RegexReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/type/matcher/regex.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RegexReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5lbnZveS90eXBlL21hdGNoZXIvcmVnZXgucHJvdG8SEmVudm95LnR5cGUu",
            "bWF0Y2hlchoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBwZXJzLnByb3RvGh11ZHBh",
            "L2Fubm90YXRpb25zL3N0YXR1cy5wcm90bxoXdmFsaWRhdGUvdmFsaWRhdGUu",
            "cHJvdG8izwEKDFJlZ2V4TWF0Y2hlchJKCgpnb29nbGVfcmUyGAEgASgLMiou",
            "ZW52b3kudHlwZS5tYXRjaGVyLlJlZ2V4TWF0Y2hlci5Hb29nbGVSRTJCCPpC",
            "BYoBAhABSAASFgoFcmVnZXgYAiABKAlCB/pCBHICEAEaRwoJR29vZ2xlUkUy",
            "EjoKEG1heF9wcm9ncmFtX3NpemUYASABKAsyHC5nb29nbGUucHJvdG9idWYu",
            "VUludDMyVmFsdWVCAhgBQhIKC2VuZ2luZV90eXBlEgP4QgEiYgoXUmVnZXhN",
            "YXRjaEFuZFN1YnN0aXR1dGUSMQoHcGF0dGVybhgBIAEoCzIgLmVudm95LnR5",
            "cGUubWF0Y2hlci5SZWdleE1hdGNoZXISFAoMc3Vic3RpdHV0aW9uGAIgASgJ",
            "QjgKIGlvLmVudm95cHJveHkuZW52b3kudHlwZS5tYXRjaGVyQgpSZWdleFBy",
            "b3RvUAG6gMjRBgIQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Type.Matcher.RegexMatcher), global::Envoy.Type.Matcher.RegexMatcher.Parser, new[]{ "GoogleRe2", "Regex" }, new[]{ "EngineType" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Type.Matcher.RegexMatcher.Types.GoogleRE2), global::Envoy.Type.Matcher.RegexMatcher.Types.GoogleRE2.Parser, new[]{ "MaxProgramSize" }, null, null, null, null)}),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Type.Matcher.RegexMatchAndSubstitute), global::Envoy.Type.Matcher.RegexMatchAndSubstitute.Parser, new[]{ "Pattern", "Substitution" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A regex matcher designed for safety when used with untrusted input.
  /// </summary>
  public sealed partial class RegexMatcher : pb::IMessage<RegexMatcher>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RegexMatcher> _parser = new pb::MessageParser<RegexMatcher>(() => new RegexMatcher());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RegexMatcher> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Type.Matcher.RegexReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RegexMatcher() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RegexMatcher(RegexMatcher other) : this() {
      regex_ = other.regex_;
      switch (other.EngineTypeCase) {
        case EngineTypeOneofCase.GoogleRe2:
          GoogleRe2 = other.GoogleRe2.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RegexMatcher Clone() {
      return new RegexMatcher(this);
    }

    /// <summary>Field number for the "google_re2" field.</summary>
    public const int GoogleRe2FieldNumber = 1;
    /// <summary>
    /// Google's RE2 regex engine.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Type.Matcher.RegexMatcher.Types.GoogleRE2 GoogleRe2 {
      get { return engineTypeCase_ == EngineTypeOneofCase.GoogleRe2 ? (global::Envoy.Type.Matcher.RegexMatcher.Types.GoogleRE2) engineType_ : null; }
      set {
        engineType_ = value;
        engineTypeCase_ = value == null ? EngineTypeOneofCase.None : EngineTypeOneofCase.GoogleRe2;
      }
    }

    /// <summary>Field number for the "regex" field.</summary>
    public const int RegexFieldNumber = 2;
    private string regex_ = "";
    /// <summary>
    /// The regex match string. The string must be supported by the configured engine.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Regex {
      get { return regex_; }
      set {
        regex_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private object engineType_;
    /// <summary>Enum of possible cases for the "engine_type" oneof.</summary>
    public enum EngineTypeOneofCase {
      None = 0,
      GoogleRe2 = 1,
    }
    private EngineTypeOneofCase engineTypeCase_ = EngineTypeOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EngineTypeOneofCase EngineTypeCase {
      get { return engineTypeCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearEngineType() {
      engineTypeCase_ = EngineTypeOneofCase.None;
      engineType_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RegexMatcher);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RegexMatcher other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(GoogleRe2, other.GoogleRe2)) return false;
      if (Regex != other.Regex) return false;
      if (EngineTypeCase != other.EngineTypeCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (engineTypeCase_ == EngineTypeOneofCase.GoogleRe2) hash ^= GoogleRe2.GetHashCode();
      if (Regex.Length != 0) hash ^= Regex.GetHashCode();
      hash ^= (int) engineTypeCase_;
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
      if (engineTypeCase_ == EngineTypeOneofCase.GoogleRe2) {
        output.WriteRawTag(10);
        output.WriteMessage(GoogleRe2);
      }
      if (Regex.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Regex);
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
      if (engineTypeCase_ == EngineTypeOneofCase.GoogleRe2) {
        output.WriteRawTag(10);
        output.WriteMessage(GoogleRe2);
      }
      if (Regex.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Regex);
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
      if (engineTypeCase_ == EngineTypeOneofCase.GoogleRe2) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GoogleRe2);
      }
      if (Regex.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Regex);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RegexMatcher other) {
      if (other == null) {
        return;
      }
      if (other.Regex.Length != 0) {
        Regex = other.Regex;
      }
      switch (other.EngineTypeCase) {
        case EngineTypeOneofCase.GoogleRe2:
          if (GoogleRe2 == null) {
            GoogleRe2 = new global::Envoy.Type.Matcher.RegexMatcher.Types.GoogleRE2();
          }
          GoogleRe2.MergeFrom(other.GoogleRe2);
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
            global::Envoy.Type.Matcher.RegexMatcher.Types.GoogleRE2 subBuilder = new global::Envoy.Type.Matcher.RegexMatcher.Types.GoogleRE2();
            if (engineTypeCase_ == EngineTypeOneofCase.GoogleRe2) {
              subBuilder.MergeFrom(GoogleRe2);
            }
            input.ReadMessage(subBuilder);
            GoogleRe2 = subBuilder;
            break;
          }
          case 18: {
            Regex = input.ReadString();
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
            global::Envoy.Type.Matcher.RegexMatcher.Types.GoogleRE2 subBuilder = new global::Envoy.Type.Matcher.RegexMatcher.Types.GoogleRE2();
            if (engineTypeCase_ == EngineTypeOneofCase.GoogleRe2) {
              subBuilder.MergeFrom(GoogleRe2);
            }
            input.ReadMessage(subBuilder);
            GoogleRe2 = subBuilder;
            break;
          }
          case 18: {
            Regex = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the RegexMatcher message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Google's `RE2 &lt;https://github.com/google/re2>`_ regex engine. The regex string must adhere to
      /// the documented `syntax &lt;https://github.com/google/re2/wiki/Syntax>`_. The engine is designed
      /// to complete execution in linear time as well as limit the amount of memory used.
      ///
      /// Envoy supports program size checking via runtime. The runtime keys `re2.max_program_size.error_level`
      /// and `re2.max_program_size.warn_level` can be set to integers as the maximum program size or
      /// complexity that a compiled regex can have before an exception is thrown or a warning is
      /// logged, respectively. `re2.max_program_size.error_level` defaults to 100, and
      /// `re2.max_program_size.warn_level` has no default if unset (will not check/log a warning).
      ///
      /// Envoy emits two stats for tracking the program size of regexes: the histogram `re2.program_size`,
      /// which records the program size, and the counter `re2.exceeded_warn_level`, which is incremented
      /// each time the program size exceeds the warn level threshold.
      /// </summary>
      public sealed partial class GoogleRE2 : pb::IMessage<GoogleRE2>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<GoogleRE2> _parser = new pb::MessageParser<GoogleRE2>(() => new GoogleRE2());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<GoogleRE2> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Envoy.Type.Matcher.RegexMatcher.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public GoogleRE2() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public GoogleRE2(GoogleRE2 other) : this() {
          MaxProgramSize = other.MaxProgramSize;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public GoogleRE2 Clone() {
          return new GoogleRE2(this);
        }

        /// <summary>Field number for the "max_program_size" field.</summary>
        public const int MaxProgramSizeFieldNumber = 1;
        private static readonly pb::FieldCodec<uint?> _single_maxProgramSize_codec = pb::FieldCodec.ForStructWrapper<uint>(10);
        private uint? maxProgramSize_;
        /// <summary>
        /// This field controls the RE2 "program size" which is a rough estimate of how complex a
        /// compiled regex is to evaluate. A regex that has a program size greater than the configured
        /// value will fail to compile. In this case, the configured max program size can be increased
        /// or the regex can be simplified. If not specified, the default is 100.
        ///
        /// This field is deprecated; regexp validation should be performed on the management server
        /// instead of being done by each individual client.
        /// </summary>
        [global::System.ObsoleteAttribute]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public uint? MaxProgramSize {
          get { return maxProgramSize_; }
          set {
            maxProgramSize_ = value;
          }
        }


        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as GoogleRE2);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(GoogleRE2 other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (MaxProgramSize != other.MaxProgramSize) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (maxProgramSize_ != null) hash ^= MaxProgramSize.GetHashCode();
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
          if (maxProgramSize_ != null) {
            _single_maxProgramSize_codec.WriteTagAndValue(output, MaxProgramSize);
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
          if (maxProgramSize_ != null) {
            _single_maxProgramSize_codec.WriteTagAndValue(ref output, MaxProgramSize);
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
          if (maxProgramSize_ != null) {
            size += _single_maxProgramSize_codec.CalculateSizeWithTag(MaxProgramSize);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(GoogleRE2 other) {
          if (other == null) {
            return;
          }
          if (other.maxProgramSize_ != null) {
            if (maxProgramSize_ == null || other.MaxProgramSize != 0) {
              MaxProgramSize = other.MaxProgramSize;
            }
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
                uint? value = _single_maxProgramSize_codec.Read(input);
                if (maxProgramSize_ == null || value != 0) {
                  MaxProgramSize = value;
                }
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
                uint? value = _single_maxProgramSize_codec.Read(ref input);
                if (maxProgramSize_ == null || value != 0) {
                  MaxProgramSize = value;
                }
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

  /// <summary>
  /// Describes how to match a string and then produce a new string using a regular
  /// expression and a substitution string.
  /// </summary>
  public sealed partial class RegexMatchAndSubstitute : pb::IMessage<RegexMatchAndSubstitute>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RegexMatchAndSubstitute> _parser = new pb::MessageParser<RegexMatchAndSubstitute>(() => new RegexMatchAndSubstitute());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RegexMatchAndSubstitute> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Type.Matcher.RegexReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RegexMatchAndSubstitute() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RegexMatchAndSubstitute(RegexMatchAndSubstitute other) : this() {
      pattern_ = other.pattern_ != null ? other.pattern_.Clone() : null;
      substitution_ = other.substitution_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RegexMatchAndSubstitute Clone() {
      return new RegexMatchAndSubstitute(this);
    }

    /// <summary>Field number for the "pattern" field.</summary>
    public const int PatternFieldNumber = 1;
    private global::Envoy.Type.Matcher.RegexMatcher pattern_;
    /// <summary>
    /// The regular expression used to find portions of a string (hereafter called
    /// the "subject string") that should be replaced. When a new string is
    /// produced during the substitution operation, the new string is initially
    /// the same as the subject string, but then all matches in the subject string
    /// are replaced by the substitution string. If replacing all matches isn't
    /// desired, regular expression anchors can be used to ensure a single match,
    /// so as to replace just one occurrence of a pattern. Capture groups can be
    /// used in the pattern to extract portions of the subject string, and then
    /// referenced in the substitution string.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Type.Matcher.RegexMatcher Pattern {
      get { return pattern_; }
      set {
        pattern_ = value;
      }
    }

    /// <summary>Field number for the "substitution" field.</summary>
    public const int SubstitutionFieldNumber = 2;
    private string substitution_ = "";
    /// <summary>
    /// The string that should be substituted into matching portions of the
    /// subject string during a substitution operation to produce a new string.
    /// Capture groups in the pattern can be referenced in the substitution
    /// string. Note, however, that the syntax for referring to capture groups is
    /// defined by the chosen regular expression engine. Google's `RE2
    /// &lt;https://github.com/google/re2>`_ regular expression engine uses a
    /// backslash followed by the capture group number to denote a numbered
    /// capture group. E.g., ``\1`` refers to capture group 1, and ``\2`` refers
    /// to capture group 2.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Substitution {
      get { return substitution_; }
      set {
        substitution_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RegexMatchAndSubstitute);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RegexMatchAndSubstitute other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Pattern, other.Pattern)) return false;
      if (Substitution != other.Substitution) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (pattern_ != null) hash ^= Pattern.GetHashCode();
      if (Substitution.Length != 0) hash ^= Substitution.GetHashCode();
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
      if (pattern_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Pattern);
      }
      if (Substitution.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Substitution);
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
      if (pattern_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Pattern);
      }
      if (Substitution.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Substitution);
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
      if (pattern_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pattern);
      }
      if (Substitution.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Substitution);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RegexMatchAndSubstitute other) {
      if (other == null) {
        return;
      }
      if (other.pattern_ != null) {
        if (pattern_ == null) {
          Pattern = new global::Envoy.Type.Matcher.RegexMatcher();
        }
        Pattern.MergeFrom(other.Pattern);
      }
      if (other.Substitution.Length != 0) {
        Substitution = other.Substitution;
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
            if (pattern_ == null) {
              Pattern = new global::Envoy.Type.Matcher.RegexMatcher();
            }
            input.ReadMessage(Pattern);
            break;
          }
          case 18: {
            Substitution = input.ReadString();
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
            if (pattern_ == null) {
              Pattern = new global::Envoy.Type.Matcher.RegexMatcher();
            }
            input.ReadMessage(Pattern);
            break;
          }
          case 18: {
            Substitution = input.ReadString();
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