using System.Reflection;
using ProyectoBanco.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace ProyectoBanco.Server.Data;

public class BancoContext : DbContext
{
    public BancoContext(DbContextOptions<BancoContext> options) : base(options)
    {
    }

    public DbSet<Cuentum>
}