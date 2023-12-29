using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessPlannerRepository.Migrations
{
    /// <inheritdoc />
    public partial class AddDaysColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Day",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "Modules");
        }
    }
}
