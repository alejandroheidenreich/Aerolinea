using System;

namespace Entidades
{
    public enum ClaseDePasajero
    {
        Tursita,
        Premium
    }
    public class Pasajero : Cliente
    {
        private const double PRECIOPORHORANACIONAL = 50;
        private const double PRECIOPORHORAINTERNACIONAL = 100;
        private Cliente cliente;
        private Equipaje equipaje;
        private ClaseDePasajero claseDePasajero;

        //equipaje pesaje o bultos?

        public Pasajero(string nombre, string apellido, DateTime fechaDeNacimiento, int dni, string email, ClaseDePasajero claseDePasajero)
            : base(nombre, apellido, fechaDeNacimiento, dni, email)
        {
            this.claseDePasajero = claseDePasajero;
        }

        //public Equipaje Equipaje
        //{
        //    get => equipaje;
        //    set => equipaje = value;
        //}
        public ClaseDePasajero Clase
        {
            get => claseDePasajero;
            set => claseDePasajero = value;
        }

        //TODO: Problematica equipaje tiene la categoria puede recibir un atributo de pasajero y pasarselo a equipaje


    }
}
