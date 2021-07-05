using System;
using System.Threading;
using System.Threading.Tasks;
using Interfaces;
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace CosmosMutex.Tests
{
    public class Tests
    {
        private string _cosmosCollection;
        private string _cosmosDatabase;
        private string _cosmosConnectionString;

        [SetUp]
        public void Setup()
        {
            var configuration = new ConfigurationBuilder().AddUserSecrets<Tests>()
                .Build();
            _cosmosConnectionString = configuration["Cosmos:ConnectionString"];
            _cosmosDatabase = configuration["Cosmos:Database"];
            _cosmosCollection = configuration["Cosmos:Container"];

        }

        [Test]
        public async Task Test1()
        {
            var client = new CosmosClient(_cosmosConnectionString);
            var container = client.GetContainer(_cosmosDatabase, _cosmosCollection);
            using var mutex = new CosmosMutex.AzureMutex(container, "xyz");
            await mutex.Lock(10);
            await mutex.Renew(100);
            Assert.ThrowsAsync<LockFailedException>(async () =>
                {
                    await mutex.Lock(10);
                }
            );
            using var mutex2 = new AzureMutex(container, "xyz");
            Assert.ThrowsAsync<LockFailedException>(async () =>
                {
                    await mutex2.Lock(10);
                }
            );
            Assert.ThrowsAsync<LockFailedException>(async () =>
                {
                    await mutex2.Renew(10);
                }
            );

        }
    }
}