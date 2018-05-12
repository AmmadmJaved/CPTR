using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Data.Data.Migrations
{
    public partial class PatientDiseaseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Diagnose",
                table: "PatientDisease");

            migrationBuilder.DropColumn(
                name: "DiseaseLevel",
                table: "PatientDisease");

            migrationBuilder.AddColumn<int>(
                name: "DiagnoseId",
                table: "PatientDisease",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiseasePrevalenceId",
                table: "PatientDisease",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Diagnose",
                columns: table => new
                {
                    DiagnoseId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Biopsies = table.Column<string>(nullable: true),
                    Bloodtest = table.Column<string>(nullable: true),
                    ImagingScans = table.Column<string>(nullable: true),
                    Laboratorytest = table.Column<string>(nullable: true),
                    Spinaltap_lumbarPuncture = table.Column<string>(nullable: true),
                    Stoolsample = table.Column<string>(nullable: true),
                    Throatswab = table.Column<string>(nullable: true),
                    Urinetest = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnose", x => x.DiagnoseId);
                });

            migrationBuilder.CreateTable(
                name: "DiseasePrevalence",
                columns: table => new
                {
                    DiseasePrevalenceId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Effectiviness = table.Column<double>(nullable: false),
                    HealthyArea = table.Column<double>(nullable: false),
                    TotalBodyHealth = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiseasePrevalence", x => x.DiseasePrevalenceId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientDisease_DiagnoseId",
                table: "PatientDisease",
                column: "DiagnoseId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDisease_DiseasePrevalenceId",
                table: "PatientDisease",
                column: "DiseasePrevalenceId");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDisease_Diagnose_DiagnoseId",
                table: "PatientDisease",
                column: "DiagnoseId",
                principalTable: "Diagnose",
                principalColumn: "DiagnoseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientDisease_DiseasePrevalence_DiseasePrevalenceId",
                table: "PatientDisease",
                column: "DiseasePrevalenceId",
                principalTable: "DiseasePrevalence",
                principalColumn: "DiseasePrevalenceId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientDisease_Diagnose_DiagnoseId",
                table: "PatientDisease");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientDisease_DiseasePrevalence_DiseasePrevalenceId",
                table: "PatientDisease");

            migrationBuilder.DropTable(
                name: "Diagnose");

            migrationBuilder.DropTable(
                name: "DiseasePrevalence");

            migrationBuilder.DropIndex(
                name: "IX_PatientDisease_DiagnoseId",
                table: "PatientDisease");

            migrationBuilder.DropIndex(
                name: "IX_PatientDisease_DiseasePrevalenceId",
                table: "PatientDisease");

            migrationBuilder.DropColumn(
                name: "DiagnoseId",
                table: "PatientDisease");

            migrationBuilder.DropColumn(
                name: "DiseasePrevalenceId",
                table: "PatientDisease");

            migrationBuilder.AddColumn<string>(
                name: "Diagnose",
                table: "PatientDisease",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DiseaseLevel",
                table: "PatientDisease",
                nullable: true);
        }
    }
}
