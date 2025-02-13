namespace Azure.AI.MetricsAdvisor
{
    public partial class MetricsAdvisorClient
    {
        protected MetricsAdvisorClient() { }
        public MetricsAdvisorClient(System.Uri endpoint, Azure.AI.MetricsAdvisor.MetricsAdvisorKeyCredential credential) { }
        public MetricsAdvisorClient(System.Uri endpoint, Azure.AI.MetricsAdvisor.MetricsAdvisorKeyCredential credential, Azure.AI.MetricsAdvisor.MetricsAdvisorClientOptions options) { }
        public virtual Azure.Response<Azure.AI.MetricsAdvisor.Models.MetricFeedback> CreateMetricFeedback(Azure.AI.MetricsAdvisor.Models.MetricFeedback feedback, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.MetricsAdvisor.Models.MetricFeedback>> CreateMetricFeedbackAsync(Azure.AI.MetricsAdvisor.Models.MetricFeedback feedback, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.AI.MetricsAdvisor.Models.AlertResult> GetAlerts(string alertConfigurationId, Azure.AI.MetricsAdvisor.Models.GetAlertsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.MetricsAdvisor.Models.AlertResult> GetAlertsAsync(string alertConfigurationId, Azure.AI.MetricsAdvisor.Models.GetAlertsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.AI.MetricsAdvisor.Models.DataAnomaly> GetAnomaliesForAlert(string alertConfigurationId, string alertId, Azure.AI.MetricsAdvisor.Models.GetAnomaliesForAlertOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.MetricsAdvisor.Models.DataAnomaly> GetAnomaliesForAlertAsync(string alertConfigurationId, string alertId, Azure.AI.MetricsAdvisor.Models.GetAnomaliesForAlertOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.AI.MetricsAdvisor.Models.DataAnomaly> GetAnomaliesForDetectionConfiguration(string detectionConfigurationId, Azure.AI.MetricsAdvisor.Models.GetAnomaliesForDetectionConfigurationOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.MetricsAdvisor.Models.DataAnomaly> GetAnomaliesForDetectionConfigurationAsync(string detectionConfigurationId, Azure.AI.MetricsAdvisor.Models.GetAnomaliesForDetectionConfigurationOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.MetricsAdvisor.Models.IncidentRootCause>> GetIncidentRootCauses(string detectionConfigurationId, string incidentId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.MetricsAdvisor.Models.IncidentRootCause>>> GetIncidentRootCausesAsync(string detectionConfigurationId, string incidentId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.AI.MetricsAdvisor.Models.AnomalyIncident> GetIncidentsForAlert(string alertConfigurationId, string alertId, Azure.AI.MetricsAdvisor.Models.GetIncidentsForAlertOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.MetricsAdvisor.Models.AnomalyIncident> GetIncidentsForAlertAsync(string alertConfigurationId, string alertId, Azure.AI.MetricsAdvisor.Models.GetIncidentsForAlertOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.AI.MetricsAdvisor.Models.AnomalyIncident> GetIncidentsForDetectionConfiguration(string detectionConfigurationId, Azure.AI.MetricsAdvisor.Models.GetIncidentsForDetectionConfigurationOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.MetricsAdvisor.Models.AnomalyIncident> GetIncidentsForDetectionConfigurationAsync(string detectionConfigurationId, Azure.AI.MetricsAdvisor.Models.GetIncidentsForDetectionConfigurationOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<string> GetMetricDimensionValues(string metricId, string dimensionName, Azure.AI.MetricsAdvisor.Models.GetMetricDimensionValuesOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<string> GetMetricDimensionValuesAsync(string metricId, string dimensionName, Azure.AI.MetricsAdvisor.Models.GetMetricDimensionValuesOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.MetricsAdvisor.Models.MetricEnrichedSeriesData>> GetMetricEnrichedSeriesData(System.Collections.Generic.IEnumerable<Azure.AI.MetricsAdvisor.Models.DimensionKey> seriesKeys, string detectionConfigurationId, System.DateTimeOffset startTime, System.DateTimeOffset endTime, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.MetricsAdvisor.Models.MetricEnrichedSeriesData>>> GetMetricEnrichedSeriesDataAsync(System.Collections.Generic.IEnumerable<Azure.AI.MetricsAdvisor.Models.DimensionKey> seriesKeys, string detectionConfigurationId, System.DateTimeOffset startTime, System.DateTimeOffset endTime, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.AI.MetricsAdvisor.Models.EnrichmentStatus> GetMetricEnrichmentStatuses(string metricId, Azure.AI.MetricsAdvisor.Models.GetMetricEnrichmentStatusesOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.MetricsAdvisor.Models.EnrichmentStatus> GetMetricEnrichmentStatusesAsync(string metricId, Azure.AI.MetricsAdvisor.Models.GetMetricEnrichmentStatusesOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.AI.MetricsAdvisor.Models.MetricFeedback> GetMetricFeedback(string feedbackId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.MetricsAdvisor.Models.MetricFeedback>> GetMetricFeedbackAsync(string feedbackId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.AI.MetricsAdvisor.Models.MetricFeedback> GetMetricFeedbacks(string metricId, Azure.AI.MetricsAdvisor.Models.GetMetricFeedbacksOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.MetricsAdvisor.Models.MetricFeedback> GetMetricFeedbacksAsync(string metricId, Azure.AI.MetricsAdvisor.Models.GetMetricFeedbacksOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.MetricsAdvisor.Models.MetricSeriesData>> GetMetricSeriesData(string metricId, Azure.AI.MetricsAdvisor.Models.GetMetricSeriesDataOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.MetricsAdvisor.Models.MetricSeriesData>>> GetMetricSeriesDataAsync(string metricId, Azure.AI.MetricsAdvisor.Models.GetMetricSeriesDataOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.AI.MetricsAdvisor.Models.MetricSeriesDefinition> GetMetricSeriesDefinitions(string metricId, Azure.AI.MetricsAdvisor.Models.GetMetricSeriesDefinitionsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.MetricsAdvisor.Models.MetricSeriesDefinition> GetMetricSeriesDefinitionsAsync(string metricId, Azure.AI.MetricsAdvisor.Models.GetMetricSeriesDefinitionsOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<string> GetValuesOfDimensionWithAnomalies(string detectionConfigurationId, string dimensionName, Azure.AI.MetricsAdvisor.Models.GetValuesOfDimensionWithAnomaliesOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<string> GetValuesOfDimensionWithAnomaliesAsync(string detectionConfigurationId, string dimensionName, Azure.AI.MetricsAdvisor.Models.GetValuesOfDimensionWithAnomaliesOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class MetricsAdvisorClientOptions : Azure.Core.ClientOptions
    {
        public MetricsAdvisorClientOptions(Azure.AI.MetricsAdvisor.MetricsAdvisorClientOptions.ServiceVersion version = Azure.AI.MetricsAdvisor.MetricsAdvisorClientOptions.ServiceVersion.V1_0) { }
        public Azure.AI.MetricsAdvisor.MetricsAdvisorClientOptions.ServiceVersion Version { get { throw null; } }
        public enum ServiceVersion
        {
            V1_0 = 1,
        }
    }
    public partial class MetricsAdvisorKeyCredential
    {
        public MetricsAdvisorKeyCredential(string subscriptionKey, string apiKey) { }
        public void UpdateApiKey(string key) { }
        public void UpdateSubscriptionKey(string key) { }
    }
}
namespace Azure.AI.MetricsAdvisor.Administration
{
    public partial class MetricsAdvisorAdministrationClient
    {
        protected MetricsAdvisorAdministrationClient() { }
        public MetricsAdvisorAdministrationClient(System.Uri endpoint, Azure.AI.MetricsAdvisor.MetricsAdvisorKeyCredential credential) { }
        public MetricsAdvisorAdministrationClient(System.Uri endpoint, Azure.AI.MetricsAdvisor.MetricsAdvisorKeyCredential credential, Azure.AI.MetricsAdvisor.MetricsAdvisorClientOptions options) { }
        public virtual Azure.Response<Azure.AI.MetricsAdvisor.Models.AnomalyAlertConfiguration> CreateAnomalyAlertConfiguration(Azure.AI.MetricsAdvisor.Models.AnomalyAlertConfiguration alertConfiguration, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.MetricsAdvisor.Models.AnomalyAlertConfiguration>> CreateAnomalyAlertConfigurationAsync(Azure.AI.MetricsAdvisor.Models.AnomalyAlertConfiguration alertConfiguration, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.AI.MetricsAdvisor.Models.DataFeed> CreateDataFeed(string dataFeedName, Azure.AI.MetricsAdvisor.Models.DataFeedSource dataSource, Azure.AI.MetricsAdvisor.Models.DataFeedGranularity dataFeedGranularity, Azure.AI.MetricsAdvisor.Models.DataFeedSchema dataFeedSchema, Azure.AI.MetricsAdvisor.Models.DataFeedIngestionSettings dataFeedIngestionSettings, Azure.AI.MetricsAdvisor.Models.DataFeedOptions dataFeedOptions = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.MetricsAdvisor.Models.DataFeed>> CreateDataFeedAsync(string dataFeedName, Azure.AI.MetricsAdvisor.Models.DataFeedSource dataSource, Azure.AI.MetricsAdvisor.Models.DataFeedGranularity dataFeedGranularity, Azure.AI.MetricsAdvisor.Models.DataFeedSchema dataFeedSchema, Azure.AI.MetricsAdvisor.Models.DataFeedIngestionSettings dataFeedIngestionSettings, Azure.AI.MetricsAdvisor.Models.DataFeedOptions dataFeedOptions = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.AI.MetricsAdvisor.Models.AlertingHook> CreateHook(Azure.AI.MetricsAdvisor.Models.AlertingHook hook, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.MetricsAdvisor.Models.AlertingHook>> CreateHookAsync(Azure.AI.MetricsAdvisor.Models.AlertingHook hook, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.AI.MetricsAdvisor.Models.AnomalyDetectionConfiguration> CreateMetricAnomalyDetectionConfiguration(Azure.AI.MetricsAdvisor.Models.AnomalyDetectionConfiguration detectionConfiguration, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.MetricsAdvisor.Models.AnomalyDetectionConfiguration>> CreateMetricAnomalyDetectionConfigurationAsync(Azure.AI.MetricsAdvisor.Models.AnomalyDetectionConfiguration detectionConfiguration, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteAnomalyAlertConfiguration(string alertConfigurationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteAnomalyAlertConfigurationAsync(string alertConfigurationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteDataFeed(string dataFeedId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteDataFeedAsync(string dataFeedId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteHook(string hookId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteHookAsync(string hookId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteMetricAnomalyDetectionConfiguration(string detectionConfigurationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteMetricAnomalyDetectionConfigurationAsync(string detectionConfigurationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.AI.MetricsAdvisor.Models.AnomalyAlertConfiguration> GetAnomalyAlertConfiguration(string alertConfigurationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.MetricsAdvisor.Models.AnomalyAlertConfiguration>> GetAnomalyAlertConfigurationAsync(string alertConfigurationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.MetricsAdvisor.Models.AnomalyAlertConfiguration>> GetAnomalyAlertConfigurations(string alertConfigurationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.MetricsAdvisor.Models.AnomalyAlertConfiguration>>> GetAnomalyAlertConfigurationsAsync(string alertConfigurationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.AI.MetricsAdvisor.Models.DataFeed> GetDataFeed(string dataFeedId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.MetricsAdvisor.Models.DataFeed>> GetDataFeedAsync(string dataFeedId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.AI.MetricsAdvisor.Models.DataFeedIngestionProgress> GetDataFeedIngestionProgress(string dataFeedId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.MetricsAdvisor.Models.DataFeedIngestionProgress>> GetDataFeedIngestionProgressAsync(string dataFeedId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.AI.MetricsAdvisor.Models.DataFeedIngestionStatus> GetDataFeedIngestionStatuses(string dataFeedId, Azure.AI.MetricsAdvisor.Models.GetDataFeedIngestionStatusesOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.MetricsAdvisor.Models.DataFeedIngestionStatus> GetDataFeedIngestionStatusesAsync(string dataFeedId, Azure.AI.MetricsAdvisor.Models.GetDataFeedIngestionStatusesOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.AI.MetricsAdvisor.Models.DataFeed> GetDataFeeds(Azure.AI.MetricsAdvisor.Models.GetDataFeedsOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.MetricsAdvisor.Models.DataFeed> GetDataFeedsAsync(Azure.AI.MetricsAdvisor.Models.GetDataFeedsOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.AI.MetricsAdvisor.Models.AlertingHook> GetHook(string hookId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.MetricsAdvisor.Models.AlertingHook>> GetHookAsync(string hookId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.AI.MetricsAdvisor.Models.AlertingHook> GetHooks(Azure.AI.MetricsAdvisor.Models.GetHooksOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.AI.MetricsAdvisor.Models.AlertingHook> GetHooksAsync(Azure.AI.MetricsAdvisor.Models.GetHooksOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.AI.MetricsAdvisor.Models.AnomalyDetectionConfiguration> GetMetricAnomalyDetectionConfiguration(string detectionConfigurationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.AI.MetricsAdvisor.Models.AnomalyDetectionConfiguration>> GetMetricAnomalyDetectionConfigurationAsync(string detectionConfigurationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.MetricsAdvisor.Models.AnomalyDetectionConfiguration>> GetMetricAnomalyDetectionConfigurations(string metricId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.AI.MetricsAdvisor.Models.AnomalyDetectionConfiguration>>> GetMetricAnomalyDetectionConfigurationsAsync(string metricId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response RefreshDataFeedIngestion(string dataFeedId, System.DateTimeOffset startTime, System.DateTimeOffset endTime, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RefreshDataFeedIngestionAsync(string dataFeedId, System.DateTimeOffset startTime, System.DateTimeOffset endTime, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response UpdateAnomalyAlertConfiguration(string alertConfigurationId, Azure.AI.MetricsAdvisor.Models.AnomalyAlertConfiguration alertConfiguration, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateAnomalyAlertConfigurationAsync(string alertConfigurationId, Azure.AI.MetricsAdvisor.Models.AnomalyAlertConfiguration alertConfiguration, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response UpdateDataFeed(string dataFeedId, Azure.AI.MetricsAdvisor.Models.DataFeed dataFeed, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateDataFeedAsync(string dataFeedId, Azure.AI.MetricsAdvisor.Models.DataFeed dataFeed, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response UpdateHook(string hookId, Azure.AI.MetricsAdvisor.Models.AlertingHook hook, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateHookAsync(string hookId, Azure.AI.MetricsAdvisor.Models.AlertingHook hook, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response UpdateMetricAnomalyDetectionConfiguration(string detectionConfigurationId, Azure.AI.MetricsAdvisor.Models.AnomalyDetectionConfiguration detectionConfiguration, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> UpdateMetricAnomalyDetectionConfigurationAsync(string detectionConfigurationId, Azure.AI.MetricsAdvisor.Models.AnomalyDetectionConfiguration detectionConfiguration, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class MetricsAdvisorAdministrationClientOptions : Azure.Core.ClientOptions
    {
        public MetricsAdvisorAdministrationClientOptions(Azure.AI.MetricsAdvisor.Administration.MetricsAdvisorAdministrationClientOptions.ServiceVersion version = Azure.AI.MetricsAdvisor.Administration.MetricsAdvisorAdministrationClientOptions.ServiceVersion.V1_0) { }
        public Azure.AI.MetricsAdvisor.Administration.MetricsAdvisorAdministrationClientOptions.ServiceVersion Version { get { throw null; } }
        public enum ServiceVersion
        {
            V1_0 = 1,
        }
    }
}
namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class AlertingHook
    {
        internal AlertingHook() { }
        public System.Collections.Generic.IReadOnlyList<string> Administrators { get { throw null; } }
        public string Description { get { throw null; } set { } }
        public string ExternalLink { get { throw null; } set { } }
        public string Id { get { throw null; } }
        public string Name { get { throw null; } }
    }
    public partial class AlertResult
    {
        internal AlertResult() { }
        public System.DateTimeOffset CreatedTime { get { throw null; } }
        public string Id { get { throw null; } }
        public System.DateTimeOffset ModifiedTime { get { throw null; } }
        public System.DateTimeOffset Timestamp { get { throw null; } }
    }
    public partial class AnomalyAlertConfiguration
    {
        public AnomalyAlertConfiguration(string name, System.Collections.Generic.IList<string> idsOfHooksToAlert, System.Collections.Generic.IList<Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertConfiguration> metricAlertConfigurations) { }
        public Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertConfigurationsOperator? CrossMetricsOperator { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public string Id { get { throw null; } }
        public System.Collections.Generic.IList<string> IdsOfHooksToAlert { get { throw null; } }
        public System.Collections.Generic.IList<Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertConfiguration> MetricAlertConfigurations { get { throw null; } }
        public string Name { get { throw null; } }
    }
    public partial class AnomalyDetectionConfiguration
    {
        public AnomalyDetectionConfiguration(string metricId, string name, Azure.AI.MetricsAdvisor.Models.MetricWholeSeriesDetectionCondition wholeSeriesDetectionConditions) { }
        public string Description { get { throw null; } set { } }
        public string Id { get { throw null; } }
        public string MetricId { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Collections.Generic.IList<Azure.AI.MetricsAdvisor.Models.MetricSingleSeriesDetectionCondition> SeriesDetectionConditions { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.AI.MetricsAdvisor.Models.MetricSeriesGroupDetectionCondition> SeriesGroupDetectionConditions { get { throw null; } set { } }
        public Azure.AI.MetricsAdvisor.Models.MetricWholeSeriesDetectionCondition WholeSeriesDetectionConditions { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AnomalyDetectorDirection : System.IEquatable<Azure.AI.MetricsAdvisor.Models.AnomalyDetectorDirection>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AnomalyDetectorDirection(string value) { throw null; }
        public static Azure.AI.MetricsAdvisor.Models.AnomalyDetectorDirection Both { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.AnomalyDetectorDirection Down { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.AnomalyDetectorDirection Up { get { throw null; } }
        public bool Equals(Azure.AI.MetricsAdvisor.Models.AnomalyDetectorDirection other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.MetricsAdvisor.Models.AnomalyDetectorDirection left, Azure.AI.MetricsAdvisor.Models.AnomalyDetectorDirection right) { throw null; }
        public static implicit operator Azure.AI.MetricsAdvisor.Models.AnomalyDetectorDirection (string value) { throw null; }
        public static bool operator !=(Azure.AI.MetricsAdvisor.Models.AnomalyDetectorDirection left, Azure.AI.MetricsAdvisor.Models.AnomalyDetectorDirection right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class AnomalyIncident
    {
        internal AnomalyIncident() { }
        public string DetectionConfigurationId { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.DimensionKey DimensionKey { get { throw null; } }
        public string Id { get { throw null; } }
        public System.DateTimeOffset LastTime { get { throw null; } }
        public string MetricId { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.AnomalySeverity Severity { get { throw null; } }
        public System.DateTimeOffset StartTime { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.IncidentStatus? Status { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AnomalySeverity : System.IEquatable<Azure.AI.MetricsAdvisor.Models.AnomalySeverity>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AnomalySeverity(string value) { throw null; }
        public static Azure.AI.MetricsAdvisor.Models.AnomalySeverity High { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.AnomalySeverity Low { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.AnomalySeverity Medium { get { throw null; } }
        public bool Equals(Azure.AI.MetricsAdvisor.Models.AnomalySeverity other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.MetricsAdvisor.Models.AnomalySeverity left, Azure.AI.MetricsAdvisor.Models.AnomalySeverity right) { throw null; }
        public static implicit operator Azure.AI.MetricsAdvisor.Models.AnomalySeverity (string value) { throw null; }
        public static bool operator !=(Azure.AI.MetricsAdvisor.Models.AnomalySeverity left, Azure.AI.MetricsAdvisor.Models.AnomalySeverity right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AnomalyStatus : System.IEquatable<Azure.AI.MetricsAdvisor.Models.AnomalyStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AnomalyStatus(string value) { throw null; }
        public static Azure.AI.MetricsAdvisor.Models.AnomalyStatus Active { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.AnomalyStatus Resolved { get { throw null; } }
        public bool Equals(Azure.AI.MetricsAdvisor.Models.AnomalyStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.MetricsAdvisor.Models.AnomalyStatus left, Azure.AI.MetricsAdvisor.Models.AnomalyStatus right) { throw null; }
        public static implicit operator Azure.AI.MetricsAdvisor.Models.AnomalyStatus (string value) { throw null; }
        public static bool operator !=(Azure.AI.MetricsAdvisor.Models.AnomalyStatus left, Azure.AI.MetricsAdvisor.Models.AnomalyStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AnomalyValue : System.IEquatable<Azure.AI.MetricsAdvisor.Models.AnomalyValue>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AnomalyValue(string value) { throw null; }
        public static Azure.AI.MetricsAdvisor.Models.AnomalyValue Anomaly { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.AnomalyValue AutoDetect { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.AnomalyValue NotAnomaly { get { throw null; } }
        public bool Equals(Azure.AI.MetricsAdvisor.Models.AnomalyValue other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.MetricsAdvisor.Models.AnomalyValue left, Azure.AI.MetricsAdvisor.Models.AnomalyValue right) { throw null; }
        public static implicit operator Azure.AI.MetricsAdvisor.Models.AnomalyValue (string value) { throw null; }
        public static bool operator !=(Azure.AI.MetricsAdvisor.Models.AnomalyValue left, Azure.AI.MetricsAdvisor.Models.AnomalyValue right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class AzureApplicationInsightsDataFeedSource : Azure.AI.MetricsAdvisor.Models.DataFeedSource
    {
        public AzureApplicationInsightsDataFeedSource(string applicationId, string apiKey, string azureCloud, string query) { }
    }
    public partial class AzureBlobDataFeedSource : Azure.AI.MetricsAdvisor.Models.DataFeedSource
    {
        public AzureBlobDataFeedSource(string connectionString, string container, string blobTemplate) { }
    }
    public partial class AzureCosmosDbDataFeedSource : Azure.AI.MetricsAdvisor.Models.DataFeedSource
    {
        public AzureCosmosDbDataFeedSource(string connectionString, string sqlQuery, string database, string collectionId) { }
    }
    public partial class AzureDataExplorerDataFeedSource : Azure.AI.MetricsAdvisor.Models.DataFeedSource
    {
        public AzureDataExplorerDataFeedSource(string connectionString, string query) { }
    }
    public partial class AzureDataLakeStorageGen2DataFeedSource : Azure.AI.MetricsAdvisor.Models.DataFeedSource
    {
        public AzureDataLakeStorageGen2DataFeedSource(string accountName, string accountKey, string fileSystemName, string directoryTemplate, string fileTemplate) { }
    }
    public partial class AzureTableDataFeedSource : Azure.AI.MetricsAdvisor.Models.DataFeedSource
    {
        public AzureTableDataFeedSource(string connectionString, string table, string query) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct BoundaryDirection : System.IEquatable<Azure.AI.MetricsAdvisor.Models.BoundaryDirection>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public BoundaryDirection(string value) { throw null; }
        public static Azure.AI.MetricsAdvisor.Models.BoundaryDirection Both { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.BoundaryDirection Down { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.BoundaryDirection Up { get { throw null; } }
        public bool Equals(Azure.AI.MetricsAdvisor.Models.BoundaryDirection other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.MetricsAdvisor.Models.BoundaryDirection left, Azure.AI.MetricsAdvisor.Models.BoundaryDirection right) { throw null; }
        public static implicit operator Azure.AI.MetricsAdvisor.Models.BoundaryDirection (string value) { throw null; }
        public static bool operator !=(Azure.AI.MetricsAdvisor.Models.BoundaryDirection left, Azure.AI.MetricsAdvisor.Models.BoundaryDirection right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ChangePointFeedbackValue
    {
        public ChangePointFeedbackValue(Azure.AI.MetricsAdvisor.Models.ChangePointValue changePointValue) { }
        public Azure.AI.MetricsAdvisor.Models.ChangePointValue ChangePointValue { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ChangePointValue : System.IEquatable<Azure.AI.MetricsAdvisor.Models.ChangePointValue>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ChangePointValue(string value) { throw null; }
        public static Azure.AI.MetricsAdvisor.Models.ChangePointValue AutoDetect { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.ChangePointValue ChangePoint { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.ChangePointValue NotChangePoint { get { throw null; } }
        public bool Equals(Azure.AI.MetricsAdvisor.Models.ChangePointValue other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.MetricsAdvisor.Models.ChangePointValue left, Azure.AI.MetricsAdvisor.Models.ChangePointValue right) { throw null; }
        public static implicit operator Azure.AI.MetricsAdvisor.Models.ChangePointValue (string value) { throw null; }
        public static bool operator !=(Azure.AI.MetricsAdvisor.Models.ChangePointValue left, Azure.AI.MetricsAdvisor.Models.ChangePointValue right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ChangeThresholdCondition
    {
        public ChangeThresholdCondition(double changePercentage, int shiftPoint, bool isWithinRange, Azure.AI.MetricsAdvisor.Models.AnomalyDetectorDirection anomalyDetectorDirection, Azure.AI.MetricsAdvisor.Models.SuppressCondition suppressCondition) { }
        public Azure.AI.MetricsAdvisor.Models.AnomalyDetectorDirection AnomalyDetectorDirection { get { throw null; } }
        public double ChangePercentage { get { throw null; } }
        public bool IsWithinRange { get { throw null; } }
        public int ShiftPoint { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.SuppressCondition SuppressCondition { get { throw null; } }
    }
    public partial class CommentFeedbackValue
    {
        public CommentFeedbackValue(string commentValue) { }
        public string CommentValue { get { throw null; } set { } }
    }
    public partial class DataAnomaly
    {
        internal DataAnomaly() { }
        public string AnomalyDetectionConfigurationId { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.AnomalyStatus? AnomalyStatus { get { throw null; } }
        public System.DateTimeOffset? CreatedTime { get { throw null; } }
        public string MetricId { get { throw null; } }
        public System.DateTimeOffset? ModifiedTime { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.DimensionKey SeriesKey { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.AnomalySeverity Severity { get { throw null; } }
        public System.DateTimeOffset Timestamp { get { throw null; } }
    }
    public partial class DataFeed
    {
        internal DataFeed() { }
        public System.DateTimeOffset? CreatedTime { get { throw null; } }
        public string Creator { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.DataFeedGranularity Granularity { get { throw null; } }
        public string Id { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.DataFeedIngestionSettings IngestionSettings { get { throw null; } }
        public bool? IsAdministrator { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> MetricIds { get { throw null; } }
        public string Name { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.DataFeedOptions Options { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.DataFeedSchema Schema { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.DataFeedSourceType SourceType { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.DataFeedStatus? Status { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DataFeedAccessMode : System.IEquatable<Azure.AI.MetricsAdvisor.Models.DataFeedAccessMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DataFeedAccessMode(string value) { throw null; }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedAccessMode Private { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedAccessMode Public { get { throw null; } }
        public bool Equals(Azure.AI.MetricsAdvisor.Models.DataFeedAccessMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.MetricsAdvisor.Models.DataFeedAccessMode left, Azure.AI.MetricsAdvisor.Models.DataFeedAccessMode right) { throw null; }
        public static implicit operator Azure.AI.MetricsAdvisor.Models.DataFeedAccessMode (string value) { throw null; }
        public static bool operator !=(Azure.AI.MetricsAdvisor.Models.DataFeedAccessMode left, Azure.AI.MetricsAdvisor.Models.DataFeedAccessMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DataFeedAutoRollupMethod : System.IEquatable<Azure.AI.MetricsAdvisor.Models.DataFeedAutoRollupMethod>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DataFeedAutoRollupMethod(string value) { throw null; }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedAutoRollupMethod Average { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedAutoRollupMethod Count { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedAutoRollupMethod Maximum { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedAutoRollupMethod Minimum { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedAutoRollupMethod None { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedAutoRollupMethod Sum { get { throw null; } }
        public bool Equals(Azure.AI.MetricsAdvisor.Models.DataFeedAutoRollupMethod other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.MetricsAdvisor.Models.DataFeedAutoRollupMethod left, Azure.AI.MetricsAdvisor.Models.DataFeedAutoRollupMethod right) { throw null; }
        public static implicit operator Azure.AI.MetricsAdvisor.Models.DataFeedAutoRollupMethod (string value) { throw null; }
        public static bool operator !=(Azure.AI.MetricsAdvisor.Models.DataFeedAutoRollupMethod left, Azure.AI.MetricsAdvisor.Models.DataFeedAutoRollupMethod right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DataFeedGranularity
    {
        public DataFeedGranularity(Azure.AI.MetricsAdvisor.Models.DataFeedGranularityType granularityType) { }
        public int? CustomGranularityValue { get { throw null; } set { } }
        public Azure.AI.MetricsAdvisor.Models.DataFeedGranularityType GranularityType { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DataFeedGranularityType : System.IEquatable<Azure.AI.MetricsAdvisor.Models.DataFeedGranularityType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DataFeedGranularityType(string value) { throw null; }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedGranularityType Custom { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedGranularityType Daily { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedGranularityType Hourly { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedGranularityType Minutely { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedGranularityType Monthly { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedGranularityType Secondly { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedGranularityType Weekly { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedGranularityType Yearly { get { throw null; } }
        public bool Equals(Azure.AI.MetricsAdvisor.Models.DataFeedGranularityType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.MetricsAdvisor.Models.DataFeedGranularityType left, Azure.AI.MetricsAdvisor.Models.DataFeedGranularityType right) { throw null; }
        public static implicit operator Azure.AI.MetricsAdvisor.Models.DataFeedGranularityType (string value) { throw null; }
        public static bool operator !=(Azure.AI.MetricsAdvisor.Models.DataFeedGranularityType left, Azure.AI.MetricsAdvisor.Models.DataFeedGranularityType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DataFeedIngestionProgress
    {
        internal DataFeedIngestionProgress() { }
        public System.DateTimeOffset? LatestActiveTimestamp { get { throw null; } }
        public System.DateTimeOffset? LatestSuccessTimestamp { get { throw null; } }
    }
    public partial class DataFeedIngestionSettings
    {
        public DataFeedIngestionSettings(System.DateTimeOffset ingestionStartTime) { }
        public int? DataSourceRequestConcurrency { get { throw null; } set { } }
        public System.TimeSpan? IngestionRetryDelay { get { throw null; } set { } }
        public System.TimeSpan? IngestionStartOffset { get { throw null; } set { } }
        public System.DateTimeOffset IngestionStartTime { get { throw null; } }
        public System.TimeSpan? StopRetryAfter { get { throw null; } set { } }
    }
    public partial class DataFeedIngestionStatus
    {
        internal DataFeedIngestionStatus() { }
        public string Message { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.IngestionStatusType? Status { get { throw null; } }
        public System.DateTimeOffset? Timestamp { get { throw null; } }
    }
    public partial class DataFeedMetric
    {
        public DataFeedMetric(string metricName) { }
        public string MetricDescription { get { throw null; } set { } }
        public string MetricDisplayName { get { throw null; } set { } }
        public string MetricId { get { throw null; } }
        public string MetricName { get { throw null; } }
    }
    public partial class DataFeedMissingDataPointFillSettings
    {
        public DataFeedMissingDataPointFillSettings() { }
        public double? CustomFillValue { get { throw null; } set { } }
        public Azure.AI.MetricsAdvisor.Models.DataFeedMissingDataPointFillType? FillType { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DataFeedMissingDataPointFillType : System.IEquatable<Azure.AI.MetricsAdvisor.Models.DataFeedMissingDataPointFillType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DataFeedMissingDataPointFillType(string value) { throw null; }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedMissingDataPointFillType CustomValue { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedMissingDataPointFillType NoFilling { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedMissingDataPointFillType PreviousValue { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedMissingDataPointFillType SmartFilling { get { throw null; } }
        public bool Equals(Azure.AI.MetricsAdvisor.Models.DataFeedMissingDataPointFillType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.MetricsAdvisor.Models.DataFeedMissingDataPointFillType left, Azure.AI.MetricsAdvisor.Models.DataFeedMissingDataPointFillType right) { throw null; }
        public static implicit operator Azure.AI.MetricsAdvisor.Models.DataFeedMissingDataPointFillType (string value) { throw null; }
        public static bool operator !=(Azure.AI.MetricsAdvisor.Models.DataFeedMissingDataPointFillType left, Azure.AI.MetricsAdvisor.Models.DataFeedMissingDataPointFillType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DataFeedOptions
    {
        public DataFeedOptions() { }
        public Azure.AI.MetricsAdvisor.Models.DataFeedAccessMode? AccessMode { get { throw null; } set { } }
        public string ActionLinkTemplate { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Administrators { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public Azure.AI.MetricsAdvisor.Models.DataFeedMissingDataPointFillSettings MissingDataPointFillSettings { get { throw null; } set { } }
        public Azure.AI.MetricsAdvisor.Models.DataFeedRollupSettings RollupSettings { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Viewers { get { throw null; } set { } }
    }
    public partial class DataFeedRollupSettings
    {
        public DataFeedRollupSettings() { }
        public string AlreadyRollupIdentificationValue { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> AutoRollupGroupByColumnNames { get { throw null; } set { } }
        public Azure.AI.MetricsAdvisor.Models.DataFeedAutoRollupMethod? RollupMethod { get { throw null; } set { } }
        public Azure.AI.MetricsAdvisor.Models.DataFeedRollupType? RollupType { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DataFeedRollupType : System.IEquatable<Azure.AI.MetricsAdvisor.Models.DataFeedRollupType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DataFeedRollupType(string value) { throw null; }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedRollupType AlreadyRollup { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedRollupType NeedRollup { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedRollupType NoRollup { get { throw null; } }
        public bool Equals(Azure.AI.MetricsAdvisor.Models.DataFeedRollupType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.MetricsAdvisor.Models.DataFeedRollupType left, Azure.AI.MetricsAdvisor.Models.DataFeedRollupType right) { throw null; }
        public static implicit operator Azure.AI.MetricsAdvisor.Models.DataFeedRollupType (string value) { throw null; }
        public static bool operator !=(Azure.AI.MetricsAdvisor.Models.DataFeedRollupType left, Azure.AI.MetricsAdvisor.Models.DataFeedRollupType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DataFeedSchema
    {
        public DataFeedSchema(System.Collections.Generic.IList<Azure.AI.MetricsAdvisor.Models.DataFeedMetric> metricColumns) { }
        public System.Collections.Generic.IList<Azure.AI.MetricsAdvisor.Models.MetricDimension> DimensionColumns { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.AI.MetricsAdvisor.Models.DataFeedMetric> MetricColumns { get { throw null; } }
        public string TimestampColumn { get { throw null; } set { } }
    }
    public abstract partial class DataFeedSource
    {
        internal DataFeedSource() { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DataFeedSourceType : System.IEquatable<Azure.AI.MetricsAdvisor.Models.DataFeedSourceType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DataFeedSourceType(string value) { throw null; }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedSourceType AzureApplicationInsights { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedSourceType AzureBlob { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedSourceType AzureCosmosDb { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedSourceType AzureDataExplorer { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedSourceType AzureDataLakeStorageGen2 { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedSourceType AzureTable { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedSourceType Elasticsearch { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedSourceType HttpRequest { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedSourceType InfluxDb { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedSourceType MongoDb { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedSourceType MySql { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedSourceType PostgreSql { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedSourceType SqlServer { get { throw null; } }
        public bool Equals(Azure.AI.MetricsAdvisor.Models.DataFeedSourceType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.MetricsAdvisor.Models.DataFeedSourceType left, Azure.AI.MetricsAdvisor.Models.DataFeedSourceType right) { throw null; }
        public static implicit operator Azure.AI.MetricsAdvisor.Models.DataFeedSourceType (string value) { throw null; }
        public static bool operator !=(Azure.AI.MetricsAdvisor.Models.DataFeedSourceType left, Azure.AI.MetricsAdvisor.Models.DataFeedSourceType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DataFeedStatus : System.IEquatable<Azure.AI.MetricsAdvisor.Models.DataFeedStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DataFeedStatus(string value) { throw null; }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedStatus Active { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DataFeedStatus Paused { get { throw null; } }
        public bool Equals(Azure.AI.MetricsAdvisor.Models.DataFeedStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.MetricsAdvisor.Models.DataFeedStatus left, Azure.AI.MetricsAdvisor.Models.DataFeedStatus right) { throw null; }
        public static implicit operator Azure.AI.MetricsAdvisor.Models.DataFeedStatus (string value) { throw null; }
        public static bool operator !=(Azure.AI.MetricsAdvisor.Models.DataFeedStatus left, Azure.AI.MetricsAdvisor.Models.DataFeedStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DetectionConditionsOperator : System.IEquatable<Azure.AI.MetricsAdvisor.Models.DetectionConditionsOperator>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DetectionConditionsOperator(string value) { throw null; }
        public static Azure.AI.MetricsAdvisor.Models.DetectionConditionsOperator And { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.DetectionConditionsOperator Or { get { throw null; } }
        public bool Equals(Azure.AI.MetricsAdvisor.Models.DetectionConditionsOperator other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.MetricsAdvisor.Models.DetectionConditionsOperator left, Azure.AI.MetricsAdvisor.Models.DetectionConditionsOperator right) { throw null; }
        public static implicit operator Azure.AI.MetricsAdvisor.Models.DetectionConditionsOperator (string value) { throw null; }
        public static bool operator !=(Azure.AI.MetricsAdvisor.Models.DetectionConditionsOperator left, Azure.AI.MetricsAdvisor.Models.DetectionConditionsOperator right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class DimensionKey : System.IEquatable<Azure.AI.MetricsAdvisor.Models.DimensionKey>
    {
        public DimensionKey() { }
        public void AddDimensionColumn(string dimensionColumnName, string dimensionColumnValue) { }
        public bool Equals(Azure.AI.MetricsAdvisor.Models.DimensionKey other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.MetricsAdvisor.Models.DimensionKey left, Azure.AI.MetricsAdvisor.Models.DimensionKey right) { throw null; }
        public static bool operator !=(Azure.AI.MetricsAdvisor.Models.DimensionKey left, Azure.AI.MetricsAdvisor.Models.DimensionKey right) { throw null; }
        public void RemoveDimensionColumn(string dimensionColumnName) { }
    }
    public partial class ElasticsearchDataFeedSource : Azure.AI.MetricsAdvisor.Models.DataFeedSource
    {
        public ElasticsearchDataFeedSource(string host, string port, string authHeader, string query) { }
    }
    public partial class EmailHook : Azure.AI.MetricsAdvisor.Models.AlertingHook
    {
        public EmailHook(string name, System.Collections.Generic.IList<string> emailsToAlert) { }
        public System.Collections.Generic.IList<string> EmailsToAlert { get { throw null; } }
    }
    public partial class EnrichmentStatus
    {
        internal EnrichmentStatus() { }
        public string Message { get { throw null; } }
        public string Status { get { throw null; } }
        public System.DateTimeOffset? Timestamp { get { throw null; } }
    }
    public partial class FeedbackDimensionFilter
    {
        public FeedbackDimensionFilter(System.Collections.Generic.IDictionary<string, string> dimension) { }
        public System.Collections.Generic.IDictionary<string, string> Dimension { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct FeedbackQueryTimeMode : System.IEquatable<Azure.AI.MetricsAdvisor.Models.FeedbackQueryTimeMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public FeedbackQueryTimeMode(string value) { throw null; }
        public static Azure.AI.MetricsAdvisor.Models.FeedbackQueryTimeMode FeedbackCreatedTime { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.FeedbackQueryTimeMode MetricTimestamp { get { throw null; } }
        public bool Equals(Azure.AI.MetricsAdvisor.Models.FeedbackQueryTimeMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.MetricsAdvisor.Models.FeedbackQueryTimeMode left, Azure.AI.MetricsAdvisor.Models.FeedbackQueryTimeMode right) { throw null; }
        public static implicit operator Azure.AI.MetricsAdvisor.Models.FeedbackQueryTimeMode (string value) { throw null; }
        public static bool operator !=(Azure.AI.MetricsAdvisor.Models.FeedbackQueryTimeMode left, Azure.AI.MetricsAdvisor.Models.FeedbackQueryTimeMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct FeedbackType : System.IEquatable<Azure.AI.MetricsAdvisor.Models.FeedbackType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public FeedbackType(string value) { throw null; }
        public static Azure.AI.MetricsAdvisor.Models.FeedbackType Anomaly { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.FeedbackType ChangePoint { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.FeedbackType Comment { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.FeedbackType Period { get { throw null; } }
        public bool Equals(Azure.AI.MetricsAdvisor.Models.FeedbackType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.MetricsAdvisor.Models.FeedbackType left, Azure.AI.MetricsAdvisor.Models.FeedbackType right) { throw null; }
        public static implicit operator Azure.AI.MetricsAdvisor.Models.FeedbackType (string value) { throw null; }
        public static bool operator !=(Azure.AI.MetricsAdvisor.Models.FeedbackType left, Azure.AI.MetricsAdvisor.Models.FeedbackType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class GetAlertsOptions
    {
        public GetAlertsOptions(System.DateTimeOffset startTime, System.DateTimeOffset endTime, Azure.AI.MetricsAdvisor.Models.TimeMode timeMode) { }
        public System.DateTimeOffset EndTime { get { throw null; } }
        public int? SkipCount { get { throw null; } set { } }
        public System.DateTimeOffset StartTime { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.TimeMode TimeMode { get { throw null; } }
        public int? TopCount { get { throw null; } set { } }
    }
    public partial class GetAnomaliesForAlertOptions
    {
        public GetAnomaliesForAlertOptions() { }
        public int? SkipCount { get { throw null; } set { } }
        public int? TopCount { get { throw null; } set { } }
    }
    public partial class GetAnomaliesForDetectionConfigurationFilter
    {
        public GetAnomaliesForDetectionConfigurationFilter() { }
        public GetAnomaliesForDetectionConfigurationFilter(Azure.AI.MetricsAdvisor.Models.AnomalySeverity minimumSeverity, Azure.AI.MetricsAdvisor.Models.AnomalySeverity maximumSeverity) { }
        public Azure.AI.MetricsAdvisor.Models.AnomalySeverity? MaximumSeverity { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.AnomalySeverity? MinimumSeverity { get { throw null; } }
        public System.Collections.Generic.IList<Azure.AI.MetricsAdvisor.Models.DimensionKey> SeriesGroupKeys { get { throw null; } set { } }
    }
    public partial class GetAnomaliesForDetectionConfigurationOptions
    {
        public GetAnomaliesForDetectionConfigurationOptions(System.DateTimeOffset startTime, System.DateTimeOffset endTime) { }
        public System.DateTimeOffset EndTime { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.GetAnomaliesForDetectionConfigurationFilter Filter { get { throw null; } set { } }
        public int? SkipCount { get { throw null; } set { } }
        public System.DateTimeOffset StartTime { get { throw null; } }
        public int? TopCount { get { throw null; } set { } }
    }
    public partial class GetDataFeedIngestionStatusesOptions
    {
        public GetDataFeedIngestionStatusesOptions(System.DateTimeOffset startTime, System.DateTimeOffset endTime) { }
        public System.DateTimeOffset EndTime { get { throw null; } }
        public int? SkipCount { get { throw null; } set { } }
        public System.DateTimeOffset StartTime { get { throw null; } }
        public int? TopCount { get { throw null; } set { } }
    }
    public partial class GetDataFeedsFilter
    {
        public GetDataFeedsFilter() { }
        public string Creator { get { throw null; } set { } }
        public Azure.AI.MetricsAdvisor.Models.DataFeedGranularityType? GranularityType { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public Azure.AI.MetricsAdvisor.Models.DataFeedSourceType? SourceType { get { throw null; } set { } }
        public Azure.AI.MetricsAdvisor.Models.DataFeedStatus? Status { get { throw null; } set { } }
    }
    public partial class GetDataFeedsOptions
    {
        public GetDataFeedsOptions() { }
        public Azure.AI.MetricsAdvisor.Models.GetDataFeedsFilter GetDataFeedsFilter { get { throw null; } set { } }
        public int? SkipCount { get { throw null; } set { } }
        public int? TopCount { get { throw null; } set { } }
    }
    public partial class GetHooksOptions
    {
        public GetHooksOptions() { }
        public string HookNameFilter { get { throw null; } set { } }
        public int? SkipCount { get { throw null; } set { } }
        public int? TopCount { get { throw null; } set { } }
    }
    public partial class GetIncidentsForAlertOptions
    {
        public GetIncidentsForAlertOptions() { }
        public int? SkipCount { get { throw null; } set { } }
        public int? TopCount { get { throw null; } set { } }
    }
    public partial class GetIncidentsForDetectionConfigurationOptions
    {
        public GetIncidentsForDetectionConfigurationOptions(System.DateTimeOffset startTime, System.DateTimeOffset endTime) { }
        public System.Collections.Generic.IList<Azure.AI.MetricsAdvisor.Models.DimensionKey> DimensionsToFilter { get { throw null; } set { } }
        public System.DateTimeOffset EndTime { get { throw null; } }
        public System.DateTimeOffset StartTime { get { throw null; } }
        public int? TopCount { get { throw null; } set { } }
    }
    public partial class GetMetricDimensionValuesOptions
    {
        public GetMetricDimensionValuesOptions() { }
        public string DimensionValueToFilter { get { throw null; } set { } }
        public int? SkipCount { get { throw null; } set { } }
        public int? TopCount { get { throw null; } set { } }
    }
    public partial class GetMetricEnrichmentStatusesOptions
    {
        public GetMetricEnrichmentStatusesOptions(System.DateTimeOffset startTime, System.DateTimeOffset endTime) { }
        public System.DateTimeOffset EndTime { get { throw null; } }
        public int? SkipCount { get { throw null; } set { } }
        public System.DateTimeOffset StartTime { get { throw null; } }
        public int? TopCount { get { throw null; } set { } }
    }
    public partial class GetMetricFeedbacksOptions
    {
        public GetMetricFeedbacksOptions() { }
        public System.DateTimeOffset? EndTime { get { throw null; } set { } }
        public Azure.AI.MetricsAdvisor.Models.FeedbackType? FeedbackType { get { throw null; } set { } }
        public Azure.AI.MetricsAdvisor.Models.DimensionKey Filter { get { throw null; } }
        public int? SkipCount { get { throw null; } set { } }
        public System.DateTimeOffset? StartTime { get { throw null; } set { } }
        public Azure.AI.MetricsAdvisor.Models.FeedbackQueryTimeMode? TimeMode { get { throw null; } set { } }
        public int? TopCount { get { throw null; } set { } }
    }
    public partial class GetMetricSeriesDataOptions
    {
        public GetMetricSeriesDataOptions(System.Collections.Generic.IEnumerable<Azure.AI.MetricsAdvisor.Models.DimensionKey> seriesToFilter, System.DateTimeOffset startTime, System.DateTimeOffset endTime) { }
        public System.DateTimeOffset EndTime { get { throw null; } }
        public System.Collections.Generic.IEnumerable<Azure.AI.MetricsAdvisor.Models.DimensionKey> SeriesToFilter { get { throw null; } }
        public int? SkipCount { get { throw null; } set { } }
        public System.DateTimeOffset StartTime { get { throw null; } }
        public int? TopCount { get { throw null; } set { } }
    }
    public partial class GetMetricSeriesDefinitionsOptions
    {
        public GetMetricSeriesDefinitionsOptions(System.DateTimeOffset activeSince) { }
        public System.DateTimeOffset ActiveSince { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.IList<string>> DimensionCombinationsToFilter { get { throw null; } set { } }
        public int? SkipCount { get { throw null; } set { } }
        public int? TopCount { get { throw null; } set { } }
    }
    public partial class GetValuesOfDimensionWithAnomaliesOptions
    {
        public GetValuesOfDimensionWithAnomaliesOptions(System.DateTimeOffset startTime, System.DateTimeOffset endTime) { }
        public Azure.AI.MetricsAdvisor.Models.DimensionKey DimensionToFilter { get { throw null; } set { } }
        public System.DateTimeOffset EndTime { get { throw null; } }
        public int? SkipCount { get { throw null; } set { } }
        public System.DateTimeOffset StartTime { get { throw null; } }
        public int? TopCount { get { throw null; } set { } }
    }
    public partial class HardThresholdCondition
    {
        public HardThresholdCondition(Azure.AI.MetricsAdvisor.Models.AnomalyDetectorDirection anomalyDetectorDirection, Azure.AI.MetricsAdvisor.Models.SuppressCondition suppressCondition) { }
        public Azure.AI.MetricsAdvisor.Models.AnomalyDetectorDirection AnomalyDetectorDirection { get { throw null; } }
        public double? LowerBound { get { throw null; } set { } }
        public Azure.AI.MetricsAdvisor.Models.SuppressCondition SuppressCondition { get { throw null; } }
        public double? UpperBound { get { throw null; } set { } }
    }
    public partial class HttpRequestDataFeedSource : Azure.AI.MetricsAdvisor.Models.DataFeedSource
    {
        public HttpRequestDataFeedSource(System.Uri url, string httpHeader, string httpMethod, string payload) { }
    }
    public partial class IncidentRootCause
    {
        internal IncidentRootCause() { }
        public string Description { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.DimensionKey DimensionKey { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Paths { get { throw null; } }
        public double Score { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct IncidentStatus : System.IEquatable<Azure.AI.MetricsAdvisor.Models.IncidentStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public IncidentStatus(string value) { throw null; }
        public static Azure.AI.MetricsAdvisor.Models.IncidentStatus Active { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.IncidentStatus Resolved { get { throw null; } }
        public bool Equals(Azure.AI.MetricsAdvisor.Models.IncidentStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.MetricsAdvisor.Models.IncidentStatus left, Azure.AI.MetricsAdvisor.Models.IncidentStatus right) { throw null; }
        public static implicit operator Azure.AI.MetricsAdvisor.Models.IncidentStatus (string value) { throw null; }
        public static bool operator !=(Azure.AI.MetricsAdvisor.Models.IncidentStatus left, Azure.AI.MetricsAdvisor.Models.IncidentStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class InfluxDbDataFeedSource : Azure.AI.MetricsAdvisor.Models.DataFeedSource
    {
        public InfluxDbDataFeedSource(string connectionString, string database, string username, string password, string query) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct IngestionStatusType : System.IEquatable<Azure.AI.MetricsAdvisor.Models.IngestionStatusType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public IngestionStatusType(string value) { throw null; }
        public static Azure.AI.MetricsAdvisor.Models.IngestionStatusType Error { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.IngestionStatusType Failed { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.IngestionStatusType NoData { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.IngestionStatusType NotStarted { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.IngestionStatusType Paused { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.IngestionStatusType Running { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.IngestionStatusType Scheduled { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.IngestionStatusType Succeeded { get { throw null; } }
        public bool Equals(Azure.AI.MetricsAdvisor.Models.IngestionStatusType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.MetricsAdvisor.Models.IngestionStatusType left, Azure.AI.MetricsAdvisor.Models.IngestionStatusType right) { throw null; }
        public static implicit operator Azure.AI.MetricsAdvisor.Models.IngestionStatusType (string value) { throw null; }
        public static bool operator !=(Azure.AI.MetricsAdvisor.Models.IngestionStatusType left, Azure.AI.MetricsAdvisor.Models.IngestionStatusType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MetricAnomalyAlertConditions
    {
        public MetricAnomalyAlertConditions() { }
        public Azure.AI.MetricsAdvisor.Models.MetricBoundaryCondition MetricBoundaryCondition { get { throw null; } set { } }
        public Azure.AI.MetricsAdvisor.Models.SeverityCondition SeverityCondition { get { throw null; } set { } }
    }
    public partial class MetricAnomalyAlertConfiguration
    {
        public MetricAnomalyAlertConfiguration(string detectionConfigurationId, Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertScope alertScope) { }
        public Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertConditions AlertConditions { get { throw null; } set { } }
        public Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertScope AlertScope { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertSnoozeCondition AlertSnoozeCondition { get { throw null; } set { } }
        public string DetectionConfigurationId { get { throw null; } }
        public bool? UseDetectionResultToFilterAnomalies { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MetricAnomalyAlertConfigurationsOperator : System.IEquatable<Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertConfigurationsOperator>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MetricAnomalyAlertConfigurationsOperator(string value) { throw null; }
        public static Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertConfigurationsOperator And { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertConfigurationsOperator Or { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertConfigurationsOperator Xor { get { throw null; } }
        public bool Equals(Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertConfigurationsOperator other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertConfigurationsOperator left, Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertConfigurationsOperator right) { throw null; }
        public static implicit operator Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertConfigurationsOperator (string value) { throw null; }
        public static bool operator !=(Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertConfigurationsOperator left, Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertConfigurationsOperator right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MetricAnomalyAlertScope
    {
        internal MetricAnomalyAlertScope() { }
        public Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertScopeType ScopeType { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.DimensionKey SeriesGroupInScope { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.TopNGroupScope TopNGroupInScope { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertScope GetScopeForSeriesGroup(Azure.AI.MetricsAdvisor.Models.DimensionKey seriesGroupKey) { throw null; }
        public static Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertScope GetScopeForTopNGroup(Azure.AI.MetricsAdvisor.Models.TopNGroupScope topNGroup) { throw null; }
        public static Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertScope GetScopeForWholeSeries() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MetricAnomalyAlertScopeType : System.IEquatable<Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertScopeType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MetricAnomalyAlertScopeType(string value) { throw null; }
        public static Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertScopeType SeriesGroup { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertScopeType TopN { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertScopeType WholeSeries { get { throw null; } }
        public bool Equals(Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertScopeType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertScopeType left, Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertScopeType right) { throw null; }
        public static implicit operator Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertScopeType (string value) { throw null; }
        public static bool operator !=(Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertScopeType left, Azure.AI.MetricsAdvisor.Models.MetricAnomalyAlertScopeType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MetricAnomalyAlertSnoozeCondition
    {
        public MetricAnomalyAlertSnoozeCondition(int autoSnooze, Azure.AI.MetricsAdvisor.Models.SnoozeScope snoozeScope, bool isOnlyForSuccessive) { }
        public int AutoSnooze { get { throw null; } }
        public bool IsOnlyForSuccessive { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.SnoozeScope SnoozeScope { get { throw null; } }
    }
    public partial class MetricAnomalyFeedback : Azure.AI.MetricsAdvisor.Models.MetricFeedback
    {
        public MetricAnomalyFeedback(string metricId, Azure.AI.MetricsAdvisor.Models.FeedbackDimensionFilter dimensionFilter, System.DateTimeOffset startTime, System.DateTimeOffset endTime, Azure.AI.MetricsAdvisor.Models.AnomalyValue value) { }
        public string AnomalyDetectionConfigurationId { get { throw null; } set { } }
        public Azure.AI.MetricsAdvisor.Models.AnomalyDetectionConfiguration AnomalyDetectionConfigurationSnapshot { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.AnomalyValue AnomalyValue { get { throw null; } }
        public System.DateTimeOffset EndTime { get { throw null; } set { } }
        public System.DateTimeOffset StartTime { get { throw null; } set { } }
    }
    public partial class MetricBoundaryCondition
    {
        public MetricBoundaryCondition(Azure.AI.MetricsAdvisor.Models.BoundaryDirection direction) { }
        public string CompanionMetricId { get { throw null; } set { } }
        public Azure.AI.MetricsAdvisor.Models.BoundaryDirection Direction { get { throw null; } }
        public double? LowerBound { get { throw null; } set { } }
        public bool? TriggerForMissing { get { throw null; } set { } }
        public double? UpperBound { get { throw null; } set { } }
    }
    public partial class MetricChangePointFeedback : Azure.AI.MetricsAdvisor.Models.MetricFeedback
    {
        public MetricChangePointFeedback(string metricId, Azure.AI.MetricsAdvisor.Models.FeedbackDimensionFilter dimensionFilter, System.DateTimeOffset startTime, System.DateTimeOffset endTime, Azure.AI.MetricsAdvisor.Models.ChangePointValue value) { }
        public Azure.AI.MetricsAdvisor.Models.ChangePointValue ChangePointValue { get { throw null; } }
        public System.DateTimeOffset EndTime { get { throw null; } set { } }
        public System.DateTimeOffset StartTime { get { throw null; } set { } }
    }
    public partial class MetricCommentFeedback : Azure.AI.MetricsAdvisor.Models.MetricFeedback
    {
        public MetricCommentFeedback(string metricId, Azure.AI.MetricsAdvisor.Models.FeedbackDimensionFilter dimensionFilter, string comment) { }
        public string Comment { get { throw null; } }
        public System.DateTimeOffset? EndTime { get { throw null; } set { } }
        public System.DateTimeOffset? StartTime { get { throw null; } set { } }
    }
    public partial class MetricDimension
    {
        public MetricDimension(string dimensionName) { }
        public string DimensionDisplayName { get { throw null; } set { } }
        public string DimensionName { get { throw null; } }
    }
    public partial class MetricEnrichedSeriesData
    {
        internal MetricEnrichedSeriesData() { }
        public System.Collections.Generic.IReadOnlyList<double> ExpectedValues { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<bool> IsAnomaly { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<double> LowerBoundaries { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<int> Periods { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.DimensionKey SeriesKey { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<System.DateTimeOffset> Timestamps { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<double> UpperBoundaries { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<double> Values { get { throw null; } }
    }
    public partial class MetricFeedback
    {
        internal MetricFeedback() { }
        public System.DateTimeOffset? CreatedTime { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.FeedbackDimensionFilter DimensionFilter { get { throw null; } }
        public string Id { get { throw null; } }
        public string MetricId { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.FeedbackType Type { get { throw null; } }
        public string UserPrincipal { get { throw null; } }
    }
    public partial class MetricPeriodFeedback : Azure.AI.MetricsAdvisor.Models.MetricFeedback
    {
        public MetricPeriodFeedback(string metricId, Azure.AI.MetricsAdvisor.Models.FeedbackDimensionFilter dimensionFilter, Azure.AI.MetricsAdvisor.Models.PeriodFeedbackValue value) { }
        public Azure.AI.MetricsAdvisor.Models.PeriodType PeriodType { get { throw null; } }
        public int PeriodValue { get { throw null; } }
    }
    public partial class MetricSeriesData
    {
        internal MetricSeriesData() { }
        public Azure.AI.MetricsAdvisor.Models.MetricSeriesDefinition Definition { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<System.DateTimeOffset> Timestamps { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<double> Values { get { throw null; } }
    }
    public partial class MetricSeriesDefinition
    {
        internal MetricSeriesDefinition() { }
        public string MetricId { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.DimensionKey SeriesKey { get { throw null; } }
    }
    public partial class MetricSeriesGroupDetectionCondition : Azure.AI.MetricsAdvisor.Models.MetricWholeSeriesDetectionCondition
    {
        public MetricSeriesGroupDetectionCondition(Azure.AI.MetricsAdvisor.Models.DimensionKey seriesGroupKey) { }
        public Azure.AI.MetricsAdvisor.Models.DimensionKey SeriesGroupKey { get { throw null; } }
    }
    public partial class MetricSingleSeriesDetectionCondition : Azure.AI.MetricsAdvisor.Models.MetricWholeSeriesDetectionCondition
    {
        public MetricSingleSeriesDetectionCondition(Azure.AI.MetricsAdvisor.Models.DimensionKey seriesKey) { }
        public Azure.AI.MetricsAdvisor.Models.DimensionKey SeriesKey { get { throw null; } }
    }
    public partial class MetricWholeSeriesDetectionCondition
    {
        public MetricWholeSeriesDetectionCondition() { }
        public Azure.AI.MetricsAdvisor.Models.ChangeThresholdCondition ChangeThresholdCondition { get { throw null; } set { } }
        public Azure.AI.MetricsAdvisor.Models.DetectionConditionsOperator? CrossConditionsOperator { get { throw null; } set { } }
        public Azure.AI.MetricsAdvisor.Models.HardThresholdCondition HardThresholdCondition { get { throw null; } set { } }
        public Azure.AI.MetricsAdvisor.Models.SmartDetectionCondition SmartDetectionCondition { get { throw null; } set { } }
    }
    public partial class MongoDbDataFeedSource : Azure.AI.MetricsAdvisor.Models.DataFeedSource
    {
        public MongoDbDataFeedSource(string connectionString, string database, string command) { }
    }
    public partial class MySqlDataFeedSource : Azure.AI.MetricsAdvisor.Models.DataFeedSource
    {
        public MySqlDataFeedSource(string connectionString, string query) { }
    }
    public partial class PeriodFeedbackValue
    {
        public PeriodFeedbackValue(Azure.AI.MetricsAdvisor.Models.PeriodType periodType, int periodValue) { }
        public Azure.AI.MetricsAdvisor.Models.PeriodType PeriodType { get { throw null; } set { } }
        public int PeriodValue { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PeriodType : System.IEquatable<Azure.AI.MetricsAdvisor.Models.PeriodType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PeriodType(string value) { throw null; }
        public static Azure.AI.MetricsAdvisor.Models.PeriodType AssignValue { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.PeriodType AutoDetect { get { throw null; } }
        public bool Equals(Azure.AI.MetricsAdvisor.Models.PeriodType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.MetricsAdvisor.Models.PeriodType left, Azure.AI.MetricsAdvisor.Models.PeriodType right) { throw null; }
        public static implicit operator Azure.AI.MetricsAdvisor.Models.PeriodType (string value) { throw null; }
        public static bool operator !=(Azure.AI.MetricsAdvisor.Models.PeriodType left, Azure.AI.MetricsAdvisor.Models.PeriodType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PostgreSqlDataFeedSource : Azure.AI.MetricsAdvisor.Models.DataFeedSource
    {
        public PostgreSqlDataFeedSource(string connectionString, string query) { }
    }
    public partial class SeverityCondition
    {
        public SeverityCondition(Azure.AI.MetricsAdvisor.Models.AnomalySeverity minimumAlertSeverity, Azure.AI.MetricsAdvisor.Models.AnomalySeverity maximumAlertSeverity) { }
        public Azure.AI.MetricsAdvisor.Models.AnomalySeverity MaximumAlertSeverity { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.AnomalySeverity MinimumAlertSeverity { get { throw null; } }
    }
    public partial class SmartDetectionCondition
    {
        public SmartDetectionCondition(double sensitivity, Azure.AI.MetricsAdvisor.Models.AnomalyDetectorDirection anomalyDetectorDirection, Azure.AI.MetricsAdvisor.Models.SuppressCondition suppressCondition) { }
        public Azure.AI.MetricsAdvisor.Models.AnomalyDetectorDirection AnomalyDetectorDirection { get { throw null; } }
        public double Sensitivity { get { throw null; } }
        public Azure.AI.MetricsAdvisor.Models.SuppressCondition SuppressCondition { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SnoozeScope : System.IEquatable<Azure.AI.MetricsAdvisor.Models.SnoozeScope>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SnoozeScope(string value) { throw null; }
        public static Azure.AI.MetricsAdvisor.Models.SnoozeScope Metric { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.SnoozeScope Series { get { throw null; } }
        public bool Equals(Azure.AI.MetricsAdvisor.Models.SnoozeScope other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.MetricsAdvisor.Models.SnoozeScope left, Azure.AI.MetricsAdvisor.Models.SnoozeScope right) { throw null; }
        public static implicit operator Azure.AI.MetricsAdvisor.Models.SnoozeScope (string value) { throw null; }
        public static bool operator !=(Azure.AI.MetricsAdvisor.Models.SnoozeScope left, Azure.AI.MetricsAdvisor.Models.SnoozeScope right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SqlServerDataFeedSource : Azure.AI.MetricsAdvisor.Models.DataFeedSource
    {
        public SqlServerDataFeedSource(string connectionString, string query) { }
    }
    public partial class SuppressCondition
    {
        public SuppressCondition(int minimumNumber, double minimumRatio) { }
        public int MinimumNumber { get { throw null; } }
        public double MinimumRatio { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct TimeMode : System.IEquatable<Azure.AI.MetricsAdvisor.Models.TimeMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public TimeMode(string value) { throw null; }
        public static Azure.AI.MetricsAdvisor.Models.TimeMode AnomalyTime { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.TimeMode CreatedTime { get { throw null; } }
        public static Azure.AI.MetricsAdvisor.Models.TimeMode ModifiedTime { get { throw null; } }
        public bool Equals(Azure.AI.MetricsAdvisor.Models.TimeMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.AI.MetricsAdvisor.Models.TimeMode left, Azure.AI.MetricsAdvisor.Models.TimeMode right) { throw null; }
        public static implicit operator Azure.AI.MetricsAdvisor.Models.TimeMode (string value) { throw null; }
        public static bool operator !=(Azure.AI.MetricsAdvisor.Models.TimeMode left, Azure.AI.MetricsAdvisor.Models.TimeMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class TopNGroupScope
    {
        public TopNGroupScope(int top, int period, int minimumTopCount) { }
        public int MinimumTopCount { get { throw null; } }
        public int Period { get { throw null; } }
        public int Top { get { throw null; } }
    }
    public partial class WebHook : Azure.AI.MetricsAdvisor.Models.AlertingHook
    {
        public WebHook(string name, string endpoint) { }
        public string CertificateKey { get { throw null; } set { } }
        public string CertificatePassword { get { throw null; } set { } }
        public string Endpoint { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> Headers { get { throw null; } set { } }
        public string Password { get { throw null; } set { } }
        public string Username { get { throw null; } set { } }
    }
}
