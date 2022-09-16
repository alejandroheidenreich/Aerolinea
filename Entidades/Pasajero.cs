using System;
using System.Net;
using System.Text;

namespace Entidades
{
    public class Pasajero : Persona
    {
        private const double PRECIOPORHORANACIONAL = 50;
        private const double PRECIOPORHORAINTERNACIONAL = 100;
        private Equipaje equipaje;

        public Pasajero(string nombre, string apellido, DateTime fechaDeNacimiento, int dni, string email) 
            :base(nombre,apellido, fechaDeNacimiento, dni,email)
        {

        }

        

        
    }
}
