using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoBanco.Client.Models;

[Table("gerente")]
public partial class Gerente
{
    [Key]
    [Column("ID_Gerente", TypeName = "int(11)")]
    public long IdGerente { get; set; }

    [Column(TypeName = "int(11)")]
    public long? Nomina { get; set; }

    [Column("ID_Usuario", TypeName = "varchar(10)")]
    public string? IdUsuario { get; set; }

    [Column("Detalles_G", TypeName = "int(11)")]
    public long? DetallesG { get; set; }

    [ForeignKey("DetallesG")]
    [InverseProperty("Gerentes")]
    public virtual DetallesGerente? DetallesGNavigation { get; set; }

    [InverseProperty("IdGerenteNavigation")]
    public virtual ICollection<IdProvider> IdProviders { get; } = new List<IdProvider>();

    [ForeignKey("IdUsuario")]
    [InverseProperty("Gerentes")]
    public virtual Usuario? IdUsuarioNavigation { get; set; }

    [ForeignKey("Nomina")]
    [InverseProperty("Gerentes")]
    public virtual Nomina? NominaNavigation { get; set; }

    [InverseProperty("IdGerenteNavigation")]
    public virtual ICollection<Prestamo> Prestamos { get; } = new List<Prestamo>();
}
