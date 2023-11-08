using System;
using System.Collections.Generic;
using ClassLibraryDatabase1.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassLibraryDatabase1.Data;

public partial class Newttsadmv1Context : DbContext
{
    public Newttsadmv1Context()
    {
    }

    public Newttsadmv1Context(DbContextOptions<Newttsadmv1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Year> Years { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Name=ConnectionStrings:TestDBContext");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Year>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("year_pkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
