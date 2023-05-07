using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinancelyAPI.Models;

[Table("Users")]

public class User
{

    public User(){
        Cards = new Collection<Card>();
    }

    [Key]
	public int UserId { get; set; }

    [Required]
    [StringLength(80)]
	public string? Name { get; set; }

    [Required]
    [StringLength(80)]
    public string? Email { get; set; }

    [Required]
    [StringLength(50)]
    public string? Password { get; set; }

    [Required]
    [StringLength(300)]
    public string? Avatar { get; set; }

    public ICollection<Card> Cards { get; set; }

}

