using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Individuo
    {
        //TODO: Posible clase padre de pasajero
        public Cliente(string nombre, string apellido, DateTime fechaDeNacimiento, int dni, string email)
            : base(nombre, apellido, fechaDeNacimiento, dni, email)
        {
            // xd
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool sonIguales = false;
            if (c1.Dni == c2.Dni)
            {
                sonIguales = true;
            }
            return sonIguales;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

        public override string ToString()
        {
            return $"{base.Apellido}, {base.Nombre} - DNI: {base.Dni}";
            ;
        }
    }
}
