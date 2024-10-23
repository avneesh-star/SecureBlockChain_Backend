using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecureBlockChain_Backend.Migrations
{
    public partial class createdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllBlockChains",
                columns: table => new
                {
                    BlockChainID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Difficulty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllBlockChains", x => x.BlockChainID);
                });

            migrationBuilder.CreateTable(
                name: "PendingTransaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SchemeId = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PendingTransaction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductsInfos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductCreator = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsInfos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "schemeInfos",
                columns: table => new
                {
                    ShcemeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShcemeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShcemeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schemeInfos", x => x.ShcemeId);
                });

            migrationBuilder.CreateTable(
                name: "SupplyBlocks",
                columns: table => new
                {
                    BlockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChainId = table.Column<int>(type: "int", nullable: false),
                    CurrentHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nounce = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    PreviousHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlockAddedTimeStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyBlocks", x => x.BlockId);
                });

            migrationBuilder.CreateTable(
                name: "UserAccounts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccessRights = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssociatedProductTypes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccounts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Verifier_1Blocks",
                columns: table => new
                {
                    BlockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChainId = table.Column<int>(type: "int", nullable: false),
                    CurrentHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nounce = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    PreviousHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlockAddedTimeStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verifier_1Blocks", x => x.BlockId);
                });

            migrationBuilder.CreateTable(
                name: "Verifier_2Blocks",
                columns: table => new
                {
                    BlockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChainId = table.Column<int>(type: "int", nullable: false),
                    CurrentHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nounce = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    PreviousHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlockAddedTimeStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verifier_2Blocks", x => x.BlockId);
                });

            migrationBuilder.CreateTable(
                name: "Verifier_3Blocks",
                columns: table => new
                {
                    BlockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChainId = table.Column<int>(type: "int", nullable: false),
                    CurrentHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nounce = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    PreviousHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlockAddedTimeStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verifier_3Blocks", x => x.BlockId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllBlockChains");

            migrationBuilder.DropTable(
                name: "PendingTransaction");

            migrationBuilder.DropTable(
                name: "ProductsInfos");

            migrationBuilder.DropTable(
                name: "schemeInfos");

            migrationBuilder.DropTable(
                name: "SupplyBlocks");

            migrationBuilder.DropTable(
                name: "UserAccounts");

            migrationBuilder.DropTable(
                name: "Verifier_1Blocks");

            migrationBuilder.DropTable(
                name: "Verifier_2Blocks");

            migrationBuilder.DropTable(
                name: "Verifier_3Blocks");
        }
    }
}
