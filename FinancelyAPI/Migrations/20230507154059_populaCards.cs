using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinancelyAPI.Migrations
{
    /// <inheritdoc />
    public partial class populaCards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Cards(CardNumber,Name,creditLimit,CardLogo,UserId) Values('1234', 'Nubank', '4500', 'https://gkpb.com.br/wp-content/uploads/2021/05/novo-logo-nubank-fundo-roxo.jpg', '1')");
            migrationBuilder.Sql("Insert into Cards(CardNumber,Name,creditLimit,CardLogo,UserId) Values('6789', 'Inter', '7300', 'https://upload.wikimedia.org/wikipedia/commons/thumb/3/36/Logo-banco-inter.svg/2560px-Logo-banco-inter.svg.png', '1')");
            migrationBuilder.Sql("Insert into Cards(CardNumber,Name,creditLimit,CardLogo,UserId) Values('5432', 'Nubank', '1500', 'https://gkpb.com.br/wp-content/uploads/2021/05/novo-logo-nubank-fundo-roxo.jpg', '2')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Cards");

        }
    }
}
