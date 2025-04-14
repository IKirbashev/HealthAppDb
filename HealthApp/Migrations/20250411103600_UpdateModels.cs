using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_medications",
                table: "medications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_healthRecords",
                table: "healthRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_documents",
                table: "documents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_biomarkers",
                table: "biomarkers");

            migrationBuilder.DropColumn(
                name: "Recomendations",
                table: "healthRecords");

            migrationBuilder.RenameTable(
                name: "medications",
                newName: "Medications");

            migrationBuilder.RenameTable(
                name: "healthRecords",
                newName: "HealthRecords");

            migrationBuilder.RenameTable(
                name: "documents",
                newName: "Documents");

            migrationBuilder.RenameTable(
                name: "biomarkers",
                newName: "Biomarkers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Medications",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Frequency",
                table: "Medications",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Medications",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Dosage",
                table: "Medications",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "HealthRecords",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Symptoms",
                table: "HealthRecords",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Recommendations",
                table: "HealthRecords",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Documents",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "Documents",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UploadDate",
                table: "Documents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<decimal>(
                name: "Value",
                table: "Biomarkers",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Unit",
                table: "Biomarkers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Biomarkers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medications",
                table: "Medications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HealthRecords",
                table: "HealthRecords",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Documents",
                table: "Documents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Biomarkers",
                table: "Biomarkers",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Medications",
                table: "Medications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HealthRecords",
                table: "HealthRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Documents",
                table: "Documents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Biomarkers",
                table: "Biomarkers");

            migrationBuilder.DropColumn(
                name: "Recommendations",
                table: "HealthRecords");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "UploadDate",
                table: "Documents");

            migrationBuilder.RenameTable(
                name: "Medications",
                newName: "medications");

            migrationBuilder.RenameTable(
                name: "HealthRecords",
                newName: "healthRecords");

            migrationBuilder.RenameTable(
                name: "Documents",
                newName: "documents");

            migrationBuilder.RenameTable(
                name: "Biomarkers",
                newName: "biomarkers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "medications",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Frequency",
                table: "medications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "medications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Dosage",
                table: "medications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "healthRecords",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Symptoms",
                table: "healthRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recomendations",
                table: "healthRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<decimal>(
                name: "Value",
                table: "biomarkers",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Unit",
                table: "biomarkers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "biomarkers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddPrimaryKey(
                name: "PK_medications",
                table: "medications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_healthRecords",
                table: "healthRecords",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_documents",
                table: "documents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_biomarkers",
                table: "biomarkers",
                column: "Id");
        }
    }
}
