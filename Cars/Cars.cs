using System.ComponentModel.DataAnnotations;
namespace VimsAPI;

public class Cars
{
    public int city_mpg { get; set; }
    public string @class { get; set; }
    public int combination_mpg { get; set; }
    public int cylinders { get; set; }
    public double displacement { get; set; }
    public string drive { get; set; }
    public string fuel_type { get; set; }
    public int highway_mpg { get; set; }
    [Required]
    public string make { get; set; }
    [Required]
    public string model { get; set; }
    public string transmission { get; set; }
    public int year { get; set; }
}