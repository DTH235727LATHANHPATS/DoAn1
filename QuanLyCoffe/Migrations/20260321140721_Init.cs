using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyCoffe.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhanCongNhanVien_Ban_BanID",
                table: "PhanCongNhanVien");

            migrationBuilder.AlterColumn<string>(
                name: "NgayLam",
                table: "PhanCongNhanVien",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "BanID",
                table: "PhanCongNhanVien",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_PhanCongNhanVien_Ban_BanID",
                table: "PhanCongNhanVien",
                column: "BanID",
                principalTable: "Ban",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhanCongNhanVien_Ban_BanID",
                table: "PhanCongNhanVien");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayLam",
                table: "PhanCongNhanVien",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "BanID",
                table: "PhanCongNhanVien",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PhanCongNhanVien_Ban_BanID",
                table: "PhanCongNhanVien",
                column: "BanID",
                principalTable: "Ban",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
