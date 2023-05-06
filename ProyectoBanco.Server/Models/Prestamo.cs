using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoBanco.Server.Models;

[Table("prestamos")]
public partial class Prestamo
{
    [Key]
    [Column(TypeName = "int(11)")]
    public long Folio { get; set; }

    [Column(TypeName = "decimal")]
    public double Monto { get; set; }

    [Column("Pago_Mes", TypeName = "decimal")]
    public double PagoMes { get; set; }

    [Column("Fecha_UPago", TypeName = "int(11)")]
    public long? FechaUpago { get; set; }

    [Column("Detalles_P", TypeName = "int(11)")]
    public long? DetallesP { get; set; }

    [Column("ID_Empleado", TypeName = "int(11)")]
    public long? IdEmpleado { get; set; }

    [Column("ID_Gerente", TypeName = "int(11)")]
    public long? IdGerente { get; set; }

    [Column("Num_Cuenta", TypeName = "int(11)")]
    public long? NumCuenta { get; set; }

    [Column(TypeName = "varchar(15)")]
    public string? Status { get; set; }

    [ForeignKey("DetallesP")]
    [InverseProperty("Prestamos")]
    public virtual DetallesPrestamo? DetallesPNavigation { get; set; }

    [InverseProperty("FolioNavigation")]
    public virtual ICollection<Historial> Historials { get; } = new List<Historial>();

    [ForeignKey("IdEmpleado")]
    [InverseProperty("Prestamos")]
    public virtual Empleado? IdEmpleadoNavigation { get; set; }

    [ForeignKey("IdGerente")]
    [InverseProperty("Prestamos")]
    public virtual Gerente? IdGerenteNavigation { get; set; }

    [ForeignKey("NumCuenta")]
    [InverseProperty("Prestamos")]
    public virtual Cuentum? NumCuentaNavigation { get; set; }
}
