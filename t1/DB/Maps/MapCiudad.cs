using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using t1.Models;

namespace t1.DB.Maps
{
    public class MapCiudad : IEntityTypeConfiguration<Ciudad>
    {
        public void Configure(EntityTypeBuilder<Ciudad> builder)
        {
            builder.ToTable("Ciudad");
            builder.HasKey(o=>o.id);


            builder.HasOne(o => o.persona).WithMany(o=>o.Ciudad).HasForeignKey(o=>o.idPersona);
        }


    }
}
