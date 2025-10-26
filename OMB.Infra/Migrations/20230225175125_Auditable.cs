using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OMB.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Auditable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "value",
                table: "OMBConfiguration",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "key",
                table: "OMBConfiguration",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "createdate",
                table: "OMBConfiguration",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "createby",
                table: "OMBConfiguration",
                newName: "CreateBy");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "OMBConfiguration",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updatedate",
                table: "OMBConfiguration",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "updateby",
                table: "OMBConfiguration",
                newName: "UpdatedBy");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "OMBConfiguration",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "OMBConfiguration");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "OMBConfiguration",
                newName: "value");

            migrationBuilder.RenameColumn(
                name: "Key",
                table: "OMBConfiguration",
                newName: "key");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "OMBConfiguration",
                newName: "createdate");

            migrationBuilder.RenameColumn(
                name: "CreateBy",
                table: "OMBConfiguration",
                newName: "createby");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "OMBConfiguration",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "OMBConfiguration",
                newName: "updatedate");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "OMBConfiguration",
                newName: "updateby");
        }
    }
}
