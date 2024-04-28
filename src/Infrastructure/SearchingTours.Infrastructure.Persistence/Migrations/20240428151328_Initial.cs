using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SearchingTours.Infrastructure.Persistence.Migrations;

/// <inheritdoc />
public partial class Initial : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "TravelAgencies",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uuid", nullable: false),
                Name = table.Column<string>(type: "text", nullable: true),
                ContactInfo = table.Column<string>(type: "text", nullable: true),
                Password = table.Column<string>(type: "text", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_TravelAgencies", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Users",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uuid", nullable: false),
                Username = table.Column<string>(type: "text", nullable: true),
                Email = table.Column<string>(type: "text", nullable: true),
                Password = table.Column<string>(type: "text", nullable: true),
                City = table.Column<string>(type: "text", nullable: true),
                Phone = table.Column<string>(type: "text", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Users", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "TravelPackages",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uuid", nullable: false),
                TravelAgencyId = table.Column<Guid>(type: "uuid", nullable: true),
                Name = table.Column<string>(type: "text", nullable: true),
                AmountOfPackage = table.Column<int>(type: "integer", nullable: true),
                AmountOfPeople = table.Column<int>(type: "integer", nullable: true),
                Destination = table.Column<string>(type: "text", nullable: true),
                Price = table.Column<decimal>(type: "numeric", nullable: true),
                Rating = table.Column<double>(type: "double precision", nullable: true),
                StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                Description = table.Column<string>(type: "text", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_TravelPackages", x => x.Id);
                table.ForeignKey(
                    name: "FK_TravelPackages_TravelAgencies_TravelAgencyId",
                    column: x => x.TravelAgencyId,
                    principalTable: "TravelAgencies",
                    principalColumn: "Id");
            });

        migrationBuilder.CreateTable(
            name: "Reviews",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uuid", nullable: false),
                TravelPackageId = table.Column<Guid>(type: "uuid", nullable: true),
                Text = table.Column<string>(type: "text", nullable: true),
                Rating = table.Column<int>(type: "integer", nullable: true),
                AuthorName = table.Column<string>(type: "text", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Reviews", x => x.Id);
                table.ForeignKey(
                    name: "FK_Reviews_TravelPackages_TravelPackageId",
                    column: x => x.TravelPackageId,
                    principalTable: "TravelPackages",
                    principalColumn: "Id");
            });

        migrationBuilder.CreateIndex(
            name: "IX_Reviews_TravelPackageId",
            table: "Reviews",
            column: "TravelPackageId");

        migrationBuilder.CreateIndex(
            name: "IX_TravelPackages_TravelAgencyId",
            table: "TravelPackages",
            column: "TravelAgencyId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Reviews");

        migrationBuilder.DropTable(
            name: "Users");

        migrationBuilder.DropTable(
            name: "TravelPackages");

        migrationBuilder.DropTable(
            name: "TravelAgencies");
    }
}
