using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyCoffe.Migrations
{
    /// <inheritdoc />
    public partial class InitDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Gia",
                table: "SanPham",
                type: "int",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.AddColumn<string>(
                name: "HinhAnh",
                table: "SanPham",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MoTa",
                table: "SanPham",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "ChucVu",
                table: "NhanVien",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "MatKhau",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TenDangNhap",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HinhAnh",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "MoTa",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "MatKhau",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "TenDangNhap",
                table: "NhanVien");

            migrationBuilder.AlterColumn<decimal>(
                name: "Gia",
                table: "SanPham",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.AlterColumn<string>(
                name: "ChucVu",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
