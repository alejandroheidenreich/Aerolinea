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

        public DataTicket(string registro, Cliente cliente, ClaseDePasajero claseDePasajero)
        {
            this.registro = registro;
            this.cliente = cliente;
            this.clase = claseDePasajero;
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
    }
}
