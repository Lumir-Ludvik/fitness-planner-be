using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessPlannerRepository.Migrations
{
    /// <inheritdoc />
    public partial class SecondRefactor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Days_DayId",
                table: "Modules");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.AddColumn<Guid>(
                name: "FridayId",
                table: "Calendars",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "MondayId",
                table: "Calendars",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SaturdayId",
                table: "Calendars",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SundayId",
                table: "Calendars",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ThursdayId",
                table: "Calendars",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TuesdayId",
                table: "Calendars",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "WednesdayId",
                table: "Calendars",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "DayBaseEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CalendarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayBaseEntity", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_FridayId",
                table: "Calendars",
                column: "FridayId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_MondayId",
                table: "Calendars",
                column: "MondayId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_SaturdayId",
                table: "Calendars",
                column: "SaturdayId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_SundayId",
                table: "Calendars",
                column: "SundayId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_ThursdayId",
                table: "Calendars",
                column: "ThursdayId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_TuesdayId",
                table: "Calendars",
                column: "TuesdayId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_WednesdayId",
                table: "Calendars",
                column: "WednesdayId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Calendars_DayBaseEntity_FridayId",
                table: "Calendars",
                column: "FridayId",
                principalTable: "DayBaseEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Calendars_DayBaseEntity_MondayId",
                table: "Calendars",
                column: "MondayId",
                principalTable: "DayBaseEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Calendars_DayBaseEntity_SaturdayId",
                table: "Calendars",
                column: "SaturdayId",
                principalTable: "DayBaseEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Calendars_DayBaseEntity_SundayId",
                table: "Calendars",
                column: "SundayId",
                principalTable: "DayBaseEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Calendars_DayBaseEntity_ThursdayId",
                table: "Calendars",
                column: "ThursdayId",
                principalTable: "DayBaseEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Calendars_DayBaseEntity_TuesdayId",
                table: "Calendars",
                column: "TuesdayId",
                principalTable: "DayBaseEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Calendars_DayBaseEntity_WednesdayId",
                table: "Calendars",
                column: "WednesdayId",
                principalTable: "DayBaseEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_DayBaseEntity_DayId",
                table: "Modules",
                column: "DayId",
                principalTable: "DayBaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calendars_DayBaseEntity_FridayId",
                table: "Calendars");

            migrationBuilder.DropForeignKey(
                name: "FK_Calendars_DayBaseEntity_MondayId",
                table: "Calendars");

            migrationBuilder.DropForeignKey(
                name: "FK_Calendars_DayBaseEntity_SaturdayId",
                table: "Calendars");

            migrationBuilder.DropForeignKey(
                name: "FK_Calendars_DayBaseEntity_SundayId",
                table: "Calendars");

            migrationBuilder.DropForeignKey(
                name: "FK_Calendars_DayBaseEntity_ThursdayId",
                table: "Calendars");

            migrationBuilder.DropForeignKey(
                name: "FK_Calendars_DayBaseEntity_TuesdayId",
                table: "Calendars");

            migrationBuilder.DropForeignKey(
                name: "FK_Calendars_DayBaseEntity_WednesdayId",
                table: "Calendars");

            migrationBuilder.DropForeignKey(
                name: "FK_Modules_DayBaseEntity_DayId",
                table: "Modules");

            migrationBuilder.DropTable(
                name: "DayBaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_Calendars_FridayId",
                table: "Calendars");

            migrationBuilder.DropIndex(
                name: "IX_Calendars_MondayId",
                table: "Calendars");

            migrationBuilder.DropIndex(
                name: "IX_Calendars_SaturdayId",
                table: "Calendars");

            migrationBuilder.DropIndex(
                name: "IX_Calendars_SundayId",
                table: "Calendars");

            migrationBuilder.DropIndex(
                name: "IX_Calendars_ThursdayId",
                table: "Calendars");

            migrationBuilder.DropIndex(
                name: "IX_Calendars_TuesdayId",
                table: "Calendars");

            migrationBuilder.DropIndex(
                name: "IX_Calendars_WednesdayId",
                table: "Calendars");

            migrationBuilder.DropColumn(
                name: "FridayId",
                table: "Calendars");

            migrationBuilder.DropColumn(
                name: "MondayId",
                table: "Calendars");

            migrationBuilder.DropColumn(
                name: "SaturdayId",
                table: "Calendars");

            migrationBuilder.DropColumn(
                name: "SundayId",
                table: "Calendars");

            migrationBuilder.DropColumn(
                name: "ThursdayId",
                table: "Calendars");

            migrationBuilder.DropColumn(
                name: "TuesdayId",
                table: "Calendars");

            migrationBuilder.DropColumn(
                name: "WednesdayId",
                table: "Calendars");

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
    }
}
