using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CookBook.Database.Migrations
{
    public partial class datab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 977, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 30, new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(9072), "Vegan sushi" },
                    { 34, new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(9281), "Vegan cakes" },
                    { 33, new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(9168), "Vegan sandwiches" },
                    { 32, new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(9136), "Vegan pasta" },
                    { 31, new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(9104), "Vegan platter" },
                    { 29, new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(9041), "Vegetarian sushi" },
                    { 12, new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(8314), "Rice" },
                    { 27, new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(8976), "Vegetarian rice" },
                    { 28, new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(9008), "Vegetarian tortilas" },
                    { 22, new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(8806), "Garlic bread" },
                    { 20, new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(8736), "Beef" },
                    { 19, new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(8703), "Cereal" },
                    { 18, new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(8670), "Beans" },
                    { 17, new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(8632), "Omlets" },
                    { 16, new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(8587), "Jams" },
                    { 21, new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(8772), "Bread" },
                    { 14, new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(8386), "Nachos" },
                    { 13, new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(8350), "Tortilas" },
                    { 23, new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(8843), "Cabbage" },
                    { 24, new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(8876), "Mushrooms" },
                    { 26, new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(8944), "Appetiser platter" },
                    { 25, new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(8910), "Schnitzel" },
                    { 15, new DateTime(2022, 6, 16, 10, 5, 54, 985, DateTimeKind.Local).AddTicks(8422), "Cakes" }
                });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4476));

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "Id", "CreatedAt", "Name", "PurchaseAmount", "PurchaseMeasure", "PurchasePrice" },
                values: new object[,]
                {
                    { 22, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4551), "Dill", 20, 0, 10m },
                    { 20, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4538), "Red chilli", 20, 0, 10m },
                    { 14, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4496), "Lime", 20, 0, 10m },
                    { 15, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4502), "Turnip", 20, 0, 10m },
                    { 16, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4508), "Sweet patatoes", 20, 0, 10m },
                    { 17, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4515), "Onion", 20, 0, 10m },
                    { 18, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4522), "Mushroom", 20, 0, 10m },
                    { 19, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4531), "Oregano", 20, 0, 10m },
                    { 13, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4489), "Cherry tomatoes", 20, 0, 10m },
                    { 21, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4544), "Turmeric", 20, 0, 10m },
                    { 24, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4564), "Crab", 20, 0, 10m },
                    { 25, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4571), "Chops", 20, 0, 10m },
                    { 26, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4577), "Cranberry", 20, 0, 10m },
                    { 27, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4584), "Kiwi", 20, 0, 10m },
                    { 28, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4590), "Mango", 20, 0, 10m },
                    { 29, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4597), "Watermelon", 20, 0, 10m },
                    { 30, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4603), "Olives", 20, 0, 10m },
                    { 23, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4557), "Keema", 20, 0, 10m },
                    { 12, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(4482), "Snake beans", 20, 0, 10m }
                });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "Name", "TotalPrice" },
                values: new object[,]
                {
                    { 6, 3, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(9379), "The process is simple!....", "Chicago pizza", 6m },
                    { 9, 8, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(9513), "The process is simple!....", "Cheese pasta", 6m },
                    { 15, 8, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(9554), "The process is simple!....", "Chocolate waffles", 6m },
                    { 14, 8, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(9547), "The process is simple!....", "Belgian waffles", 6m },
                    { 13, 8, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(9541), "The process is simple!....", "Tagliatelle", 6m },
                    { 12, 8, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(9535), "The process is simple!....", "Bucatini", 6m },
                    { 11, 8, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(9525), "The process is simple!....", "Linguine", 6m },
                    { 10, 8, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(9519), "The process is simple!....", "Patato gnocchi", 6m },
                    { 8, 3, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(9506), "The process is simple!....", "Detroit pizza ", 16m },
                    { 7, 3, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(9496), "The process is simple!....", "California pizza", 6m },
                    { 5, 3, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(9373), "The process is simple!....", "Sicilian pizza", 6m },
                    { 4, 3, new DateTime(2022, 6, 16, 10, 5, 54, 986, DateTimeKind.Local).AddTicks(9367), "The process is simple!....", "Neapolitan Pizza", 5m }
                });

            migrationBuilder.UpdateData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 987, DateTimeKind.Local).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 987, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 987, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 987, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 987, DateTimeKind.Local).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 6, 16, 10, 5, 54, 987, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.InsertData(
                table: "RecipeDetail",
                columns: new[] { "Id", "Amount", "CreatedAt", "IngredientId", "Measure", "Price", "RecipeId" },
                values: new object[,]
                {
                    { 7, 20, new DateTime(2022, 6, 16, 10, 5, 54, 987, DateTimeKind.Local).AddTicks(3155), 1, 1, 1m, 1 },
                    { 8, 10, new DateTime(2022, 6, 16, 10, 5, 54, 987, DateTimeKind.Local).AddTicks(3161), 4, 1, 1m, 1 },
                    { 9, 10, new DateTime(2022, 6, 16, 10, 5, 54, 987, DateTimeKind.Local).AddTicks(3167), 4, 1, 1m, 2 },
                    { 11, 10, new DateTime(2022, 6, 16, 10, 5, 54, 987, DateTimeKind.Local).AddTicks(3179), 6, 1, 1m, 1 },
                    { 10, 10, new DateTime(2022, 6, 16, 10, 5, 54, 987, DateTimeKind.Local).AddTicks(3173), 5, 1, 1m, 2 }
                });

            migrationBuilder.InsertData(
                table: "RecipeDetail",
                columns: new[] { "Id", "Amount", "CreatedAt", "IngredientId", "Measure", "Price", "RecipeId" },
                values: new object[,]
                {
                    { 12, 10, new DateTime(2022, 6, 16, 10, 5, 54, 987, DateTimeKind.Local).AddTicks(3186), 2, 1, 1m, 5 },
                    { 13, 10, new DateTime(2022, 6, 16, 10, 5, 54, 987, DateTimeKind.Local).AddTicks(3192), 6, 1, 1m, 6 },
                    { 14, 10, new DateTime(2022, 6, 16, 10, 5, 54, 987, DateTimeKind.Local).AddTicks(3198), 3, 1, 1m, 7 },
                    { 15, 3, new DateTime(2022, 6, 16, 10, 5, 54, 987, DateTimeKind.Local).AddTicks(3204), 4, 1, 1m, 8 },
                    { 16, 10, new DateTime(2022, 6, 16, 10, 5, 54, 987, DateTimeKind.Local).AddTicks(3210), 7, 1, 1m, 8 },
                    { 17, 10, new DateTime(2022, 6, 16, 10, 5, 54, 987, DateTimeKind.Local).AddTicks(3216), 5, 1, 1m, 8 },
                    { 18, 10, new DateTime(2022, 6, 16, 10, 5, 54, 987, DateTimeKind.Local).AddTicks(3222), 8, 1, 1m, 8 },
                    { 19, 10, new DateTime(2022, 6, 16, 10, 5, 54, 987, DateTimeKind.Local).AddTicks(3229), 9, 1, 1m, 8 },
                    { 20, 10, new DateTime(2022, 6, 16, 10, 5, 54, 987, DateTimeKind.Local).AddTicks(3235), 10, 1, 1m, 8 },
                    { 21, 10, new DateTime(2022, 6, 16, 10, 5, 54, 987, DateTimeKind.Local).AddTicks(3241), 11, 1, 1m, 8 },
                    { 22, 10, new DateTime(2022, 6, 16, 10, 5, 54, 987, DateTimeKind.Local).AddTicks(3247), 15, 1, 1m, 8 },
                    { 23, 10, new DateTime(2022, 6, 16, 10, 5, 54, 987, DateTimeKind.Local).AddTicks(3254), 17, 1, 1m, 8 },
                    { 24, 10, new DateTime(2022, 6, 16, 10, 5, 54, 987, DateTimeKind.Local).AddTicks(3260), 18, 1, 1m, 8 },
                    { 25, 10, new DateTime(2022, 6, 16, 10, 5, 54, 987, DateTimeKind.Local).AddTicks(3266), 19, 1, 1m, 8 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "CreatedAt", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hanna", "Tiro", "z01QT6U6fBJ7V4CFH1OGxYeI590=", "2FXZAkMyYbukVb4Dx6KmeA==", "hanna" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Belma", "Nukic", "SFYgaifGcgohxB2/WF4h1+K2sWw=", "1hcigBgsoVW6sPlMS5QSIg==", "belma" }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "RecipeDetail",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
