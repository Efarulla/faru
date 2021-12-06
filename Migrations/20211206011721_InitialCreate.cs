﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantillaAppi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
           name: "Eventos",
           columns: table => new
           {
               id = table.Column<int>(type: "int", nullable: false)
                   .Annotation("SqlServer:Identity", "1, 1"),
               title = table.Column<string>(type: "nvarchar(max)", nullable: true),
               start = table.Column<string>(type: "nvarchar(max)", nullable: true),
               end = table.Column<string>(type: "nvarchar(max)", nullable: true),
               color = table.Column<string>(type: "nvarchar(max)", nullable: true),
               tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
               email = table.Column<string>(type: "nvarchar(max)", nullable: true),
           },
           constraints: table =>
           {
               table.PrimaryKey("PK_Eventos", x => x.id);
           });
      
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eventos");
        }
    }
}
