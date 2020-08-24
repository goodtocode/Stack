﻿using GoodToCode.Subjects.Infrastructure;
using GoodToCode.Subjects.Models;
using GoodToCode.Shared.Specs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace GoodToCode.Subjects.Specs
{
    [Binding]
    public class BusinessAggregateSteps : IAggregateSteps<AssociateAggregate>
    {
        private readonly SubjectsDbContext _dbContext;
        private readonly string _connectionString;
        private readonly IConfiguration _config;
        private int _rowsAffected;

        public Guid SutKey { get; private set; }
        public AssociateAggregate Aggregate { get; private set; }
        public IList<AssociateAggregate> RecycleBin { get; private set; }

        public Business SutBusiness { get; private set; }

        public BusinessAggregateSteps()
        {
            _config = new ConfigurationFactory("Subjects.Specs").Create();
            _connectionString = new ConnectionStringFactory(_config).Create();
            _dbContext = new DbContextFactory(_connectionString).Create();
            Aggregate = new AssociateAggregate(_dbContext);
        }

        [Given(@"A new Business is created for the aggregate")]
        public void GivenANewBusinessIsCreatedForTheAggregate()
        {
            SutKey = Guid.NewGuid();
            SutBusiness = new Business()
            {
                BusinessKey = SutKey,
                BusinessName = "BusinessAggregateSteps.cs Test"
            };
        }

        [When(@"the business does not exist in persistence")]
        public async Task WhenTheBusinessDoesNotExistInPersistence()
        {
            var found = await _dbContext.Business.Where(x => x.BusinessKey == SutKey).AnyAsync();
            Assert.IsFalse(found);
        }

        [When(@"the business is saved via the aggregate")]
        public async Task WhenTheBusinessIsSavedViaTheAggregate()
        {
            _rowsAffected = await Aggregate.BusinessSaveAsync(SutBusiness);
            SutKey = SutBusiness.BusinessKey;
            Assert.IsTrue(_rowsAffected > 0);
        }

        [Then(@"the aggregate inserted business can be queried by key")]
        public async Task ThenTheAggregateInsertedBusinessCanBeQueriedByKey()
        {
            var found = await _dbContext.Business.Where(x => x.BusinessKey == SutKey).AnyAsync();
            Assert.IsTrue(found);
        }

        [TestCleanup]
        public async Task Cleanup()
        {
            await Aggregate.BusinessDeleteAsync(SutBusiness);
        }
    }
}