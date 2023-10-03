using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace takenbeheer_dal.Migrations
{
    /// <inheritdoc />
    public partial class _3Third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "ToDoTaken",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "ToDoTaken");
        }
    }
}
