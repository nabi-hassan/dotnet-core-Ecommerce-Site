
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webCalculator.Models
{
    public class ModelsContext : DbContext
    {
        public DbSet<ProductData> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string databasePath = $"{AppDomain.CurrentDomain.SetupInformation.ApplicationBase}\\Data\\ProductsDatabase.db";
            options.UseSqlite(@"Data Source={databasePath}");
        }
    }
}