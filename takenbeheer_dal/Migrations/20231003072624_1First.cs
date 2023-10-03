using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace takenbeheer_dal.Migrations
{
    /// <inheritdoc />
    public partial class _1First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToDoTaken",
                columns: table => new
                {
                    ToDoTaskID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ToDoFinishedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDoStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDoCreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoTaken", x => x.ToDoTaskID);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CommentCreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToDoTaskID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comments_ToDoTaken_ToDoTaskID",
                        column: x => x.ToDoTaskID,
                        principalTable: "ToDoTaken",
                        principalColumn: "ToDoTaskID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ToDoTaskID",
                table: "Comments",
                column: "ToDoTaskID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ToDoTaken");
        }
    }
}
