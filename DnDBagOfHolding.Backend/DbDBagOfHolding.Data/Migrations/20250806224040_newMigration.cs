using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DnDBagOfHolding.Data.Migrations
{
    /// <inheritdoc />
    public partial class newMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContainerAssignments_Characters_CharacterId1",
                table: "ContainerAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_ContainerAssignments_Containers_ContainerId1",
                table: "ContainerAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Containers_ContainerTypes_ContainerTypeId1",
                table: "Containers");

            migrationBuilder.DropIndex(
                name: "IX_Containers_ContainerTypeId1",
                table: "Containers");

            migrationBuilder.DropIndex(
                name: "IX_ContainerAssignments_CharacterId1",
                table: "ContainerAssignments");

            migrationBuilder.DropIndex(
                name: "IX_ContainerAssignments_ContainerId1",
                table: "ContainerAssignments");

            migrationBuilder.DropColumn(
                name: "ContainerTypeId1",
                table: "Containers");

            migrationBuilder.DropColumn(
                name: "CharacterId1",
                table: "ContainerAssignments");

            migrationBuilder.DropColumn(
                name: "ContainerId1",
                table: "ContainerAssignments");

            migrationBuilder.AlterColumn<long>(
                name: "ItemId",
                table: "ItemAssignments",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<long>(
                name: "ContainerId",
                table: "ItemAssignments",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<long>(
                name: "CharacterId",
                table: "ItemAssignments",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<long>(
                name: "ContainerTypeId",
                table: "Containers",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<long>(
                name: "ContainerId",
                table: "ContainerAssignments",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<long>(
                name: "CharacterId",
                table: "ContainerAssignments",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "Characters",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Containers_ContainerTypeId",
                table: "Containers",
                column: "ContainerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ContainerAssignments_CharacterId",
                table: "ContainerAssignments",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_ContainerAssignments_ContainerId",
                table: "ContainerAssignments",
                column: "ContainerId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_UserId",
                table: "Characters",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Users_UserId",
                table: "Characters",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContainerAssignments_Characters_CharacterId",
                table: "ContainerAssignments",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContainerAssignments_Containers_ContainerId",
                table: "ContainerAssignments",
                column: "ContainerId",
                principalTable: "Containers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Containers_ContainerTypes_ContainerTypeId",
                table: "Containers",
                column: "ContainerTypeId",
                principalTable: "ContainerTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Users_UserId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_ContainerAssignments_Characters_CharacterId",
                table: "ContainerAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_ContainerAssignments_Containers_ContainerId",
                table: "ContainerAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Containers_ContainerTypes_ContainerTypeId",
                table: "Containers");

            migrationBuilder.DropIndex(
                name: "IX_Containers_ContainerTypeId",
                table: "Containers");

            migrationBuilder.DropIndex(
                name: "IX_ContainerAssignments_CharacterId",
                table: "ContainerAssignments");

            migrationBuilder.DropIndex(
                name: "IX_ContainerAssignments_ContainerId",
                table: "ContainerAssignments");

            migrationBuilder.DropIndex(
                name: "IX_Characters_UserId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Characters");

            migrationBuilder.AlterColumn<Guid>(
                name: "ItemId",
                table: "ItemAssignments",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<Guid>(
                name: "ContainerId",
                table: "ItemAssignments",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<Guid>(
                name: "CharacterId",
                table: "ItemAssignments",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<Guid>(
                name: "ContainerTypeId",
                table: "Containers",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "ContainerTypeId1",
                table: "Containers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<Guid>(
                name: "ContainerId",
                table: "ContainerAssignments",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<Guid>(
                name: "CharacterId",
                table: "ContainerAssignments",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "CharacterId1",
                table: "ContainerAssignments",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ContainerId1",
                table: "ContainerAssignments",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Containers_ContainerTypeId1",
                table: "Containers",
                column: "ContainerTypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_ContainerAssignments_CharacterId1",
                table: "ContainerAssignments",
                column: "CharacterId1");

            migrationBuilder.CreateIndex(
                name: "IX_ContainerAssignments_ContainerId1",
                table: "ContainerAssignments",
                column: "ContainerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ContainerAssignments_Characters_CharacterId1",
                table: "ContainerAssignments",
                column: "CharacterId1",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContainerAssignments_Containers_ContainerId1",
                table: "ContainerAssignments",
                column: "ContainerId1",
                principalTable: "Containers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Containers_ContainerTypes_ContainerTypeId1",
                table: "Containers",
                column: "ContainerTypeId1",
                principalTable: "ContainerTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
