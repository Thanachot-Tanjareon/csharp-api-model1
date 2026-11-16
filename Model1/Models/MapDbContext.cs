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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
