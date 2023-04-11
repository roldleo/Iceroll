using IceRoll.Models;
using Microsoft.EntityFrameworkCore;
using Rollice.Data;

public class RolliceContext : DbContext
{
    public DbSet<Product> Products{get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data source=Rollice.db");
    }

    protected override void OnModelCreating(ModelBuilder
modelBuilder)
 {
 modelBuilder.ApplyConfiguration(new ProductConfiguration()).Seed();
 }

}