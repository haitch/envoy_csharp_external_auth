// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/config/filter/http/gzip/v2/gzip.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Filter.Http.Gzip.V2 {

  /// <summary>Holder for reflection information generated from envoy/config/filter/http/gzip/v2/gzip.proto</summary>
  public static partial class GzipReflection {

    #region Descriptor
    /// <summary>File descriptor for envoy/config/filter/http/gzip/v2/gzip.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GzipReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitlbnZveS9jb25maWcvZmlsdGVyL2h0dHAvZ3ppcC92Mi9nemlwLnByb3Rv",
            "EiBlbnZveS5jb25maWcuZmlsdGVyLmh0dHAuZ3ppcC52Mho3ZW52b3kvY29u",
            "ZmlnL2ZpbHRlci9odHRwL2NvbXByZXNzb3IvdjIvY29tcHJlc3Nvci5wcm90",
            "bxoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBwZXJzLnByb3RvGh51ZHBhL2Fubm90",
            "YXRpb25zL21pZ3JhdGUucHJvdG8aHXVkcGEvYW5ub3RhdGlvbnMvc3RhdHVz",
            "LnByb3RvGhd2YWxpZGF0ZS92YWxpZGF0ZS5wcm90byK7BQoER3ppcBI9Cgxt",
            "ZW1vcnlfbGV2ZWwYASABKAsyHC5nb29nbGUucHJvdG9idWYuVUludDMyVmFs",
            "dWVCCfpCBioEGAkoARI4Cg5jb250ZW50X2xlbmd0aBgCIAEoCzIcLmdvb2ds",
            "ZS5wcm90b2J1Zi5VSW50MzJWYWx1ZUICGAESYQoRY29tcHJlc3Npb25fbGV2",
            "ZWwYAyABKA4yPC5lbnZveS5jb25maWcuZmlsdGVyLmh0dHAuZ3ppcC52Mi5H",
            "emlwLkNvbXByZXNzaW9uTGV2ZWwuRW51bUII+kIFggECEAESYgoUY29tcHJl",
            "c3Npb25fc3RyYXRlZ3kYBCABKA4yOi5lbnZveS5jb25maWcuZmlsdGVyLmh0",
            "dHAuZ3ppcC52Mi5HemlwLkNvbXByZXNzaW9uU3RyYXRlZ3lCCPpCBYIBAhAB",
            "EhgKDGNvbnRlbnRfdHlwZRgGIAMoCUICGAESIgoWZGlzYWJsZV9vbl9ldGFn",
            "X2hlYWRlchgHIAEoCEICGAESKQodcmVtb3ZlX2FjY2VwdF9lbmNvZGluZ19o",
            "ZWFkZXIYCCABKAhCAhgBEjwKC3dpbmRvd19iaXRzGAkgASgLMhwuZ29vZ2xl",
            "LnByb3RvYnVmLlVJbnQzMlZhbHVlQgn6QgYqBBgPKAkSRgoKY29tcHJlc3Nv",
            "chgKIAEoCzIyLmVudm95LmNvbmZpZy5maWx0ZXIuaHR0cC5jb21wcmVzc29y",
            "LnYyLkNvbXByZXNzb3IaPAoQQ29tcHJlc3Npb25MZXZlbCIoCgRFbnVtEgsK",
            "B0RFRkFVTFQQABIICgRCRVNUEAESCQoFU1BFRUQQAiJGChNDb21wcmVzc2lv",
            "blN0cmF0ZWd5EgsKB0RFRkFVTFQQABIMCghGSUxURVJFRBABEgsKB0hVRkZN",
            "QU4QAhIHCgNSTEUQA0JyCi5pby5lbnZveXByb3h5LmVudm95LmNvbmZpZy5m",
            "aWx0ZXIuaHR0cC5nemlwLnYyQglHemlwUHJvdG9QAfKY/o8FJxIlZW52b3ku",
            "ZXh0ZW5zaW9ucy5maWx0ZXJzLmh0dHAuZ3ppcC52M7qAyNEGAhABYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Config.Filter.Http.Compressor.V2.CompressorReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Udpa.Annotations.MigrateReflection.Descriptor, global::Udpa.Annotations.StatusReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Filter.Http.Gzip.V2.Gzip), global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Parser, new[]{ "MemoryLevel", "ContentLength", "CompressionLevel", "CompressionStrategy", "ContentType", "DisableOnEtagHeader", "RemoveAcceptEncodingHeader", "WindowBits", "Compressor" }, null, new[]{ typeof(global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Types.CompressionStrategy) }, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Types.CompressionLevel), global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Types.CompressionLevel.Parser, null, null, new[]{ typeof(global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Types.CompressionLevel.Types.Enum) }, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// [#next-free-field: 11]
  /// </summary>
  public sealed partial class Gzip : pb::IMessage<Gzip>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Gzip> _parser = new pb::MessageParser<Gzip>(() => new Gzip());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Gzip> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Filter.Http.Gzip.V2.GzipReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Gzip() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Gzip(Gzip other) : this() {
      MemoryLevel = other.MemoryLevel;
      ContentLength = other.ContentLength;
      compressionLevel_ = other.compressionLevel_;
      compressionStrategy_ = other.compressionStrategy_;
      contentType_ = other.contentType_.Clone();
      disableOnEtagHeader_ = other.disableOnEtagHeader_;
      removeAcceptEncodingHeader_ = other.removeAcceptEncodingHeader_;
      WindowBits = other.WindowBits;
      compressor_ = other.compressor_ != null ? other.compressor_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Gzip Clone() {
      return new Gzip(this);
    }

    /// <summary>Field number for the "memory_level" field.</summary>
    public const int MemoryLevelFieldNumber = 1;
    private static readonly pb::FieldCodec<uint?> _single_memoryLevel_codec = pb::FieldCodec.ForStructWrapper<uint>(10);
    private uint? memoryLevel_;
    /// <summary>
    /// Value from 1 to 9 that controls the amount of internal memory used by zlib. Higher values
    /// use more memory, but are faster and produce better compression results. The default value is 5.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint? MemoryLevel {
      get { return memoryLevel_; }
      set {
        memoryLevel_ = value;
      }
    }


    /// <summary>Field number for the "content_length" field.</summary>
    public const int ContentLengthFieldNumber = 2;
    private static readonly pb::FieldCodec<uint?> _single_contentLength_codec = pb::FieldCodec.ForStructWrapper<uint>(18);
    private uint? contentLength_;
    /// <summary>
    /// Minimum response length, in bytes, which will trigger compression. The default value is 30.
    /// .. attention:
    ///
    ///    **This field is deprecated**. Set the `compressor` field instead.
    /// </summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint? ContentLength {
      get { return contentLength_; }
      set {
        contentLength_ = value;
      }
    }


    /// <summary>Field number for the "compression_level" field.</summary>
    public const int CompressionLevelFieldNumber = 3;
    private global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Types.CompressionLevel.Types.Enum compressionLevel_ = global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Types.CompressionLevel.Types.Enum.Default;
    /// <summary>
    /// A value used for selecting the zlib compression level. This setting will affect speed and
    /// amount of compression applied to the content. "BEST" provides higher compression at the cost of
    /// higher latency, "SPEED" provides lower compression with minimum impact on response time.
    /// "DEFAULT" provides an optimal result between speed and compression. This field will be set to
    /// "DEFAULT" if not specified.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Types.CompressionLevel.Types.Enum CompressionLevel {
      get { return compressionLevel_; }
      set {
        compressionLevel_ = value;
      }
    }

    /// <summary>Field number for the "compression_strategy" field.</summary>
    public const int CompressionStrategyFieldNumber = 4;
    private global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Types.CompressionStrategy compressionStrategy_ = global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Types.CompressionStrategy.Default;
    /// <summary>
    /// A value used for selecting the zlib compression strategy which is directly related to the
    /// characteristics of the content. Most of the time "DEFAULT" will be the best choice, though
    /// there are situations which changing this parameter might produce better results. For example,
    /// run-length encoding (RLE) is typically used when the content is known for having sequences
    /// which same data occurs many consecutive times. For more information about each strategy, please
    /// refer to zlib manual.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Types.CompressionStrategy CompressionStrategy {
      get { return compressionStrategy_; }
      set {
        compressionStrategy_ = value;
      }
    }

    /// <summary>Field number for the "content_type" field.</summary>
    public const int ContentTypeFieldNumber = 6;
    private static readonly pb::FieldCodec<string> _repeated_contentType_codec
        = pb::FieldCodec.ForString(50);
    private readonly pbc::RepeatedField<string> contentType_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Set of strings that allows specifying which mime-types yield compression; e.g.,
    /// application/json, text/html, etc. When this field is not defined, compression will be applied
    /// to the following mime-types: "application/javascript", "application/json",
    /// "application/xhtml+xml", "image/svg+xml", "text/css", "text/html", "text/plain", "text/xml".
    /// .. attention:
    ///
    ///    **This field is deprecated**. Set the `compressor` field instead.
    /// </summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> ContentType {
      get { return contentType_; }
    }

    /// <summary>Field number for the "disable_on_etag_header" field.</summary>
    public const int DisableOnEtagHeaderFieldNumber = 7;
    private bool disableOnEtagHeader_;
    /// <summary>
    /// If true, disables compression when the response contains an etag header. When it is false, the
    /// filter will preserve weak etags and remove the ones that require strong validation.
    /// .. attention:
    ///
    ///    **This field is deprecated**. Set the `compressor` field instead.
    /// </summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool DisableOnEtagHeader {
      get { return disableOnEtagHeader_; }
      set {
        disableOnEtagHeader_ = value;
      }
    }

    /// <summary>Field number for the "remove_accept_encoding_header" field.</summary>
    public const int RemoveAcceptEncodingHeaderFieldNumber = 8;
    private bool removeAcceptEncodingHeader_;
    /// <summary>
    /// If true, removes accept-encoding from the request headers before dispatching it to the upstream
    /// so that responses do not get compressed before reaching the filter.
    /// .. attention:
    ///
    ///    **This field is deprecated**. Set the `compressor` field instead.
    /// </summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool RemoveAcceptEncodingHeader {
      get { return removeAcceptEncodingHeader_; }
      set {
        removeAcceptEncodingHeader_ = value;
      }
    }

    /// <summary>Field number for the "window_bits" field.</summary>
    public const int WindowBitsFieldNumber = 9;
    private static readonly pb::FieldCodec<uint?> _single_windowBits_codec = pb::FieldCodec.ForStructWrapper<uint>(74);
    private uint? windowBits_;
    /// <summary>
    /// Value from 9 to 15 that represents the base two logarithmic of the compressor's window size.
    /// Larger window results in better compression at the expense of memory usage. The default is 12
    /// which will produce a 4096 bytes window. For more details about this parameter, please refer to
    /// zlib manual > deflateInit2.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint? WindowBits {
      get { return windowBits_; }
      set {
        windowBits_ = value;
      }
    }


    /// <summary>Field number for the "compressor" field.</summary>
    public const int CompressorFieldNumber = 10;
    private global::Envoy.Config.Filter.Http.Compressor.V2.Compressor compressor_;
    /// <summary>
    /// Set of configuration parameters common for all compression filters. If this field is set then
    /// the fields `content_length`, `content_type`, `disable_on_etag_header` and
    /// `remove_accept_encoding_header` are ignored.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Envoy.Config.Filter.Http.Compressor.V2.Compressor Compressor {
      get { return compressor_; }
      set {
        compressor_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Gzip);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Gzip other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MemoryLevel != other.MemoryLevel) return false;
      if (ContentLength != other.ContentLength) return false;
      if (CompressionLevel != other.CompressionLevel) return false;
      if (CompressionStrategy != other.CompressionStrategy) return false;
      if(!contentType_.Equals(other.contentType_)) return false;
      if (DisableOnEtagHeader != other.DisableOnEtagHeader) return false;
      if (RemoveAcceptEncodingHeader != other.RemoveAcceptEncodingHeader) return false;
      if (WindowBits != other.WindowBits) return false;
      if (!object.Equals(Compressor, other.Compressor)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (memoryLevel_ != null) hash ^= MemoryLevel.GetHashCode();
      if (contentLength_ != null) hash ^= ContentLength.GetHashCode();
      if (CompressionLevel != global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Types.CompressionLevel.Types.Enum.Default) hash ^= CompressionLevel.GetHashCode();
      if (CompressionStrategy != global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Types.CompressionStrategy.Default) hash ^= CompressionStrategy.GetHashCode();
      hash ^= contentType_.GetHashCode();
      if (DisableOnEtagHeader != false) hash ^= DisableOnEtagHeader.GetHashCode();
      if (RemoveAcceptEncodingHeader != false) hash ^= RemoveAcceptEncodingHeader.GetHashCode();
      if (windowBits_ != null) hash ^= WindowBits.GetHashCode();
      if (compressor_ != null) hash ^= Compressor.GetHashCode();
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
      if (memoryLevel_ != null) {
        _single_memoryLevel_codec.WriteTagAndValue(output, MemoryLevel);
      }
      if (contentLength_ != null) {
        _single_contentLength_codec.WriteTagAndValue(output, ContentLength);
      }
      if (CompressionLevel != global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Types.CompressionLevel.Types.Enum.Default) {
        output.WriteRawTag(24);
        output.WriteEnum((int) CompressionLevel);
      }
      if (CompressionStrategy != global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Types.CompressionStrategy.Default) {
        output.WriteRawTag(32);
        output.WriteEnum((int) CompressionStrategy);
      }
      contentType_.WriteTo(output, _repeated_contentType_codec);
      if (DisableOnEtagHeader != false) {
        output.WriteRawTag(56);
        output.WriteBool(DisableOnEtagHeader);
      }
      if (RemoveAcceptEncodingHeader != false) {
        output.WriteRawTag(64);
        output.WriteBool(RemoveAcceptEncodingHeader);
      }
      if (windowBits_ != null) {
        _single_windowBits_codec.WriteTagAndValue(output, WindowBits);
      }
      if (compressor_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Compressor);
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
      if (memoryLevel_ != null) {
        _single_memoryLevel_codec.WriteTagAndValue(ref output, MemoryLevel);
      }
      if (contentLength_ != null) {
        _single_contentLength_codec.WriteTagAndValue(ref output, ContentLength);
      }
      if (CompressionLevel != global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Types.CompressionLevel.Types.Enum.Default) {
        output.WriteRawTag(24);
        output.WriteEnum((int) CompressionLevel);
      }
      if (CompressionStrategy != global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Types.CompressionStrategy.Default) {
        output.WriteRawTag(32);
        output.WriteEnum((int) CompressionStrategy);
      }
      contentType_.WriteTo(ref output, _repeated_contentType_codec);
      if (DisableOnEtagHeader != false) {
        output.WriteRawTag(56);
        output.WriteBool(DisableOnEtagHeader);
      }
      if (RemoveAcceptEncodingHeader != false) {
        output.WriteRawTag(64);
        output.WriteBool(RemoveAcceptEncodingHeader);
      }
      if (windowBits_ != null) {
        _single_windowBits_codec.WriteTagAndValue(ref output, WindowBits);
      }
      if (compressor_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Compressor);
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
      if (memoryLevel_ != null) {
        size += _single_memoryLevel_codec.CalculateSizeWithTag(MemoryLevel);
      }
      if (contentLength_ != null) {
        size += _single_contentLength_codec.CalculateSizeWithTag(ContentLength);
      }
      if (CompressionLevel != global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Types.CompressionLevel.Types.Enum.Default) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CompressionLevel);
      }
      if (CompressionStrategy != global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Types.CompressionStrategy.Default) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CompressionStrategy);
      }
      size += contentType_.CalculateSize(_repeated_contentType_codec);
      if (DisableOnEtagHeader != false) {
        size += 1 + 1;
      }
      if (RemoveAcceptEncodingHeader != false) {
        size += 1 + 1;
      }
      if (windowBits_ != null) {
        size += _single_windowBits_codec.CalculateSizeWithTag(WindowBits);
      }
      if (compressor_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Compressor);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Gzip other) {
      if (other == null) {
        return;
      }
      if (other.memoryLevel_ != null) {
        if (memoryLevel_ == null || other.MemoryLevel != 0) {
          MemoryLevel = other.MemoryLevel;
        }
      }
      if (other.contentLength_ != null) {
        if (contentLength_ == null || other.ContentLength != 0) {
          ContentLength = other.ContentLength;
        }
      }
      if (other.CompressionLevel != global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Types.CompressionLevel.Types.Enum.Default) {
        CompressionLevel = other.CompressionLevel;
      }
      if (other.CompressionStrategy != global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Types.CompressionStrategy.Default) {
        CompressionStrategy = other.CompressionStrategy;
      }
      contentType_.Add(other.contentType_);
      if (other.DisableOnEtagHeader != false) {
        DisableOnEtagHeader = other.DisableOnEtagHeader;
      }
      if (other.RemoveAcceptEncodingHeader != false) {
        RemoveAcceptEncodingHeader = other.RemoveAcceptEncodingHeader;
      }
      if (other.windowBits_ != null) {
        if (windowBits_ == null || other.WindowBits != 0) {
          WindowBits = other.WindowBits;
        }
      }
      if (other.compressor_ != null) {
        if (compressor_ == null) {
          Compressor = new global::Envoy.Config.Filter.Http.Compressor.V2.Compressor();
        }
        Compressor.MergeFrom(other.Compressor);
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
            uint? value = _single_memoryLevel_codec.Read(input);
            if (memoryLevel_ == null || value != 0) {
              MemoryLevel = value;
            }
            break;
          }
          case 18: {
            uint? value = _single_contentLength_codec.Read(input);
            if (contentLength_ == null || value != 0) {
              ContentLength = value;
            }
            break;
          }
          case 24: {
            CompressionLevel = (global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Types.CompressionLevel.Types.Enum) input.ReadEnum();
            break;
          }
          case 32: {
            CompressionStrategy = (global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Types.CompressionStrategy) input.ReadEnum();
            break;
          }
          case 50: {
            contentType_.AddEntriesFrom(input, _repeated_contentType_codec);
            break;
          }
          case 56: {
            DisableOnEtagHeader = input.ReadBool();
            break;
          }
          case 64: {
            RemoveAcceptEncodingHeader = input.ReadBool();
            break;
          }
          case 74: {
            uint? value = _single_windowBits_codec.Read(input);
            if (windowBits_ == null || value != 0) {
              WindowBits = value;
            }
            break;
          }
          case 82: {
            if (compressor_ == null) {
              Compressor = new global::Envoy.Config.Filter.Http.Compressor.V2.Compressor();
            }
            input.ReadMessage(Compressor);
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
            uint? value = _single_memoryLevel_codec.Read(ref input);
            if (memoryLevel_ == null || value != 0) {
              MemoryLevel = value;
            }
            break;
          }
          case 18: {
            uint? value = _single_contentLength_codec.Read(ref input);
            if (contentLength_ == null || value != 0) {
              ContentLength = value;
            }
            break;
          }
          case 24: {
            CompressionLevel = (global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Types.CompressionLevel.Types.Enum) input.ReadEnum();
            break;
          }
          case 32: {
            CompressionStrategy = (global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Types.CompressionStrategy) input.ReadEnum();
            break;
          }
          case 50: {
            contentType_.AddEntriesFrom(ref input, _repeated_contentType_codec);
            break;
          }
          case 56: {
            DisableOnEtagHeader = input.ReadBool();
            break;
          }
          case 64: {
            RemoveAcceptEncodingHeader = input.ReadBool();
            break;
          }
          case 74: {
            uint? value = _single_windowBits_codec.Read(ref input);
            if (windowBits_ == null || value != 0) {
              WindowBits = value;
            }
            break;
          }
          case 82: {
            if (compressor_ == null) {
              Compressor = new global::Envoy.Config.Filter.Http.Compressor.V2.Compressor();
            }
            input.ReadMessage(Compressor);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Gzip message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CompressionStrategy {
        [pbr::OriginalName("DEFAULT")] Default = 0,
        [pbr::OriginalName("FILTERED")] Filtered = 1,
        [pbr::OriginalName("HUFFMAN")] Huffman = 2,
        [pbr::OriginalName("RLE")] Rle = 3,
      }

      public sealed partial class CompressionLevel : pb::IMessage<CompressionLevel>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<CompressionLevel> _parser = new pb::MessageParser<CompressionLevel>(() => new CompressionLevel());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<CompressionLevel> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Envoy.Config.Filter.Http.Gzip.V2.Gzip.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public CompressionLevel() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public CompressionLevel(CompressionLevel other) : this() {
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public CompressionLevel Clone() {
          return new CompressionLevel(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as CompressionLevel);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(CompressionLevel other) {
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
        public void MergeFrom(CompressionLevel other) {
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

        #region Nested types
        /// <summary>Container for nested types declared in the CompressionLevel message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static partial class Types {
          public enum Enum {
            [pbr::OriginalName("DEFAULT")] Default = 0,
            [pbr::OriginalName("BEST")] Best = 1,
            [pbr::OriginalName("SPEED")] Speed = 2,
          }

        }
        #endregion

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
