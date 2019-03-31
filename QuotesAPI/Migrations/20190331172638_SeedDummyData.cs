using Microsoft.EntityFrameworkCore.Migrations;

namespace QuotesAPI.Migrations
{
    public partial class SeedDummyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "QuotesModel",
                columns: new[] { "Id", "Author", "Text" },
                values: new object[,]
                {
                    { 1, "Lorem Ipsum1", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.1" },
                    { 29, "Lorem Ipsum29", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.29" },
                    { 28, "Lorem Ipsum28", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.28" },
                    { 27, "Lorem Ipsum27", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.27" },
                    { 26, "Lorem Ipsum26", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.26" },
                    { 25, "Lorem Ipsum25", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.25" },
                    { 24, "Lorem Ipsum24", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.24" },
                    { 23, "Lorem Ipsum23", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.23" },
                    { 22, "Lorem Ipsum22", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.22" },
                    { 21, "Lorem Ipsum21", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.21" },
                    { 20, "Lorem Ipsum20", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.20" },
                    { 19, "Lorem Ipsum19", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.19" },
                    { 18, "Lorem Ipsum18", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.18" },
                    { 17, "Lorem Ipsum17", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.17" },
                    { 30, "Lorem Ipsum30", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.30" },
                    { 16, "Lorem Ipsum16", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.16" },
                    { 14, "Lorem Ipsum14", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.14" },
                    { 13, "Lorem Ipsum13", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.13" },
                    { 12, "Lorem Ipsum12", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.12" },
                    { 11, "Lorem Ipsum11", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.11" },
                    { 10, "Lorem Ipsum10", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.10" },
                    { 9, "Lorem Ipsum9", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.9" },
                    { 8, "Lorem Ipsum8", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.8" },
                    { 7, "Lorem Ipsum7", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.7" },
                    { 6, "Lorem Ipsum6", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.6" },
                    { 5, "Lorem Ipsum5", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.5" },
                    { 4, "Lorem Ipsum4", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.4" },
                    { 3, "Lorem Ipsum3", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.3" },
                    { 2, "Lorem Ipsum2", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.2" },
                    { 15, "Lorem Ipsum15", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.15" },
                    { 31, "Lorem Ipsum31", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse consectetur.31" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "QuotesModel",
                keyColumn: "Id",
                keyValue: 31);
        }
    }
}
