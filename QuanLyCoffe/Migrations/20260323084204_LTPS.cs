using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyCoffe.Migrations
{
    /// <inheritdoc />
    public partial class LTPS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietPhieuNhap");

            migrationBuilder.DropTable(
                name: "NguyenLieu");

            migrationBuilder.DropTable(
                name: "PhieuNhap");

            migrationBuilder.DropTable(
                name: "NhaCungCap");

            migrationBuilder.AddColumn<string>(
                name: "GhiChuHoaDon",
                table: "HoaDon",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BanID",
                table: "ChiTietHoaDon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HoVaTenNhanVien",
                table: "ChiTietHoaDon",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NhanVienID",
                table: "ChiTietHoaDon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDon_BanID",
                table: "ChiTietHoaDon",
                column: "BanID");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDon_Ban_BanID",
                table: "ChiTietHoaDon",
                column: "BanID",
                principalTable: "Ban",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDon_Ban_BanID",
                table: "ChiTietHoaDon");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietHoaDon_BanID",
                table: "ChiTietHoaDon");

            migrationBuilder.DropColumn(
                name: "GhiChuHoaDon",
                table: "HoaDon");

            migrationBuilder.DropColumn(
                name: "BanID",
                table: "ChiTietHoaDon");

            migrationBuilder.DropColumn(
                name: "HoVaTenNhanVien",
                table: "ChiTietHoaDon");

            migrationBuilder.DropColumn(
                name: "NhanVienID",
                table: "ChiTietHoaDon");

            migrationBuilder.CreateTable(
                name: "NhaCungCap",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenNCC = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCap", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NguyenLieu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NhaCungCapID = table.Column<int>(type: "int", nullable: false),
                    DonViTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuongTon = table.Column<double>(type: "float", nullable: false),
                    TenNguyenLieu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguyenLieu", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NguyenLieu_NhaCungCap_NhaCungCapID",
                        column: x => x.NhaCungCapID,
                        principalTable: "NhaCungCap",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuNhap",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NhaCungCapID = table.Column<int>(type: "int", nullable: false),
                    NgayNhap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuNhap", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PhieuNhap_NhaCungCap_NhaCungCapID",
                        column: x => x.NhaCungCapID,
                        principalTable: "NhaCungCap",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuNhap",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NguyenLieuID = table.Column<int>(type: "int", nullable: false),
                    PhieuNhapID = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    SoLuong = table.Column<double>(type: "float", nullable: false),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuNhap", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuNhap_NguyenLieu_NguyenLieuID",
                        column: x => x.NguyenLieuID,
                        principalTable: "NguyenLieu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuNhap_PhieuNhap_PhieuNhapID",
                        column: x => x.PhieuNhapID,
                        principalTable: "PhieuNhap",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuNhap_NguyenLieuID",
                table: "ChiTietPhieuNhap",
                column: "NguyenLieuID");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuNhap_PhieuNhapID",
                table: "ChiTietPhieuNhap",
                column: "PhieuNhapID");

            migrationBuilder.CreateIndex(
                name: "IX_NguyenLieu_NhaCungCapID",
                table: "NguyenLieu",
                column: "NhaCungCapID");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhap_NhaCungCapID",
                table: "PhieuNhap",
                column: "NhaCungCapID");
        }
    }
}
