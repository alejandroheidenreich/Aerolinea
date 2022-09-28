using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Individuo
    {
        public Cliente(string nombre, string apellido, DateTime fechaDeNacimiento, int dni, string email)
            : base(nombre, apellido, fechaDeNacimiento, dni, email)
        {
            // xd
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.Dni == c2.Dni;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            //TODO: aplicar
            Cliente aux = obj as Cliente;
            return aux is not null && aux == this;  
        }

        public override int GetHashCode()
        {
            //TODO: aplicar
            return this.Dni;
        }

        public override string ToString()
        {
            return $"{base.Apellido}, {base.Nombre} - DNI: {base.Dni}";  
        }
    }
}
