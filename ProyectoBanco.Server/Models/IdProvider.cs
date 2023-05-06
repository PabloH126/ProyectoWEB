using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoBanco.Server.Models;

[Table("id_provider")]
public partial class IdProvider
{
    [Key]
    [Column("ID_Provider", TypeName = "int(11)")]
    public long IdProvider1 { get; set; }

    [Column("Detalles_C", TypeName = "int(11)")]
    public long? DetallesC { get; set; }

    [Column("Detalles_E", TypeName = "int(11)")]
    public long? DetallesE { get; set; }

    [Column("Detalles_G", TypeName = "int(11)")]
    public long? DetallesG { get; set; }

    [Column("Detalles_H", TypeName = "int(11)")]
    public long? DetallesH { get; set; }

    [Column("Detalles_P", TypeName = "int(11)")]
    public long? DetallesP { get; set; }

    [Column("Detalles_U", TypeName = "int(11)")]
    public long? DetallesU { get; set; }

    [Column("ID_Datos", TypeName = "int(11)")]
    public long? IdDatos { get; set; }

    [Column("ID_Empleado", TypeName = "int(11)")]
    public long? IdEmpleado { get; set; }

    [Column("ID_Gerente", TypeName = "int(11)")]
    public long? IdGerente { get; set; }

    [Column("ID_Historial", TypeName = "int(11)")]
    public long? IdHistorial { get; set; }

    [ForeignKey("DetallesC")]
    [InverseProperty("IdProviders")]
    public virtual DetallesCuentum? DetallesCNavigation { get; set; }

    [ForeignKey("DetallesE")]
    [InverseProperty("IdProviders")]
    public virtual DetallesEmpleado? DetallesENavigation { get; set; }

    [ForeignKey("DetallesG")]
    [InverseProperty("IdProviders")]
    public virtual DetallesGerente? DetallesGNavigation { get; set; }

    [ForeignKey("DetallesH")]
    [InverseProperty("IdProviders")]
    public virtual DetallesHistorial? DetallesHNavigation { get; set; }

    [ForeignKey("DetallesP")]
    [InverseProperty("IdProviders")]
    public virtual DetallesPrestamo? DetallesPNavigation { get; set; }

    [ForeignKey("DetallesU")]
    [InverseProperty("IdProviders")]
    public virtual DetallesUsuario? DetallesUNavigation { get; set; }

    [ForeignKey("IdDatos")]
    [InverseProperty("IdProviders")]
    public virtual Dato? IdDatosNavigation { get; set; }

    [ForeignKey("IdEmpleado")]
    [InverseProperty("IdProviders")]
    public virtual Empleado? IdEmpleadoNavigation { get; set; }

    [ForeignKey("IdGerente")]
    [InverseProperty("IdProviders")]
    public virtual Gerente? IdGerenteNavigation { get; set; }

    [ForeignKey("IdHistorial")]
    [InverseProperty("IdProviders")]
    public virtual Historial? IdHistorialNavigation { get; set; }
}
