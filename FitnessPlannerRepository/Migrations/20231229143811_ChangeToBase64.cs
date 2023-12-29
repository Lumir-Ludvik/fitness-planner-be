using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessPlannerRepository.Migrations
{
    /// <inheritdoc />
    public partial class ChangeToBase64 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bytes",
                table: "Modules");

            migrationBuilder.AddColumn<string>(
                name: "Base64Img",
                table: "Modules",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Base64Img",
                table: "Modules");

            migrationBuilder.AddColumn<byte[]>(
                name: "Bytes",
                table: "Modules",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

        }
    }
}
