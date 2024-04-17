using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proposals.API.Migrations
{
    /// <inheritdoc />
    public partial class FK_Experiment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExperimentId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Experiment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_ExperimentId",
                table: "Users",
                column: "ExperimentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Experiment_ExperimentId",
                table: "Users",
                column: "ExperimentId",
                principalTable: "Experiment",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Experiment_ExperimentId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ExperimentId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ExperimentId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Experiment");
        }
    }
}
