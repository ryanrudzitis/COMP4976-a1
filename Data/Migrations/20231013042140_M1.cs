using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment1.Data.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contact List",
                columns: table => new
                {
                    AccountNo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Street = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    PostalCode = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Modified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact List", x => x.AccountNo);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                columns: table => new
                {
                    PaymentMethodId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Modified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.PaymentMethodId);
                });

            migrationBuilder.CreateTable(
                name: "TransactionType",
                columns: table => new
                {
                    TransactionTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Modified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionType", x => x.TransactionTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Donations",
                columns: table => new
                {
                    TransId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TransactionTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    AccountNo = table.Column<int>(type: "INTEGER", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Amount = table.Column<float>(type: "REAL", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Modified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donations", x => x.TransId);
                    table.ForeignKey(
                        name: "FK_Donations_Contact List_AccountNo",
                        column: x => x.AccountNo,
                        principalTable: "Contact List",
                        principalColumn: "AccountNo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Donations_PaymentMethod_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethod",
                        principalColumn: "PaymentMethodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Donations_TransactionType_TransactionTypeId",
                        column: x => x.TransactionTypeId,
                        principalTable: "TransactionType",
                        principalColumn: "TransactionTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "867eac6e-d939-4ae9-8a7b-c3c6d4868777", null, new DateTime(2023, 10, 12, 21, 21, 40, 828, DateTimeKind.Local).AddTicks(780), "Admin", "ADMIN" },
                    { "ba1b347b-8a9b-4597-a057-9b28d2b26675", null, new DateTime(2023, 10, 12, 21, 21, 40, 828, DateTimeKind.Local).AddTicks(870), "Finance", "FINANCE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1e54bc8f-e32e-4a63-b2db-c3d6eb6e6d62", 0, "c9d19113-5a00-48f2-85c5-0aa5b73ad363", "f@f.f", true, false, null, "F@F.F", "F@F.F", "AQAAAAIAAYagAAAAEI4UIyh0/pfV1fL7qUgOjTR2UFKVK0zu6is254E5LimFNTkJUeQcKTcf/Y/m8ft3Uw==", null, false, "755b7bb6-1100-4b58-b1bc-559f15e0518a", false, "f@f.f" },
                    { "ff725bcb-20dd-4ce8-ae35-519d4c418b27", 0, "12fa0155-45bf-403e-b0c8-633c3d01082f", "a@a.a", true, false, null, "A@A.A", "A@A.A", "AQAAAAIAAYagAAAAEKQuu04n4u8l622b88C2ig0QRrxbDKGJJ/4X/OOvz6hh8H90pdr0gu0uEN/6SUKl2w==", null, false, "42ed5b83-bcb7-4402-af4e-7af23b2c87cb", false, "a@a.a" }
                });

            migrationBuilder.InsertData(
                table: "Contact List",
                columns: new[] { "AccountNo", "City", "Country", "Created", "CreatedBy", "Email", "FirstName", "LastName", "Modified", "ModifiedBy", "PostalCode", "Street" },
                values: new object[,]
                {
                    { 1, "Maple Ridge", "Canada", new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7700), "a@a.a", "john.doe@example.com", "John", "Doe", new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7710), "a@a.a", "12345", "123 Main St" },
                    { 2, "Dallas", "USA", new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7720), "a@a.a", "jane.smith@example.com", "Jane", "Smith", new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7720), "a@a.a", "67890", "456 Elm St" },
                    { 3, "Oakville", "Canada", new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7720), "a@a.a", "alice.johnson@example.com", "Alice", "Johnson", new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7720), "a@a.a", "54321", "789 Oak St" }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "PaymentMethodId", "Created", "CreatedBy", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7770), "a@a.a", new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7770), "a@a.a", "Cash" },
                    { 2, new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7770), "a@a.a", new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7780), "a@a.a", "Credit Card" },
                    { 3, new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7780), "a@a.a", new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7780), "a@a.a", "PayPal" }
                });

            migrationBuilder.InsertData(
                table: "TransactionType",
                columns: new[] { "TransactionTypeId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7750), "a@a.a", "Donation", new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7750), "a@a.a", "Donation" },
                    { 2, new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7750), "a@a.a", "Pledge", new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7750), "a@a.a", "Pledge" },
                    { 3, new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7750), "a@a.a", "Event", new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7750), "a@a.a", "Event" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ba1b347b-8a9b-4597-a057-9b28d2b26675", "1e54bc8f-e32e-4a63-b2db-c3d6eb6e6d62" },
                    { "867eac6e-d939-4ae9-8a7b-c3c6d4868777", "ff725bcb-20dd-4ce8-ae35-519d4c418b27" }
                });

            migrationBuilder.InsertData(
                table: "Donations",
                columns: new[] { "TransId", "AccountNo", "Amount", "Created", "CreatedBy", "Date", "Modified", "ModifiedBy", "Notes", "PaymentMethodId", "TransactionTypeId" },
                values: new object[,]
                {
                    { 1, 1, 100f, new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7800), "a@a.a", new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7790), new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7800), "a@a.a", "Donation 1", 1, 1 },
                    { 2, 2, 200f, new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7810), "a@a.a", new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7800), new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7810), "a@a.a", "Dontation 2", 2, 2 },
                    { 3, 3, 300f, new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7810), "a@a.a", new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7810), new DateTime(2023, 10, 12, 21, 21, 40, 902, DateTimeKind.Local).AddTicks(7810), "a@a.a", "Donation 3", 3, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Donations_AccountNo",
                table: "Donations",
                column: "AccountNo");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_PaymentMethodId",
                table: "Donations",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_TransactionTypeId",
                table: "Donations",
                column: "TransactionTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Donations");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Contact List");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "TransactionType");
        }
    }
}
