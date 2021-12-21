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
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public class IndexRecoveryRequestParameters : RequestParameters<IndexRecoveryRequestParameters>
	{
		[JsonIgnore]
		public bool? ActiveOnly { get => Q<bool?>("active_only"); set => Q("active_only", value); }

		[JsonIgnore]
		public bool? Detailed { get => Q<bool?>("detailed"); set => Q("detailed", value); }
	}

	public partial class IndexRecoveryRequest : PlainRequestBase<IndexRecoveryRequestParameters>
	{
		public IndexRecoveryRequest()
		{
		}

		public IndexRecoveryRequest(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementRecovery;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? ActiveOnly { get => Q<bool?>("active_only"); set => Q("active_only", value); }

		[JsonIgnore]
		public bool? Detailed { get => Q<bool?>("detailed"); set => Q("detailed", value); }
	}

	public sealed partial class IndexRecoveryRequestDescriptor : RequestDescriptorBase<IndexRecoveryRequestDescriptor, IndexRecoveryRequestParameters>
	{
		public IndexRecoveryRequestDescriptor()
		{
		}

		public IndexRecoveryRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
		{
		}

		internal IndexRecoveryRequestDescriptor(Action<IndexRecoveryRequestDescriptor> configure) => configure.Invoke(this);
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementRecovery;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public IndexRecoveryRequestDescriptor ActiveOnly(bool? activeOnly) => Qs("active_only", activeOnly);
		public IndexRecoveryRequestDescriptor Detailed(bool? detailed) => Qs("detailed", detailed);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WriteEndObject();
		}
	}
}