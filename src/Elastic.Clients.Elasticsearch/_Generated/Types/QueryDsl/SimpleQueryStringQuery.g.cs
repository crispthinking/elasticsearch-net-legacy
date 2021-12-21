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
	public partial class SimpleQueryStringQuery : QueryDsl.QueryBase, IQueryContainerVariant
	{
		[JsonIgnore]
		string QueryDsl.IQueryContainerVariant.QueryContainerVariantName => "simple_query_string";
		[JsonInclude]
		[JsonPropertyName("analyzer")]
		public string? Analyzer { get; set; }

		[JsonInclude]
		[JsonPropertyName("analyze_wildcard")]
		public bool? AnalyzeWildcard { get; set; }

		[JsonInclude]
		[JsonPropertyName("auto_generate_synonyms_phrase_query")]
		public bool? AutoGenerateSynonymsPhraseQuery { get; set; }

		[JsonInclude]
		[JsonPropertyName("default_operator")]
		public Elastic.Clients.Elasticsearch.QueryDsl.Operator? DefaultOperator { get; set; }

		[JsonInclude]
		[JsonPropertyName("fields")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Field>? Fields { get; set; }

		[JsonInclude]
		[JsonPropertyName("flags")]
		public string? Flags { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzzy_max_expansions")]
		public int? FuzzyMaxExpansions { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzzy_prefix_length")]
		public int? FuzzyPrefixLength { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzzy_transpositions")]
		public bool? FuzzyTranspositions { get; set; }

		[JsonInclude]
		[JsonPropertyName("lenient")]
		public bool? Lenient { get; set; }

		[JsonInclude]
		[JsonPropertyName("minimum_should_match")]
		public Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatch { get; set; }

		[JsonInclude]
		[JsonPropertyName("query")]
		public string Query { get; set; }

		[JsonInclude]
		[JsonPropertyName("quote_field_suffix")]
		public string? QuoteFieldSuffix { get; set; }
	}

	public sealed partial class SimpleQueryStringQueryDescriptor<TDocument> : DescriptorBase<SimpleQueryStringQueryDescriptor<TDocument>>
	{
		public SimpleQueryStringQueryDescriptor()
		{
		}

		internal SimpleQueryStringQueryDescriptor(Action<SimpleQueryStringQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		internal string? AnalyzerValue { get; private set; }

		internal bool? AnalyzeWildcardValue { get; private set; }

		internal bool? AutoGenerateSynonymsPhraseQueryValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.QueryDsl.Operator? DefaultOperatorValue { get; private set; }

		internal IEnumerable<Elastic.Clients.Elasticsearch.Field>? FieldsValue { get; private set; }

		internal string? FlagsValue { get; private set; }

		internal int? FuzzyMaxExpansionsValue { get; private set; }

		internal int? FuzzyPrefixLengthValue { get; private set; }

		internal bool? FuzzyTranspositionsValue { get; private set; }

		internal bool? LenientValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatchValue { get; private set; }

		internal string QueryValue { get; private set; }

		internal string? QuoteFieldSuffixValue { get; private set; }

		internal float? BoostValue { get; private set; }

		internal string? QueryNameValue { get; private set; }

		public SimpleQueryStringQueryDescriptor<TDocument> Analyzer(string? analyzer) => Assign(analyzer, (a, v) => a.AnalyzerValue = v);
		public SimpleQueryStringQueryDescriptor<TDocument> AnalyzeWildcard(bool? analyzeWildcard = true) => Assign(analyzeWildcard, (a, v) => a.AnalyzeWildcardValue = v);
		public SimpleQueryStringQueryDescriptor<TDocument> AutoGenerateSynonymsPhraseQuery(bool? autoGenerateSynonymsPhraseQuery = true) => Assign(autoGenerateSynonymsPhraseQuery, (a, v) => a.AutoGenerateSynonymsPhraseQueryValue = v);
		public SimpleQueryStringQueryDescriptor<TDocument> DefaultOperator(Elastic.Clients.Elasticsearch.QueryDsl.Operator? defaultOperator) => Assign(defaultOperator, (a, v) => a.DefaultOperatorValue = v);
		public SimpleQueryStringQueryDescriptor<TDocument> Fields(IEnumerable<Elastic.Clients.Elasticsearch.Field>? fields) => Assign(fields, (a, v) => a.FieldsValue = v);
		public SimpleQueryStringQueryDescriptor<TDocument> Flags(string? flags) => Assign(flags, (a, v) => a.FlagsValue = v);
		public SimpleQueryStringQueryDescriptor<TDocument> FuzzyMaxExpansions(int? fuzzyMaxExpansions) => Assign(fuzzyMaxExpansions, (a, v) => a.FuzzyMaxExpansionsValue = v);
		public SimpleQueryStringQueryDescriptor<TDocument> FuzzyPrefixLength(int? fuzzyPrefixLength) => Assign(fuzzyPrefixLength, (a, v) => a.FuzzyPrefixLengthValue = v);
		public SimpleQueryStringQueryDescriptor<TDocument> FuzzyTranspositions(bool? fuzzyTranspositions = true) => Assign(fuzzyTranspositions, (a, v) => a.FuzzyTranspositionsValue = v);
		public SimpleQueryStringQueryDescriptor<TDocument> Lenient(bool? lenient = true) => Assign(lenient, (a, v) => a.LenientValue = v);
		public SimpleQueryStringQueryDescriptor<TDocument> MinimumShouldMatch(Elastic.Clients.Elasticsearch.MinimumShouldMatch? minimumShouldMatch) => Assign(minimumShouldMatch, (a, v) => a.MinimumShouldMatchValue = v);
		public SimpleQueryStringQueryDescriptor<TDocument> Query(string query) => Assign(query, (a, v) => a.QueryValue = v);
		public SimpleQueryStringQueryDescriptor<TDocument> QuoteFieldSuffix(string? quoteFieldSuffix) => Assign(quoteFieldSuffix, (a, v) => a.QuoteFieldSuffixValue = v);
		public SimpleQueryStringQueryDescriptor<TDocument> Boost(float? boost) => Assign(boost, (a, v) => a.BoostValue = v);
		public SimpleQueryStringQueryDescriptor<TDocument> QueryName(string? queryName) => Assign(queryName, (a, v) => a.QueryNameValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(AnalyzerValue))
			{
				writer.WritePropertyName("analyzer");
				writer.WriteStringValue(AnalyzerValue);
			}

			if (AnalyzeWildcardValue.HasValue)
			{
				writer.WritePropertyName("analyze_wildcard");
				writer.WriteBooleanValue(AnalyzeWildcardValue.Value);
			}

			if (AutoGenerateSynonymsPhraseQueryValue.HasValue)
			{
				writer.WritePropertyName("auto_generate_synonyms_phrase_query");
				writer.WriteBooleanValue(AutoGenerateSynonymsPhraseQueryValue.Value);
			}

			if (DefaultOperatorValue is not null)
			{
				writer.WritePropertyName("default_operator");
				JsonSerializer.Serialize(writer, DefaultOperatorValue, options);
			}

			if (FieldsValue is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, FieldsValue, options);
			}

			if (FlagsValue is not null)
			{
				writer.WritePropertyName("flags");
				JsonSerializer.Serialize(writer, FlagsValue, options);
			}

			if (FuzzyMaxExpansionsValue.HasValue)
			{
				writer.WritePropertyName("fuzzy_max_expansions");
				writer.WriteNumberValue(FuzzyMaxExpansionsValue.Value);
			}

			if (FuzzyPrefixLengthValue.HasValue)
			{
				writer.WritePropertyName("fuzzy_prefix_length");
				writer.WriteNumberValue(FuzzyPrefixLengthValue.Value);
			}

			if (FuzzyTranspositionsValue.HasValue)
			{
				writer.WritePropertyName("fuzzy_transpositions");
				writer.WriteBooleanValue(FuzzyTranspositionsValue.Value);
			}

			if (LenientValue.HasValue)
			{
				writer.WritePropertyName("lenient");
				writer.WriteBooleanValue(LenientValue.Value);
			}

			if (MinimumShouldMatchValue is not null)
			{
				writer.WritePropertyName("minimum_should_match");
				JsonSerializer.Serialize(writer, MinimumShouldMatchValue, options);
			}

			writer.WritePropertyName("query");
			writer.WriteStringValue(QueryValue);
			if (!string.IsNullOrEmpty(QuoteFieldSuffixValue))
			{
				writer.WritePropertyName("quote_field_suffix");
				writer.WriteStringValue(QuoteFieldSuffixValue);
			}

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