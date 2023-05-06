using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TazosStore.Server.Models;

public class Tazo
{
    public int Id { get; set; }
    //DataAnnotations
    [Required][StringLength(50)]
    public required string Name { get; set; }
    [Required][StringLength(20)]
    public required string Material { get; set; }
    [Required][StringLength(20)]
    public required string SerialNumber { get; set; }
    [Required][StringLength(20)]
    public required string Theme { get; set; }
    [Required]
    public required string Size { get; set; }
    [Required][Range (1,100)]
    public required decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }

}