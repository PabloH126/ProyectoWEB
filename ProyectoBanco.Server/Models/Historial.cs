using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoBanco.Server.Models;

[Table("historial")]
public partial class Historial
{
    [Key]
    [Column("ID_Historial", TypeName = "int(11)")]
    public long IdHistorial { get; set; }

    [Column(TypeName = "int(11)")]
    public long? Cantidad { get; set; }

    [Column(TypeName = "int(11)")]
    public long? Folio { get; set; }

    [Column("Detalles_H", TypeName = "int(11)")]
    public long? DetallesH { get; set; }

    [InverseProperty("IdHistorialNavigation")]
    public virtual ICollection<DetallesCuentum> DetallesCuenta { get; } = new List<DetallesCuentum>();

    [ForeignKey("DetallesH")]
    [InverseProperty("Historials")]
    public virtual DetallesHistorial? DetallesHNavigation { get; set; }

    [ForeignKey("Folio")]
    [InverseProperty("Historials")]
    public virtual Prestamo? FolioNavigation { get; set; }

    [InverseProperty("IdHistorialNavigation")]
    public virtual ICollection<IdProvider> IdProviders { get; } = new List<IdProvider>();
}
