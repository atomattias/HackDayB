using System.ComponentModel.DataAnnotations;


public class Countries
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? continet { get; set; }
    public string? Population { get; set; }
    public List<Festivals>? Festivals { get; set; }

}