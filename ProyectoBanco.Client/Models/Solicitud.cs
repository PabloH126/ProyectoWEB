using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoBanco.Client.Models;

[Table("solicitud")]
public partial class Solicitud
{
    [Key]
    [Column("ID_Solicitud", TypeName = "int(11)")]
    public long IdSolicitud { get; set; }

    [Column("Status_Solicitud", TypeName = "varchar(10)")]
    public string StatusSolicitud { get; set; } = null!;

    [Column("Detalles_U", TypeName = "int(11)")]
    public long? DetallesU { get; set; }

    [ForeignKey("DetallesU")]
    [InverseProperty("Solicituds")]
    public virtual DetallesUsuario? DetallesUNavigation { get; set; }
}
