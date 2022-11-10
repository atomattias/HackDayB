using System.ComponentModel.DataAnnotations;

namespace Festivity.Models;
public class Landmarks
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Country { get; set; }
    
}