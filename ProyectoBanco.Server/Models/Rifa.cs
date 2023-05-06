using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoBanco.Server.Models;

[Table("rifa")]
public partial class Rifa
{
    [Key]
    [Column("N_Boleto", TypeName = "int(11)")]
    public long NBoleto { get; set; }

    [Column("Fecha_Boleto", TypeName = "int(11)")]
    public long? FechaBoleto { get; set; }

    [InverseProperty("NBoletoNavigation")]
    public virtual ICollection<DetallesCuentum> DetallesCuenta { get; } = new List<DetallesCuentum>();
}
