using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shipment.Migrations
{
    /// <inheritdoc />
    public partial class intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "TbCarriers");

            migrationBuilder.DropTable(
                name: "TbCities");

            migrationBuilder.DropTable(
                name: "TbCountries");

            migrationBuilder.DropTable(
                name: "TbPaymentMethods");

            migrationBuilder.DropTable(
                name: "TbSetting");

            migrationBuilder.DropTable(
                name: "TbShippingTypes");

            migrationBuilder.DropTable(
                name: "TbShippments");

            migrationBuilder.DropTable(
                name: "TbShippmentStatus");

            migrationBuilder.DropTable(
                name: "TbSubscriptionPackages");

            migrationBuilder.DropTable(
                name: "TbUserReceivers");

            migrationBuilder.DropTable(
                name: "TbUserSebders");

            migrationBuilder.DropTable(
                name: "TbUserSubscriptions");
        }
    }
}
