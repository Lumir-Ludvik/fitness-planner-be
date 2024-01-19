using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessPlannerRepository.Migrations
{
    /// <inheritdoc />
    public partial class RenameNameColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Calendars_CalendarId",
                table: "Modules");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Modules",
                newName: "Title");

            migrationBuilder.AlterColumn<string>(
                name: "Day",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "CalendarId",
                table: "Modules",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Calendars_CalendarId",
                table: "Modules",
                column: "CalendarId",
                principalTable: "Calendars",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Calendars_CalendarId",
                table: "Modules");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Modules",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Day",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CalendarId",
                table: "Modules",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Calendars_CalendarId",
                table: "Modules",
                column: "CalendarId",
                principalTable: "Calendars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
