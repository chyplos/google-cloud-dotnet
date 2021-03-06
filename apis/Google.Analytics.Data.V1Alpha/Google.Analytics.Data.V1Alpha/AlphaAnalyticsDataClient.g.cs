// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Analytics.Data.V1Alpha
{
    /// <summary>Settings for <see cref="AlphaAnalyticsDataClient"/> instances.</summary>
    public sealed partial class AlphaAnalyticsDataSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AlphaAnalyticsDataSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AlphaAnalyticsDataSettings"/>.</returns>
        public static AlphaAnalyticsDataSettings GetDefault() => new AlphaAnalyticsDataSettings();

        /// <summary>Constructs a new <see cref="AlphaAnalyticsDataSettings"/> object with default settings.</summary>
        public AlphaAnalyticsDataSettings()
        {
        }

        private AlphaAnalyticsDataSettings(AlphaAnalyticsDataSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            RunReportSettings = existing.RunReportSettings;
            RunPivotReportSettings = existing.RunPivotReportSettings;
            BatchRunReportsSettings = existing.BatchRunReportsSettings;
            BatchRunPivotReportsSettings = existing.BatchRunPivotReportsSettings;
            GetMetadataSettings = existing.GetMetadataSettings;
            RunRealtimeReportSettings = existing.RunRealtimeReportSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AlphaAnalyticsDataSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlphaAnalyticsDataClient.RunReport</c> and <c>AlphaAnalyticsDataClient.RunReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlphaAnalyticsDataClient.RunPivotReport</c> and <c>AlphaAnalyticsDataClient.RunPivotReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunPivotReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlphaAnalyticsDataClient.BatchRunReports</c> and <c>AlphaAnalyticsDataClient.BatchRunReportsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchRunReportsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlphaAnalyticsDataClient.BatchRunPivotReports</c> and
        /// <c>AlphaAnalyticsDataClient.BatchRunPivotReportsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchRunPivotReportsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlphaAnalyticsDataClient.GetMetadata</c> and <c>AlphaAnalyticsDataClient.GetMetadataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMetadataSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlphaAnalyticsDataClient.RunRealtimeReport</c> and <c>AlphaAnalyticsDataClient.RunRealtimeReportAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunRealtimeReportSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AlphaAnalyticsDataSettings"/> object.</returns>
        public AlphaAnalyticsDataSettings Clone() => new AlphaAnalyticsDataSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AlphaAnalyticsDataClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AlphaAnalyticsDataClientBuilder : gaxgrpc::ClientBuilderBase<AlphaAnalyticsDataClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AlphaAnalyticsDataSettings Settings { get; set; }

        partial void InterceptBuild(ref AlphaAnalyticsDataClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AlphaAnalyticsDataClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AlphaAnalyticsDataClient Build()
        {
            AlphaAnalyticsDataClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AlphaAnalyticsDataClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AlphaAnalyticsDataClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AlphaAnalyticsDataClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AlphaAnalyticsDataClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AlphaAnalyticsDataClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AlphaAnalyticsDataClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AlphaAnalyticsDataClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AlphaAnalyticsDataClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AlphaAnalyticsDataClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AlphaAnalyticsData client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Google Analytics reporting data service.
    /// </remarks>
    public abstract partial class AlphaAnalyticsDataClient
    {
        /// <summary>
        /// The default endpoint for the AlphaAnalyticsData service, which is a host of "analyticsdata.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "analyticsdata.googleapis.com:443";

        /// <summary>The default AlphaAnalyticsData scopes.</summary>
        /// <remarks>
        /// The default AlphaAnalyticsData scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/analytics</description></item>
        /// <item><description>https://www.googleapis.com/auth/analytics.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/analytics",
            "https://www.googleapis.com/auth/analytics.readonly",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AlphaAnalyticsDataClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AlphaAnalyticsDataClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AlphaAnalyticsDataClient"/>.</returns>
        public static stt::Task<AlphaAnalyticsDataClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AlphaAnalyticsDataClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AlphaAnalyticsDataClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AlphaAnalyticsDataClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="AlphaAnalyticsDataClient"/>.</returns>
        public static AlphaAnalyticsDataClient Create() => new AlphaAnalyticsDataClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AlphaAnalyticsDataClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AlphaAnalyticsDataSettings"/>.</param>
        /// <returns>The created <see cref="AlphaAnalyticsDataClient"/>.</returns>
        internal static AlphaAnalyticsDataClient Create(grpccore::CallInvoker callInvoker, AlphaAnalyticsDataSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AlphaAnalyticsData.AlphaAnalyticsDataClient grpcClient = new AlphaAnalyticsData.AlphaAnalyticsDataClient(callInvoker);
            return new AlphaAnalyticsDataClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC AlphaAnalyticsData client</summary>
        public virtual AlphaAnalyticsData.AlphaAnalyticsDataClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a customized report of your Google Analytics event data. Reports
        /// contain statistics derived from data collected by the Google Analytics
        /// tracking code. The data returned from the API is as a table with columns
        /// for the requested dimensions and metrics. Metrics are individual
        /// measurements of user activity on your property, such as active users or
        /// event count. Dimensions break down metrics across some common criteria,
        /// such as country or event name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunReportResponse RunReport(RunReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a customized report of your Google Analytics event data. Reports
        /// contain statistics derived from data collected by the Google Analytics
        /// tracking code. The data returned from the API is as a table with columns
        /// for the requested dimensions and metrics. Metrics are individual
        /// measurements of user activity on your property, such as active users or
        /// event count. Dimensions break down metrics across some common criteria,
        /// such as country or event name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunReportResponse> RunReportAsync(RunReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a customized report of your Google Analytics event data. Reports
        /// contain statistics derived from data collected by the Google Analytics
        /// tracking code. The data returned from the API is as a table with columns
        /// for the requested dimensions and metrics. Metrics are individual
        /// measurements of user activity on your property, such as active users or
        /// event count. Dimensions break down metrics across some common criteria,
        /// such as country or event name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunReportResponse> RunReportAsync(RunReportRequest request, st::CancellationToken cancellationToken) =>
            RunReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a customized pivot report of your Google Analytics event data.
        /// Pivot reports are more advanced and expressive formats than regular
        /// reports. In a pivot report, dimensions are only visible if they are
        /// included in a pivot. Multiple pivots can be specified to further dissect
        /// your data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunPivotReportResponse RunPivotReport(RunPivotReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a customized pivot report of your Google Analytics event data.
        /// Pivot reports are more advanced and expressive formats than regular
        /// reports. In a pivot report, dimensions are only visible if they are
        /// included in a pivot. Multiple pivots can be specified to further dissect
        /// your data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunPivotReportResponse> RunPivotReportAsync(RunPivotReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a customized pivot report of your Google Analytics event data.
        /// Pivot reports are more advanced and expressive formats than regular
        /// reports. In a pivot report, dimensions are only visible if they are
        /// included in a pivot. Multiple pivots can be specified to further dissect
        /// your data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunPivotReportResponse> RunPivotReportAsync(RunPivotReportRequest request, st::CancellationToken cancellationToken) =>
            RunPivotReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns multiple reports in a batch. All reports must be for the same
        /// Entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchRunReportsResponse BatchRunReports(BatchRunReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns multiple reports in a batch. All reports must be for the same
        /// Entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRunReportsResponse> BatchRunReportsAsync(BatchRunReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns multiple reports in a batch. All reports must be for the same
        /// Entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRunReportsResponse> BatchRunReportsAsync(BatchRunReportsRequest request, st::CancellationToken cancellationToken) =>
            BatchRunReportsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns multiple pivot reports in a batch. All reports must be for the same
        /// Entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchRunPivotReportsResponse BatchRunPivotReports(BatchRunPivotReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns multiple pivot reports in a batch. All reports must be for the same
        /// Entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRunPivotReportsResponse> BatchRunPivotReportsAsync(BatchRunPivotReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns multiple pivot reports in a batch. All reports must be for the same
        /// Entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchRunPivotReportsResponse> BatchRunPivotReportsAsync(BatchRunPivotReportsRequest request, st::CancellationToken cancellationToken) =>
            BatchRunPivotReportsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for dimensions and metrics available in reporting methods.
        /// Used to explore the dimensions and metrics. In this method, a Google
        /// Analytics GA4 Property Identifier is specified in the request, and
        /// the metadata response includes Custom dimensions and metrics as well as
        /// Universal metadata.
        /// 
        /// For example if a custom metric with parameter name `levels_unlocked` is
        /// registered to a property, the Metadata response will contain
        /// `customEvent:levels_unlocked`. Universal metadata are dimensions and
        /// metrics applicable to any property such as `country` and `totalUsers`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Metadata GetMetadata(GetMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata for dimensions and metrics available in reporting methods.
        /// Used to explore the dimensions and metrics. In this method, a Google
        /// Analytics GA4 Property Identifier is specified in the request, and
        /// the metadata response includes Custom dimensions and metrics as well as
        /// Universal metadata.
        /// 
        /// For example if a custom metric with parameter name `levels_unlocked` is
        /// registered to a property, the Metadata response will contain
        /// `customEvent:levels_unlocked`. Universal metadata are dimensions and
        /// metrics applicable to any property such as `country` and `totalUsers`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Metadata> GetMetadataAsync(GetMetadataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metadata for dimensions and metrics available in reporting methods.
        /// Used to explore the dimensions and metrics. In this method, a Google
        /// Analytics GA4 Property Identifier is specified in the request, and
        /// the metadata response includes Custom dimensions and metrics as well as
        /// Universal metadata.
        /// 
        /// For example if a custom metric with parameter name `levels_unlocked` is
        /// registered to a property, the Metadata response will contain
        /// `customEvent:levels_unlocked`. Universal metadata are dimensions and
        /// metrics applicable to any property such as `country` and `totalUsers`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Metadata> GetMetadataAsync(GetMetadataRequest request, st::CancellationToken cancellationToken) =>
            GetMetadataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for dimensions and metrics available in reporting methods.
        /// Used to explore the dimensions and metrics. In this method, a Google
        /// Analytics GA4 Property Identifier is specified in the request, and
        /// the metadata response includes Custom dimensions and metrics as well as
        /// Universal metadata.
        /// 
        /// For example if a custom metric with parameter name `levels_unlocked` is
        /// registered to a property, the Metadata response will contain
        /// `customEvent:levels_unlocked`. Universal metadata are dimensions and
        /// metrics applicable to any property such as `country` and `totalUsers`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the metadata to retrieve. This name field is
        /// specified in the URL path and not URL parameters. Property is a numeric
        /// Google Analytics GA4 Property identifier. To learn more, see [where to find
        /// your Property
        /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id).
        /// 
        /// Example: properties/1234/metadata
        /// 
        /// Set the Property ID to 0 for dimensions and metrics common to all
        /// properties. In this special mode, this method will not return custom
        /// dimensions and metrics.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Metadata GetMetadata(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetadata(new GetMetadataRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for dimensions and metrics available in reporting methods.
        /// Used to explore the dimensions and metrics. In this method, a Google
        /// Analytics GA4 Property Identifier is specified in the request, and
        /// the metadata response includes Custom dimensions and metrics as well as
        /// Universal metadata.
        /// 
        /// For example if a custom metric with parameter name `levels_unlocked` is
        /// registered to a property, the Metadata response will contain
        /// `customEvent:levels_unlocked`. Universal metadata are dimensions and
        /// metrics applicable to any property such as `country` and `totalUsers`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the metadata to retrieve. This name field is
        /// specified in the URL path and not URL parameters. Property is a numeric
        /// Google Analytics GA4 Property identifier. To learn more, see [where to find
        /// your Property
        /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id).
        /// 
        /// Example: properties/1234/metadata
        /// 
        /// Set the Property ID to 0 for dimensions and metrics common to all
        /// properties. In this special mode, this method will not return custom
        /// dimensions and metrics.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Metadata> GetMetadataAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetadataAsync(new GetMetadataRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for dimensions and metrics available in reporting methods.
        /// Used to explore the dimensions and metrics. In this method, a Google
        /// Analytics GA4 Property Identifier is specified in the request, and
        /// the metadata response includes Custom dimensions and metrics as well as
        /// Universal metadata.
        /// 
        /// For example if a custom metric with parameter name `levels_unlocked` is
        /// registered to a property, the Metadata response will contain
        /// `customEvent:levels_unlocked`. Universal metadata are dimensions and
        /// metrics applicable to any property such as `country` and `totalUsers`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the metadata to retrieve. This name field is
        /// specified in the URL path and not URL parameters. Property is a numeric
        /// Google Analytics GA4 Property identifier. To learn more, see [where to find
        /// your Property
        /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id).
        /// 
        /// Example: properties/1234/metadata
        /// 
        /// Set the Property ID to 0 for dimensions and metrics common to all
        /// properties. In this special mode, this method will not return custom
        /// dimensions and metrics.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Metadata> GetMetadataAsync(string name, st::CancellationToken cancellationToken) =>
            GetMetadataAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for dimensions and metrics available in reporting methods.
        /// Used to explore the dimensions and metrics. In this method, a Google
        /// Analytics GA4 Property Identifier is specified in the request, and
        /// the metadata response includes Custom dimensions and metrics as well as
        /// Universal metadata.
        /// 
        /// For example if a custom metric with parameter name `levels_unlocked` is
        /// registered to a property, the Metadata response will contain
        /// `customEvent:levels_unlocked`. Universal metadata are dimensions and
        /// metrics applicable to any property such as `country` and `totalUsers`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the metadata to retrieve. This name field is
        /// specified in the URL path and not URL parameters. Property is a numeric
        /// Google Analytics GA4 Property identifier. To learn more, see [where to find
        /// your Property
        /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id).
        /// 
        /// Example: properties/1234/metadata
        /// 
        /// Set the Property ID to 0 for dimensions and metrics common to all
        /// properties. In this special mode, this method will not return custom
        /// dimensions and metrics.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Metadata GetMetadata(MetadataName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetadata(new GetMetadataRequest
            {
                MetadataName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for dimensions and metrics available in reporting methods.
        /// Used to explore the dimensions and metrics. In this method, a Google
        /// Analytics GA4 Property Identifier is specified in the request, and
        /// the metadata response includes Custom dimensions and metrics as well as
        /// Universal metadata.
        /// 
        /// For example if a custom metric with parameter name `levels_unlocked` is
        /// registered to a property, the Metadata response will contain
        /// `customEvent:levels_unlocked`. Universal metadata are dimensions and
        /// metrics applicable to any property such as `country` and `totalUsers`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the metadata to retrieve. This name field is
        /// specified in the URL path and not URL parameters. Property is a numeric
        /// Google Analytics GA4 Property identifier. To learn more, see [where to find
        /// your Property
        /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id).
        /// 
        /// Example: properties/1234/metadata
        /// 
        /// Set the Property ID to 0 for dimensions and metrics common to all
        /// properties. In this special mode, this method will not return custom
        /// dimensions and metrics.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Metadata> GetMetadataAsync(MetadataName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMetadataAsync(new GetMetadataRequest
            {
                MetadataName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns metadata for dimensions and metrics available in reporting methods.
        /// Used to explore the dimensions and metrics. In this method, a Google
        /// Analytics GA4 Property Identifier is specified in the request, and
        /// the metadata response includes Custom dimensions and metrics as well as
        /// Universal metadata.
        /// 
        /// For example if a custom metric with parameter name `levels_unlocked` is
        /// registered to a property, the Metadata response will contain
        /// `customEvent:levels_unlocked`. Universal metadata are dimensions and
        /// metrics applicable to any property such as `country` and `totalUsers`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the metadata to retrieve. This name field is
        /// specified in the URL path and not URL parameters. Property is a numeric
        /// Google Analytics GA4 Property identifier. To learn more, see [where to find
        /// your Property
        /// ID](https://developers.google.com/analytics/devguides/reporting/data/v1/property-id).
        /// 
        /// Example: properties/1234/metadata
        /// 
        /// Set the Property ID to 0 for dimensions and metrics common to all
        /// properties. In this special mode, this method will not return custom
        /// dimensions and metrics.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Metadata> GetMetadataAsync(MetadataName name, st::CancellationToken cancellationToken) =>
            GetMetadataAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// The Google Analytics Realtime API returns a customized report of realtime
        /// event data for your property. These reports show events and usage from the
        /// last 30 minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RunRealtimeReportResponse RunRealtimeReport(RunRealtimeReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// The Google Analytics Realtime API returns a customized report of realtime
        /// event data for your property. These reports show events and usage from the
        /// last 30 minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunRealtimeReportResponse> RunRealtimeReportAsync(RunRealtimeReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// The Google Analytics Realtime API returns a customized report of realtime
        /// event data for your property. These reports show events and usage from the
        /// last 30 minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RunRealtimeReportResponse> RunRealtimeReportAsync(RunRealtimeReportRequest request, st::CancellationToken cancellationToken) =>
            RunRealtimeReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AlphaAnalyticsData client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Google Analytics reporting data service.
    /// </remarks>
    public sealed partial class AlphaAnalyticsDataClientImpl : AlphaAnalyticsDataClient
    {
        private readonly gaxgrpc::ApiCall<RunReportRequest, RunReportResponse> _callRunReport;

        private readonly gaxgrpc::ApiCall<RunPivotReportRequest, RunPivotReportResponse> _callRunPivotReport;

        private readonly gaxgrpc::ApiCall<BatchRunReportsRequest, BatchRunReportsResponse> _callBatchRunReports;

        private readonly gaxgrpc::ApiCall<BatchRunPivotReportsRequest, BatchRunPivotReportsResponse> _callBatchRunPivotReports;

        private readonly gaxgrpc::ApiCall<GetMetadataRequest, Metadata> _callGetMetadata;

        private readonly gaxgrpc::ApiCall<RunRealtimeReportRequest, RunRealtimeReportResponse> _callRunRealtimeReport;

        /// <summary>
        /// Constructs a client wrapper for the AlphaAnalyticsData service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AlphaAnalyticsDataSettings"/> used within this client.</param>
        public AlphaAnalyticsDataClientImpl(AlphaAnalyticsData.AlphaAnalyticsDataClient grpcClient, AlphaAnalyticsDataSettings settings)
        {
            GrpcClient = grpcClient;
            AlphaAnalyticsDataSettings effectiveSettings = settings ?? AlphaAnalyticsDataSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callRunReport = clientHelper.BuildApiCall<RunReportRequest, RunReportResponse>(grpcClient.RunReportAsync, grpcClient.RunReport, effectiveSettings.RunReportSettings);
            Modify_ApiCall(ref _callRunReport);
            Modify_RunReportApiCall(ref _callRunReport);
            _callRunPivotReport = clientHelper.BuildApiCall<RunPivotReportRequest, RunPivotReportResponse>(grpcClient.RunPivotReportAsync, grpcClient.RunPivotReport, effectiveSettings.RunPivotReportSettings);
            Modify_ApiCall(ref _callRunPivotReport);
            Modify_RunPivotReportApiCall(ref _callRunPivotReport);
            _callBatchRunReports = clientHelper.BuildApiCall<BatchRunReportsRequest, BatchRunReportsResponse>(grpcClient.BatchRunReportsAsync, grpcClient.BatchRunReports, effectiveSettings.BatchRunReportsSettings);
            Modify_ApiCall(ref _callBatchRunReports);
            Modify_BatchRunReportsApiCall(ref _callBatchRunReports);
            _callBatchRunPivotReports = clientHelper.BuildApiCall<BatchRunPivotReportsRequest, BatchRunPivotReportsResponse>(grpcClient.BatchRunPivotReportsAsync, grpcClient.BatchRunPivotReports, effectiveSettings.BatchRunPivotReportsSettings);
            Modify_ApiCall(ref _callBatchRunPivotReports);
            Modify_BatchRunPivotReportsApiCall(ref _callBatchRunPivotReports);
            _callGetMetadata = clientHelper.BuildApiCall<GetMetadataRequest, Metadata>(grpcClient.GetMetadataAsync, grpcClient.GetMetadata, effectiveSettings.GetMetadataSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMetadata);
            Modify_GetMetadataApiCall(ref _callGetMetadata);
            _callRunRealtimeReport = clientHelper.BuildApiCall<RunRealtimeReportRequest, RunRealtimeReportResponse>(grpcClient.RunRealtimeReportAsync, grpcClient.RunRealtimeReport, effectiveSettings.RunRealtimeReportSettings).WithGoogleRequestParam("property", request => request.Property);
            Modify_ApiCall(ref _callRunRealtimeReport);
            Modify_RunRealtimeReportApiCall(ref _callRunRealtimeReport);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_RunReportApiCall(ref gaxgrpc::ApiCall<RunReportRequest, RunReportResponse> call);

        partial void Modify_RunPivotReportApiCall(ref gaxgrpc::ApiCall<RunPivotReportRequest, RunPivotReportResponse> call);

        partial void Modify_BatchRunReportsApiCall(ref gaxgrpc::ApiCall<BatchRunReportsRequest, BatchRunReportsResponse> call);

        partial void Modify_BatchRunPivotReportsApiCall(ref gaxgrpc::ApiCall<BatchRunPivotReportsRequest, BatchRunPivotReportsResponse> call);

        partial void Modify_GetMetadataApiCall(ref gaxgrpc::ApiCall<GetMetadataRequest, Metadata> call);

        partial void Modify_RunRealtimeReportApiCall(ref gaxgrpc::ApiCall<RunRealtimeReportRequest, RunRealtimeReportResponse> call);

        partial void OnConstruction(AlphaAnalyticsData.AlphaAnalyticsDataClient grpcClient, AlphaAnalyticsDataSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AlphaAnalyticsData client</summary>
        public override AlphaAnalyticsData.AlphaAnalyticsDataClient GrpcClient { get; }

        partial void Modify_RunReportRequest(ref RunReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunPivotReportRequest(ref RunPivotReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchRunReportsRequest(ref BatchRunReportsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchRunPivotReportsRequest(ref BatchRunPivotReportsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMetadataRequest(ref GetMetadataRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunRealtimeReportRequest(ref RunRealtimeReportRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns a customized report of your Google Analytics event data. Reports
        /// contain statistics derived from data collected by the Google Analytics
        /// tracking code. The data returned from the API is as a table with columns
        /// for the requested dimensions and metrics. Metrics are individual
        /// measurements of user activity on your property, such as active users or
        /// event count. Dimensions break down metrics across some common criteria,
        /// such as country or event name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RunReportResponse RunReport(RunReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunReportRequest(ref request, ref callSettings);
            return _callRunReport.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a customized report of your Google Analytics event data. Reports
        /// contain statistics derived from data collected by the Google Analytics
        /// tracking code. The data returned from the API is as a table with columns
        /// for the requested dimensions and metrics. Metrics are individual
        /// measurements of user activity on your property, such as active users or
        /// event count. Dimensions break down metrics across some common criteria,
        /// such as country or event name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RunReportResponse> RunReportAsync(RunReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunReportRequest(ref request, ref callSettings);
            return _callRunReport.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a customized pivot report of your Google Analytics event data.
        /// Pivot reports are more advanced and expressive formats than regular
        /// reports. In a pivot report, dimensions are only visible if they are
        /// included in a pivot. Multiple pivots can be specified to further dissect
        /// your data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RunPivotReportResponse RunPivotReport(RunPivotReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunPivotReportRequest(ref request, ref callSettings);
            return _callRunPivotReport.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a customized pivot report of your Google Analytics event data.
        /// Pivot reports are more advanced and expressive formats than regular
        /// reports. In a pivot report, dimensions are only visible if they are
        /// included in a pivot. Multiple pivots can be specified to further dissect
        /// your data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RunPivotReportResponse> RunPivotReportAsync(RunPivotReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunPivotReportRequest(ref request, ref callSettings);
            return _callRunPivotReport.Async(request, callSettings);
        }

        /// <summary>
        /// Returns multiple reports in a batch. All reports must be for the same
        /// Entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchRunReportsResponse BatchRunReports(BatchRunReportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRunReportsRequest(ref request, ref callSettings);
            return _callBatchRunReports.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns multiple reports in a batch. All reports must be for the same
        /// Entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchRunReportsResponse> BatchRunReportsAsync(BatchRunReportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRunReportsRequest(ref request, ref callSettings);
            return _callBatchRunReports.Async(request, callSettings);
        }

        /// <summary>
        /// Returns multiple pivot reports in a batch. All reports must be for the same
        /// Entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchRunPivotReportsResponse BatchRunPivotReports(BatchRunPivotReportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRunPivotReportsRequest(ref request, ref callSettings);
            return _callBatchRunPivotReports.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns multiple pivot reports in a batch. All reports must be for the same
        /// Entity.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchRunPivotReportsResponse> BatchRunPivotReportsAsync(BatchRunPivotReportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRunPivotReportsRequest(ref request, ref callSettings);
            return _callBatchRunPivotReports.Async(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for dimensions and metrics available in reporting methods.
        /// Used to explore the dimensions and metrics. In this method, a Google
        /// Analytics GA4 Property Identifier is specified in the request, and
        /// the metadata response includes Custom dimensions and metrics as well as
        /// Universal metadata.
        /// 
        /// For example if a custom metric with parameter name `levels_unlocked` is
        /// registered to a property, the Metadata response will contain
        /// `customEvent:levels_unlocked`. Universal metadata are dimensions and
        /// metrics applicable to any property such as `country` and `totalUsers`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Metadata GetMetadata(GetMetadataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMetadataRequest(ref request, ref callSettings);
            return _callGetMetadata.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for dimensions and metrics available in reporting methods.
        /// Used to explore the dimensions and metrics. In this method, a Google
        /// Analytics GA4 Property Identifier is specified in the request, and
        /// the metadata response includes Custom dimensions and metrics as well as
        /// Universal metadata.
        /// 
        /// For example if a custom metric with parameter name `levels_unlocked` is
        /// registered to a property, the Metadata response will contain
        /// `customEvent:levels_unlocked`. Universal metadata are dimensions and
        /// metrics applicable to any property such as `country` and `totalUsers`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Metadata> GetMetadataAsync(GetMetadataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMetadataRequest(ref request, ref callSettings);
            return _callGetMetadata.Async(request, callSettings);
        }

        /// <summary>
        /// The Google Analytics Realtime API returns a customized report of realtime
        /// event data for your property. These reports show events and usage from the
        /// last 30 minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RunRealtimeReportResponse RunRealtimeReport(RunRealtimeReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunRealtimeReportRequest(ref request, ref callSettings);
            return _callRunRealtimeReport.Sync(request, callSettings);
        }

        /// <summary>
        /// The Google Analytics Realtime API returns a customized report of realtime
        /// event data for your property. These reports show events and usage from the
        /// last 30 minutes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RunRealtimeReportResponse> RunRealtimeReportAsync(RunRealtimeReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunRealtimeReportRequest(ref request, ref callSettings);
            return _callRunRealtimeReport.Async(request, callSettings);
        }
    }
}
