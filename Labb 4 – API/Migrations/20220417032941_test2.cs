using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb_4___API.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "HobbyID", "HobbyDescription", "HobbyName" },
                values: new object[,]
                {
                    { 3, "Watching and analysing movies.", "Movies" },
                    { 2, "Creating and modifying computer programs.", "Programming" },
                    { 4, "Playing chess.", "Chess" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "UserPhoneNumber",
                value: 4608000);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "UserAge", "UserFirstName", "UserLastName", "UserPhoneNumber" },
                values: new object[,]
                {
                    { 2, 25, "Daniel", "Gyrén", 939314 },
                    { 3, 36, "Tobias", "L", 3827202 },
                    { 4, 32, "Anas", "A", 18456759 },
                    { 5, 39, "Alexandra", "Anderson", 69438204 }
                });

            migrationBuilder.UpdateData(
                table: "Websites",
                keyColumn: "WebsiteID",
                keyValue: 1,
                column: "WebsiteLink",
                value: "https://www.Food.com/");

            migrationBuilder.InsertData(
                table: "Websites",
                columns: new[] { "WebsiteID", "HobbyID", "UserID", "WebsiteLink" },
                values: new object[,]
                {
                    { 2, 2, 2, "https://www.imdb.com/" },
                    { 3, 3, 3, "https://docs.microsoft.com/en-us/dotnet/csharp/" },
                    { 4, 3, 4, "https://docs.microsoft.com/en-us/dotnet/csharp/" },
                    { 5, 4, 5, "https://www.chess.com/" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Websites",
                keyColumn: "WebsiteID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Websites",
                keyColumn: "WebsiteID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Websites",
                keyColumn: "WebsiteID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Websites",
                keyColumn: "WebsiteID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "HobbyID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "UserPhoneNumber",
                value: 460800);

            migrationBuilder.UpdateData(
                table: "Websites",
                keyColumn: "WebsiteID",
                keyValue: 1,
                column: "WebsiteLink",
                value: "https://www.Food.com");
        }
    }
}
