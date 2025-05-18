using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CP2.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moto_GARAGEM_GaragemId",
                table: "Moto");

            migrationBuilder.DropIndex(
                name: "IX_Moto_GaragemId",
                table: "Moto");

            migrationBuilder.DropColumn(
                name: "GaragemId",
                table: "Moto");

            migrationBuilder.CreateIndex(
                name: "IX_Moto_IdGaragem",
                table: "Moto",
                column: "IdGaragem");

            migrationBuilder.AddForeignKey(
                name: "FK_Moto_GARAGEM_IdGaragem",
                table: "Moto",
                column: "IdGaragem",
                principalTable: "GARAGEM",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moto_GARAGEM_IdGaragem",
                table: "Moto");

            migrationBuilder.DropIndex(
                name: "IX_Moto_IdGaragem",
                table: "Moto");

            migrationBuilder.AddColumn<Guid>(
                name: "GaragemId",
                table: "Moto",
                type: "RAW(16)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Moto_GaragemId",
                table: "Moto",
                column: "GaragemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Moto_GARAGEM_GaragemId",
                table: "Moto",
                column: "GaragemId",
                principalTable: "GARAGEM",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
