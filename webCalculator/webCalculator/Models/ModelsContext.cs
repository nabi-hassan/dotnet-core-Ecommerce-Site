
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
            => options.UseSqlite(@"Data Source=D:\CSharp\dotnet-core-Ecommerce-Site\webCalculator\webCalculator\Data\ProductsDatabase.db");
    }
}
