using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRM_VUS.Migrations
{
    /// <inheritdoc />
    public partial class ms1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KindOfSchedules",
                table: "tschedules");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KindOfSchedules",
                table: "tschedules",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
