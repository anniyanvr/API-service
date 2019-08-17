// Generated by the gRPC C++ plugin.
// If you make any local change, they will be lost.
// source: stt.proto

#include "stt.pb.h"
#include "stt.grpc.pb.h"

#include <functional>
#include <grpcpp/impl/codegen/async_stream.h>
#include <grpcpp/impl/codegen/async_unary_call.h>
#include <grpcpp/impl/codegen/channel_interface.h>
#include <grpcpp/impl/codegen/client_unary_call.h>
#include <grpcpp/impl/codegen/client_callback.h>
#include <grpcpp/impl/codegen/method_handler_impl.h>
#include <grpcpp/impl/codegen/rpc_service_method.h>
#include <grpcpp/impl/codegen/server_callback.h>
#include <grpcpp/impl/codegen/service_type.h>
#include <grpcpp/impl/codegen/sync_stream.h>
namespace SpeechToText {

static const char* Listener_method_names[] = {
  "/SpeechToText.Listener/DoConfig",
  "/SpeechToText.Listener/DoSpeechToText",
};

std::unique_ptr< Listener::Stub> Listener::NewStub(const std::shared_ptr< ::grpc::ChannelInterface>& channel, const ::grpc::StubOptions& options) {
  (void)options;
  std::unique_ptr< Listener::Stub> stub(new Listener::Stub(channel));
  return stub;
}

Listener::Stub::Stub(const std::shared_ptr< ::grpc::ChannelInterface>& channel)
  : channel_(channel), rpcmethod_DoConfig_(Listener_method_names[0], ::grpc::internal::RpcMethod::NORMAL_RPC, channel)
  , rpcmethod_DoSpeechToText_(Listener_method_names[1], ::grpc::internal::RpcMethod::BIDI_STREAMING, channel)
  {}

::grpc::Status Listener::Stub::DoConfig(::grpc::ClientContext* context, const ::SpeechToText::ConfigSTT& request, ::SpeechToText::ConfigResult* response) {
  return ::grpc::internal::BlockingUnaryCall(channel_.get(), rpcmethod_DoConfig_, context, request, response);
}

void Listener::Stub::experimental_async::DoConfig(::grpc::ClientContext* context, const ::SpeechToText::ConfigSTT* request, ::SpeechToText::ConfigResult* response, std::function<void(::grpc::Status)> f) {
  return ::grpc::internal::CallbackUnaryCall(stub_->channel_.get(), stub_->rpcmethod_DoConfig_, context, request, response, std::move(f));
}

void Listener::Stub::experimental_async::DoConfig(::grpc::ClientContext* context, const ::grpc::ByteBuffer* request, ::SpeechToText::ConfigResult* response, std::function<void(::grpc::Status)> f) {
  return ::grpc::internal::CallbackUnaryCall(stub_->channel_.get(), stub_->rpcmethod_DoConfig_, context, request, response, std::move(f));
}

::grpc::ClientAsyncResponseReader< ::SpeechToText::ConfigResult>* Listener::Stub::AsyncDoConfigRaw(::grpc::ClientContext* context, const ::SpeechToText::ConfigSTT& request, ::grpc::CompletionQueue* cq) {
  return ::grpc::internal::ClientAsyncResponseReaderFactory< ::SpeechToText::ConfigResult>::Create(channel_.get(), cq, rpcmethod_DoConfig_, context, request, true);
}

::grpc::ClientAsyncResponseReader< ::SpeechToText::ConfigResult>* Listener::Stub::PrepareAsyncDoConfigRaw(::grpc::ClientContext* context, const ::SpeechToText::ConfigSTT& request, ::grpc::CompletionQueue* cq) {
  return ::grpc::internal::ClientAsyncResponseReaderFactory< ::SpeechToText::ConfigResult>::Create(channel_.get(), cq, rpcmethod_DoConfig_, context, request, false);
}

::grpc::ClientReaderWriter< ::SpeechToText::SpeechChunk, ::SpeechToText::TranscriptChunk>* Listener::Stub::DoSpeechToTextRaw(::grpc::ClientContext* context) {
  return ::grpc::internal::ClientReaderWriterFactory< ::SpeechToText::SpeechChunk, ::SpeechToText::TranscriptChunk>::Create(channel_.get(), rpcmethod_DoSpeechToText_, context);
}

void Listener::Stub::experimental_async::DoSpeechToText(::grpc::ClientContext* context, ::grpc::experimental::ClientBidiReactor< ::SpeechToText::SpeechChunk,::SpeechToText::TranscriptChunk>* reactor) {
  ::grpc::internal::ClientCallbackReaderWriterFactory< ::SpeechToText::SpeechChunk,::SpeechToText::TranscriptChunk>::Create(stub_->channel_.get(), stub_->rpcmethod_DoSpeechToText_, context, reactor);
}

::grpc::ClientAsyncReaderWriter< ::SpeechToText::SpeechChunk, ::SpeechToText::TranscriptChunk>* Listener::Stub::AsyncDoSpeechToTextRaw(::grpc::ClientContext* context, ::grpc::CompletionQueue* cq, void* tag) {
  return ::grpc::internal::ClientAsyncReaderWriterFactory< ::SpeechToText::SpeechChunk, ::SpeechToText::TranscriptChunk>::Create(channel_.get(), cq, rpcmethod_DoSpeechToText_, context, true, tag);
}

::grpc::ClientAsyncReaderWriter< ::SpeechToText::SpeechChunk, ::SpeechToText::TranscriptChunk>* Listener::Stub::PrepareAsyncDoSpeechToTextRaw(::grpc::ClientContext* context, ::grpc::CompletionQueue* cq) {
  return ::grpc::internal::ClientAsyncReaderWriterFactory< ::SpeechToText::SpeechChunk, ::SpeechToText::TranscriptChunk>::Create(channel_.get(), cq, rpcmethod_DoSpeechToText_, context, false, nullptr);
}

Listener::Service::Service() {
  AddMethod(new ::grpc::internal::RpcServiceMethod(
      Listener_method_names[0],
      ::grpc::internal::RpcMethod::NORMAL_RPC,
      new ::grpc::internal::RpcMethodHandler< Listener::Service, ::SpeechToText::ConfigSTT, ::SpeechToText::ConfigResult>(
          std::mem_fn(&Listener::Service::DoConfig), this)));
  AddMethod(new ::grpc::internal::RpcServiceMethod(
      Listener_method_names[1],
      ::grpc::internal::RpcMethod::BIDI_STREAMING,
      new ::grpc::internal::BidiStreamingHandler< Listener::Service, ::SpeechToText::SpeechChunk, ::SpeechToText::TranscriptChunk>(
          std::mem_fn(&Listener::Service::DoSpeechToText), this)));
}

Listener::Service::~Service() {
}

::grpc::Status Listener::Service::DoConfig(::grpc::ServerContext* context, const ::SpeechToText::ConfigSTT* request, ::SpeechToText::ConfigResult* response) {
  (void) context;
  (void) request;
  (void) response;
  return ::grpc::Status(::grpc::StatusCode::UNIMPLEMENTED, "");
}

::grpc::Status Listener::Service::DoSpeechToText(::grpc::ServerContext* context, ::grpc::ServerReaderWriter< ::SpeechToText::TranscriptChunk, ::SpeechToText::SpeechChunk>* stream) {
  (void) context;
  (void) stream;
  return ::grpc::Status(::grpc::StatusCode::UNIMPLEMENTED, "");
}


}  // namespace SpeechToText
