// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Diagnostics;
using System.Threading;

using Azure.Core.Pipeline;

using OpenTelemetry.Trace;

namespace OpenTelemetry.Exporter.AzureMonitor
{
    public class AzureMonitorTraceExporter : ActivityExporter
    {
        private readonly AzureMonitorTransmitter AzureMonitorTransmitter;
        private readonly AzureMonitorExporterOptions options;
        private readonly string instrumentationKey;

        public AzureMonitorTraceExporter(AzureMonitorExporterOptions options)
        {
            this.options = options ?? throw new ArgumentNullException(nameof(options));
            ConnectionString.ConnectionStringParser.GetValues(this.options.ConnectionString, out this.instrumentationKey, out _);

            this.AzureMonitorTransmitter = new AzureMonitorTransmitter(options);
        }

        /// <inheritdoc/>
        public override ExportResult Export(in Batch<Activity> batch)
        {
            try
            {
                var telemetryItems = AzureMonitorConverter.Convert(batch, this.instrumentationKey);

                // TODO: Handle return value, it can be converted as metrics.
                // TODO: Validate CancellationToken and async pattern here.
                this.AzureMonitorTransmitter.TrackAsync(telemetryItems, false, CancellationToken.None).EnsureCompleted();
                return ExportResult.Success;
            }
            catch (Exception ex)
            {
                AzureMonitorTraceExporterEventSource.Log.FailedExport(ex);
                return ExportResult.Failure;
            }
        }
    }
}
