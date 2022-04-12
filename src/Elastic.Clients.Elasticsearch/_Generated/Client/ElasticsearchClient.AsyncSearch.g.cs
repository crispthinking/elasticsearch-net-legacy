// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using System;
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Elastic.Clients.Elasticsearch.AsyncSearch
{
	public class AsyncSearchNamespace : NamespacedClientProxy
	{
		internal AsyncSearchNamespace(ElasticsearchClient client) : base(client)
		{
		}

		public AsyncSearchStatusResponse Status(AsyncSearchStatusRequest request)
		{
			request.BeforeRequest();
			return DoRequest<AsyncSearchStatusRequest, AsyncSearchStatusResponse>(request);
		}

		public Task<AsyncSearchStatusResponse> StatusAsync(AsyncSearchStatusRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<AsyncSearchStatusRequest, AsyncSearchStatusResponse>(request, cancellationToken);
		}

		public AsyncSearchStatusResponse Status(Elastic.Clients.Elasticsearch.Id id, Action<AsyncSearchStatusRequestDescriptor> configureRequest = null)
		{
			var descriptor = new AsyncSearchStatusRequestDescriptor(id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<AsyncSearchStatusRequestDescriptor, AsyncSearchStatusResponse>(descriptor);
		}

		public Task<AsyncSearchStatusResponse> StatusAsync(Elastic.Clients.Elasticsearch.Id id, Action<AsyncSearchStatusRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new AsyncSearchStatusRequestDescriptor(id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<AsyncSearchStatusRequestDescriptor, AsyncSearchStatusResponse>(descriptor);
		}

		public AsyncSearchSubmitResponse<TDocument> Submit<TDocument>(AsyncSearchSubmitRequest request)
		{
			request.BeforeRequest();
			return DoRequest<AsyncSearchSubmitRequest, AsyncSearchSubmitResponse<TDocument>>(request);
		}

		public Task<AsyncSearchSubmitResponse<TDocument>> SubmitAsync<TDocument>(AsyncSearchSubmitRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<AsyncSearchSubmitRequest, AsyncSearchSubmitResponse<TDocument>>(request, cancellationToken);
		}

		public AsyncSearchSubmitResponse<TDocument> Submit<TDocument>(Action<AsyncSearchSubmitRequestDescriptor<TDocument>> configureRequest = null)
		{
			var descriptor = new AsyncSearchSubmitRequestDescriptor<TDocument>();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<AsyncSearchSubmitRequestDescriptor<TDocument>, AsyncSearchSubmitResponse<TDocument>>(descriptor);
		}

		public Task<AsyncSearchSubmitResponse<TDocument>> SubmitAsync<TDocument>(Action<AsyncSearchSubmitRequestDescriptor<TDocument>> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new AsyncSearchSubmitRequestDescriptor<TDocument>();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<AsyncSearchSubmitRequestDescriptor<TDocument>, AsyncSearchSubmitResponse<TDocument>>(descriptor);
		}

		public DeleteAsyncSearchResponse Delete(DeleteAsyncSearchRequest request)
		{
			request.BeforeRequest();
			return DoRequest<DeleteAsyncSearchRequest, DeleteAsyncSearchResponse>(request);
		}

		public Task<DeleteAsyncSearchResponse> DeleteAsync(DeleteAsyncSearchRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<DeleteAsyncSearchRequest, DeleteAsyncSearchResponse>(request, cancellationToken);
		}

		public DeleteAsyncSearchResponse Delete(Elastic.Clients.Elasticsearch.Id id, Action<DeleteAsyncSearchRequestDescriptor> configureRequest = null)
		{
			var descriptor = new DeleteAsyncSearchRequestDescriptor(id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<DeleteAsyncSearchRequestDescriptor, DeleteAsyncSearchResponse>(descriptor);
		}

		public Task<DeleteAsyncSearchResponse> DeleteAsync(Elastic.Clients.Elasticsearch.Id id, Action<DeleteAsyncSearchRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new DeleteAsyncSearchRequestDescriptor(id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<DeleteAsyncSearchRequestDescriptor, DeleteAsyncSearchResponse>(descriptor);
		}

		public GetAsyncSearchResponse<TDocument> Get<TDocument>(GetAsyncSearchRequest request)
		{
			request.BeforeRequest();
			return DoRequest<GetAsyncSearchRequest, GetAsyncSearchResponse<TDocument>>(request);
		}

		public Task<GetAsyncSearchResponse<TDocument>> GetAsync<TDocument>(GetAsyncSearchRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<GetAsyncSearchRequest, GetAsyncSearchResponse<TDocument>>(request, cancellationToken);
		}

		public GetAsyncSearchResponse<TDocument> Get<TDocument>(Elastic.Clients.Elasticsearch.Id id, Action<GetAsyncSearchRequestDescriptor<TDocument>> configureRequest = null)
		{
			var descriptor = new GetAsyncSearchRequestDescriptor<TDocument>(id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<GetAsyncSearchRequestDescriptor<TDocument>, GetAsyncSearchResponse<TDocument>>(descriptor);
		}

		public Task<GetAsyncSearchResponse<TDocument>> GetAsync<TDocument>(Elastic.Clients.Elasticsearch.Id id, Action<GetAsyncSearchRequestDescriptor<TDocument>> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new GetAsyncSearchRequestDescriptor<TDocument>(id);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<GetAsyncSearchRequestDescriptor<TDocument>, GetAsyncSearchResponse<TDocument>>(descriptor);
		}
	}
}