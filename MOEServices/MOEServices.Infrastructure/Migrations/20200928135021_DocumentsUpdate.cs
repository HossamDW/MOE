using Microsoft.EntityFrameworkCore.Migrations;

namespace MOEServices.Infrastructure.Migrations
{
    public partial class DocumentsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdCardPath",
                table: "CertificateAttestation",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "CertificateAttestation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StudyCertificatePath",
                table: "CertificateAttestation",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCardPath",
                table: "CertificateAttestation");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "CertificateAttestation");

            migrationBuilder.DropColumn(
                name: "StudyCertificatePath",
                table: "CertificateAttestation");
        }
    }
}
