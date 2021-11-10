// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/extensions/access_loggers/stream/v3/stream.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Extensions.AccessLoggers.Stream.V3 {

  /// <summary>Holder for reflection information generated from envoy/extensions/access_loggers/stream/v3/stream.proto</summary>
  public static partial class StreamReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/extensions/access_loggers/stream/v3/stream.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StreamReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZlbnZveS9leHRlbnNpb25zL2FjY2Vzc19sb2dnZXJzL3N0cmVhbS92My9z",
            "dHJlYW0ucHJvdG8SKWVudm95LmV4dGVuc2lvbnMuYWNjZXNzX2xvZ2dlcnMu",
            "c3RyZWFtLnYzGjVlbnZveS9jb25maWcvY29yZS92My9zdWJzdGl0dXRpb25f",
            "Zm9ybWF0X3N0cmluZy5wcm90bxoddWRwYS9hbm5vdGF0aW9ucy9zdGF0dXMu",
            "cHJvdG8aF3ZhbGlkYXRlL3ZhbGlkYXRlLnByb3RvInYKD1N0ZG91dEFjY2Vz",
            "c0xvZxJOCgpsb2dfZm9ybWF0GAEgASgLMi4uZW52b3kuY29uZmlnLmNvcmUu",
            "djMuU3Vic3RpdHV0aW9uRm9ybWF0U3RyaW5nQgj6QgWKAQIQAUgAQhMKEWFj",
            "Y2Vzc19sb2dfZm9ybWF0InYKD1N0ZGVyckFjY2Vzc0xvZxJOCgpsb2dfZm9y",
            "bWF0GAEgASgLMi4uZW52b3kuY29uZmlnLmNvcmUudjMuU3Vic3RpdHV0aW9u",
            "Rm9ybWF0U3RyaW5nQgj6QgWKAQIQAUgAQhMKEWFjY2Vzc19sb2dfZm9ybWF0",
            "QlAKN2lvLmVudm95cHJveHkuZW52b3kuZXh0ZW5zaW9ucy5hY2Nlc3NfbG9n",
            "Z2Vycy5zdHJlYW0udjNCC1N0cmVhbVByb3RvUAG6gMjRBgIQAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Config.Core.V3.SubstitutionFormatStringReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Extensions.AccessLoggers.Stream.V3.StdoutAccessLog), global::Envoy.Extensions.AccessLoggers.Stream.V3.StdoutAccessLog.Parser, new[]{ "LogFormat" }, new[]{ "AccessLogFormat" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Extensions.AccessLoggers.Stream.V3.StderrAccessLog), global::Envoy.Extensions.AccessLoggers.Stream.V3.StderrAccessLog.Parser, new[]{ "LogFormat" }, new[]{ "AccessLogFormat" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Custom configuration for an :ref:`AccessLog &lt;envoy_v3_api_msg_config.accesslog.v3.AccessLog>`
  /// that writes log entries directly to the operating system's standard output.
  /// </summary>
  public sealed partial class StdoutAccessLog : pb::IMessage<StdoutAccessLog>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StdoutAccessLog> _parser = new pb::MessageParser<StdoutAccessLog>(() => new StdoutAccessLog());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StdoutAccessLog> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Extensions.AccessLoggers.Stream.V3.StreamReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StdoutAccessLog() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StdoutAccessLog(StdoutAccessLog other) : this() {
      switch (other.AccessLogFormatCase) {
        case AccessLogFormatOneofCase.LogFormat:
          LogFormat = other.LogFormat.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StdoutAccessLog Clone() {
      return new StdoutAccessLog(this);
    }

    /// <summary>Field number for the "log_format" field.</summary>
    public const int LogFormatFieldNumber = 1;
    /// <summary>
    /// Configuration to form access log data and format.
    /// If not specified, use :ref:`default format &lt;config_access_log_default_format>`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Config.Core.V3.SubstitutionFormatString LogFormat {
      get { return accessLogFormatCase_ == AccessLogFormatOneofCase.LogFormat ? (global::Envoy.Config.Core.V3.SubstitutionFormatString) accessLogFormat_ : null; }
      set {
        accessLogFormat_ = value;
        accessLogFormatCase_ = value == null ? AccessLogFormatOneofCase.None : AccessLogFormatOneofCase.LogFormat;
      }
    }

    private object accessLogFormat_;
    /// <summary>Enum of possible cases for the "access_log_format" oneof.</summary>
    public enum AccessLogFormatOneofCase {
      None = 0,
      LogFormat = 1,
    }
    private AccessLogFormatOneofCase accessLogFormatCase_ = AccessLogFormatOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccessLogFormatOneofCase AccessLogFormatCase {
      get { return accessLogFormatCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAccessLogFormat() {
      accessLogFormatCase_ = AccessLogFormatOneofCase.None;
      accessLogFormat_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StdoutAccessLog);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StdoutAccessLog other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(LogFormat, other.LogFormat)) return false;
      if (AccessLogFormatCase != other.AccessLogFormatCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (accessLogFormatCase_ == AccessLogFormatOneofCase.LogFormat) hash ^= LogFormat.GetHashCode();
      hash ^= (int) accessLogFormatCase_;
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
      if (accessLogFormatCase_ == AccessLogFormatOneofCase.LogFormat) {
        output.WriteRawTag(10);
        output.WriteMessage(LogFormat);
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
      if (accessLogFormatCase_ == AccessLogFormatOneofCase.LogFormat) {
        output.WriteRawTag(10);
        output.WriteMessage(LogFormat);
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
      if (accessLogFormatCase_ == AccessLogFormatOneofCase.LogFormat) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LogFormat);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StdoutAccessLog other) {
      if (other == null) {
        return;
      }
      switch (other.AccessLogFormatCase) {
        case AccessLogFormatOneofCase.LogFormat:
          if (LogFormat == null) {
            LogFormat = new global::Envoy.Config.Core.V3.SubstitutionFormatString();
          }
          LogFormat.MergeFrom(other.LogFormat);
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
            global::Envoy.Config.Core.V3.SubstitutionFormatString subBuilder = new global::Envoy.Config.Core.V3.SubstitutionFormatString();
            if (accessLogFormatCase_ == AccessLogFormatOneofCase.LogFormat) {
              subBuilder.MergeFrom(LogFormat);
            }
            input.ReadMessage(subBuilder);
            LogFormat = subBuilder;
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
            global::Envoy.Config.Core.V3.SubstitutionFormatString subBuilder = new global::Envoy.Config.Core.V3.SubstitutionFormatString();
            if (accessLogFormatCase_ == AccessLogFormatOneofCase.LogFormat) {
              subBuilder.MergeFrom(LogFormat);
            }
            input.ReadMessage(subBuilder);
            LogFormat = subBuilder;
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Custom configuration for an :ref:`AccessLog &lt;envoy_v3_api_msg_config.accesslog.v3.AccessLog>`
  /// that writes log entries directly to the operating system's standard error.
  /// </summary>
  public sealed partial class StderrAccessLog : pb::IMessage<StderrAccessLog>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StderrAccessLog> _parser = new pb::MessageParser<StderrAccessLog>(() => new StderrAccessLog());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StderrAccessLog> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Extensions.AccessLoggers.Stream.V3.StreamReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StderrAccessLog() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StderrAccessLog(StderrAccessLog other) : this() {
      switch (other.AccessLogFormatCase) {
        case AccessLogFormatOneofCase.LogFormat:
          LogFormat = other.LogFormat.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StderrAccessLog Clone() {
      return new StderrAccessLog(this);
    }

    /// <summary>Field number for the "log_format" field.</summary>
    public const int LogFormatFieldNumber = 1;
    /// <summary>
    /// Configuration to form access log data and format.
    /// If not specified, use :ref:`default format &lt;config_access_log_default_format>`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Config.Core.V3.SubstitutionFormatString LogFormat {
      get { return accessLogFormatCase_ == AccessLogFormatOneofCase.LogFormat ? (global::Envoy.Config.Core.V3.SubstitutionFormatString) accessLogFormat_ : null; }
      set {
        accessLogFormat_ = value;
        accessLogFormatCase_ = value == null ? AccessLogFormatOneofCase.None : AccessLogFormatOneofCase.LogFormat;
      }
    }

    private object accessLogFormat_;
    /// <summary>Enum of possible cases for the "access_log_format" oneof.</summary>
    public enum AccessLogFormatOneofCase {
      None = 0,
      LogFormat = 1,
    }
    private AccessLogFormatOneofCase accessLogFormatCase_ = AccessLogFormatOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AccessLogFormatOneofCase AccessLogFormatCase {
      get { return accessLogFormatCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAccessLogFormat() {
      accessLogFormatCase_ = AccessLogFormatOneofCase.None;
      accessLogFormat_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StderrAccessLog);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StderrAccessLog other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(LogFormat, other.LogFormat)) return false;
      if (AccessLogFormatCase != other.AccessLogFormatCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (accessLogFormatCase_ == AccessLogFormatOneofCase.LogFormat) hash ^= LogFormat.GetHashCode();
      hash ^= (int) accessLogFormatCase_;
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
      if (accessLogFormatCase_ == AccessLogFormatOneofCase.LogFormat) {
        output.WriteRawTag(10);
        output.WriteMessage(LogFormat);
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
      if (accessLogFormatCase_ == AccessLogFormatOneofCase.LogFormat) {
        output.WriteRawTag(10);
        output.WriteMessage(LogFormat);
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
      if (accessLogFormatCase_ == AccessLogFormatOneofCase.LogFormat) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LogFormat);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StderrAccessLog other) {
      if (other == null) {
        return;
      }
      switch (other.AccessLogFormatCase) {
        case AccessLogFormatOneofCase.LogFormat:
          if (LogFormat == null) {
            LogFormat = new global::Envoy.Config.Core.V3.SubstitutionFormatString();
          }
          LogFormat.MergeFrom(other.LogFormat);
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
            global::Envoy.Config.Core.V3.SubstitutionFormatString subBuilder = new global::Envoy.Config.Core.V3.SubstitutionFormatString();
            if (accessLogFormatCase_ == AccessLogFormatOneofCase.LogFormat) {
              subBuilder.MergeFrom(LogFormat);
            }
            input.ReadMessage(subBuilder);
            LogFormat = subBuilder;
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
            global::Envoy.Config.Core.V3.SubstitutionFormatString subBuilder = new global::Envoy.Config.Core.V3.SubstitutionFormatString();
            if (accessLogFormatCase_ == AccessLogFormatOneofCase.LogFormat) {
              subBuilder.MergeFrom(LogFormat);
            }
            input.ReadMessage(subBuilder);
            LogFormat = subBuilder;
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