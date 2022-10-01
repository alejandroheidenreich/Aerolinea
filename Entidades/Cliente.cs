using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Individuo
    {
        private DateTime antiguedadComoCliente;


        public Cliente(string nombre, string apellido, DateTime fechaDeNacimiento, int dni, string email, DateTime antiguedadComoCliente)
            : base(nombre, apellido, fechaDeNacimiento, dni, email)
        {
            this.antiguedadComoCliente = antiguedadComoCliente;
        }
        public DateTime Antiguedad
        {
            get => antiguedadComoCliente;
            set => antiguedadComoCliente = value;
        }

        public override int CalcularAntiguedad()
        {
            return DateTime.Now.Year - this.antiguedadComoCliente.Year;
        }
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.GetHashCode() == c2.GetHashCode();
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            Cliente aux = obj as Cliente;
            return aux is not null && aux == this;  
        }

        public override string ToString()
        {
            return $"{base.Apellido}, {base.Nombre} - DNI: {base.GetHashCode()}";  
        }
    }
}
