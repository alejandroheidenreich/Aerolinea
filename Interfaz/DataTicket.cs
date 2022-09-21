using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public class DataTicket
    {
        private string id;
        private Cliente cliente;
        private ClaseDePasajero clase;
        private double precio;
        //private Button boton;
                
        public DataTicket(string id, Cliente cliente, ClaseDePasajero claseDePasajero, double precio/*, Button boton*/)
        {
            this.id = id;
            this.cliente = cliente;
            this.clase = claseDePasajero;
            this.precio = precio;
            //this.boton = boton;
        }
        public string Id
        {
            get => id;
        }
        public string Cliente
        {
            get => $"{cliente.Nombre} {cliente.Apellido}";
        }
        public ClaseDePasajero Clase
        {
            get => clase;
        }
        public double Precio
        {
            get => precio;
        }
        //public Button Boton
        //{
        //    get => boton;
        //}
    }
}
