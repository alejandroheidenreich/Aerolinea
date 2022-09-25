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
        private string registro;
        private Cliente cliente;
        private ClaseDePasajero clase;
        private double precio;

        public DataTicket(string registro, Cliente cliente, ClaseDePasajero claseDePasajero, double precio)
        {
            this.registro = registro;
            this.cliente = cliente;
            this.clase = claseDePasajero;
            this.precio = precio;
        }
        public string Registro
        {
            get => registro;
        }
        public string Cliente
        {
            get => $"{cliente.Nombre} {cliente.Apellido}";
        }
        public ClaseDePasajero Clase
        {
            get => clase;
        }
        public string Precio
        {
            get => $"{precio.ToString("0.##")} U$D";
        }
    }
}
