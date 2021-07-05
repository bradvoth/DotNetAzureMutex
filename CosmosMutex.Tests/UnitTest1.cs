using System;
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
        public void Test1()
        {
            Assert.Pass();
        }
    }
}