using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinancelyAPI.Models;

[Table("Cards")]

public class Card
{
    public Card() {
        Bills = new Collection<Bill>();
    }


    [Key]
    public int CardId { get; set; }

    [Required]
    [StringLength(16)]
    public int CardNumber { get; set; }

    [Required]
    [StringLength(80)]
    public string? Name { get; set; }

    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public decimal creditLimit { get; set; }

    [StringLength(300)]
    public string? CardLogo { get; set; }

    public int UserId { get; set; }//foreign key for User tabel

    public User User { get; set; }

    public ICollection <Bill> Bills { get; set; }
}

