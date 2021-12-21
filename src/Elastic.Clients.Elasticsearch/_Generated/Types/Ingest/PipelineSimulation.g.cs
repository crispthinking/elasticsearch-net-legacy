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
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ingest.Simulate
{
	public partial class PipelineSimulation
	{
		[JsonInclude]
		[JsonPropertyName("doc")]
		public Elastic.Clients.Elasticsearch.Ingest.Simulate.DocumentSimulation? Doc { get; init; }

		[JsonInclude]
		[JsonPropertyName("processor_results")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Ingest.Simulate.PipelineSimulation>? ProcessorResults { get; init; }

		[JsonInclude]
		[JsonPropertyName("tag")]
		public string? Tag { get; init; }

		[JsonInclude]
		[JsonPropertyName("processor_type")]
		public string? ProcessorType { get; init; }

		[JsonInclude]
		[JsonPropertyName("status")]
		public Elastic.Clients.Elasticsearch.Watcher.ActionStatusOptions? Status { get; init; }
	}
}