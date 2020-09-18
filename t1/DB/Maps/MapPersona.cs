using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using t1.Models;

namespace t1.DB
{
    public class MapPersona:IEntityTypeConfiguration<Persona>
    {

        public void Configure(EntityTypeBuilder<Persona>builder)
        {
            builder.ToTable("Persona");
            builder.HasKey(o=>o.id);


        }


    }
}
