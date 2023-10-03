using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace takenbeheer_dal.Migrations
{
    /// <inheritdoc />
    public partial class _2Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "ToDoTaken");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "ToDoTaken",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
