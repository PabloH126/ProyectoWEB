using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoBanco.Server.Models;

[Table("usuario")]
public partial class Usuario
{
    [Key]
    [Column("ID_Usuario", TypeName = "varchar(10)")]
    public string IdUsuario { get; set; } = null!;

    [Column("Detalles_U", TypeName = "int(11)")]
    public long? DetallesU { get; set; }

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<Cuentum> Cuenta { get; } = new List<Cuentum>();

    [ForeignKey("DetallesU")]
    [InverseProperty("Usuarios")]
    public virtual DetallesUsuario? DetallesUNavigation { get; set; }

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<Gerente> Gerentes { get; } = new List<Gerente>();
}
