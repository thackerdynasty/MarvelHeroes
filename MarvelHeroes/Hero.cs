using System.ComponentModel.DataAnnotations;

namespace MarvelHeroes;

public class Hero
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public string Power { get; set; }
}
