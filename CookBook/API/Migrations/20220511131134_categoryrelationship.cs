using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class categoryrelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Recipe",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_CategoryId",
                table: "Recipe",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_Category_CategoryId",
                table: "Recipe",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_Category_CategoryId",
                table: "Recipe");

            migrationBuilder.DropIndex(
                name: "IX_Recipe_CategoryId",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Recipe");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "AppUserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "NajF0+p4nlUb3glEDDYGgUBJQkc=", "HnFcZdGuwh7/ZdOjigjbpA==" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "AppUserId",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "ADkRE2EDJRj8/DY0ULVFls5wMpM=", "WvCwmTYxWDIeZXTYj+DFsw==" });
        }
    }
}
