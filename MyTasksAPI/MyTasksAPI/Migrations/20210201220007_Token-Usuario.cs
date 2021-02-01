using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTasksAPI.Migrations
{
    public partial class TokenUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Token_AspNetUsers_usuarioId",
                table: "Token");

            migrationBuilder.RenameColumn(
                name: "usuarioId",
                table: "Token",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Token_usuarioId",
                table: "Token",
                newName: "IX_Token_UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Token_AspNetUsers_UsuarioId",
                table: "Token",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Token_AspNetUsers_UsuarioId",
                table: "Token");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Token",
                newName: "usuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Token_UsuarioId",
                table: "Token",
                newName: "IX_Token_usuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Token_AspNetUsers_usuarioId",
                table: "Token",
                column: "usuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
