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

using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Moq;
using System.Management.Automation;
using Xunit;

namespace Microsoft.Azure.Commands.Batch.Test.Accounts
{
    public class RemoveBatchAccountCommandTests
    {
        private RemoveBatchAccountCommand cmdlet;
        private Mock<BatchClient> batchClientMock;
        private Mock<ICommandRuntime> commandRuntimeMock;

        public RemoveBatchAccountCommandTests()
        {
            batchClientMock = new Mock<BatchClient>();
            commandRuntimeMock = new Mock<ICommandRuntime>();
            cmdlet = new RemoveBatchAccountCommand()
            {
                CommandRuntime = commandRuntimeMock.Object,
                BatchClient = batchClientMock.Object
            };
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void RemoveBatchAccountWithResourceLookup()
        {
            RemoveBatchAccountTest(true);
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void RemoveBatchAccountWithoutResourceLookup()
        {
            RemoveBatchAccountTest(false);
        }

        private void RemoveBatchAccountTest(bool lookupAccountResource)
        {
            string accountName = "account01";
            string resourceGroup = "resourceGroup";

            OperationResponse deleteResponse = new OperationResponse();
            batchClientMock.Setup(b => b.DeleteAccount(resourceGroup, accountName)).Returns(deleteResponse);

            cmdlet.AccountName = accountName;

            if (lookupAccountResource)
            {
                cmdlet.ResourceGroupName = null;
                batchClientMock.Setup(b => b.GetGroupForAccountNoThrow(accountName)).Returns(resourceGroup);
            }
            else
            {
                cmdlet.ResourceGroupName = resourceGroup;
            }

            cmdlet.Force = true;
            commandRuntimeMock.Setup(f => f.ShouldProcess(It.IsAny<string>(), It.IsAny<string>())).Returns(true);
            cmdlet.ExecuteCmdlet();

            batchClientMock.Verify(b => b.DeleteAccount(resourceGroup, accountName), Times.Once());
        }
    }
}
