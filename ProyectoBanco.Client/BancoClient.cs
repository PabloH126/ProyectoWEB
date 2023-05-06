using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoBanco.Client.Models;
using ProyectoBanco.Client.Functions;

namespace ProyectoBanco.Client;

public class BancoClient
{
    public static readonly List<Dato> data = new ()
    {
        new Dato()
        {
            IdDatos = 1,
            Nombres = "Juan Pablo",
            ApellidoP = "Lopez",
            ApellidoM = "Hernandez",
            Dia = "12",
            Mes = "06",
            Año = "2003"
        }
    };

    public static readonly List<DetallesUsuario> detallesUsuarios = new()
    {
        new DetallesUsuario()
        {
            DetallesU = 1,
            Curp = "LOHJ030612HJCPRNA5",
            IdDatos = 1
        }
    };

    public static readonly List<Usuario> usuarios = new()
    {
        new Usuario()
        {
            IdUsuario = "JuanLH2003",
            DetallesU = 1
        }
    };

    public static readonly List<Solicitud> solicitudes = new()
    {
        new Solicitud()
        {
            IdSolicitud = 1,
            DetallesU = 1,
            StatusSolicitud = "Aprobada"
        }
    };

    public static readonly List<DetallesCuentum> detallesCuentas = new()
    {
        new DetallesCuentum()
        {
            DetallesC = 1,
            Saldo = 10000,
            NBoleto = 0,
            IdHistorial = 1,
        }
    };

    public static readonly List<Cuentum> cuentas = new()
    {
        new Cuentum()
        {
            NumCuenta = 3956754810,
            Contraseña = "03ua26eo",
            IdUsuario = "JuanLH2003",
            DetallesC = 1
        }
    };

    public static readonly List<DetallesGerente> detallesGerentes = new()
    {
        new DetallesGerente()
        {
        }
    };

    public static readonly List<Gerente> gerentes = new()
    {
        new Gerente()
        {
        }
    };

    public static Dato[] GetDatos()
    {
        return data.ToArray();
    }

    public static DetallesUsuario[] GetDetallesU()
    {
        return detallesUsuarios.ToArray();
    }

    public static Usuario[] GetUsuarios()
    {
        return usuarios.ToArray();
    }

    public static void AddUsuario(Dato datos, string curp)
    {
        datos.IdDatos = data.Max(d => d.IdDatos) + 1;
        data.Add(datos);

        DetallesUsuario detallesU = new()
        {
            DetallesU = datos.IdDatos,
            Curp = curp,
            IdDatos = datos.IdDatos
        };

        detallesUsuarios.Add(detallesU);
        
        Usuario usuario = new()
        {
            IdUsuario = GenerarUsuario.generarUsernameUsuario(datos.IdDatos, data),
            DetallesU = detallesU.DetallesU
        };
        usuarios.Add(usuario);
    }

    public static void AddGerente(Dato datos)
    {
        datos.IdDatos = data.Max(d => d.IdDatos) + 1;
        data.Add(datos);

        DetallesGerente detallesG = new()
        {
            DetallesG = datos.IdDatos,
            DiasVacaciones = 0,
            IdDatos = datos.IdDatos
        };

        detallesGerentes.Add(detallesG);

        Gerente gerente = new()
        {
            IdGerente = datos.IdDatos,
            Nomina = GenerarUsuario.getNumeroCuenta(),
            DetallesG = datos.IdDatos
        };

        gerentes.Add(gerente);
    }

    public static Dato getDato(int id)
    {
        return data.Find(d => d.IdDatos == id)??
        throw new Exception("Could not find the data");
    }

    public static Cuentum verifyCuentaUsuario(string username, string password)
    {
        Cuentum? cuentaUsuario = cuentas.Find(vC => vC.IdUsuario == username && vC.Contraseña == password);
        return cuentaUsuario!;
    }

    public static Gerente verifyCuentaGerente(long id, long? nomina)
    {
        Gerente? cuentaGerente = gerentes.Find(vG => vG.IdGerente == id && vG.Nomina == nomina);
        return cuentaGerente!;
    }

    public static DetallesUsuario getDetallesU(int id)
    {
        return detallesUsuarios.Find(dU => dU.DetallesU == id) ??
        throw new Exception("Could not find the user details");
    }

    public static DetallesGerente getDetallesG(int id)
    {
        return detallesGerentes.Find(dG => dG.DetallesG == id) ??
        throw new Exception("Could not find the manager details");
    }

    public static Usuario getUsuario(int id)
    {
        return usuarios.Find(u => u.DetallesU == id) ??
        throw new Exception("Could not find the user");
    }

    public static Gerente getGerente(int id)
    {
        return gerentes.Find(g => g.IdGerente == id) ??
        throw new Exception("Could not find the manager");
    }

    public static void DeleteUser(int id)
    {
        Dato datos = getDato(id);
        DetallesUsuario detallesU = getDetallesU(id);
        Usuario usuario = getUsuario(id);

        data.Remove(datos);
        detallesUsuarios.Remove(detallesU);
        usuarios.Remove(usuario);
    }
}   
