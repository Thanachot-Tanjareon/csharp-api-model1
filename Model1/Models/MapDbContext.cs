using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Model1.Models;

public partial class MapDbContext : DbContext
{

    public MapDbContext(DbContextOptions<MapDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
