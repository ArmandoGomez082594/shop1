﻿

namespace shop1.Web.Data
{
    
    using Microsoft.EntityFrameworkCore;
    using shop1.Web.Data.Entities;

    public class DataContext: DbContext
    {

        public DbSet<Product> Products{ get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

    }
}
