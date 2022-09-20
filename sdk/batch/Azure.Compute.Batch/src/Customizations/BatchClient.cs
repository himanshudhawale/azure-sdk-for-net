﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core.Pipeline;
using Azure.Core;

namespace Azure.Compute.Batch
{
    public partial class BatchClient
    {
        private AccountClient accountClient;
        private ApplicationClient applicationClient;
        private CertificateClient certificateClient;
        private ComputeNodeClient computeNodeClient;
        private ComputeNodeExtensionClient computeNodeExtensionClient;
        private FileClient fileClient;
        private JobClient jobClient;
        private JobScheduleClient jobScheduleClient;
        private PoolClient poolClient;
        private TaskClient taskClient;

#pragma warning disable CA1056 // URI-like properties should not be strings
        public string BatchUrl { get; set; }
#pragma warning restore CA1056 // URI-like properties should not be strings

        #region Subclient Properties

        public AccountClient AccountClient
        {
            get
            {
                if (accountClient == null)
                {
                    accountClient = CreateAccountClient();
                }

                return accountClient;
            }
        }

        public ApplicationClient ApplicationClient
        {
            get
            {
                if (applicationClient == null)
                {
                    applicationClient = CreateApplicationClient();
                }

                return applicationClient;
            }
        }

        public CertificateClient CertificateClient
        {
            get
            {
                if (certificateClient == null)
                {
                    certificateClient = CreateCertificateClient();
                }

                return certificateClient;
            }
        }

        public ComputeNodeClient ComputeNodeClient
        {
            get
            {
                if (computeNodeClient == null)
                {
                    computeNodeClient = CreateComputeNodeClient();
                }

                return computeNodeClient;
            }
        }

        public ComputeNodeExtensionClient ComputeNodeExtensionClient
        {
            get
            {
                if (computeNodeExtensionClient == null)
                {
                    computeNodeExtensionClient = CreateComputeNodeExtensionClient();
                }

                return computeNodeExtensionClient;
            }
        }

        public FileClient FileClient
        {
            get
            {
                if (fileClient == null)
                {
                    fileClient = CreateFileClient();
                }

                return fileClient;
            }
        }

        public JobClient JobClient
        {
            get
            {
                if (jobClient == null)
                {
                    jobClient = CreateJobClient();
                }

                return jobClient;
            }
        }

        public JobScheduleClient JobScheduleClient
        {
            get
            {
                if (jobScheduleClient == null)
                {
                    jobScheduleClient = CreateJobScheduleClient();
                }

                return jobScheduleClient;
            }
        }

        public PoolClient PoolClient
        {
            get
            {
                if (poolClient == null)
                {
                    poolClient = CreatePoolClient();
                }

                return poolClient;
            }
        }

        public TaskClient TaskClient
        {
            get
            {
                if (taskClient == null)
                {
                    taskClient = CreateTaskClient();
                }

                return taskClient;
            }
        }

        #endregion Subclient Properties

        private BatchClient(TokenCredential credential) : this(credential, new BatchClientOptions())
        {
        }

        private BatchClient(TokenCredential credential, BatchClientOptions options)
        {
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new BatchClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
        }

#pragma warning disable CA1054 // URI-like parameters should not be strings
        public BatchClient(string batchUrl, TokenCredential credential, BatchClientOptions options = null)
#pragma warning restore CA1054 // URI-like parameters should not be strings
            : this(credential, options)
        {
            this.BatchUrl = batchUrl;
        }

        #region Subclient Factories

        public AccountClient CreateAccountClient()
        {
            return this.GetAccountClientClient(BatchUrl);
        }

        public ApplicationClient CreateApplicationClient()
        {
            return this.GetApplicationClientClient(BatchUrl);
        }

        public CertificateClient CreateCertificateClient()
        {
            return this.GetCertificateClientClient(BatchUrl);
        }

        public ComputeNodeClient CreateComputeNodeClient()
        {
            return this.GetComputeNodeClientClient(BatchUrl);
        }

        public ComputeNodeExtensionClient CreateComputeNodeExtensionClient()
        {
            return this.GetComputeNodeExtensionClientClient(BatchUrl);
        }

        public FileClient CreateFileClient()
        {
            return this.GetFileClientClient(BatchUrl);
        }

        public JobClient CreateJobClient()
        {
            return this.GetJobClientClient(BatchUrl);
        }

        public JobScheduleClient CreateJobScheduleClient()
        {
            return this.GetJobScheduleClientClient(BatchUrl);
        }

        public PoolClient CreatePoolClient()
        {
            return this.GetPoolClientClient(BatchUrl);
        }

        public TaskClient CreateTaskClient()
        {
            return this.GetTaskClientClient(BatchUrl);
        }

        #endregion Subclient Factories
    }
}
