// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/monitoring/v3/group_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2016 Google Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.Monitoring.V3 {
  /// <summary>
  /// The Group API lets you inspect and manage your
  /// [groups](google.monitoring.v3.Group).
  ///
  /// A group is a named filter that is used to identify
  /// a collection of monitored resources. Groups are typically used to
  /// mirror the physical and/or logical topology of the environment.
  /// Because group membership is computed dynamically, monitored
  /// resources that are started in the future are automatically placed
  /// in matching groups. By using a group to name monitored resources in,
  /// for example, an alert policy, the target of that alert policy is
  /// updated automatically as monitored resources are added and removed
  /// from the infrastructure.
  /// </summary>
  public static partial class GroupService
  {
    static readonly string __ServiceName = "google.monitoring.v3.GroupService";

    static readonly grpc::Marshaller<global::Google.Cloud.Monitoring.V3.ListGroupsRequest> __Marshaller_ListGroupsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Monitoring.V3.ListGroupsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Monitoring.V3.ListGroupsResponse> __Marshaller_ListGroupsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Monitoring.V3.ListGroupsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Monitoring.V3.GetGroupRequest> __Marshaller_GetGroupRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Monitoring.V3.GetGroupRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Monitoring.V3.Group> __Marshaller_Group = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Monitoring.V3.Group.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Monitoring.V3.CreateGroupRequest> __Marshaller_CreateGroupRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Monitoring.V3.CreateGroupRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Monitoring.V3.UpdateGroupRequest> __Marshaller_UpdateGroupRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Monitoring.V3.UpdateGroupRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Monitoring.V3.DeleteGroupRequest> __Marshaller_DeleteGroupRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Monitoring.V3.DeleteGroupRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Monitoring.V3.ListGroupMembersRequest> __Marshaller_ListGroupMembersRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Monitoring.V3.ListGroupMembersRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Monitoring.V3.ListGroupMembersResponse> __Marshaller_ListGroupMembersResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Monitoring.V3.ListGroupMembersResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.Monitoring.V3.ListGroupsRequest, global::Google.Cloud.Monitoring.V3.ListGroupsResponse> __Method_ListGroups = new grpc::Method<global::Google.Cloud.Monitoring.V3.ListGroupsRequest, global::Google.Cloud.Monitoring.V3.ListGroupsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListGroups",
        __Marshaller_ListGroupsRequest,
        __Marshaller_ListGroupsResponse);

    static readonly grpc::Method<global::Google.Cloud.Monitoring.V3.GetGroupRequest, global::Google.Cloud.Monitoring.V3.Group> __Method_GetGroup = new grpc::Method<global::Google.Cloud.Monitoring.V3.GetGroupRequest, global::Google.Cloud.Monitoring.V3.Group>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetGroup",
        __Marshaller_GetGroupRequest,
        __Marshaller_Group);

    static readonly grpc::Method<global::Google.Cloud.Monitoring.V3.CreateGroupRequest, global::Google.Cloud.Monitoring.V3.Group> __Method_CreateGroup = new grpc::Method<global::Google.Cloud.Monitoring.V3.CreateGroupRequest, global::Google.Cloud.Monitoring.V3.Group>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateGroup",
        __Marshaller_CreateGroupRequest,
        __Marshaller_Group);

    static readonly grpc::Method<global::Google.Cloud.Monitoring.V3.UpdateGroupRequest, global::Google.Cloud.Monitoring.V3.Group> __Method_UpdateGroup = new grpc::Method<global::Google.Cloud.Monitoring.V3.UpdateGroupRequest, global::Google.Cloud.Monitoring.V3.Group>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateGroup",
        __Marshaller_UpdateGroupRequest,
        __Marshaller_Group);

    static readonly grpc::Method<global::Google.Cloud.Monitoring.V3.DeleteGroupRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteGroup = new grpc::Method<global::Google.Cloud.Monitoring.V3.DeleteGroupRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteGroup",
        __Marshaller_DeleteGroupRequest,
        __Marshaller_Empty);

    static readonly grpc::Method<global::Google.Cloud.Monitoring.V3.ListGroupMembersRequest, global::Google.Cloud.Monitoring.V3.ListGroupMembersResponse> __Method_ListGroupMembers = new grpc::Method<global::Google.Cloud.Monitoring.V3.ListGroupMembersRequest, global::Google.Cloud.Monitoring.V3.ListGroupMembersResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListGroupMembers",
        __Marshaller_ListGroupMembersRequest,
        __Marshaller_ListGroupMembersResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Monitoring.V3.GroupServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GroupService</summary>
    public abstract partial class GroupServiceBase
    {
      /// <summary>
      /// Lists the existing groups.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Monitoring.V3.ListGroupsResponse> ListGroups(global::Google.Cloud.Monitoring.V3.ListGroupsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Gets a single group.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Monitoring.V3.Group> GetGroup(global::Google.Cloud.Monitoring.V3.GetGroupRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates a new group.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Monitoring.V3.Group> CreateGroup(global::Google.Cloud.Monitoring.V3.CreateGroupRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates an existing group.
      /// You can change any group attributes except `name`.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Monitoring.V3.Group> UpdateGroup(global::Google.Cloud.Monitoring.V3.UpdateGroupRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes an existing group.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteGroup(global::Google.Cloud.Monitoring.V3.DeleteGroupRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Lists the monitored resources that are members of a group.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Monitoring.V3.ListGroupMembersResponse> ListGroupMembers(global::Google.Cloud.Monitoring.V3.ListGroupMembersRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for GroupService</summary>
    public partial class GroupServiceClient : grpc::ClientBase<GroupServiceClient>
    {
      /// <summary>Creates a new client for GroupService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GroupServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GroupService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GroupServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GroupServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GroupServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Lists the existing groups.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Monitoring.V3.ListGroupsResponse ListGroups(global::Google.Cloud.Monitoring.V3.ListGroupsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListGroups(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists the existing groups.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Monitoring.V3.ListGroupsResponse ListGroups(global::Google.Cloud.Monitoring.V3.ListGroupsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListGroups, null, options, request);
      }
      /// <summary>
      /// Lists the existing groups.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Monitoring.V3.ListGroupsResponse> ListGroupsAsync(global::Google.Cloud.Monitoring.V3.ListGroupsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListGroupsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists the existing groups.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Monitoring.V3.ListGroupsResponse> ListGroupsAsync(global::Google.Cloud.Monitoring.V3.ListGroupsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListGroups, null, options, request);
      }
      /// <summary>
      /// Gets a single group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Monitoring.V3.Group GetGroup(global::Google.Cloud.Monitoring.V3.GetGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetGroup(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets a single group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Monitoring.V3.Group GetGroup(global::Google.Cloud.Monitoring.V3.GetGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetGroup, null, options, request);
      }
      /// <summary>
      /// Gets a single group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Monitoring.V3.Group> GetGroupAsync(global::Google.Cloud.Monitoring.V3.GetGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetGroupAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets a single group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Monitoring.V3.Group> GetGroupAsync(global::Google.Cloud.Monitoring.V3.GetGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetGroup, null, options, request);
      }
      /// <summary>
      /// Creates a new group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Monitoring.V3.Group CreateGroup(global::Google.Cloud.Monitoring.V3.CreateGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateGroup(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a new group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Monitoring.V3.Group CreateGroup(global::Google.Cloud.Monitoring.V3.CreateGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateGroup, null, options, request);
      }
      /// <summary>
      /// Creates a new group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Monitoring.V3.Group> CreateGroupAsync(global::Google.Cloud.Monitoring.V3.CreateGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateGroupAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a new group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Monitoring.V3.Group> CreateGroupAsync(global::Google.Cloud.Monitoring.V3.CreateGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateGroup, null, options, request);
      }
      /// <summary>
      /// Updates an existing group.
      /// You can change any group attributes except `name`.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Monitoring.V3.Group UpdateGroup(global::Google.Cloud.Monitoring.V3.UpdateGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateGroup(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates an existing group.
      /// You can change any group attributes except `name`.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Monitoring.V3.Group UpdateGroup(global::Google.Cloud.Monitoring.V3.UpdateGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateGroup, null, options, request);
      }
      /// <summary>
      /// Updates an existing group.
      /// You can change any group attributes except `name`.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Monitoring.V3.Group> UpdateGroupAsync(global::Google.Cloud.Monitoring.V3.UpdateGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateGroupAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates an existing group.
      /// You can change any group attributes except `name`.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Monitoring.V3.Group> UpdateGroupAsync(global::Google.Cloud.Monitoring.V3.UpdateGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateGroup, null, options, request);
      }
      /// <summary>
      /// Deletes an existing group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteGroup(global::Google.Cloud.Monitoring.V3.DeleteGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteGroup(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes an existing group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteGroup(global::Google.Cloud.Monitoring.V3.DeleteGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteGroup, null, options, request);
      }
      /// <summary>
      /// Deletes an existing group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteGroupAsync(global::Google.Cloud.Monitoring.V3.DeleteGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteGroupAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes an existing group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteGroupAsync(global::Google.Cloud.Monitoring.V3.DeleteGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteGroup, null, options, request);
      }
      /// <summary>
      /// Lists the monitored resources that are members of a group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Monitoring.V3.ListGroupMembersResponse ListGroupMembers(global::Google.Cloud.Monitoring.V3.ListGroupMembersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListGroupMembers(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists the monitored resources that are members of a group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Monitoring.V3.ListGroupMembersResponse ListGroupMembers(global::Google.Cloud.Monitoring.V3.ListGroupMembersRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListGroupMembers, null, options, request);
      }
      /// <summary>
      /// Lists the monitored resources that are members of a group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Monitoring.V3.ListGroupMembersResponse> ListGroupMembersAsync(global::Google.Cloud.Monitoring.V3.ListGroupMembersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListGroupMembersAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists the monitored resources that are members of a group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Monitoring.V3.ListGroupMembersResponse> ListGroupMembersAsync(global::Google.Cloud.Monitoring.V3.ListGroupMembersRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListGroupMembers, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GroupServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GroupServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GroupServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListGroups, serviceImpl.ListGroups)
          .AddMethod(__Method_GetGroup, serviceImpl.GetGroup)
          .AddMethod(__Method_CreateGroup, serviceImpl.CreateGroup)
          .AddMethod(__Method_UpdateGroup, serviceImpl.UpdateGroup)
          .AddMethod(__Method_DeleteGroup, serviceImpl.DeleteGroup)
          .AddMethod(__Method_ListGroupMembers, serviceImpl.ListGroupMembers).Build();
    }

  }
}
#endregion
