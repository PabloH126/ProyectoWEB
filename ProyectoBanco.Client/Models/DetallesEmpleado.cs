using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoBanco.Client.Models;

[Table("detalles_empleado")]
public partial class DetallesEmpleado
{
    [Key]
    [Column("Detalles_E", TypeName = "int(11)")]
    public long DetallesE { get; set; }

    [Column("Prestamos_Aprobados", TypeName = "int(11)")]
    public long? PrestamosAprobados { get; set; }

    [Column("ID_Datos", TypeName = "int(11)")]
    public long? IdDatos { get; set; }

    [InverseProperty("DetallesENavigation")]
    public virtual ICollection<Empleado> Empleados { get; } = new List<Empleado>();

    [ForeignKey("IdDatos")]
    [InverseProperty("DetallesEmpleados")]
    public virtual Dato? IdDatosNavigation { get; set; }

    [InverseProperty("DetallesENavigation")]
    public virtual ICollection<IdProvider> IdProviders { get; } = new List<IdProvider>();

    [InverseProperty("DetallesENavigation")]
    public virtual ICollection<Nomina> Nominas { get; } = new List<Nomina>();
}
