// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: v2ray.com/core/transport/internet/headers/wechat/config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace V2Ray.Core.Transport.Internet.Headers.Wechat {

  /// <summary>Holder for reflection information generated from v2ray.com/core/transport/internet/headers/wechat/config.proto</summary>
  public static partial class ConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for v2ray.com/core/transport/internet/headers/wechat/config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj12MnJheS5jb20vY29yZS90cmFuc3BvcnQvaW50ZXJuZXQvaGVhZGVycy93",
            "ZWNoYXQvY29uZmlnLnByb3RvEix2MnJheS5jb3JlLnRyYW5zcG9ydC5pbnRl",
            "cm5ldC5oZWFkZXJzLndlY2hhdCINCgtWaWRlb0NvbmZpZ0JrCjBjb20udjJy",
            "YXkuY29yZS50cmFuc3BvcnQuaW50ZXJuZXQuaGVhZGVycy53ZWNoYXRQAVoG",
            "d2VjaGF0qgIsVjJSYXkuQ29yZS5UcmFuc3BvcnQuSW50ZXJuZXQuSGVhZGVy",
            "cy5XZWNoYXRiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::V2Ray.Core.Transport.Internet.Headers.Wechat.VideoConfig), global::V2Ray.Core.Transport.Internet.Headers.Wechat.VideoConfig.Parser, null, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class VideoConfig : pb::IMessage<VideoConfig> {
    private static readonly pb::MessageParser<VideoConfig> _parser = new pb::MessageParser<VideoConfig>(() => new VideoConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VideoConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::V2Ray.Core.Transport.Internet.Headers.Wechat.ConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VideoConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VideoConfig(VideoConfig other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VideoConfig Clone() {
      return new VideoConfig(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VideoConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VideoConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(VideoConfig other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
