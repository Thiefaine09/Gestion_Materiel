using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GestionMatériel.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodePostal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateur",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateur", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materiel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marque = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Num_Serie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_Install = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materiel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materiel_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Intervention",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Commentaire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Technicien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterielId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intervention", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Intervention_Materiel_MaterielId",
                        column: x => x.MaterielId,
                        principalTable: "Materiel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "Adresse", "CodePostal", "Email", "Nom", "Prenom", "Telephone", "Ville" },
                values: new object[,]
                {
                    { 1, "34, rue de Bellevue", "77340", "laurent.herique@laposte.net", "HERIQUE", "Laurent", "0627495967", "Pontault Combault" },
                    { 2, "4, rue Charles Bras", "77230", "vincent.gourdin@gm.com", "GOURDIN", "Vincent", "0627657889", "Emerainville" }
                });

            migrationBuilder.InsertData(
                table: "Utilisateur",
                columns: new[] { "Id", "Login", "Password", "Role" },
                values: new object[] { 1, "thiefaine@gmail.com", "2A14BD9B87AF2EB07E98A80F7BD35FD545C1C1CC1EFBCCB35B086C99615C96F8CC41126A21B4A7C4030163C674D549699037BE3E4E1F3BBB3A08B927553DB951", "Admin" });

            migrationBuilder.InsertData(
                table: "Materiel",
                columns: new[] { "Id", "ClientId", "Date_Install", "Marque", "Num_Serie", "Type" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 4, 18, 12, 12, 7, 240, DateTimeKind.Local).AddTicks(6474), "Dell", "233986937902", "Ordinateur" },
                    { 2, 1, new DateTime(2023, 4, 18, 12, 12, 7, 240, DateTimeKind.Local).AddTicks(6525), "IIyama", "56677887902", "Ecran" },
                    { 3, 2, new DateTime(2023, 4, 18, 12, 12, 7, 240, DateTimeKind.Local).AddTicks(6527), "HP", "87566777021", "Imprimante" }
                });

            migrationBuilder.InsertData(
                table: "Intervention",
                columns: new[] { "Id", "Commentaire", "Date", "MaterielId", "Technicien" },
                values: new object[] { 1, "Bourrage récurent", new DateTime(2023, 4, 18, 12, 12, 7, 240, DateTimeKind.Local).AddTicks(6538), 3, "Adrien" });

            migrationBuilder.CreateIndex(
                name: "IX_Intervention_MaterielId",
                table: "Intervention",
                column: "MaterielId");

            migrationBuilder.CreateIndex(
                name: "IX_Materiel_ClientId",
                table: "Materiel",
                column: "ClientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Intervention");

            migrationBuilder.DropTable(
                name: "Utilisateur");

            migrationBuilder.DropTable(
                name: "Materiel");

            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
