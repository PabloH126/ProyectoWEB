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

    public class ValidarCurp
    {
        public static bool validarCurp(string Curp, string Nombre, string ApellidoP, string ApellidoM, string DiaN, string MesN, string AñoN)
        {
            Curp.ToUpper();
            WriteLine($"Se verificará este curp: {Curp}");
            if(Curp.Length < 18)
            {
                WriteLine("Se necesitan 18 caracteres");
                return false;
            }

            Curp.ToArray();

            string NombreMayus = Nombre.ToUpper();
            string ApellidoPMayus = ApellidoP.ToUpper();
            string ApellidoMMayus =ApellidoM.ToUpper();

            WriteLine(NombreMayus);
            WriteLine(ApellidoPMayus);
            WriteLine(ApellidoMMayus);
            
            if(Curp[0] == ApellidoPMayus[0])
            {
                int i = 1;

                while(isVocal(ApellidoPMayus[i]) == false)
                {
                    isVocal(ApellidoP[i]);
                    i++;
                }

                if(Curp[1] == ApellidoPMayus[i] && Curp[2] == ApellidoMMayus[0] && Curp[3] == NombreMayus[0] && Curp[4] == AñoN[2] && Curp[5] == AñoN[3] && Curp[6] == MesN[0] && Curp[7] == MesN[1] && Curp[8] == DiaN[0] && Curp[9] == DiaN[1])
                {

                    WriteLine("El curp es válido");
                    return true;
                }
            }

            WriteLine("El CURP es inválido, intente nuevamente");
            
            return false;
        }


        private static bool isVocal(char letra)
        {
            int confirmacion = 0;
            switch(letra)
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U': confirmacion = 1;
                          break;
                default:  break;
            }

            if(confirmacion == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckNumeros(string Nombre, string ApellidoP, string ApellidoM)
        {
            int TNombre = Nombre.Length;
            int TApellidoP = ApellidoP.Length;
            int TApellidoM = ApellidoM.Length;

            Nombre.ToArray();
            ApellidoP.ToArray();
            ApellidoM.ToArray();

            for(int i = 0; i < TNombre; i++)
            {
                switch(Nombre[i])
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9': WriteLine("No se aceptan numeros en el nombre");
                              return false;
                }
            }

            for(int i = 0; i < TApellidoP; i++)
            {
                switch(ApellidoP[i])
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9': WriteLine("No se aceptan numeros en el apellido paterno");
                              return false;
                }
            }

            for(int i = 0; i < TApellidoM; i++)
            {
                switch(ApellidoM[i])
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9': WriteLine("No se aceptan numeros en el apellido materno");
                              return false;
                }
            }
            return true;
        }
    }
