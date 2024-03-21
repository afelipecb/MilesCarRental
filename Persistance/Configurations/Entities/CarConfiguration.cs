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
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            //builder.Property(x => x.UserId).IsRequired(false);
            builder.HasData(
                new Car { Id = 1, Brand = "Mazda", Model = "CX50", Year = 2019, Color = "Rojo", SeatNumber = 4, GearBox = "Manual", NumberPlate = "NOE875", Status = false, LocationId = 6 },
                new Car { Id = 2, Brand = "Kia", Model = "Seltos", Year = 2020, Color = "Azul", SeatNumber = 5, GearBox = "Manual", NumberPlate = "FJF811", Status = false, LocationId = 1 },
                new Car { Id = 3, Brand = "Renault", Model = "Stepway", Year = 2021, Color = "Café", SeatNumber = 5, GearBox = "Manual", NumberPlate = "UYQ55", Status = false, LocationId = 4 },
                new Car { Id = 4, Brand = "Chevrolet", Model = "Captiva", Year = 2018, Color = "Azul", SeatNumber = 5, GearBox = "Manual", NumberPlate = "AAC717", Status = false, LocationId = 4 },
                new Car { Id = 5, Brand = "Renault", Model = "Kwid", Year = 2015, Color = "Gris", SeatNumber = 5, GearBox = "Automatico", NumberPlate = "ANO497", Status = false, LocationId = 2 },
                new Car { Id = 6, Brand = "Renault", Model = "Duster", Year = 2023, Color = "Verde", SeatNumber = 4, GearBox = "Manual", NumberPlate = "YUT88", Status = false, LocationId = 6 },
                new Car { Id = 7, Brand = "Mazda", Model = "3", Year = 2016, Color = "Gris", SeatNumber = 5, GearBox = "Manual", NumberPlate = "SGE835", Status = false, LocationId = 7 },
                new Car { Id = 8, Brand = "Kia", Model = "Seltos", Year = 2024, Color = "Gris", SeatNumber = 5, GearBox = "Manual", NumberPlate = "DHY1", Status = false, LocationId = 4 },
                new Car { Id = 9, Brand = "Mazda", Model = "MX5", Year = 2021, Color = "Azul", SeatNumber = 5, GearBox = "Automatico", NumberPlate = "OMP602", Status = false, LocationId = 6 },
                new Car { Id = 10, Brand = "Mazda", Model = "CX90", Year = 2021, Color = "Rojo", SeatNumber = 5, GearBox = "Manual", NumberPlate = "MFK50", Status = false, LocationId = 6 },
                new Car { Id = 11, Brand = "Kia", Model = "Seltos", Year = 2019, Color = "Gris", SeatNumber = 4, GearBox = "Manual", NumberPlate = "WAZ493", Status = false, LocationId = 4 },
                new Car { Id = 12, Brand = "Mazda", Model = "MX5", Year = 2017, Color = "Azul", SeatNumber = 4, GearBox = "Manual", NumberPlate = "POR457", Status = false, LocationId = 1 },
                new Car { Id = 13, Brand = "Mazda", Model = "CX30", Year = 2016, Color = "Gris", SeatNumber = 4, GearBox = "Manual", NumberPlate = "RTW767", Status = false, LocationId = 5 },
                new Car { Id = 14, Brand = "Renault", Model = "Kwid", Year = 2024, Color = "Café", SeatNumber = 5, GearBox = "Manual", NumberPlate = "SUP587", Status = false, LocationId = 3 },
                new Car { Id = 15, Brand = "Renault", Model = "Stepway", Year = 2024, Color = "Negro", SeatNumber = 5, GearBox = "Manual", NumberPlate = "MXR174", Status = false, LocationId = 5 },
                new Car { Id = 16, Brand = "Chevrolet", Model = "Captiva", Year = 2017, Color = "Blanco", SeatNumber = 5, GearBox = "Automatico", NumberPlate = "HVO761", Status = false, LocationId = 4 },
                new Car { Id = 17, Brand = "Mazda", Model = "3", Year = 2014, Color = "Negro", SeatNumber = 5, GearBox = "Manual", NumberPlate = "WMY785", Status = false, LocationId = 4 },
                new Car { Id = 18, Brand = "Mazda", Model = "CX90", Year = 2020, Color = "Azul", SeatNumber = 4, GearBox = "Manual", NumberPlate = "USL352", Status = false, LocationId = 6 },
                new Car { Id = 19, Brand = "Mazda", Model = "CX90", Year = 2016, Color = "Negro", SeatNumber = 5, GearBox = "Manual", NumberPlate = "UPB829", Status = false, LocationId = 5 },
                new Car { Id = 20, Brand = "Mazda", Model = "CX90", Year = 2014, Color = "Amarillo", SeatNumber = 5, GearBox = "Manual", NumberPlate = "CML53", Status = false, LocationId = 7 },
                new Car { Id = 21, Brand = "Mazda", Model = "CX30", Year = 2022, Color = "Café", SeatNumber = 4, GearBox = "Manual", NumberPlate = "LZJ864", Status = false, LocationId = 4 },
                new Car { Id = 22, Brand = "Chevrolet", Model = "Captiva", Year = 2018, Color = "Blanco", SeatNumber = 5, GearBox = "Automatico", NumberPlate = "QDD8", Status = false, LocationId = 5 },
                new Car { Id = 23, Brand = "Renault", Model = "Kwid", Year = 2024, Color = "Gris", SeatNumber = 5, GearBox = "Manual", NumberPlate = "LZE298", Status = false, LocationId = 4 },
                new Car { Id = 24, Brand = "Mazda", Model = "CX50", Year = 2024, Color = "Blanco", SeatNumber = 5, GearBox = "Manual", NumberPlate = "GAG850", Status = false, LocationId = 4 },
                new Car { Id = 25, Brand = "Mazda", Model = "CX50", Year = 2020, Color = "Verde", SeatNumber = 4, GearBox = "Automatico", NumberPlate = "OXO79", Status = false, LocationId = 7 },
                new Car { Id = 26, Brand = "Mazda", Model = "CX50", Year = 2015, Color = "Amarillo", SeatNumber = 4, GearBox = "Automatico", NumberPlate = "HHU651", Status = false, LocationId = 4 },
                new Car { Id = 27, Brand = "Chevrolet", Model = "Cruze", Year = 2014, Color = "Amarillo", SeatNumber = 5, GearBox = "Manual", NumberPlate = "OHI602", Status = false, LocationId = 4 },
                new Car { Id = 28, Brand = "Kia", Model = "Sorento", Year = 2015, Color = "Azul", SeatNumber = 5, GearBox = "Automatico", NumberPlate = "BLQ819", Status = false, LocationId = 5 },
                new Car { Id = 29, Brand = "Renault", Model = "Stepway", Year = 2018, Color = "Azul", SeatNumber = 4, GearBox = "Manual", NumberPlate = "IKM38", Status = false, LocationId = 5 },
                new Car { Id = 30, Brand = "Renault", Model = "Stepway", Year = 2022, Color = "Gris", SeatNumber = 4, GearBox = "Manual", NumberPlate = "CIX522", Status = false, LocationId = 1 },
                new Car { Id = 31, Brand = "Mazda", Model = "CX50", Year = 2017, Color = "Amarillo", SeatNumber = 4, GearBox = "Manual", NumberPlate = "EVS289", Status = false, LocationId = 2 },
                new Car { Id = 32, Brand = "Mazda", Model = "CX90", Year = 2021, Color = "Verde", SeatNumber = 5, GearBox = "Manual", NumberPlate = "OAY436", Status = false, LocationId = 1 },
                new Car { Id = 33, Brand = "Chevrolet", Model = "Cruze", Year = 2022, Color = "Café", SeatNumber = 4, GearBox = "Manual", NumberPlate = "LZG965", Status = false, LocationId = 2 },
                new Car { Id = 34, Brand = "Chevrolet", Model = "Sail", Year = 2023, Color = "Gris", SeatNumber = 5, GearBox = "Manual", NumberPlate = "ZBM568", Status = false, LocationId = 2 },
                new Car { Id = 35, Brand = "Renault", Model = "Stepway", Year = 2014, Color = "Amarillo", SeatNumber = 5, GearBox = "Manual", NumberPlate = "JXY470", Status = false, LocationId = 4 },
                new Car { Id = 36, Brand = "Chevrolet", Model = "Sail", Year = 2023, Color = "Rojo", SeatNumber = 5, GearBox = "Manual", NumberPlate = "HTN235", Status = false, LocationId = 6 },
                new Car { Id = 37, Brand = "Chevrolet", Model = "Captiva", Year = 2019, Color = "Amarillo", SeatNumber = 5, GearBox = "Manual", NumberPlate = "MWW878", Status = false, LocationId = 6 },
                new Car { Id = 38, Brand = "Kia", Model = "Seltos", Year = 2020, Color = "Negro", SeatNumber = 4, GearBox = "Manual", NumberPlate = "QVT836", Status = false, LocationId = 2 },
                new Car { Id = 39, Brand = "Chevrolet", Model = "Captiva", Year = 2022, Color = "Rojo", SeatNumber = 4, GearBox = "Manual", NumberPlate = "ZBT673", Status = false, LocationId = 3 },
                new Car { Id = 40, Brand = "Chevrolet", Model = "Cruze", Year = 2022, Color = "Verde", SeatNumber = 5, GearBox = "Manual", NumberPlate = "LUA444", Status = false, LocationId = 7 },
                new Car { Id = 41, Brand = "Renault", Model = "Duster", Year = 2016, Color = "Negro", SeatNumber = 4, GearBox = "Manual", NumberPlate = "FND190", Status = false, LocationId = 6 },
                new Car { Id = 42, Brand = "Renault", Model = "Oroch", Year = 2014, Color = "Café", SeatNumber = 5, GearBox = "Automatico", NumberPlate = "HXC970", Status = false, LocationId = 3 },
                new Car { Id = 43, Brand = "Chevrolet", Model = "Sail", Year = 2017, Color = "Azul", SeatNumber = 5, GearBox = "Manual", NumberPlate = "WNL967", Status = false, LocationId = 3 },
                new Car { Id = 44, Brand = "Chevrolet", Model = "Spark", Year = 2017, Color = "Negro", SeatNumber = 5, GearBox = "Automatico", NumberPlate = "YFZ27", Status = false, LocationId = 4 },
                new Car { Id = 45, Brand = "Kia", Model = "Seltos", Year = 2023, Color = "Azul", SeatNumber = 4, GearBox = "Manual", NumberPlate = "DGJ695", Status = false, LocationId = 6 },
                new Car { Id = 46, Brand = "Chevrolet", Model = "Spark", Year = 2024, Color = "Amarillo", SeatNumber = 5, GearBox = "Automatico", NumberPlate = "FSO302", Status = false, LocationId = 6 },
                new Car { Id = 47, Brand = "Mazda", Model = "CX90", Year = 2021, Color = "Blanco", SeatNumber = 5, GearBox = "Manual", NumberPlate = "GRR715", Status = false, LocationId = 2 },
                new Car { Id = 48, Brand = "Kia", Model = "Sportage", Year = 2019, Color = "Azul", SeatNumber = 5, GearBox = "Manual", NumberPlate = "DRY956", Status = false, LocationId = 7 },
                new Car { Id = 49, Brand = "Kia", Model = "Sorento", Year = 2017, Color = "Café", SeatNumber = 5, GearBox = "Manual", NumberPlate = "MYE52", Status = false, LocationId = 3 },
                new Car { Id = 50, Brand = "Kia", Model = "Sorento", Year = 2019, Color = "Gris", SeatNumber = 5, GearBox = "Manual", NumberPlate = "HUG777", Status = false, LocationId = 2 },
                new Car { Id = 51, Brand = "Renault", Model = "Kwid", Year = 2021, Color = "Rojo", SeatNumber = 4, GearBox = "Manual", NumberPlate = "AJY630", Status = false, LocationId = 5 },
                new Car { Id = 52, Brand = "Renault", Model = "Duster", Year = 2020, Color = "Negro", SeatNumber = 4, GearBox = "Automatico", NumberPlate = "QXA527", Status = false, LocationId = 1 },
                new Car { Id = 53, Brand = "Mazda", Model = "CX30", Year = 2015, Color = "Blanco", SeatNumber = 5, GearBox = "Manual", NumberPlate = "EPK130", Status = false, LocationId = 2 },
                new Car { Id = 54, Brand = "Chevrolet", Model = "Spark", Year = 2016, Color = "Azul", SeatNumber = 5, GearBox = "Automatico", NumberPlate = "ZRJ866", Status = false, LocationId = 6 },
                new Car { Id = 55, Brand = "Kia", Model = "Sorento", Year = 2020, Color = "Amarillo", SeatNumber = 5, GearBox = "Manual", NumberPlate = "XEM939", Status = false, LocationId = 7 },
                new Car { Id = 56, Brand = "Chevrolet", Model = "Captiva", Year = 2015, Color = "Café", SeatNumber = 5, GearBox = "Manual", NumberPlate = "IJM72", Status = false, LocationId = 3 },
                new Car { Id = 57, Brand = "Kia", Model = "Sorento", Year = 2017, Color = "Blanco", SeatNumber = 4, GearBox = "Manual", NumberPlate = "NAD627", Status = false, LocationId = 4 },
                new Car { Id = 58, Brand = "Chevrolet", Model = "Captiva", Year = 2021, Color = "Café", SeatNumber = 5, GearBox = "Manual", NumberPlate = "RWQ510", Status = false, LocationId = 1 },
                new Car { Id = 59, Brand = "Chevrolet", Model = "Aveo", Year = 2016, Color = "Amarillo", SeatNumber = 5, GearBox = "Manual", NumberPlate = "GWD182", Status = false, LocationId = 7 },
                new Car { Id = 60, Brand = "Kia", Model = "Seltos", Year = 2019, Color = "Verde", SeatNumber = 4, GearBox = "Automatico", NumberPlate = "BRN385", Status = false, LocationId = 2 },
                new Car { Id = 61, Brand = "Kia", Model = "Sorento", Year = 2021, Color = "Azul", SeatNumber = 4, GearBox = "Automatico", NumberPlate = "HFO42", Status = false, LocationId = 5 },
                new Car { Id = 62, Brand = "Renault", Model = "Duster", Year = 2018, Color = "Amarillo", SeatNumber = 4, GearBox = "Manual", NumberPlate = "ZDF894", Status = false, LocationId = 7 },
                new Car { Id = 63, Brand = "Mazda", Model = "CX50", Year = 2020, Color = "Negro", SeatNumber = 4, GearBox = "Automatico", NumberPlate = "PYP943", Status = false, LocationId = 7 },
                new Car { Id = 64, Brand = "Chevrolet", Model = "Captiva", Year = 2014, Color = "Rojo", SeatNumber = 4, GearBox = "Manual", NumberPlate = "RHU790", Status = false, LocationId = 1 },
                new Car { Id = 65, Brand = "Renault", Model = "Duster", Year = 2014, Color = "Blanco", SeatNumber = 5, GearBox = "Manual", NumberPlate = "FMN829", Status = false, LocationId = 2 },
                new Car { Id = 66, Brand = "Kia", Model = "Sorento", Year = 2019, Color = "Rojo", SeatNumber = 5, GearBox = "Manual", NumberPlate = "QHS646", Status = false, LocationId = 6 },
                new Car { Id = 67, Brand = "Renault", Model = "Stepway", Year = 2024, Color = "Blanco", SeatNumber = 5, GearBox = "Manual", NumberPlate = "ALC736", Status = false, LocationId = 7 },
                new Car { Id = 68, Brand = "Renault", Model = "Oroch", Year = 2021, Color = "Café", SeatNumber = 4, GearBox = "Automatico", NumberPlate = "EAA501", Status = false, LocationId = 2 },
                new Car { Id = 69, Brand = "Renault", Model = "Stepway", Year = 2016, Color = "Amarillo", SeatNumber = 4, GearBox = "Manual", NumberPlate = "HJF693", Status = false, LocationId = 2 },
                new Car { Id = 70, Brand = "Mazda", Model = "CX50", Year = 2019, Color = "Azul", SeatNumber = 5, GearBox = "Manual", NumberPlate = "NXS797", Status = false, LocationId = 1 },
                new Car { Id = 71, Brand = "Mazda", Model = "CX90", Year = 2017, Color = "Negro", SeatNumber = 5, GearBox = "Automatico", NumberPlate = "QWA8", Status = false, LocationId = 4 },
                new Car { Id = 72, Brand = "Renault", Model = "Kwid", Year = 2016, Color = "Café", SeatNumber = 5, GearBox = "Manual", NumberPlate = "BDF784", Status = false, LocationId = 5 },
                new Car { Id = 73, Brand = "Chevrolet", Model = "Cruze", Year = 2021, Color = "Café", SeatNumber = 4, GearBox = "Manual", NumberPlate = "ATQ76", Status = false, LocationId = 6 },
                new Car { Id = 74, Brand = "Mazda", Model = "CX50", Year = 2019, Color = "Verde", SeatNumber = 4, GearBox = "Automatico", NumberPlate = "VTD260", Status = false, LocationId = 4 },
                new Car { Id = 75, Brand = "Mazda", Model = "3", Year = 2021, Color = "Gris", SeatNumber = 5, GearBox = "Manual", NumberPlate = "IZG917", Status = false, LocationId = 3 },
                new Car { Id = 76, Brand = "Chevrolet", Model = "Captiva", Year = 2024, Color = "Blanco", SeatNumber = 4, GearBox = "Manual", NumberPlate = "DME308", Status = false, LocationId = 4 },
                new Car { Id = 77, Brand = "Mazda", Model = "3", Year = 2019, Color = "Blanco", SeatNumber = 5, GearBox = "Automatico", NumberPlate = "VCQ146", Status = false, LocationId = 3 },
                new Car { Id = 78, Brand = "Mazda", Model = "CX90", Year = 2023, Color = "Amarillo", SeatNumber = 5, GearBox = "Manual", NumberPlate = "FGP714", Status = false, LocationId = 7 },
                new Car { Id = 79, Brand = "Renault", Model = "Oroch", Year = 2020, Color = "Café", SeatNumber = 4, GearBox = "Manual", NumberPlate = "PIS687", Status = false, LocationId = 5 },
                new Car { Id = 80, Brand = "Chevrolet", Model = "Captiva", Year = 2019, Color = "Verde", SeatNumber = 5, GearBox = "Manual", NumberPlate = "EFV401", Status = false, LocationId = 3 },
                new Car { Id = 81, Brand = "Chevrolet", Model = "Aveo", Year = 2022, Color = "Café", SeatNumber = 5, GearBox = "Manual", NumberPlate = "AIZ187", Status = false, LocationId = 2 },
                new Car { Id = 82, Brand = "Renault", Model = "Duster", Year = 2015, Color = "Negro", SeatNumber = 5, GearBox = "Manual", NumberPlate = "PED984", Status = false, LocationId = 1 },
                new Car { Id = 83, Brand = "Chevrolet", Model = "Spark", Year = 2022, Color = "Rojo", SeatNumber = 4, GearBox = "Manual", NumberPlate = "TAG315", Status = false, LocationId = 7 },
                new Car { Id = 84, Brand = "Kia", Model = "Sportage", Year = 2018, Color = "Azul", SeatNumber = 5, GearBox = "Manual", NumberPlate = "MTB676", Status = false, LocationId = 3 },
                new Car { Id = 85, Brand = "Kia", Model = "Sorento", Year = 2024, Color = "Amarillo", SeatNumber = 5, GearBox = "Manual", NumberPlate = "DUG929", Status = false, LocationId = 4 },
                new Car { Id = 86, Brand = "Renault", Model = "Kwid", Year = 2022, Color = "Rojo", SeatNumber = 4, GearBox = "Manual", NumberPlate = "QUR869", Status = false, LocationId = 2 },
                new Car { Id = 87, Brand = "Mazda", Model = "CX30", Year = 2016, Color = "Amarillo", SeatNumber = 5, GearBox = "Manual", NumberPlate = "SYI867", Status = false, LocationId = 7 },
                new Car { Id = 88, Brand = "Renault", Model = "Oroch", Year = 2019, Color = "Blanco", SeatNumber = 4, GearBox = "Manual", NumberPlate = "JHY656", Status = false, LocationId = 2 },
                new Car { Id = 89, Brand = "Chevrolet", Model = "Aveo", Year = 2022, Color = "Negro", SeatNumber = 4, GearBox = "Manual", NumberPlate = "ZFM365", Status = false, LocationId = 2 },
                new Car { Id = 90, Brand = "Mazda", Model = "MX5", Year = 2023, Color = "Verde", SeatNumber = 5, GearBox = "Manual", NumberPlate = "EWX251", Status = false, LocationId = 5 },
                new Car { Id = 91, Brand = "Chevrolet", Model = "Cruze", Year = 2018, Color = "Rojo", SeatNumber = 5, GearBox = "Manual", NumberPlate = "FUT943", Status = false, LocationId = 5 },
                new Car { Id = 92, Brand = "Mazda", Model = "MX5", Year = 2014, Color = "Verde", SeatNumber = 5, GearBox = "Manual", NumberPlate = "VKQ362", Status = false, LocationId = 7 }
                );
        }
    }
}
