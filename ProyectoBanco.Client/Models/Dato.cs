using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoBanco.Client.Models;

[Table("datos")]
public partial class Dato
{
    [Key]
    [Column("ID_Datos", TypeName = "int(11)")]
    public long IdDatos { get; set; }

    [Column(TypeName = "varchar(30)")]
    public string? Nombres { get; set; }

    [Column(TypeName = "varchar(20)")]
    public string? ApellidoP { get; set; }

    [Column(TypeName = "varchar(20)")]
    public string? ApellidoM { get; set; }

    [Column(TypeName = "varchar(2)")]
    public string? Dia { get; set; }

    [Column(TypeName = "varchar(2)")]
    public string? Mes { get; set; }

    [Column(TypeName = "varchar(4)")]
    public string? Año { get; set; }

    [InverseProperty("IdDatosNavigation")]
    public virtual ICollection<DetallesEmpleado> DetallesEmpleados { get; } = new List<DetallesEmpleado>();

    [InverseProperty("IdDatosNavigation")]
    public virtual ICollection<DetallesGerente> DetallesGerentes { get; } = new List<DetallesGerente>();

    [InverseProperty("IdDatosNavigation")]
    public virtual ICollection<DetallesUsuario> DetallesUsuarios { get; } = new List<DetallesUsuario>();

    [InverseProperty("IdDatosNavigation")]
    public virtual ICollection<IdProvider> IdProviders { get; } = new List<IdProvider>();
}
