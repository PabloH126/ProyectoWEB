using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoBanco.Server.Models;

[Table("empleado")]
public partial class Empleado
{
    [Key]
    [Column("ID_Empleado", TypeName = "int(11)")]
    public long IdEmpleado { get; set; }

    [Column(TypeName = "int(11)")]
    public long? Nomina { get; set; }

    [Column("Detalles_E", TypeName = "int(11)")]
    public long? DetallesE { get; set; }

    [ForeignKey("DetallesE")]
    [InverseProperty("Empleados")]
    public virtual DetallesEmpleado? DetallesENavigation { get; set; }

    [InverseProperty("IdEmpleadoNavigation")]
    public virtual ICollection<IdProvider> IdProviders { get; } = new List<IdProvider>();

    [ForeignKey("Nomina")]
    [InverseProperty("Empleados")]
    public virtual Nomina? NominaNavigation { get; set; }

    [InverseProperty("IdEmpleadoNavigation")]
    public virtual ICollection<Prestamo> Prestamos { get; } = new List<Prestamo>();
}
