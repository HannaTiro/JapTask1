using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class recipeforeign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_Category_CategoryId",
                table: "Recipe");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Recipe",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "AppUserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "tRVRLbtDkdunkcWNWyjoMGipdOM=", "MG7ot+HqsOJk/+X/GU5+EQ==" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "AppUserId",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "/C3hMPysVUXZCmQXOYQICydT5bY=", "BKxxJB63LIJ55Y1M4LrPXw==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_Category_CategoryId",
                table: "Recipe",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_Category_CategoryId",
                table: "Recipe");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Recipe",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "AppUserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "7sJfYg3ZOqOLUlmUrsY5TREPRSg=", "G4+jBvr1qO/oz/M+l8Ng9w==" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "AppUserId",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "kezFdH/BeE4oKg+cIiOdAabaSq0=", "Ll6DncMGSI9YKpGf5RcQRg==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_Category_CategoryId",
                table: "Recipe",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
