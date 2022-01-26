using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesRentalAPI.Migrations
{
    public partial class AddingMoreDummyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "DateOfBirth", "Email", "FirstName", "LastName", "Mobile", "RegistrationDate", "UniqueKey" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yoyo@gmail.com", "yaseen", "Ahmed", 123456787, new DateTime(2017, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "yo12546785" },
                    { 2, new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yoyo@gmail.com", "Maaz", "Ahmed", 123456787, new DateTime(2017, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "yo78945612" },
                    { 3, new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yoyo@gmail.com", "Muiz", "Ahmed", 123456787, new DateTime(2017, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "yo74185296" },
                    { 4, new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yoyo@gmail.com", "Kaif", "Ahmed", 123456787, new DateTime(2017, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "yo96852741" },
                    { 5, new DateTime(2000, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yoyo@gmail.com", "Faizan", "Ahmed", 123456787, new DateTime(2017, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "yo14725896" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Drama" },
                    { 3, "Romance" },
                    { 4, "Action" },
                    { 5, "Horror" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Director", "GenreId", "Image", "Producer", "Rating", "ReleaseDate", "Title", "TrailerURI", "Writer" },
                values: new object[,]
                {
                    { 3, "It is one of the finest movies with full of drama and emotion", "Kon hai Ki", 1, "image.png", "Mere Paas Paisay nai Hein", "4.1", new DateTime(2017, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Housefull 3", "Youtube/trailers", "Malum nai" },
                    { 4, "It is one of the finest movies with full of drama and emotion", "Kon hai Ki", 1, "image.png", "Mere Paas Paisay nai Hein", "4.3", new DateTime(2017, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bol Bachan", "Youtube/trailers", "Malum nai" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Director", "GenreId", "Image", "Producer", "Rating", "ReleaseDate", "Title", "TrailerURI", "Writer" },
                values: new object[,]
                {
                    { 1, "It is one of the finest movies with full of drama and emotion", "Kon hai Ki", 2, "image.png", "Mere Paas Paisay nai Hein", "4", new DateTime(2017, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dil Ke Arman", "Youtube/trailers", "Malum nai" },
                    { 2, "It is one of the finest movies with full of drama and emotion", "Kon hai Ki", 2, "image.png", "Mere Paas Paisay nai Hein", "4.3", new DateTime(2017, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kal Ho Na Ho", "Youtube/trailers", "Malum nai" },
                    { 8, "It is one of the finest movies with full of drama and emotion", "Kon hai Ki", 3, "image.png", "Mere Paas Paisay nai Hein", "4.2", new DateTime(2017, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jab Harry Met To Sejal", "Youtube/trailers", "Malum nai" },
                    { 9, "It is one of the finest movies with full of drama and emotion", "Kon hai Ki", 3, "image.png", "Mere Paas Paisay nai Hein", "4", new DateTime(2017, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ae Dil Hai Mushkil", "Youtube/trailers", "Malum nai" },
                    { 5, "It is one of the finest movies with full of drama and emotion", "Kon hai Ki", 4, "image.png", "Mere Paas Paisay nai Hein", "4.9", new DateTime(2017, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Don 3", "Youtube/trailers", "Malum nai" },
                    { 7, "It is one of the finest movies with full of drama and emotion", "Kon hai Ki", 4, "image.png", "Mere Paas Paisay nai Hein", "4.6", new DateTime(2017, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dhoom 3", "Youtube/trailers", "Malum nai" },
                    { 6, "It is one of the finest movies with full of drama and emotion", "Kon hai Ki", 5, "image.png", "Mere Paas Paisay nai Hein", "4.2", new DateTime(2017, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annabel", "Youtube/trailers", "Malum nai" },
                    { 10, "It is one of the finest movies with full of drama and emotion", "Kon hai Ki", 5, "image.png", "Mere Paas Paisay nai Hein", "4.4", new DateTime(2017, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isssh Phir Koi Hai...", "Youtube/trailers", "Malum nai" }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "IsAvailable", "MovieId", "UniqueKey" },
                values: new object[,]
                {
                    { 5, true, 3, "124578yo" },
                    { 6, true, 3, "124578yo" },
                    { 7, false, 4, "124578yo" },
                    { 8, false, 4, "124578yo" }
                });

            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "Id", "CustomerId", "RentalDate", "ReturnedDate", "Status", "StockId" },
                values: new object[] { 4, 3, new DateTime(2018, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 8 });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "IsAvailable", "MovieId", "UniqueKey" },
                values: new object[,]
                {
                    { 1, false, 1, "124578yo" },
                    { 2, true, 1, "124578yo" },
                    { 3, false, 2, "124578yo" },
                    { 4, false, 2, "124578yo" },
                    { 15, false, 8, "124578yo" },
                    { 16, false, 9, "124578yo" },
                    { 9, true, 5, "124578yo" },
                    { 10, false, 5, "124578yo" },
                    { 13, false, 7, "124578yo" },
                    { 14, true, 7, "124578yo" },
                    { 11, true, 6, "124578yo" },
                    { 12, false, 6, "124578yo" },
                    { 17, false, 10, "124578yo" },
                    { 18, true, 10, "124578yo" }
                });

            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "Id", "CustomerId", "RentalDate", "ReturnedDate", "Status", "StockId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2018, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 2, 4, new DateTime(2018, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3 },
                    { 3, 5, new DateTime(2018, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 },
                    { 8, 2, new DateTime(2018, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 15 },
                    { 9, 4, new DateTime(2018, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 16 },
                    { 5, 2, new DateTime(2018, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 10 },
                    { 7, 3, new DateTime(2018, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 13 },
                    { 6, 1, new DateTime(2018, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 12 },
                    { 10, 5, new DateTime(2018, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 17 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
