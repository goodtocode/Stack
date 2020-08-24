﻿using GoodToCode.Shared.Specs;
using GoodToCode.Subjects.Infrastructure;
using GoodToCode.Subjects.Models;
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
    public class BusinessCreateSteps : ICrudSteps<Business>
    {
        private readonly SubjectsDbContext _dbContext;
        private readonly string _connectionString;
        private readonly IConfiguration _config;
        private int _rowsAffected;
        
        public Guid SutKey { get; private set; }
        public Business Sut { get; private set; }
        public IList<Business> RecycleBin { get; private set; } = new List<Business>();

        public BusinessCreateSteps()
        {
            _config = new ConfigurationFactory("Subjects.Specs").Create();
            _connectionString = new ConnectionStringFactory(_config).Create();
            _dbContext = new DbContextFactory(_connectionString).Create();
        }

        [Given(@"A new Business has been created")]
        public void GivenANewBusinessHasBeenCreated()
        {
            SutKey = Guid.NewGuid();
            Sut = new Business()
            {
                BusinessKey = SutKey,
                BusinessName = "BusinessCreateSteps.cs Test",
                TaxNumber = string.Empty,
                
                
            };
        }

        [When(@"the Business does not exist in persistence by key")]
        public async Task WhenTheBusinessDoesNotExistInPersistenceByKey()
        {
            var found = await _dbContext.Business.Where(x => x.BusinessKey == SutKey).AnyAsync();
            Assert.IsFalse(found);
        }

        [When(@"Business is inserted via Entity Framework")]
        public async Task WhenBusinessIsInsertedViaEntityFramework()
        {
            _dbContext.Business.Add(Sut);
            _rowsAffected = await _dbContext.SaveChangesAsync();
            SutKey = Sut.BusinessKey;
            Assert.IsTrue(_rowsAffected > 0);
        }

        [Then(@"the new business can be queried by key")]
        public async Task ThenTheNewBusinessCanBeQueriedByKey()
        {
            var found = await _dbContext.Business.Where(x => x.BusinessKey == SutKey).AnyAsync();
            Assert.IsTrue(found);
        }

        [TestCleanup]
        public async Task Cleanup()
        {
            foreach(var item in RecycleBin)
            {
                _dbContext.Entry(item).State = EntityState.Deleted;
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}