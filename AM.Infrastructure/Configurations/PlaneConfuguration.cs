using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class PlaneConfuguration : IEntityTypeConfiguration<Plane>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Plane> builder)
        {
            builder.HasKey(p => p.PlaneId); //equivalent de key
            builder.ToTable("MyPlanes");
            builder.Property(p => p.Capacity).HasColumnName("Mycapacity");
        }
    }
}
