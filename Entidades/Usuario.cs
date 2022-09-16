using System;
using System.Net;

namespace Entidades
{
    public class Usuario : Persona
    {
        private string nombreDeUsuario;
        private string contrasenia;


        public Usuario(string nombre, string apellido, DateTime fechaDeNacimiento, int dni, string email, string nombreDeUsuario, string contrasenia):base(nombre,apellido, fechaDeNacimiento, dni,email)
        {
            this.nombreDeUsuario = nombreDeUsuario;
            this.contrasenia = contrasenia;
        }
        public string NombreDeUsuario
        {
            get => nombreDeUsuario;
        }
        
        
        public bool VerificarContrasenia(string contraseniaActual)
        {
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

        public override int GetHashCode()
        {
            return nombreDeUsuario.GetHashCode()
                    + contrasenia.GetHashCode();
        }
    }
}
