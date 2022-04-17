using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb_4___API.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 2,
                columns: new[] { "HobbyDescription", "HobbyName" },
                values: new object[] { "Watching and analysing movies.", "Movies" });

            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 3,
                columns: new[] { "HobbyDescription", "HobbyName" },
                values: new object[] { "Creating and modifying computer programs.", "Programming" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 2,
                columns: new[] { "HobbyDescription", "HobbyName" },
                values: new object[] { "Creating and modifying computer programs.", "Programming" });

            migrationBuilder.UpdateData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 3,
                columns: new[] { "HobbyDescription", "HobbyName" },
                values: new object[] { "Watching and analysing movies.", "Movies" });
        }
    }
}
