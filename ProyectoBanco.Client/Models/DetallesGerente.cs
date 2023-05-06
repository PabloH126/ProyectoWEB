using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoBanco.Client.Models;

[Table("detalles_gerente")]
public partial class DetallesGerente
{
    [Key]
    [Column("Detalles_G", TypeName = "int(11)")]
    public long DetallesG { get; set; }

    [Column("Dias_Vacaciones", TypeName = "int(11)")]
    public long? DiasVacaciones { get; set; }

    [Column("ID_Datos", TypeName = "int(11)")]
    public long? IdDatos { get; set; }

    [InverseProperty("DetallesGNavigation")]
    public virtual ICollection<Gerente> Gerentes { get; } = new List<Gerente>();

    [ForeignKey("IdDatos")]
    [InverseProperty("DetallesGerentes")]
    public virtual Dato? IdDatosNavigation { get; set; }

    [InverseProperty("DetallesGNavigation")]
    public virtual ICollection<IdProvider> IdProviders { get; } = new List<IdProvider>();

    [InverseProperty("DetallesGNavigation")]
    public virtual ICollection<Nomina> Nominas { get; } = new List<Nomina>();
}
