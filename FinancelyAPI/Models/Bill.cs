using System;
namespace FinancelyAPI.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Bills")]

public class Bill
{
    [Key]
    public int BillId { get; set; }

    [Required]
    [Column(TypeName ="decimal(10,2)")]
    public decimal BillValue { get; set; }

    public DateTime ExpiryDate { get; set; }

    public int CardId { get; set; } //foreign key to Card tabel

    public Card? Cards { get; set; }

}

