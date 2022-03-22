
using System.ComponentModel.DataAnnotations;

public class User
{
    [Required]
    public int Id { get; set; }

    [MaxLength(50)]
    public string FirstName { get; set; } = string.Empty;

    [MaxLength(50)]
    public string LastName { get; set; } = string.Empty;
}