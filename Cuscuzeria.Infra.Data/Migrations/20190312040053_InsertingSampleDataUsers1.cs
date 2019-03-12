using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cuscuzeria.Infra.Data.Migrations
{
    public partial class InsertingSampleDataUsers1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "UserId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "UserId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "UserId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "UserId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "UserId",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "UserId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 3, 12, 1, 0, 52, 706, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "UserId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 3, 12, 0, 56, 48, 59, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "UserId", "CreatedAt", "Email", "LastOrder", "Password", "Phone", "UrlImg", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 3, 12, 0, 56, 48, 58, DateTimeKind.Local), "mihai@email.com", new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "SZ@111222", "+55719988-7733", null, "mihai" },
                    { 2, new DateTime(2019, 3, 12, 0, 56, 48, 59, DateTimeKind.Local), "yjqom@email.com", new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "SZ@111222", "+55719988-7733", null, "yjqom" },
                    { 3, new DateTime(2019, 3, 12, 0, 56, 48, 59, DateTimeKind.Local), "ojbzg@email.com", new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "SZ@111222", "+55719988-7733", null, "ojbzg " },
                    { 4, new DateTime(2019, 3, 12, 0, 56, 48, 59, DateTimeKind.Local), "sgdxp@email.com", new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "SZ@111222", "+55719988-7733", null, "sgdxp" },
                    { 5, new DateTime(2019, 3, 12, 0, 56, 48, 59, DateTimeKind.Local), "tkolf@email.com", new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "SZ@111222", "+55719988-7733", null, "tkolf" },
                    { 6, new DateTime(2019, 3, 12, 0, 56, 48, 59, DateTimeKind.Local), "jkgvb@email.com", new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "SZ@111222", "+55719988-7733", null, "jkgvb" },
                    { 7, new DateTime(2019, 3, 12, 0, 56, 48, 59, DateTimeKind.Local), "wkint@email.com", new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "SZ@111222", "+55719988-7733", null, "wkint" },
                    { 8, new DateTime(2019, 3, 12, 0, 56, 48, 59, DateTimeKind.Local), "zeozf@email.com", new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "SZ@111222", "+55719988-7733", null, "zeozf" },
                    { 9, new DateTime(2019, 3, 12, 0, 56, 48, 59, DateTimeKind.Local), "ywabo@email.com", new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "SZ@111222", "+55719988-7733", null, "ywabo" },
                    { 10, new DateTime(2019, 3, 12, 0, 56, 48, 59, DateTimeKind.Local), "qcrlf@email.com", new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "SZ@111222", "+55719988-7733", null, "qcrlf" },
                    { 11, new DateTime(2019, 3, 12, 0, 56, 48, 59, DateTimeKind.Local), "wfqyd@email.com", new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), "SZ@111222", "+55719988-7733", null, "wfqyd" }
                });
        }
    }
}
