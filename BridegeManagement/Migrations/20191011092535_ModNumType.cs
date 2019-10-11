using Microsoft.EntityFrameworkCore.Migrations;

namespace BridegeManagement.Migrations
{
    public partial class ModNumType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Num",
                table: "Damages",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Num",
                table: "Damages",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
