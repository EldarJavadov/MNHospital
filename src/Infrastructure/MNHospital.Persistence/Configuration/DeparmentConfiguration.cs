using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MNHospital.Domain.Entities;

namespace MNHospital.Persistence.Configuration;

public class DeparmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.Property(d => d.Name)
            .IsRequired()
            .HasMaxLength(255);
    }
}
