using System;
using Microsoft.EntityFrameworkCore;
namespace HRM_Human
 
{
    public class MemDb : DbContext
    {
        public MemDb(DbContextOptions<MemDb> options) : base(options){ }
        public DbSet<Mem> Mems => Set<Mem>();
    }
}
