using System;
using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Infrastructure.Persistance.Configuration
{
    public class FrequentDefectConfiguration: IEntityTypeConfiguration<FrequentDefect>
    { 
        public void Configure(EntityTypeBuilder<FrequentDefect> builder)
        {
            builder.Property(x => x.Title).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.LastModified).HasDefaultValue(DateTime.Now);
        }
    }
}
