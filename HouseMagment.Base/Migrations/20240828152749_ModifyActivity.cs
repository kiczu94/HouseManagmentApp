using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseManagment.Migrations
{
    /// <inheritdoc />
    public partial class ModifyActivity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "personId",
                table: "Activity",
                newName: "responsiblePersonId");

            migrationBuilder.AddColumn<bool>(
                name: "isFinished",
                table: "Activity",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isFinished",
                table: "Activity");

            migrationBuilder.RenameColumn(
                name: "responsiblePersonId",
                table: "Activity",
                newName: "personId");
        }
    }
}
