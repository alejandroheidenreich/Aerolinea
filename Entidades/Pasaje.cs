using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public enum ClaseDePasajero
    {
        Tursita,
        Premium
    }
    public class Pasaje
    {
        private string idRegistro;
        private Cliente cliente;
        private Vuelo vuelo;
        private ClaseDePasajero claseDePasajero;
        private bool equipajeDeMano;
        private List<double> equipajeDeBodega;
        private int equipajesMaximos;
        private double pesoAdicional;

        // equipaje pesaje o bultos? validarlo se puede pasar de mas y cobrar adicional

        // un cliente se puede comprar todos los pasajes? se lo puede comprar

        public Pasaje(Cliente cliente, ClaseDePasajero claseDePasajero)
        {
            this.idRegistro = GenerarRegsitro();
            this.cliente = cliente;
            this.claseDePasajero = claseDePasajero;
            this.equipajesMaximos = 4;
            this.pesoAdicional = 0;
            this.equipajeDeBodega = new List<double>();
            this.EquipajeDeMano = false;
        }

        public string IdRegistro
        {
            get => idRegistro;
            set => idRegistro = value;
        }

        public ClaseDePasajero Clase
        {
            get => claseDePasajero;
            set => claseDePasajero = value;
        }
        public Cliente Cliente
        {
            get => cliente;
            set => cliente = value;
        }
        public bool EquipajeDeMano
        {
            get => equipajeDeMano;
            set => equipajeDeMano = value;
        }
        public double PesoAdicional
        {
            get
            {
                CalcularPesoEquipajeAdicional();
                return pesoAdicional;
            }
        }

        public List<double> EquipajeDeBodega
        {
            get => equipajeDeBodega;
            set => equipajeDeBodega = value;
        }

        public void AgregarEquipaje(double pesoValija)
        {
            if (this.equipajeDeBodega.Count > this.equipajesMaximos)
            {
                throw new Exception($"Llego al maximo ({this.equipajesMaximos}) de equipajes en bodega");
            }
            else
            {
                equipajeDeBodega.Add(pesoValija);
            }
        }

        private void CalcularPesoEquipajeAdicional()
        {
            if (this.claseDePasajero == ClaseDePasajero.Tursita)
            {
                CondicionarEquipaje(25, 1);
            }
            else if (this.claseDePasajero == ClaseDePasajero.Premium)
            {
                CondicionarEquipaje(21,2);
            }
        }

        private void CondicionarEquipaje(int peso, int cantidad)
        {
            for (int i = 0; i < this.equipajeDeBodega.Count; i++)
            {
                if (i < cantidad && this.equipajeDeBodega[i] > peso)
                {
                    this.pesoAdicional += this.equipajeDeBodega[i] - peso;
                    break;
                }
                this.pesoAdicional += this.equipajeDeBodega[i];
            }
        }

        private string GenerarRegsitro()
        {
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] matriculaArray = new char[6];
            Random random = new Random();

            for (int i = 0; i < matriculaArray.Length; i++)
            {
                matriculaArray[i] = caracteres[random.Next(caracteres.Length)];
            }

            return new String(matriculaArray);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Registro: {this.idRegistro} - ");
            sb.AppendLine(this.claseDePasajero.ToString());
            sb.AppendLine(this.cliente.ToString());

            return sb.ToString();
        }

    }
}
