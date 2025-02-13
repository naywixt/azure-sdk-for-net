﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary>
    /// Describes an Azure Application Insights data source which ingests data into a <see cref="DataFeed"/> for anomaly detection.
    /// </summary>
    public class AzureApplicationInsightsDataFeedSource : DataFeedSource
    {
        // TODODOCS.
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureApplicationInsightsDataFeedSource"/> class.
        /// </summary>
        /// <param name="applicationId">The Application ID.</param>
        /// <param name="apiKey">The API key.</param>
        /// <param name="azureCloud"></param>
        /// <param name="query"></param>
        /// <exception cref="ArgumentNullException"><paramref name="applicationId"/>, <paramref name="apiKey"/>, <paramref name="azureCloud"/>, or <paramref name="query"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="applicationId"/>, <paramref name="apiKey"/>, <paramref name="azureCloud"/>, or <paramref name="query"/> is empty.</exception>
        public AzureApplicationInsightsDataFeedSource(string applicationId, string apiKey, string azureCloud, string query)
            : base(DataFeedSourceType.AzureApplicationInsights)
        {
            Argument.AssertNotNullOrEmpty(azureCloud, nameof(azureCloud));
            Argument.AssertNotNullOrEmpty(applicationId, nameof(applicationId));
            Argument.AssertNotNullOrEmpty(apiKey, nameof(apiKey));
            Argument.AssertNotNullOrEmpty(query, nameof(query));

            Parameter = new AzureApplicationInsightsParameter(azureCloud, applicationId, apiKey, query);
        }
    }
}
