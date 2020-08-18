// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial struct DocumentSentimentInternal
    {
        internal static DocumentSentimentInternal DeserializeDocumentSentimentInternal(JsonElement element)
        {
            string id = default;
            TextSentiment sentiment = default;
            Optional<TextDocumentStatistics> statistics = default;
            SentimentConfidenceScores confidenceScores = default;
            IReadOnlyList<SentenceSentimentInternal> sentences = default;
            IReadOnlyList<TextAnalyticsWarning_internal> warnings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sentiment"))
                {
                    sentiment = property.Value.GetString().ToTextSentiment();
                    continue;
                }
                if (property.NameEquals("statistics"))
                {
                    statistics = TextDocumentStatistics.DeserializeTextDocumentStatistics(property.Value);
                    continue;
                }
                if (property.NameEquals("confidenceScores"))
                {
                    confidenceScores = SentimentConfidenceScores.DeserializeSentimentConfidenceScores(property.Value);
                    continue;
                }
                if (property.NameEquals("sentences"))
                {
                    List<SentenceSentimentInternal> array = new List<SentenceSentimentInternal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SentenceSentimentInternal.DeserializeSentenceSentimentInternal(item));
                    }
                    sentences = array;
                    continue;
                }
                if (property.NameEquals("warnings"))
                {
                    List<TextAnalyticsWarning_internal> array = new List<TextAnalyticsWarning_internal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TextAnalyticsWarning_internal.DeserializeTextAnalyticsWarning_internal(item));
                    }
                    warnings = array;
                    continue;
                }
            }
            return new DocumentSentimentInternal(id, sentiment, Optional.ToNullable(statistics), confidenceScores, sentences, warnings);
        }
    }
}