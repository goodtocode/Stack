﻿using GoodToCode.Shared.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace GoodToCode.Subjects.Infrastructure
{
    public partial class SubjectsDbContextDeploy : SubjectsDbContext
    {
        public SubjectsDbContextDeploy()
             : base(new DbContextOptionsBuilder<SubjectsDbContext>().Options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionFromAzureSettings("Stack:Shared:SqlConnection"));
                //optionsBuilder.UseCosmos(GetConnectionFromAzureSettings("Stack:Shared:CosmosConnection"));
            }
        }

        public string GetConnectionFromAzureSettings(string configKey)
        {
            var builder = new ConfigurationBuilder();
            builder.AddAzureAppConfigurationWithSentinel(Environment.GetEnvironmentVariable("AppSettingsConnection"), "Stack:Shared:Sentinel");
            var config = builder.Build();

            return config[configKey];
        }
    }
}
