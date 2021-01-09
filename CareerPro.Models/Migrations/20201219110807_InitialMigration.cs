using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CareerPro.Model.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    ProfilePicUrl = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    UserType = table.Column<int>(nullable: false),
                    ActiveUser = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobCategories",
                columns: table => new
                {
                    CategoryID = table.Column<string>(nullable: false),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobCategories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    JobID = table.Column<string>(nullable: false),
                    PostedByID = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    CategoryID = table.Column<string>(nullable: true),
                    Salary = table.Column<decimal>(type: "money", nullable: false),
                    DatePublished = table.Column<DateTime>(nullable: false),
                    Deadline = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.JobID);
                    table.ForeignKey(
                        name: "FK_Jobs_JobCategories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "JobCategories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jobs_AspNetUsers_PostedByID",
                        column: x => x.PostedByID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ActiveUser", "Address", "ConcurrencyStamp", "DateAdded", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicUrl", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[,]
                {
                    { "userid1", 0, true, "Mirpur-2, Dhaka", "290eb678-df97-4c87-b2c1-acb95f19d843", new DateTime(2020, 12, 19, 11, 8, 6, 789, DateTimeKind.Utc).AddTicks(6615), "johnsmith@gmail.com", false, false, null, null, null, null, "0123456789", false, "img/featured-listing-2.jpg", "35873d34-9411-45b0-a513-5f3d20d7f8b5", false, "johnsmith", 0 },
                    { "userid2", 0, true, "Banani, Dhaka", "28827232-1c8d-4a8e-b990-6befc261b172", new DateTime(2020, 12, 19, 11, 8, 6, 789, DateTimeKind.Utc).AddTicks(9131), "doesup@gmail.com", false, false, null, null, null, null, "9123456789", false, "img/featured-listing-4.jpg", "36cca7d3-dfd7-4b4e-9805-677b7d169080", false, "doesup", 0 },
                    { "userid4", 0, true, "Headquarter: Kualalampur, Malaysia, Regional office: Dhaka, Bangladesh", "2c1adcc6-9e10-4f6e-b26e-c22137abff20", new DateTime(2020, 12, 19, 11, 8, 6, 789, DateTimeKind.Utc).AddTicks(9180), "abccorp@gmail.com", false, false, null, null, null, null, "79746565421", false, "img/featured-listing-1.jpg", "2adab955-a68e-422d-8b9a-862fc088bad7", false, "abccorp", 1 },
                    { "userid5", 0, true, "Dhaka, Bangladesh", "c6e9de0d-672a-4300-8ad5-e977e0b3578e", new DateTime(2020, 12, 19, 11, 8, 6, 789, DateTimeKind.Utc).AddTicks(9189), "smartsoftware@gmail.com", false, false, null, null, null, null, "6546541166", false, "img/featured-listing-5.jpg", "59d07940-6999-4632-9e8b-8823ec3d72ae", false, "smartsoftware", 1 }
                });

            migrationBuilder.InsertData(
                table: "JobCategories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { "IT", "IT" },
                    { "programmer", "Computer Programming" },
                    { "engg", "Engineering" },
                    { "analyst", "Data Analysis" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "JobID", "Address", "CategoryID", "DatePublished", "Deadline", "Description", "PostedByID", "Salary", "Title" },
                values: new object[,]
                {
                    { "job2", "Khulna, Bangladesh", "IT", new DateTime(2020, 12, 19, 11, 8, 6, 792, DateTimeKind.Utc).AddTicks(364), new DateTime(2021, 5, 19, 11, 8, 6, 792, DateTimeKind.Unspecified).AddTicks(380), "We are looking for an experienced Digital Marketing Specialist who has efficient skill and experienced in Digital Marketing.", "userid4", 50000m, "Digital Marketing Specialist" },
                    { "job4", "Khulna, Bangladesh", "IT", new DateTime(2020, 12, 19, 11, 8, 6, 792, DateTimeKind.Utc).AddTicks(520), new DateTime(2021, 5, 19, 11, 8, 6, 792, DateTimeKind.Unspecified).AddTicks(521), "We are looking for an experienced Digital Marketing Intern who has skill and experienced in Digital Marketing.", "userid5", 10000m, "Digital Marketing Intern" },
                    { "job9", "Dhaka, Bangladesh", "IT", new DateTime(2020, 12, 19, 11, 8, 6, 792, DateTimeKind.Utc).AddTicks(534), new DateTime(2021, 5, 19, 11, 8, 6, 792, DateTimeKind.Unspecified).AddTicks(535), "We are looking for an experienced Software Engineer who has efficient Codign skill and experienced in ASP.NET Core Tech.", "userid4", 60000m, "Support Engineer" },
                    { "job10", "Khulna, Bangladesh", "IT", new DateTime(2020, 12, 19, 11, 8, 6, 792, DateTimeKind.Utc).AddTicks(537), new DateTime(2021, 5, 19, 11, 8, 6, 792, DateTimeKind.Unspecified).AddTicks(538), "We are looking for an experienced Marketing Specialist who has efficient skill and experienced in Marketing.", "userid1", 50000m, "Product Marketing Specialist" },
                    { "job1", "Dhaka, Bangladesh", "programmer", new DateTime(2020, 12, 19, 11, 8, 6, 791, DateTimeKind.Utc).AddTicks(5498), new DateTime(2021, 5, 19, 11, 8, 6, 791, DateTimeKind.Unspecified).AddTicks(6006), "We are looking for an experienced Software Engineer who has efficient Codign skill and experienced in ASP.NET Core Tech.", "userid1", 60000m, "Software Engineer" },
                    { "job3", "Dhaka, Bangladesh", "programmer", new DateTime(2020, 12, 19, 11, 8, 6, 792, DateTimeKind.Utc).AddTicks(515), new DateTime(2021, 5, 19, 11, 8, 6, 792, DateTimeKind.Unspecified).AddTicks(516), "We are looking for an experienced Data Engineer who has efficient Codign skill and experienced in Big Data.", "userid2", 80000m, "Data Engineer" },
                    { "job5", "Dhaka, Bangladesh", "programmer", new DateTime(2020, 12, 19, 11, 8, 6, 792, DateTimeKind.Utc).AddTicks(523), new DateTime(2021, 5, 19, 11, 8, 6, 792, DateTimeKind.Unspecified).AddTicks(524), "We are looking for an experienced Support Engineer who has efficient Codign skill and experienced in ASP.NET Core Tech.", "userid2", 60000m, "Support Engineer" },
                    { "job6", "Khulna, Bangladesh", "engg", new DateTime(2020, 12, 19, 11, 8, 6, 792, DateTimeKind.Utc).AddTicks(526), new DateTime(2021, 5, 19, 11, 8, 6, 792, DateTimeKind.Unspecified).AddTicks(526), "We are looking for an experienced Mechanical Engineer who has efficient skill and experienced in the field.", "userid5", 50000m, "Mechanical Engineer" },
                    { "job7", "Dhaka, Bangladesh", "engg", new DateTime(2020, 12, 19, 11, 8, 6, 792, DateTimeKind.Utc).AddTicks(528), new DateTime(2021, 5, 19, 11, 8, 6, 792, DateTimeKind.Unspecified).AddTicks(529), "We are looking for an experienced Technical Engineer who has efficient Codign skill and experienced in the Tech.", "userid1", 60000m, "Technical Engineer" },
                    { "job8", "Khulna, Bangladesh", "analyst", new DateTime(2020, 12, 19, 11, 8, 6, 792, DateTimeKind.Utc).AddTicks(531), new DateTime(2021, 5, 19, 11, 8, 6, 792, DateTimeKind.Unspecified).AddTicks(532), "We are looking for an experienced Data analyst who has efficient skill and experienced in the field.", "userid2", 50000m, "Data analyst" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_CategoryID",
                table: "Jobs",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_PostedByID",
                table: "Jobs",
                column: "PostedByID");
        }

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
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "JobCategories");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
