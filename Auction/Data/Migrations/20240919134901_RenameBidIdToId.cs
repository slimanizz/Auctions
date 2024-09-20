using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Auction.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameBidIdToId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BidId",
                table: "bids",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "bids",
                newName: "BidId");
        }
    }
}
