﻿using System;
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

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Tabulation> Tabulations { get; set; }

    public virtual DbSet<Year> Years { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Name=ConnectionStrings:TestDBContext");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("category_pkey");
        });

        modelBuilder.Entity<Tabulation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tabulation_pkey");
        });

        modelBuilder.Entity<Year>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("year_pkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
