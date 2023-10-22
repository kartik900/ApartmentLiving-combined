using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace HouseAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    EmployeeName = table.Column<string>(nullable: true),
                    EmployeeDept = table.Column<string>(nullable: true),
                    EmployeeMobile = table.Column<string>(nullable: true),
                    EmployeeEmail = table.Column<string>(nullable: true),
                    EmployeePassword = table.Column<string>(nullable: true),
                    IsApproved = table.Column<string>(nullable: true),
                    EmployeeWallet = table.Column<int>(nullable: true),
                    EmployeeRating = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "HouseList",
                columns: table => new
                {
                    HouseId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IsFree = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseList", x => x.HouseId);
                });

            migrationBuilder.CreateTable(
                name: "Residents",
                columns: table => new
                {
                    ResidentId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ResidentName = table.Column<string>(nullable: true),
                    ResidentHouseNo = table.Column<int>(nullable: true),
                    ResidentType = table.Column<string>(nullable: true),
                    ResidentMobileNo = table.Column<string>(nullable: true),
                    ResidentEmail = table.Column<string>(nullable: true),
                    ResidentPassword = table.Column<string>(nullable: true),
                    IsApproved = table.Column<string>(nullable: true),
                    ResidentWallet = table.Column<int>(nullable: true),
                    ResidentHouseNoNavigationHouseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residents", x => x.ResidentId);
                    table.ForeignKey(
                        name: "FK_Residents_HouseList_ResidentHouseNoNavigationHouseId",
                        column: x => x.ResidentHouseNoNavigationHouseId,
                        principalTable: "HouseList",
                        principalColumn: "HouseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Complaints",
                columns: table => new
                {
                    ComplaintId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ResidentId = table.Column<int>(nullable: true),
                    ComplaintRegarding = table.Column<string>(nullable: true),
                    ComplaintStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaints", x => x.ComplaintId);
                    table.ForeignKey(
                        name: "FK_Complaints_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Residents",
                        principalColumn: "ResidentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DashBoardPosts",
                columns: table => new
                {
                    DashItemId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DashTitle = table.Column<string>(nullable: true),
                    DashType = table.Column<string>(nullable: true),
                    DashBody = table.Column<string>(nullable: true),
                    DashIntendedFor = table.Column<string>(nullable: true),
                    ResidentId = table.Column<int>(nullable: true),
                    DashTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DashBoardPosts", x => x.DashItemId);
                    table.ForeignKey(
                        name: "FK_DashBoardPosts_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Residents",
                        principalColumn: "ResidentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FriendsAndFamily",
                columns: table => new
                {
                    FaFid = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    FaFname = table.Column<string>(nullable: true),
                    ResidentId = table.Column<int>(nullable: true),
                    Relation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FriendsAndFamily", x => x.FaFid);
                    table.ForeignKey(
                        name: "FK_FriendsAndFamily_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Residents",
                        principalColumn: "ResidentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ServiceType = table.Column<string>(nullable: true),
                    AppointmentTime = table.Column<DateTime>(nullable: true),
                    ServiceStatus = table.Column<string>(nullable: true),
                    ServiceMessage = table.Column<string>(nullable: true),
                    ServicePrice = table.Column<int>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: true),
                    ResidentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_Services_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Services_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Residents",
                        principalColumn: "ResidentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    VisitorId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    VisitorName = table.Column<string>(nullable: true),
                    VisitorResaon = table.Column<string>(nullable: true),
                    VisitStartTime = table.Column<DateTime>(nullable: true),
                    VisitEndTime = table.Column<DateTime>(nullable: true),
                    ResidentId = table.Column<int>(nullable: true),
                    VisitorEntryStatus = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.VisitorId);
                    table.ForeignKey(
                        name: "FK_Visitors_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Visitors_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Residents",
                        principalColumn: "ResidentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    PaymentFor = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: true),
                    ResidentId = table.Column<int>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: true),
                    PaymentStatus = table.Column<string>(nullable: true),
                    ServiceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Residents",
                        principalColumn: "ResidentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Complaints_ResidentId",
                table: "Complaints",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_DashBoardPosts_ResidentId",
                table: "DashBoardPosts",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_FriendsAndFamily_ResidentId",
                table: "FriendsAndFamily",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_EmployeeId",
                table: "Payments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ResidentId",
                table: "Payments",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ServiceId",
                table: "Payments",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Residents_ResidentHouseNoNavigationHouseId",
                table: "Residents",
                column: "ResidentHouseNoNavigationHouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_EmployeeId",
                table: "Services",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ResidentId",
                table: "Services",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitors_EmployeeId",
                table: "Visitors",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitors_ResidentId",
                table: "Visitors",
                column: "ResidentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Complaints");

            migrationBuilder.DropTable(
                name: "DashBoardPosts");

            migrationBuilder.DropTable(
                name: "FriendsAndFamily");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Residents");

            migrationBuilder.DropTable(
                name: "HouseList");
        }
    }
}
