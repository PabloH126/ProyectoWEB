using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoBanco.Server.Models;

[Table("detalles_prestamo")]
public partial class DetallesPrestamo
{
    [Key]
    [Column("Detalles_P", TypeName = "int(11)")]
    public long DetallesP { get; set; }

    [Column("Fecha_Solicitud", TypeName = "int(11)")]
    public long? FechaSolicitud { get; set; }

    [Column("Fecha_Aprobacion", TypeName = "int(11)")]
    public long? FechaAprobacion { get; set; }

    [Column("Fecha_Liquidacion", TypeName = "int(11)")]
    public long? FechaLiquidacion { get; set; }

    [Column(TypeName = "int(11)")]
    public long? Periodo { get; set; }

    [InverseProperty("DetallesPNavigation")]
    public virtual ICollection<IdProvider> IdProviders { get; } = new List<IdProvider>();

    [InverseProperty("DetallesPNavigation")]
    public virtual ICollection<Prestamo> Prestamos { get; } = new List<Prestamo>();
}
