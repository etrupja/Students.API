using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Students.API.Migrations
{
    /// <inheritdoc />
    public partial class Added_Demo_Column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Demo",
                table: "Students",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Demo",
                table: "Students");
        }
    }
}
