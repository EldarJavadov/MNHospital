﻿using Microsoft.EntityFrameworkCore;
using MNHospital.Domain.Entities;
using MNHospital.Persistence.Configuration;

namespace MNHospital.Persistence.Context;

public class MNHospitalDBContext : DbContext
{
    public MNHospitalDBContext(DbContextOptions<MNHospitalDBContext> options) : base(options)
    {
        
    }

    public DbSet<Department> Departments { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DeparmentConfiguration).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}