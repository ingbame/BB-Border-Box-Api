using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BBBorderBox.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Telegram");

            migrationBuilder.CreateTable(
                name: "ChatsUpdates",
                schema: "Telegram",
                columns: table => new
                {
                    UpdateId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageId = table.Column<long>(type: "bigint", nullable: false),
                    Date = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    MessageText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserId = table.Column<long>(type: "bigint", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChatId = table.Column<long>(type: "bigint", nullable: false),
                    TypedCommand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReturnResponse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NeedHuman = table.Column<bool>(type: "bit", nullable: false),
                    TalkingWithHuman = table.Column<bool>(type: "bit", nullable: false),
                    EmployId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatsUpdates_UpdateId", x => x.UpdateId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChatsUpdates",
                schema: "Telegram");
        }
    }
}
