using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private string nombreDeUsuario;
        private string contrasenia;


        public Usuario(string nombreDeUsuario, string contrasenia)
        {
            this.nombreDeUsuario = nombreDeUsuario;
            this.contrasenia = contrasenia;
        }
        public string NombreDeUsuario { get => nombreDeUsuario; }

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
            return usuario is not null &&  this == usuario;
        }
    }
}
