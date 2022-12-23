using Microsoft.EntityFrameworkCore.Migrations;

namespace InventorySekolah.Migrations
{
    public partial class addLaporan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PemeliharaanId",
                table: "Laporans",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PengadaanId",
                table: "Laporans",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Laporans_PemeliharaanId",
                table: "Laporans",
                column: "PemeliharaanId");

            migrationBuilder.CreateIndex(
                name: "IX_Laporans_PengadaanId",
                table: "Laporans",
                column: "PengadaanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Laporans_Pemeliharaans_PemeliharaanId",
                table: "Laporans",
                column: "PemeliharaanId",
                principalTable: "Pemeliharaans",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Laporans_Pengadaans_PengadaanId",
                table: "Laporans",
                column: "PengadaanId",
                principalTable: "Pengadaans",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Laporans_Pemeliharaans_PemeliharaanId",
                table: "Laporans");

            migrationBuilder.DropForeignKey(
                name: "FK_Laporans_Pengadaans_PengadaanId",
                table: "Laporans");

            migrationBuilder.DropIndex(
                name: "IX_Laporans_PemeliharaanId",
                table: "Laporans");

            migrationBuilder.DropIndex(
                name: "IX_Laporans_PengadaanId",
                table: "Laporans");

            migrationBuilder.DropColumn(
                name: "PemeliharaanId",
                table: "Laporans");

            migrationBuilder.DropColumn(
                name: "PengadaanId",
                table: "Laporans");
        }
    }
}
