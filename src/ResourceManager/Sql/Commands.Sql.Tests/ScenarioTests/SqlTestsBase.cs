﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using Microsoft.WindowsAzure.Management.Storage;
using Microsoft.WindowsAzure.Management.WebSites;
using Microsoft.WindowsAzure.Testing;
using Microsoft.Azure.Management.Sql;
using Microsoft.Azure.Management.Resources;

namespace Microsoft.WindowsAzure.Commands.ScenarioTest.SqlTests
{
    public class SqlTestsBase
    {
        private EnvironmentSetupHelper helper;

        protected SqlTestsBase()
        {
            helper = new EnvironmentSetupHelper();
        }

        protected void SetupManagementClients()
        {
            var sqlCSMClient = GetSqlCSMClient(); // to interact with the security endpoints
            var storageClient = GetStorageClient();
            var resourcesClient = GetResourcesClient();
            helper.SetupSomeOfManagementClients(sqlCSMClient, storageClient, resourcesClient);
        }

        protected void RunPowerShellTest(params string[] scripts)
        {
            // Enable undo functionality as well as mock recording
            using (UndoContext context = UndoContext.Current)
            {
                // Configure recordings
                context.Start(TestUtilities.GetCallingClass(2), TestUtilities.GetCurrentMethodName(2));
               // context.Start(TestUtilities.GetCallingClass(), TestUtilities.GetCurrentMethodName());

                // See explanation below
                SetupManagementClients();

                // Specify either ResourceManager or ServiceManagement mode
                helper.SetupEnvironment(AzureModule.AzureResourceManager);

                // Add all ps1 files used in the test
                helper.SetupModules(AzureModule.AzureResourceManager, "ScenarioTests\\Common.ps1",
                    "ScenarioTests\\" + this.GetType().Name + ".ps1");

                // Run actual test
                helper.RunPowerShellTest(scripts);
            }
        }

        protected SqlManagementClient GetSqlCSMClient()
        {
            return TestBase.GetServiceClient<SqlManagementClient>(new CSMTestEnvironmentFactory());
        }

        protected StorageManagementClient GetStorageClient()
        {
            return TestBase.GetServiceClient<StorageManagementClient>(new RDFETestEnvironmentFactory());
        }

        protected ResourceManagementClient GetResourcesClient()
        {
            return TestBase.GetServiceClient<ResourceManagementClient>(new CSMTestEnvironmentFactory());
        }
    }
}
