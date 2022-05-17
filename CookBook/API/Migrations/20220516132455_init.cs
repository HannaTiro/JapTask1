using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Username = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PasswordSalt = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.AppUserId);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IngredientPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Measure = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.IngredientId);
                });

            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 100, nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.RecipeId);
                    table.ForeignKey(
                        name: "FK_Recipe_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeDetail",
                columns: table => new
                {
                    RecipeDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Measure = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeDetail", x => x.RecipeDetailId);
                    table.ForeignKey(
                        name: "fk_rd_ingr",
                        column: x => x.IngredientId,
                        principalTable: "Ingredient",
                        principalColumn: "IngredientId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_rd_recep",
                        column: x => x.RecipeId,
                        principalTable: "Recipe",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "AppUserId", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[,]
                {
                    { 1, "Hanna", "Tiro", "JXrkcmVp44bGr/UHHaMyecKVHtY=", "RiiHQ3XGHctnPOb7/bxDzQ==", "hanna" },
                    { 2, "Belma", "Nukic", "SE2RJHcDP9iTB1Qp5Z+8bddBPLk=", "sLspPZEVL0HbIHL6/WCqmA==", "belma" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 11, "Barbeque" },
                    { 9, "Asian food" },
                    { 8, "Pasta" },
                    { 7, "Meat" },
                    { 6, "Sandwiches" },
                    { 10, "Taccos" },
                    { 4, "Fish" },
                    { 3, "Pizzas" },
                    { 2, "Waffles" },
                    { 1, "Pancakes" },
                    { 5, "Sushi" }
                });

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "IngredientId", "Amount", "IngredientName", "IngredientPrice", "Measure" },
                values: new object[,]
                {
                    { 10, 17, "Salt", 10m, "kg" },
                    { 1, 9, "Eggs", 5m, "kom" },
                    { 2, 170, "Milk", 200m, "l" },
                    { 3, 50, "Flour", 70m, "kg" },
                    { 4, 2, "Chicken", 16m, "kg" },
                    { 5, 2, "Beef", 20m, "kg" },
                    { 6, 5, "Cheese", 20m, "kg" },
                    { 7, 3, "Yogurt", 7m, "l" },
                    { 8, 10, "Patatoes", 30m, "kg" },
                    { 9, 10, "Spinach", 10m, "kg" },
                    { 11, 20, "Peper", 10m, "kg" }
                });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "RecipeId", "CategoryId", "Description", "RecipeName", "TotalPrice" },
                values: new object[] { 1, 1, "The process is simple!....", "Nutella pancakes", 5m });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "RecipeId", "CategoryId", "Description", "RecipeName", "TotalPrice" },
                values: new object[] { 2, 1, "The process is simple! ...", "Protein pancakes", 6m });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "RecipeId", "CategoryId", "Description", "RecipeName", "TotalPrice" },
                values: new object[] { 3, 1, "The process is simple!.....", "Rafaelo pancakes", 7m });

            migrationBuilder.InsertData(
                table: "RecipeDetail",
                columns: new[] { "RecipeDetailId", "Amount", "IngredientId", "Measure", "Price", "RecipeId" },
                values: new object[,]
                {
                    { 1, 3, 1, "kom", 1m, 1 },
                    { 2, 3, 2, "l", 1m, 1 },
                    { 3, 20, 3, "g", 1m, 1 },
                    { 4, 3, 1, "kom", 1m, 2 },
                    { 5, 3, 2, "l", 1m, 2 },
                    { 6, 20, 3, "g", 1m, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_CategoryId",
                table: "Recipe",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeDetail_IngredientId",
                table: "RecipeDetail",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeDetail_RecipeId",
                table: "RecipeDetail",
                column: "RecipeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.DropTable(
                name: "RecipeDetail");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Recipe");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
