using System.ComponentModel.DataAnnotations;

namespace Festivity.Models;
public class Festivals
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public string? Season { get; set; }
    public DateTime Period { get; set; }
}