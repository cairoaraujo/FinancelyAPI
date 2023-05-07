using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinancelyAPI.Migrations
{
    /// <inheritdoc />
    public partial class populaBills : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Bills(BillValue, ExpiryDate, CardId) Values(500, now(), '1')");
            migrationBuilder.Sql("Insert into Bills(BillValue, ExpiryDate, CardId) Values(700, now(), '2')");
            migrationBuilder.Sql("Insert into Bills(BillValue, ExpiryDate, CardId) Values(350, now(), '3')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Bills");
        }
    }
}
