using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class secondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Users_UserId",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "Transmision",
                table: "Cars",
                newName: "GearBox");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Cars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "Color", "GearBox", "LocationId", "Model", "NumberPlate", "SeatNumber", "UserId", "Year" },
                values: new object[,]
                {
                    { 1, "Mazda", "Rojo", "Manual", 6, "CX50", "NOE875", 4, null, 2019 },
                    { 2, "Kia", "Azul", "Manual", 1, "Seltos", "FJF811", 5, null, 2020 },
                    { 3, "Renault", "Café", "Manual", 4, "Stepway", "UYQ55", 5, null, 2021 },
                    { 4, "Chevrolet", "Azul", "Manual", 4, "Captiva", "AAC717", 5, null, 2018 },
                    { 5, "Renault", "Gris", "Automatico", 2, "Kwid", "ANO497", 5, null, 2015 },
                    { 6, "Renault", "Verde", "Manual", 6, "Duster", "YUT88", 4, null, 2023 },
                    { 7, "Mazda", "Gris", "Manual", 7, "3", "SGE835", 5, null, 2016 },
                    { 8, "Kia", "Gris", "Manual", 4, "Seltos", "DHY1", 5, null, 2024 },
                    { 9, "Mazda", "Azul", "Automatico", 6, "MX5", "OMP602", 5, null, 2021 },
                    { 10, "Mazda", "Rojo", "Manual", 6, "CX90", "MFK50", 5, null, 2021 },
                    { 11, "Kia", "Gris", "Manual", 4, "Seltos", "WAZ493", 4, null, 2019 },
                    { 12, "Mazda", "Azul", "Manual", 1, "MX5", "POR457", 4, null, 2017 },
                    { 13, "Mazda", "Gris", "Manual", 5, "CX30", "RTW767", 4, null, 2016 },
                    { 14, "Renault", "Café", "Manual", 3, "Kwid", "SUP587", 5, null, 2024 },
                    { 15, "Renault", "Negro", "Manual", 5, "Stepway", "MXR174", 5, null, 2024 },
                    { 16, "Chevrolet", "Blanco", "Automatico", 4, "Captiva", "HVO761", 5, null, 2017 },
                    { 17, "Mazda", "Negro", "Manual", 4, "3", "WMY785", 5, null, 2014 },
                    { 18, "Mazda", "Azul", "Manual", 6, "CX90", "USL352", 4, null, 2020 },
                    { 19, "Mazda", "Negro", "Manual", 5, "CX90", "UPB829", 5, null, 2016 },
                    { 20, "Mazda", "Amarillo", "Manual", 7, "CX90", "CML53", 5, null, 2014 },
                    { 21, "Mazda", "Café", "Manual", 4, "CX30", "LZJ864", 4, null, 2022 },
                    { 22, "Chevrolet", "Blanco", "Automatico", 5, "Captiva", "QDD8", 5, null, 2018 },
                    { 23, "Renault", "Gris", "Manual", 4, "Kwid", "LZE298", 5, null, 2024 },
                    { 24, "Mazda", "Blanco", "Manual", 4, "CX50", "GAG850", 5, null, 2024 },
                    { 25, "Mazda", "Verde", "Automatico", 7, "CX50", "OXO79", 4, null, 2020 },
                    { 26, "Mazda", "Amarillo", "Automatico", 4, "CX50", "HHU651", 4, null, 2015 },
                    { 27, "Chevrolet", "Amarillo", "Manual", 4, "Cruze", "OHI602", 5, null, 2014 },
                    { 28, "Kia", "Azul", "Automatico", 5, "Sorento", "BLQ819", 5, null, 2015 },
                    { 29, "Renault", "Azul", "Manual", 5, "Stepway", "IKM38", 4, null, 2018 },
                    { 30, "Renault", "Gris", "Manual", 1, "Stepway", "CIX522", 4, null, 2022 },
                    { 31, "Mazda", "Amarillo", "Manual", 2, "CX50", "EVS289", 4, null, 2017 },
                    { 32, "Mazda", "Verde", "Manual", 1, "CX90", "OAY436", 5, null, 2021 },
                    { 33, "Chevrolet", "Café", "Manual", 2, "Cruze", "LZG965", 4, null, 2022 },
                    { 34, "Chevrolet", "Gris", "Manual", 2, "Sail", "ZBM568", 5, null, 2023 },
                    { 35, "Renault", "Amarillo", "Manual", 4, "Stepway", "JXY470", 5, null, 2014 },
                    { 36, "Chevrolet", "Rojo", "Manual", 6, "Sail", "HTN235", 5, null, 2023 },
                    { 37, "Chevrolet", "Amarillo", "Manual", 6, "Captiva", "MWW878", 5, null, 2019 },
                    { 38, "Kia", "Negro", "Manual", 2, "Seltos", "QVT836", 4, null, 2020 },
                    { 39, "Chevrolet", "Rojo", "Manual", 3, "Captiva", "ZBT673", 4, null, 2022 },
                    { 40, "Chevrolet", "Verde", "Manual", 7, "Cruze", "LUA444", 5, null, 2022 },
                    { 41, "Renault", "Negro", "Manual", 6, "Duster", "FND190", 4, null, 2016 },
                    { 42, "Renault", "Café", "Automatico", 3, "Oroch", "HXC970", 5, null, 2014 },
                    { 43, "Chevrolet", "Azul", "Manual", 3, "Sail", "WNL967", 5, null, 2017 },
                    { 44, "Chevrolet", "Negro", "Automatico", 4, "Spark", "YFZ27", 5, null, 2017 },
                    { 45, "Kia", "Azul", "Manual", 6, "Seltos", "DGJ695", 4, null, 2023 },
                    { 46, "Chevrolet", "Amarillo", "Automatico", 6, "Spark", "FSO302", 5, null, 2024 },
                    { 47, "Mazda", "Blanco", "Manual", 2, "CX90", "GRR715", 5, null, 2021 },
                    { 48, "Kia", "Azul", "Manual", 7, "Sportage", "DRY956", 5, null, 2019 },
                    { 49, "Kia", "Café", "Manual", 3, "Sorento", "MYE52", 5, null, 2017 },
                    { 50, "Kia", "Gris", "Manual", 2, "Sorento", "HUG777", 5, null, 2019 },
                    { 51, "Renault", "Rojo", "Manual", 5, "Kwid", "AJY630", 4, null, 2021 },
                    { 52, "Renault", "Negro", "Automatico", 1, "Duster", "QXA527", 4, null, 2020 },
                    { 53, "Mazda", "Blanco", "Manual", 2, "CX30", "EPK130", 5, null, 2015 },
                    { 54, "Chevrolet", "Azul", "Automatico", 6, "Spark", "ZRJ866", 5, null, 2016 },
                    { 55, "Kia", "Amarillo", "Manual", 7, "Sorento", "XEM939", 5, null, 2020 },
                    { 56, "Chevrolet", "Café", "Manual", 3, "Captiva", "IJM72", 5, null, 2015 },
                    { 57, "Kia", "Blanco", "Manual", 4, "Sorento", "NAD627", 4, null, 2017 },
                    { 58, "Chevrolet", "Café", "Manual", 1, "Captiva", "RWQ510", 5, null, 2021 },
                    { 59, "Chevrolet", "Amarillo", "Manual", 7, "Aveo", "GWD182", 5, null, 2016 },
                    { 60, "Kia", "Verde", "Automatico", 2, "Seltos", "BRN385", 4, null, 2019 },
                    { 61, "Kia", "Azul", "Automatico", 5, "Sorento", "HFO42", 4, null, 2021 },
                    { 62, "Renault", "Amarillo", "Manual", 7, "Duster", "ZDF894", 4, null, 2018 },
                    { 63, "Mazda", "Negro", "Automatico", 7, "CX50", "PYP943", 4, null, 2020 },
                    { 64, "Chevrolet", "Rojo", "Manual", 1, "Captiva", "RHU790", 4, null, 2014 },
                    { 65, "Renault", "Blanco", "Manual", 2, "Duster", "FMN829", 5, null, 2014 },
                    { 66, "Kia", "Rojo", "Manual", 6, "Sorento", "QHS646", 5, null, 2019 },
                    { 67, "Renault", "Blanco", "Manual", 7, "Stepway", "ALC736", 5, null, 2024 },
                    { 68, "Renault", "Café", "Automatico", 2, "Oroch", "EAA501", 4, null, 2021 },
                    { 69, "Renault", "Amarillo", "Manual", 2, "Stepway", "HJF693", 4, null, 2016 },
                    { 70, "Mazda", "Azul", "Manual", 1, "CX50", "NXS797", 5, null, 2019 },
                    { 71, "Mazda", "Negro", "Automatico", 4, "CX90", "QWA8", 5, null, 2017 },
                    { 72, "Renault", "Café", "Manual", 5, "Kwid", "BDF784", 5, null, 2016 },
                    { 73, "Chevrolet", "Café", "Manual", 6, "Cruze", "ATQ76", 4, null, 2021 },
                    { 74, "Mazda", "Verde", "Automatico", 4, "CX50", "VTD260", 4, null, 2019 },
                    { 75, "Mazda", "Gris", "Manual", 3, "3", "IZG917", 5, null, 2021 },
                    { 76, "Chevrolet", "Blanco", "Manual", 4, "Captiva", "DME308", 4, null, 2024 },
                    { 77, "Mazda", "Blanco", "Automatico", 3, "3", "VCQ146", 5, null, 2019 },
                    { 78, "Mazda", "Amarillo", "Manual", 7, "CX90", "FGP714", 5, null, 2023 },
                    { 79, "Renault", "Café", "Manual", 5, "Oroch", "PIS687", 4, null, 2020 },
                    { 80, "Chevrolet", "Verde", "Manual", 3, "Captiva", "EFV401", 5, null, 2019 },
                    { 81, "Chevrolet", "Café", "Manual", 2, "Aveo", "AIZ187", 5, null, 2022 },
                    { 82, "Renault", "Negro", "Manual", 1, "Duster", "PED984", 5, null, 2015 },
                    { 83, "Chevrolet", "Rojo", "Manual", 7, "Spark", "TAG315", 4, null, 2022 },
                    { 84, "Kia", "Azul", "Manual", 3, "Sportage", "MTB676", 5, null, 2018 },
                    { 85, "Kia", "Amarillo", "Manual", 4, "Sorento", "DUG929", 5, null, 2024 },
                    { 86, "Renault", "Rojo", "Manual", 2, "Kwid", "QUR869", 4, null, 2022 },
                    { 87, "Mazda", "Amarillo", "Manual", 7, "CX30", "SYI867", 5, null, 2016 },
                    { 88, "Renault", "Blanco", "Manual", 2, "Oroch", "JHY656", 4, null, 2019 },
                    { 89, "Chevrolet", "Negro", "Manual", 2, "Aveo", "ZFM365", 4, null, 2022 },
                    { 90, "Mazda", "Verde", "Manual", 5, "MX5", "EWX251", 5, null, 2023 },
                    { 91, "Chevrolet", "Rojo", "Manual", 5, "Cruze", "FUT943", 5, null, 2018 },
                    { 92, "Mazda", "Verde", "Manual", 7, "MX5", "VKQ362", 5, null, 2014 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Users_UserId",
                table: "Cars",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Users_UserId",
                table: "Cars");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.RenameColumn(
                name: "GearBox",
                table: "Cars",
                newName: "Transmision");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Model",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Users_UserId",
                table: "Cars",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
