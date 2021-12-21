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
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	internal sealed class MatchBoolPrefixQueryConverter : FieldNameQueryConverterBase<MatchBoolPrefixQuery>
	{
		internal override MatchBoolPrefixQuery ReadInternal(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			var variant = new MatchBoolPrefixQuery();
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					var property = reader.GetString();
					if (property == "analyzer")
					{
						variant.Analyzer = JsonSerializer.Deserialize<string?>(ref reader, options);
						continue;
					}

					if (property == "fuzziness")
					{
						variant.Fuzziness = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Fuzziness?>(ref reader, options);
						continue;
					}

					if (property == "fuzzy_rewrite")
					{
						variant.FuzzyRewrite = JsonSerializer.Deserialize<string?>(ref reader, options);
						continue;
					}

					if (property == "fuzzy_transpositions")
					{
						variant.FuzzyTranspositions = JsonSerializer.Deserialize<bool?>(ref reader, options);
						continue;
					}

					if (property == "max_expansions")
					{
						variant.MaxExpansions = JsonSerializer.Deserialize<int?>(ref reader, options);
						continue;
					}

					if (property == "minimum_should_match")
					{
						variant.MinimumShouldMatch = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.MinimumShouldMatch?>(ref reader, options);
						continue;
					}

					if (property == "operator")
					{
						variant.Operator = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.Operator?>(ref reader, options);
						continue;
					}

					if (property == "prefix_length")
					{
						variant.PrefixLength = JsonSerializer.Deserialize<int?>(ref reader, options);
						continue;
					}

					if (property == "query")
					{
						variant.Query = JsonSerializer.Deserialize<string>(ref reader, options);
						continue;
					}

					if (property == "boost")
					{
						variant.Boost = JsonSerializer.Deserialize<float?>(ref reader, options);
						continue;
					}

					if (property == "_name")
					{
						variant.QueryName = JsonSerializer.Deserialize<string?>(ref reader, options);
						continue;
					}
				}
			}

			reader.Read();
			return variant;
		}

		internal override void WriteInternal(Utf8JsonWriter writer, MatchBoolPrefixQuery value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(value.Analyzer))
			{
				writer.WritePropertyName("analyzer");
				writer.WriteStringValue(value.Analyzer);
			}

			if (value.Fuzziness is not null)
			{
				writer.WritePropertyName("fuzziness");
				JsonSerializer.Serialize(writer, value.Fuzziness, options);
			}

			if (value.FuzzyRewrite is not null)
			{
				writer.WritePropertyName("fuzzy_rewrite");
				JsonSerializer.Serialize(writer, value.FuzzyRewrite, options);
			}

			if (value.FuzzyTranspositions.HasValue)
			{
				writer.WritePropertyName("fuzzy_transpositions");
				writer.WriteBooleanValue(value.FuzzyTranspositions.Value);
			}

			if (value.MaxExpansions.HasValue)
			{
				writer.WritePropertyName("max_expansions");
				writer.WriteNumberValue(value.MaxExpansions.Value);
			}

			if (value.MinimumShouldMatch is not null)
			{
				writer.WritePropertyName("minimum_should_match");
				JsonSerializer.Serialize(writer, value.MinimumShouldMatch, options);
			}

			if (value.Operator is not null)
			{
				writer.WritePropertyName("operator");
				JsonSerializer.Serialize(writer, value.Operator, options);
			}

			if (value.PrefixLength.HasValue)
			{
				writer.WritePropertyName("prefix_length");
				writer.WriteNumberValue(value.PrefixLength.Value);
			}

			writer.WritePropertyName("query");
			writer.WriteStringValue(value.Query);
			if (value.Boost.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(value.Boost.Value);
			}

			if (!string.IsNullOrEmpty(value.QueryName))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(value.QueryName);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(MatchBoolPrefixQueryConverter))]
	public partial class MatchBoolPrefixQuery : FieldNameQueryBase, IQueryContainerVariant
	{
		[JsonIgnore]
		string QueryDsl.IQueryContainerVariant.QueryContainerVariantName => "match_bool_prefix";
		[JsonInclude]
		[JsonPropertyName("analyzer")]
		public string? Analyzer { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzziness")]
		public Elastic.Clients.Elasticsearch.Fuzziness? Fuzziness { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzzy_rewrite")]
		public string? FuzzyRewrite { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzzy_transpositions")]
		public bool? FuzzyTranspositions { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_expansions")]
		public int? MaxExpansions { get; set; }

		[JsonInclude]
		[JsonPropertyName("minimum_should_match")]
		public Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatch { get; set; }

		[JsonInclude]
		[JsonPropertyName("operator")]
		public Elastic.Clients.Elasticsearch.QueryDsl.Operator? Operator { get; set; }

		[JsonInclude]
		[JsonPropertyName("prefix_length")]
		public int? PrefixLength { get; set; }

		[JsonInclude]
		[JsonPropertyName("query")]
		public string Query { get; set; }
	}

	public sealed partial class MatchBoolPrefixQueryDescriptor<TDocument> : FieldNameQueryDescriptorBase<MatchBoolPrefixQueryDescriptor<TDocument>, TDocument>
	{
		public MatchBoolPrefixQueryDescriptor()
		{
		}

		internal MatchBoolPrefixQueryDescriptor(Action<MatchBoolPrefixQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		internal string? AnalyzerValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Fuzziness? FuzzinessValue { get; private set; }

		internal string? FuzzyRewriteValue { get; private set; }

		internal bool? FuzzyTranspositionsValue { get; private set; }

		internal int? MaxExpansionsValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatchValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.QueryDsl.Operator? OperatorValue { get; private set; }

		internal int? PrefixLengthValue { get; private set; }

		internal string QueryValue { get; private set; }

		internal float? BoostValue { get; private set; }

		internal string? QueryNameValue { get; private set; }

		public MatchBoolPrefixQueryDescriptor<TDocument> Analyzer(string? analyzer) => Assign(analyzer, (a, v) => a.AnalyzerValue = v);
		public MatchBoolPrefixQueryDescriptor<TDocument> Fuzziness(Elastic.Clients.Elasticsearch.Fuzziness? fuzziness) => Assign(fuzziness, (a, v) => a.FuzzinessValue = v);
		public MatchBoolPrefixQueryDescriptor<TDocument> FuzzyRewrite(string? fuzzyRewrite) => Assign(fuzzyRewrite, (a, v) => a.FuzzyRewriteValue = v);
		public MatchBoolPrefixQueryDescriptor<TDocument> FuzzyTranspositions(bool? fuzzyTranspositions = true) => Assign(fuzzyTranspositions, (a, v) => a.FuzzyTranspositionsValue = v);
		public MatchBoolPrefixQueryDescriptor<TDocument> MaxExpansions(int? maxExpansions) => Assign(maxExpansions, (a, v) => a.MaxExpansionsValue = v);
		public MatchBoolPrefixQueryDescriptor<TDocument> MinimumShouldMatch(Elastic.Clients.Elasticsearch.MinimumShouldMatch? minimumShouldMatch) => Assign(minimumShouldMatch, (a, v) => a.MinimumShouldMatchValue = v);
		public MatchBoolPrefixQueryDescriptor<TDocument> Operator(Elastic.Clients.Elasticsearch.QueryDsl.Operator? op) => Assign(op, (a, v) => a.OperatorValue = v);
		public MatchBoolPrefixQueryDescriptor<TDocument> PrefixLength(int? prefixLength) => Assign(prefixLength, (a, v) => a.PrefixLengthValue = v);
		public MatchBoolPrefixQueryDescriptor<TDocument> Query(string query) => Assign(query, (a, v) => a.QueryValue = v);
		public MatchBoolPrefixQueryDescriptor<TDocument> Boost(float? boost) => Assign(boost, (a, v) => a.BoostValue = v);
		public MatchBoolPrefixQueryDescriptor<TDocument> QueryName(string? queryName) => Assign(queryName, (a, v) => a.QueryNameValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WritePropertyName(settings.Inferrer.Field(_field));
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(AnalyzerValue))
			{
				writer.WritePropertyName("analyzer");
				writer.WriteStringValue(AnalyzerValue);
			}

			if (FuzzinessValue is not null)
			{
				writer.WritePropertyName("fuzziness");
				JsonSerializer.Serialize(writer, FuzzinessValue, options);
			}

			if (FuzzyRewriteValue is not null)
			{
				writer.WritePropertyName("fuzzy_rewrite");
				JsonSerializer.Serialize(writer, FuzzyRewriteValue, options);
			}

			if (FuzzyTranspositionsValue.HasValue)
			{
				writer.WritePropertyName("fuzzy_transpositions");
				writer.WriteBooleanValue(FuzzyTranspositionsValue.Value);
			}

			if (MaxExpansionsValue.HasValue)
			{
				writer.WritePropertyName("max_expansions");
				writer.WriteNumberValue(MaxExpansionsValue.Value);
			}

			if (MinimumShouldMatchValue is not null)
			{
				writer.WritePropertyName("minimum_should_match");
				JsonSerializer.Serialize(writer, MinimumShouldMatchValue, options);
			}

			if (OperatorValue is not null)
			{
				writer.WritePropertyName("operator");
				JsonSerializer.Serialize(writer, OperatorValue, options);
			}

			if (PrefixLengthValue.HasValue)
			{
				writer.WritePropertyName("prefix_length");
				writer.WriteNumberValue(PrefixLengthValue.Value);
			}

			writer.WritePropertyName("query");
			writer.WriteStringValue(QueryValue);
			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			writer.WriteEndObject();
		}
	}
}