using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinancelyAPI.Migrations
{
    /// <inheritdoc />
    public partial class populaUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Users(Name, Email, Password, Avatar) Values('Cairo', 'cairo253@gmail.com','123456', 'https://w7.pngwing.com/pngs/340/946/png-transparent-avatar-user-computer-icons-software-developer-avatar-child-face-heroes-thumbnail.png')");
            migrationBuilder.Sql("Insert into Users(Name, Email, Password, Avatar) Values('Malu', 'britocmalu@gmail.com','123456', 'https://w7.pngwing.com/pngs/129/292/png-transparent-female-avatar-girl-face-woman-user-flat-classy-users-icon.png')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Users");
        }
    }
}
