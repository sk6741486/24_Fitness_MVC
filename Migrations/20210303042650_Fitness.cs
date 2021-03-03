using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _24_Fitness_MVC.Migrations
{
    public partial class Fitness : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Activity_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Time_Duration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Trainer_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CenterDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CenterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Club_Id = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Open_Hours = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Activitie = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CenterDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FitnessClub",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Club_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Club_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Club_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Package_Id = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FitnessClub", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Package",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Package_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Package_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Package_Duration = table.Column<int>(type: "int", nullable: false),
                    Package_Condition = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Package", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trainer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Trainer_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trainer_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trainer_Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainer", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "CenterDetail");

            migrationBuilder.DropTable(
                name: "FitnessClub");

            migrationBuilder.DropTable(
                name: "Package");

            migrationBuilder.DropTable(
                name: "Trainer");
        }
    }
}
