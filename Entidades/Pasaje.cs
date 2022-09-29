using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Pasaje
    {
        private string idRegistro;
        private Cliente cliente;
        private ClaseDePasajero claseDePasajero;
        private bool equipajeDeMano;
        private List<double> equipajeDeBodega;
        private int equipajesMaximos;
        private double pesoAdicional;

        private Pasaje()
        {
            this.idRegistro = GenerarRegsitro();
            this.equipajeDeBodega = new List<double>();
            this.EquipajeDeMano = false;
            this.equipajesMaximos = 4;
            this.pesoAdicional = 0;
        }
        public Pasaje(Cliente cliente, ClaseDePasajero claseDePasajero):this()
        {
            this.cliente = cliente;
            this.claseDePasajero = claseDePasajero;
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
                return this.pesoAdicional;
            }
        }

        public List<double> EquipajeDeBodega
        {
            get => equipajeDeBodega;
            set => equipajeDeBodega = value;
        }
        public int EquipajesMaximos
        {
            get => equipajesMaximos;
            set => equipajesMaximos = value;
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
                OrdenarEquipaje();
                this.pesoAdicional = CalcularPesoEquipajeAdicional();
            }
        }
        private double CalcularPesoEquipajeAdicional()
        {
            double pesoValija;
            if (this.claseDePasajero == ClaseDePasajero.Tursita)
            {
                pesoValija = CondicionarEquipaje(25, 1);
            }
            else
            {
                pesoValija = CondicionarEquipaje(21,2);
            }
            return pesoValija;
        }
        private double CondicionarEquipaje(int peso, int cantidad)
        {
            double pesoAdicional = 0;
            for (int i = 0; i < this.equipajeDeBodega.Count; i++)
            {
                if (i < cantidad)
                {
                    if (this.equipajeDeBodega[i] > peso)
                    {
                        pesoAdicional += this.equipajeDeBodega[i] - peso;
                    }
                }
                else
                {
                    pesoAdicional += this.equipajeDeBodega[i];
                }
            }

            return pesoAdicional;
        }

        private void OrdenarEquipaje()
        {
            double aux;
            for (int i = 0; i < this.equipajeDeBodega.Count; i++)
            {
                for (int j = 0; j < this.equipajeDeBodega.Count; j++)
                {
                    if (this.equipajeDeBodega[i] > this.equipajeDeBodega[j])
                    {
                        aux = this.equipajeDeBodega[i];
                        this.equipajeDeBodega[i] = this.equipajeDeBodega[j];
                        this.equipajeDeBodega[j] = aux;
                    }
                }
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
