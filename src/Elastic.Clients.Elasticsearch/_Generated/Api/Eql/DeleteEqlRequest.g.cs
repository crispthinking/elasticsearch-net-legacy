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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Eql
{
	public class DeleteEqlRequestParameters : RequestParameters<DeleteEqlRequestParameters>
	{
	}

	public partial class DeleteEqlRequest : PlainRequestBase<DeleteEqlRequestParameters>
	{
		public DeleteEqlRequest(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.EqlDelete;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
	}

	public sealed partial class DeleteEqlRequestDescriptor<TDocument> : RequestDescriptorBase<DeleteEqlRequestDescriptor<TDocument>, DeleteEqlRequestParameters>
	{
		internal DeleteEqlRequestDescriptor(Action<DeleteEqlRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		public DeleteEqlRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
		{
		}

		internal DeleteEqlRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.EqlDelete;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		public DeleteEqlRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
		{
			RouteValues.Required("id", id);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}

	public sealed partial class DeleteEqlRequestDescriptor : RequestDescriptorBase<DeleteEqlRequestDescriptor, DeleteEqlRequestParameters>
	{
		internal DeleteEqlRequestDescriptor(Action<DeleteEqlRequestDescriptor> configure) => configure.Invoke(this);
		public DeleteEqlRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
		{
		}

		internal DeleteEqlRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.EqlDelete;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		public DeleteEqlRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
		{
			RouteValues.Required("id", id);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}