using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoBanco.Server.Models;

[Table("detalles_cuenta")]
public partial class DetallesCuentum
{
    [Key]
    [Column("Detalles_C", TypeName = "int(11)")]
    public long DetallesC { get; set; }

    [Column(TypeName = "int(11)")]
    public long? Saldo { get; set; }

    [Column("N_Boleto", TypeName = "int(11)")]
    public long? NBoleto { get; set; }

    [Column("ID_Historial", TypeName = "int(11)")]
    public long? IdHistorial { get; set; }

    [Column(TypeName = "varchar(4)")]
    public string? PrestamoA { get; set; }

    [InverseProperty("DetallesCNavigation")]
    public virtual ICollection<Cuentum> Cuenta { get; } = new List<Cuentum>();

    [ForeignKey("IdHistorial")]
    [InverseProperty("DetallesCuenta")]
    public virtual Historial? IdHistorialNavigation { get; set; }

    [InverseProperty("DetallesCNavigation")]
    public virtual ICollection<IdProvider> IdProviders { get; } = new List<IdProvider>();

    [ForeignKey("NBoleto")]
    [InverseProperty("DetallesCuenta")]
    public virtual Rifa? NBoletoNavigation { get; set; }
}
