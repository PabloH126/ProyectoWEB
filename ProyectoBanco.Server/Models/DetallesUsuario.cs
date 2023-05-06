using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoBanco.Server.Models;

[Table("detalles_usuario")]
public partial class DetallesUsuario
{
    [Key]
    [Column("Detalles_U", TypeName = "int(11)")]
    public long DetallesU { get; set; }

    [Column("CURP", TypeName = "varchar(18)")]
    public string? Curp { get; set; }

    [Column(TypeName = "varchar(10)")]
    public string? Solicitud { get; set; }

    [Column("ID_Datos", TypeName = "int(11)")]
    public long? IdDatos { get; set; }

    [ForeignKey("IdDatos")]
    [InverseProperty("DetallesUsuarios")]
    public virtual Dato? IdDatosNavigation { get; set; }

    [InverseProperty("DetallesUNavigation")]
    public virtual ICollection<IdProvider> IdProviders { get; } = new List<IdProvider>();

    [InverseProperty("DetallesUNavigation")]
    public virtual ICollection<Solicitud> Solicituds { get; } = new List<Solicitud>();

    [InverseProperty("DetallesUNavigation")]
    public virtual ICollection<Usuario> Usuarios { get; } = new List<Usuario>();
}
