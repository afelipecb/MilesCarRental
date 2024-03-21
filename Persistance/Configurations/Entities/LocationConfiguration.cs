using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Configurations.Entities
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.HasData(
                new Location
                {
                    Id = 1,
                    City = "Bogota",
                    NameLocation = "Chico Norte",
                    Adress = "Carrera 23 # 45"
                },
                new Location
                {
                    Id = 2,
                    City = "Bogota",
                    NameLocation = "Bosa",
                    Adress = "Carrera 12 # 45"
                },
                new Location
                {
                    Id = 3,
                    City = "Bogota",
                    NameLocation = "Usme",
                    Adress = "Carrera 34 # 45"
                },
                new Location
                {
                    Id = 4,
                    City = "Medellin",
                    NameLocation = "Provenza",
                    Adress = "Carrera 55 # 32"
                },
                new Location
                {
                    Id = 5,
                    City = "Medellin",
                    NameLocation = "Poblado",
                    Adress = "Carrera 12 # 32"
                },
                new Location
                {
                    Id = 6,
                    City = "Barranquilla",
                    NameLocation = "Barrio Abajo",
                    Adress = "Av Murillo # 15"
                },
                new Location
                {
                    Id = 7,
                    City = "Barranquilla",
                    NameLocation = "Malecon",
                    Adress = "Carrera 4 # 40"
                }
                ) ;
        }
    }
}
