// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: stt.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace SpeechToText {
  /// <summary>
  /// The Listener service definition.
  /// </summary>
  public static partial class Listener
  {
    static readonly string __ServiceName = "SpeechToText.Listener";

    static readonly grpc::Marshaller<global::SpeechToText.SpeechChunk> __Marshaller_SpeechToText_SpeechChunk = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SpeechToText.SpeechChunk.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::SpeechToText.TranscriptChunk> __Marshaller_SpeechToText_TranscriptChunk = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::SpeechToText.TranscriptChunk.Parser.ParseFrom);

    static readonly grpc::Method<global::SpeechToText.SpeechChunk, global::SpeechToText.TranscriptChunk> __Method_DoSpeechToText = new grpc::Method<global::SpeechToText.SpeechChunk, global::SpeechToText.TranscriptChunk>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "DoSpeechToText",
        __Marshaller_SpeechToText_SpeechChunk,
        __Marshaller_SpeechToText_TranscriptChunk);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::SpeechToText.SttReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Listener</summary>
    [grpc::BindServiceMethod(typeof(Listener), "BindService")]
    public abstract partial class ListenerBase
    {
      public virtual global::System.Threading.Tasks.Task DoSpeechToText(grpc::IAsyncStreamReader<global::SpeechToText.SpeechChunk> requestStream, grpc::IServerStreamWriter<global::SpeechToText.TranscriptChunk> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Listener</summary>
    public partial class ListenerClient : grpc::ClientBase<ListenerClient>
    {
      /// <summary>Creates a new client for Listener</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ListenerClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Listener that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ListenerClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ListenerClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ListenerClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncDuplexStreamingCall<global::SpeechToText.SpeechChunk, global::SpeechToText.TranscriptChunk> DoSpeechToText(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DoSpeechToText(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::SpeechToText.SpeechChunk, global::SpeechToText.TranscriptChunk> DoSpeechToText(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_DoSpeechToText, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ListenerClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ListenerClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ListenerBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_DoSpeechToText, serviceImpl.DoSpeechToText).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ListenerBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_DoSpeechToText, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::SpeechToText.SpeechChunk, global::SpeechToText.TranscriptChunk>(serviceImpl.DoSpeechToText));
    }

  }
}
#endregion
