// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: stt.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace SpeechToText {

  /// <summary>Holder for reflection information generated from stt.proto</summary>
  public static partial class SttReflection {

    #region Descriptor
    /// <summary>File descriptor for stt.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SttReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CglzdHQucHJvdG8SDFNwZWVjaFRvVGV4dCJJCgtTcGVlY2hDaHVuaxIPCgdj",
            "b250ZW50GAEgASgMEg0KBXRva2VuGAIgASgJEgwKBGxhbmcYAyABKAkSDAoE",
            "ZGVtbxgEIAEoCSKRAQoPVHJhbnNjcmlwdENodW5rEgsKA2FzchgBIAEoCRIS",
            "Cgp0cmFuc2NyaXB0GAIgASgJEhAKCGlzX2ZpbmFsGAMgASgIEhIKCmNvbmZp",
            "ZGVuY2UYBCABKAISDgoGYW5zd2VyGAUgASgJEhEKCWltYWdlX3VybBgGIAEo",
            "CRIUCgxpbWFnZV95ZXNfbm8YByABKAkyXAoITGlzdGVuZXISUAoORG9TcGVl",
            "Y2hUb1RleHQSGS5TcGVlY2hUb1RleHQuU3BlZWNoQ2h1bmsaHS5TcGVlY2hU",
            "b1RleHQuVHJhbnNjcmlwdENodW5rIgAoATABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::SpeechToText.SpeechChunk), global::SpeechToText.SpeechChunk.Parser, new[]{ "Content", "Token", "Lang", "Demo" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::SpeechToText.TranscriptChunk), global::SpeechToText.TranscriptChunk.Parser, new[]{ "Asr", "Transcript", "IsFinal", "Confidence", "Answer", "ImageUrl", "ImageYesNo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// audio chunk
  /// </summary>
  public sealed partial class SpeechChunk : pb::IMessage<SpeechChunk> {
    private static readonly pb::MessageParser<SpeechChunk> _parser = new pb::MessageParser<SpeechChunk>(() => new SpeechChunk());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SpeechChunk> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SpeechToText.SttReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SpeechChunk() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SpeechChunk(SpeechChunk other) : this() {
      content_ = other.content_;
      token_ = other.token_;
      lang_ = other.lang_;
      demo_ = other.demo_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SpeechChunk Clone() {
      return new SpeechChunk(this);
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 1;
    private pb::ByteString content_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "token" field.</summary>
    public const int TokenFieldNumber = 2;
    private string token_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Token {
      get { return token_; }
      set {
        token_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "lang" field.</summary>
    public const int LangFieldNumber = 3;
    private string lang_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Lang {
      get { return lang_; }
      set {
        lang_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "demo" field.</summary>
    public const int DemoFieldNumber = 4;
    private string demo_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Demo {
      get { return demo_; }
      set {
        demo_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SpeechChunk);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SpeechChunk other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Content != other.Content) return false;
      if (Token != other.Token) return false;
      if (Lang != other.Lang) return false;
      if (Demo != other.Demo) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Content.Length != 0) hash ^= Content.GetHashCode();
      if (Token.Length != 0) hash ^= Token.GetHashCode();
      if (Lang.Length != 0) hash ^= Lang.GetHashCode();
      if (Demo.Length != 0) hash ^= Demo.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Content.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Content);
      }
      if (Token.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Token);
      }
      if (Lang.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Lang);
      }
      if (Demo.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Demo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Content);
      }
      if (Token.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Token);
      }
      if (Lang.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Lang);
      }
      if (Demo.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Demo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SpeechChunk other) {
      if (other == null) {
        return;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
      }
      if (other.Token.Length != 0) {
        Token = other.Token;
      }
      if (other.Lang.Length != 0) {
        Lang = other.Lang;
      }
      if (other.Demo.Length != 0) {
        Demo = other.Demo;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Content = input.ReadBytes();
            break;
          }
          case 18: {
            Token = input.ReadString();
            break;
          }
          case 26: {
            Lang = input.ReadString();
            break;
          }
          case 34: {
            Demo = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// response
  /// </summary>
  public sealed partial class TranscriptChunk : pb::IMessage<TranscriptChunk> {
    private static readonly pb::MessageParser<TranscriptChunk> _parser = new pb::MessageParser<TranscriptChunk>(() => new TranscriptChunk());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TranscriptChunk> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SpeechToText.SttReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TranscriptChunk() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TranscriptChunk(TranscriptChunk other) : this() {
      asr_ = other.asr_;
      transcript_ = other.transcript_;
      isFinal_ = other.isFinal_;
      confidence_ = other.confidence_;
      answer_ = other.answer_;
      imageUrl_ = other.imageUrl_;
      imageYesNo_ = other.imageYesNo_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TranscriptChunk Clone() {
      return new TranscriptChunk(this);
    }

    /// <summary>Field number for the "asr" field.</summary>
    public const int AsrFieldNumber = 1;
    private string asr_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Asr {
      get { return asr_; }
      set {
        asr_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "transcript" field.</summary>
    public const int TranscriptFieldNumber = 2;
    private string transcript_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Transcript {
      get { return transcript_; }
      set {
        transcript_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "is_final" field.</summary>
    public const int IsFinalFieldNumber = 3;
    private bool isFinal_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsFinal {
      get { return isFinal_; }
      set {
        isFinal_ = value;
      }
    }

    /// <summary>Field number for the "confidence" field.</summary>
    public const int ConfidenceFieldNumber = 4;
    private float confidence_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Confidence {
      get { return confidence_; }
      set {
        confidence_ = value;
      }
    }

    /// <summary>Field number for the "answer" field.</summary>
    public const int AnswerFieldNumber = 5;
    private string answer_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Answer {
      get { return answer_; }
      set {
        answer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "image_url" field.</summary>
    public const int ImageUrlFieldNumber = 6;
    private string imageUrl_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ImageUrl {
      get { return imageUrl_; }
      set {
        imageUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "image_yes_no" field.</summary>
    public const int ImageYesNoFieldNumber = 7;
    private string imageYesNo_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ImageYesNo {
      get { return imageYesNo_; }
      set {
        imageYesNo_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TranscriptChunk);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TranscriptChunk other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Asr != other.Asr) return false;
      if (Transcript != other.Transcript) return false;
      if (IsFinal != other.IsFinal) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Confidence, other.Confidence)) return false;
      if (Answer != other.Answer) return false;
      if (ImageUrl != other.ImageUrl) return false;
      if (ImageYesNo != other.ImageYesNo) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Asr.Length != 0) hash ^= Asr.GetHashCode();
      if (Transcript.Length != 0) hash ^= Transcript.GetHashCode();
      if (IsFinal != false) hash ^= IsFinal.GetHashCode();
      if (Confidence != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Confidence);
      if (Answer.Length != 0) hash ^= Answer.GetHashCode();
      if (ImageUrl.Length != 0) hash ^= ImageUrl.GetHashCode();
      if (ImageYesNo.Length != 0) hash ^= ImageYesNo.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Asr.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Asr);
      }
      if (Transcript.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Transcript);
      }
      if (IsFinal != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsFinal);
      }
      if (Confidence != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(Confidence);
      }
      if (Answer.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Answer);
      }
      if (ImageUrl.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(ImageUrl);
      }
      if (ImageYesNo.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ImageYesNo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Asr.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Asr);
      }
      if (Transcript.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Transcript);
      }
      if (IsFinal != false) {
        size += 1 + 1;
      }
      if (Confidence != 0F) {
        size += 1 + 4;
      }
      if (Answer.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Answer);
      }
      if (ImageUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ImageUrl);
      }
      if (ImageYesNo.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ImageYesNo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TranscriptChunk other) {
      if (other == null) {
        return;
      }
      if (other.Asr.Length != 0) {
        Asr = other.Asr;
      }
      if (other.Transcript.Length != 0) {
        Transcript = other.Transcript;
      }
      if (other.IsFinal != false) {
        IsFinal = other.IsFinal;
      }
      if (other.Confidence != 0F) {
        Confidence = other.Confidence;
      }
      if (other.Answer.Length != 0) {
        Answer = other.Answer;
      }
      if (other.ImageUrl.Length != 0) {
        ImageUrl = other.ImageUrl;
      }
      if (other.ImageYesNo.Length != 0) {
        ImageYesNo = other.ImageYesNo;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Asr = input.ReadString();
            break;
          }
          case 18: {
            Transcript = input.ReadString();
            break;
          }
          case 24: {
            IsFinal = input.ReadBool();
            break;
          }
          case 37: {
            Confidence = input.ReadFloat();
            break;
          }
          case 42: {
            Answer = input.ReadString();
            break;
          }
          case 50: {
            ImageUrl = input.ReadString();
            break;
          }
          case 58: {
            ImageYesNo = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
