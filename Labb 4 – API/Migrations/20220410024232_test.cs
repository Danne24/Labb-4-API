using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb_4___API.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    HobbyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HobbyName = table.Column<string>(nullable: true),
                    HobbyDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.HobbyID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserAge = table.Column<int>(nullable: false),
                    UserFirstName = table.Column<string>(nullable: true),
                    UserLastName = table.Column<string>(nullable: true),
                    UserPhoneNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Websites",
                columns: table => new
                {
                    WebsiteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WebsiteLink = table.Column<string>(nullable: true),
                    HobbyID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Websites", x => x.WebsiteID);
                    table.ForeignKey(
                        name: "FK_Websites_Hobbies_HobbyID",
                        column: x => x.HobbyID,
                        principalTable: "Hobbies",
                        principalColumn: "HobbyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Websites_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "HobbyID", "HobbyDescription", "HobbyName" },
                values: new object[] { 1, "Cooking and preparing food.", "Cooking" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "UserAge", "UserFirstName", "UserLastName", "UserPhoneNumber" },
                values: new object[] { 1, 55, "Paul", "Foster", 460800 });

            migrationBuilder.InsertData(
                table: "Websites",
                columns: new[] { "WebsiteID", "HobbyID", "UserID", "WebsiteLink" },
                values: new object[] { 1, 1, 1, "https://www.Food.com" });

            migrationBuilder.CreateIndex(
                name: "IX_Websites_HobbyID",
                table: "Websites",
                column: "HobbyID");

            migrationBuilder.CreateIndex(
                name: "IX_Websites_UserID",
                table: "Websites",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Websites");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
