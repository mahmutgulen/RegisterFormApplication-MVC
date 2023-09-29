using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RFA.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mako : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationInfoId = table.Column<int>(type: "int", nullable: false),
                    ParticipationFee = table.Column<int>(type: "int", nullable: false),
                    GalaFee = table.Column<int>(type: "int", nullable: false),
                    AccommodationFee = table.Column<int>(type: "int", nullable: false),
                    CourseFee = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegistrationInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Commitee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationType = table.Column<byte>(type: "tinyint", nullable: true),
                    GalaType = table.Column<byte>(type: "tinyint", nullable: true),
                    AccomodationType = table.Column<byte>(type: "tinyint", nullable: true),
                    PreCourseType = table.Column<byte>(type: "tinyint", nullable: true),
                    PostCourseType = table.Column<byte>(type: "tinyint", nullable: true),
                    CompoanionFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanionType = table.Column<byte>(type: "tinyint", nullable: true),
                    CompanionGalaType = table.Column<byte>(type: "tinyint", nullable: true),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationInfos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentInfos");

            migrationBuilder.DropTable(
                name: "RegistrationInfos");
        }
    }
}
