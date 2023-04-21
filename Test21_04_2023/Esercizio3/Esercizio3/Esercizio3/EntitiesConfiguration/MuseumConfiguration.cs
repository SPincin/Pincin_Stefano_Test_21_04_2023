using Esercizio3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio3.EntitiesConfiguration
{
    internal class MuseumConfiguration : IEntityTypeConfiguration<Museum>
    {
        public void Configure(EntityTypeBuilder<Museum> entity)
        {
            throw new NotImplementedException();
        }
    }
}
