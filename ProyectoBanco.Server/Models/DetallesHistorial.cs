using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoBanco.Server.Models;

[Table("detalles_historial")]
public partial class DetallesHistorial
{
    [Key]
    [Column("Detalles_H", TypeName = "int(11)")]
    public long DetallesH { get; set; }

    [Column("N_Pagos_Realizados", TypeName = "int(11)")]
    public long? NPagosRealizados { get; set; }

    [Column("N_Pagos_Pendientes", TypeName = "int(11)")]
    public long? NPagosPendientes { get; set; }

    [Column(TypeName = "varchar(10)")]
    public string? Estado { get; set; }

    [InverseProperty("DetallesHNavigation")]
    public virtual ICollection<Historial> Historials { get; } = new List<Historial>();

    [InverseProperty("DetallesHNavigation")]
    public virtual ICollection<IdProvider> IdProviders { get; } = new List<IdProvider>();
}
