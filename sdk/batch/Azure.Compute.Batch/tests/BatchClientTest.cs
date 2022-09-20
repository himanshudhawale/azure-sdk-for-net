// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Compute.Batch.Models;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.Compute.Batch.Tests
{
    public class BatchClientTest: RecordedTestBase<BatchClientTestEnvironment>
    {
        public BatchClientTest(bool isAsync) : base(isAsync)
        {
        }

        protected BatchClient CreateClient()
        {
            HttpClientHandler httpHandler = new();
            httpHandler.ServerCertificateCustomValidationCallback = (_, _, _, _) =>
            {
                return true;
            };

            BatchClientOptions options = new BatchClientOptions(BatchClientOptions.ServiceVersion.V2022_01_01_15_0);
            options.Transport = new HttpClientTransport(httpHandler);

            BatchClient batchClient = InstrumentClient(new BatchClient(TestEnvironment.Endpoint, TestEnvironment.Credential, InstrumentClientOptions(options)));
            batchClient.BatchUrl = TestEnvironment.Endpoint;
            foreach (PropertyInfo property in batchClient.GetType().GetProperties())
            {
                if (property.GetType() == typeof(BaseClient))
                {
                    BaseClient baseClient = property.GetValue(typeof(BaseClient)) as BaseClient;
                    baseClient.ContentHandler = GetContentFromResponse;
                }
            }

            return batchClient;
        }

        [RecordedTest]
        public void TestOperation()
        {
            BatchClient client = CreateClient();
            client.JobClient.AddJob(new Job { Id = "testjob", PoolInfo = new PoolInformation { PoolId = "managerPool" } });
            Job job = client.JobClient.ListJobs().First();
            Assert.Equals(job.Id, "testjob2");
        }

        // Add live tests here. If you need more information please refer https://github.com/Azure/azure-sdk-for-net/blob/main/CONTRIBUTING.md#live-testing and
        // here are some examples: https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/synapse/Azure.Analytics.Synapse.AccessControl/tests/AccessControlClientLiveTests.cs.

        #region Helpers

        private static BinaryData GetContentFromResponse(Response r)
        {
            // Workaround azure/azure-sdk-for-net#21048, which prevents .Content from working when dealing with responses
            // from the playback system.

            MemoryStream ms = new MemoryStream();
            r.ContentStream.CopyTo(ms);
            return new BinaryData(ms.ToArray());
        }
        #endregion
    }
}
