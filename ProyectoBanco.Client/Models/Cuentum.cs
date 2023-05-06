using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoBanco.Client.Models;

[Table("cuenta")]
public partial class Cuentum
{
    [Key]
    [Column("Num_Cuenta", TypeName = "int(11)")]
    public long NumCuenta { get; set; }

    [Column(TypeName = "varchar(10)")]
    public string? Contraseña { get; set; }

    [Column("ID_Usuario", TypeName = "varchar(10)")]
    public string? IdUsuario { get; set; }

    [Column("Detalles_C", TypeName = "int(11)")]
    public long? DetallesC { get; set; }

    [ForeignKey("DetallesC")]
    [InverseProperty("Cuenta")]
    public virtual DetallesCuentum? DetallesCNavigation { get; set; }

    [ForeignKey("IdUsuario")]
    [InverseProperty("Cuenta")]
    public virtual Usuario? IdUsuarioNavigation { get; set; }

    [InverseProperty("NumCuentaNavigation")]
    public virtual ICollection<Prestamo> Prestamos { get; } = new List<Prestamo>();
}
