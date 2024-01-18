using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessPlannerRepository.Migrations
{
    /// <inheritdoc />
    public partial class RefactorDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Calendars_CalendarId",
                table: "Modules");

            migrationBuilder.DropIndex(
                name: "IX_Modules_CalendarId",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "CalendarId",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "Day",
                table: "Modules");

            migrationBuilder.AddColumn<Guid>(
                name: "DayId",
                table: "Modules",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CalendarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Days_Calendars_CalendarId",
                        column: x => x.CalendarId,
                        principalTable: "Calendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Modules_DayId",
                table: "Modules",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_Days_CalendarId",
                table: "Days",
                column: "CalendarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Days_DayId",
                table: "Modules",
                column: "DayId",
                principalTable: "Days",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Days_DayId",
                table: "Modules");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropIndex(
                name: "IX_Modules_DayId",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "DayId",
                table: "Modules");

            migrationBuilder.AddColumn<Guid>(
                name: "CalendarId",
                table: "Modules",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Day",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Modules_CalendarId",
                table: "Modules",
                column: "CalendarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Calendars_CalendarId",
                table: "Modules",
                column: "CalendarId",
                principalTable: "Calendars",
                principalColumn: "Id");
        }
    }
}
