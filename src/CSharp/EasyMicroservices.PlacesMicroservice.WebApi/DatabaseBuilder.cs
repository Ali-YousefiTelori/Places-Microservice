﻿using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.Cores.Relational.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EasyMicroservices.PlacesMicroservice
{
    public class DatabaseBuilder : EntityFrameworkCoreDatabaseBuilder
    {
        public DatabaseBuilder(IConfiguration configuration, IDatabaseWidgetManager widgetManager) : base(configuration, widgetManager)
        {
        }

        public override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var entity = GetEntity();
            if (entity.IsSqlServer())
                optionsBuilder.UseSqlServer(entity.ConnectionString);
            else if (entity.IsInMemory())
                optionsBuilder.UseInMemoryDatabase("Places");
        }
    }
}
