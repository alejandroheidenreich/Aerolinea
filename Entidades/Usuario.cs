using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;

namespace Entidades
{
    public class Usuario : Individuo
    {
        private string nombreDeUsuario;
        private string contrasenia;

        public Usuario(string nombre, string apellido, DateTime fechaDeNacimiento, int dni, string email, string nombreDeUsuario, string contrasenia)
            :base(nombre,apellido, fechaDeNacimiento, dni,email)
        {
            Sistema.VerificarUsuarioNoRepetido(nombreDeUsuario,dni);
            ValidarString(nombreDeUsuario, out this.nombreDeUsuario, "El nombre no puede ser nulo.");
            ValidarContrasenia(contrasenia, out this.contrasenia);
        }
        public string NombreDeUsuario
        {
            get => nombreDeUsuario;
        }
        
        public bool VerificarContrasenia(string contraseniaActual)
        {
            // booleando para saber si viene con cambio de contraseña
            if (contraseniaActual == this.contrasenia)
            {
                return true;
            }
            return false;
        }
        private void CambiarContrasenia(string nuevaContrasenia)
        {
            //TODO: Desarrollar cambio de contraseña
            this.contrasenia = nuevaContrasenia;
        }

        public static bool operator ==(Usuario u1, Usuario u2)
        {
            return u1.nombreDeUsuario == u2.nombreDeUsuario && u1.contrasenia == u2.contrasenia;
        }

        public static bool operator !=(Usuario u1, Usuario u2)
        {
            return !(u1 == u2);
        }

        public override bool Equals(object obj)
        {
            Usuario usuario = obj as Usuario;
            return usuario is not null && this == usuario;
        }

        private static void ValidarString(string strAValidar, out string strValidado, string msjError)
        {
            strValidado = String.Empty;
            if (strAValidar is not null)
            {
                strValidado = strAValidar;
            }
            else
            {
                throw new ArgumentNullException(msjError);
            }
        }

        private static void ValidarContrasenia(string contraseniaAValidar, out string contraseniaValidado)
        {
            contraseniaValidado = string.Empty;

            if (contraseniaAValidar is null)
            {
                throw new ArgumentNullException("La contraseña no puede ser nula");
            }
            else if (contraseniaAValidar.Length < 8)
            {
                throw new FormatException("La contraseña debe tener un largo de 8 caracteres");
            }
            else if (!ValidarContieneMinus(contraseniaAValidar))
            {
                throw new FormatException("La contraseña debe tener a lo menos una Minuscula");
            }
            else if (!ValidarContieneMayus(contraseniaAValidar))
            {
                throw new FormatException("La contraseña debe tener a lo menos una Mayuscula");
            }
            else if (!ValidarContieneNumerico(contraseniaAValidar))
            {
                throw new FormatException("La contraseña debe tener a lo menos un Numero");
            }
            else if (!ValidarContieneSimbolo(contraseniaAValidar))
            {
                throw new FormatException("La contraseña debe tener a lo menos un Simbolo");
            }
            else
            {
                contraseniaValidado = contraseniaAValidar;
            } 
        }

        private static bool ValidarContieneMinus(string contrasenia)
        {
            char[] contraseniaArray = contrasenia.ToArray();

            foreach (char item in contraseniaArray)
            {
                if (Char.IsLower(item))
                {
                    return true;
                }
            }
            return false;
        }
        private static bool ValidarContieneMayus(string contrasenia)
        {
            char[] contraseniaArray = contrasenia.ToArray();

            foreach (char item in contraseniaArray)
            {
                if (Char.IsUpper(item))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool ValidarContieneNumerico(string contrasenia)
        {
            char[] contraseniaArray = contrasenia.ToArray();

            foreach (char item in contraseniaArray)
            {
                if (Char.IsDigit(item))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool ValidarContieneSimbolo(string contrasenia)
        {
            char[] contraseniaArray = contrasenia.ToArray();

            foreach (char item in contraseniaArray)
            {
                if (item > 32 && item < 127 && !Char.IsDigit(item) && !Char.IsUpper(item))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
