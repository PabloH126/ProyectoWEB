using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage; 
using ProyectoBanco.Client.Models;

namespace ProyectoBanco.Client.Functions;

    public class GenerarUsuario
    {
        public static void ToArrayDatos(string Nombre, string ApellidoP, string ApellidoM, string DiaN, string MesN, string AñoN)
        {
            Nombre.ToArray();
            ApellidoP.ToArray();
            ApellidoM.ToArray();
            DiaN.ToArray();
            MesN.ToArray();
            AñoN.ToArray();
        }

        public static long getNumeroCuenta()
        {
            Random rnd = new Random();
            long NCuenta = rnd.NextInt64(1000000000, 9999999999);
            return NCuenta;
        }

        public static string generarUsernameUsuario(long id, List<Dato> data)
        {
            string? Nombre = "";
            string? ApellidoP = "";
            string? ApellidoM = "";
            string? DiaN = " ";
            string? MesN = "";
            string? AñoN = "";
            string? Username = "";

            Dato? datos = data.FirstOrDefault(d => d.IdDatos == id)!;
            {
                    Nombre = datos.Nombres!;
                    ApellidoP = datos.ApellidoP!;
                    ApellidoM = datos.ApellidoM!;
                    DiaN = datos.Dia!;
                    MesN = datos.Mes!;
                    AñoN = datos.Año!;
            }
            
            ToArrayDatos(Nombre, ApellidoP, ApellidoM, DiaN, MesN, AñoN);

            int i = 0;

            while(Nombre[i]!=' ')
            {
                Username += Nombre[i];
                i++;
            }

            Username = Username + ApellidoP[0] + ApellidoM[0] + AñoN.ToString();
            WriteLine($"El username asignado es: {Username}");
            return Username;
        }  

        public static string generarPasswordUsuario(long id, List<Dato> data)
        {
            string? Nombre = " ";
            string? ApellidoP = " ";
            string? ApellidoM = " ";
            string? DiaN = " ";
            string? MesN = " ";
            string? AñoN = " ";
            string? Password = " ";

            Dato? datos = data.FirstOrDefault(d => d.IdDatos == id)!;
            {
                    Nombre = datos.Nombres!;
                    ApellidoP = datos.ApellidoP!;
                    ApellidoM = datos.ApellidoM!;
                    DiaN = datos.Dia!;
                    MesN = datos.Mes!;
                    AñoN = datos.Año!;
            }
            
            ToArrayDatos(Nombre, ApellidoP, ApellidoM, DiaN, MesN, AñoN);

            Password = " " + AñoN[2] + AñoN[3] + Nombre[1] + Nombre[2] + DiaN[1] + MesN [1] + ApellidoM[1] + ApellidoP[1];
            WriteLine($"El password asignado es: {Password}");
            return Password;
        }  
    }
