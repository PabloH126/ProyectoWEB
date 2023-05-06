using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoBanco.Client.Models;

[Table("nomina")]
public partial class Nomina
{
    [Key]
    [Column("Nomina", TypeName = "int(11)")]
    public long Nomina1 { get; set; }

    [Column("Detalles_E", TypeName = "int(11)")]
    public long? DetallesE { get; set; }

    [Column("Detalles_G", TypeName = "int(11)")]
    public long? DetallesG { get; set; }

    [ForeignKey("DetallesE")]
    [InverseProperty("Nominas")]
    public virtual DetallesEmpleado? DetallesENavigation { get; set; }

    [ForeignKey("DetallesG")]
    [InverseProperty("Nominas")]
    public virtual DetallesGerente? DetallesGNavigation { get; set; }

    [InverseProperty("NominaNavigation")]
    public virtual ICollection<Empleado> Empleados { get; } = new List<Empleado>();

    [InverseProperty("NominaNavigation")]
    public virtual ICollection<Gerente> Gerentes { get; } = new List<Gerente>();
}
