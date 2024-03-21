using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Configurations.Entities
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User { Id = 1, Name = " Hugo García", DocumentId = 6788729 },
                new User { Id = 2, Name = " Martín Rodríguez", DocumentId = 65772969 },
                new User { Id = 3, Name = " Lucas González", DocumentId = 38745615 },
                new User { Id = 4, Name = " Mateo Fernández", DocumentId = 76848338 },
                new User { Id = 5, Name = " Leo López", DocumentId = 56040483 },
                new User { Id = 6, Name = " Daniel Martínez", DocumentId = 16904163 },
                new User { Id = 7, Name = " Alejandro Sánchez", DocumentId = 16426418 },
                new User { Id = 8, Name = " Pablo Pérez", DocumentId = 14780125 },
                new User { Id = 9, Name = " Manuel Gómez", DocumentId = 43625518 },
                new User { Id = 10, Name = " Álvaro Martín", DocumentId = 23265025 },
                new User { Id = 11, Name = " Adrián Jimenez", DocumentId = 48842146 },
                new User { Id = 12, Name = " David Hernández", DocumentId = 95791823 },
                new User { Id = 13, Name = " Mario Ruiz", DocumentId = 65087482 },
                new User { Id = 14, Name = " Enzo Díaz", DocumentId = 4191223 },
                new User { Id = 15, Name = " Diego Moreno", DocumentId = 33925090 },
                new User { Id = 16, Name = " Marcos Muñoz", DocumentId = 14120076 },
                new User { Id = 17, Name = " Izan Álvarez", DocumentId = 49253492 },
                new User { Id = 18, Name = " Javier Romero", DocumentId = 52519468 },
                new User { Id = 19, Name = " Marco Gutiérrez", DocumentId = 16057111 },
                new User { Id = 20, Name = " Álex Alonso", DocumentId = 91200892 },
                new User { Id = 21, Name = " Bruno Navarro", DocumentId = 43707990 },
                new User { Id = 22, Name = " Oliver Torres", DocumentId = 24476816 }
                );
        }
    }
}
