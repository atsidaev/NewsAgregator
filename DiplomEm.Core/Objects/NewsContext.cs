﻿using DiplomEm.Core.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
namespace DiplomEm.Core
{
    public class NewsContext :DbContext
    {
        public NewsContext() : base(WebConfigurationManager.ConnectionStrings["storage"].ToString())
        {  }

        public DbSet<News> NewsSet { get; set; }
        public DbSet<NewsSource> SourceSet { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new NewsMap());
            modelBuilder.Configurations.Add(new SourceMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
