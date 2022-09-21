using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipaje
    {
        //TODO: Desarrolar clase equipaje
        private bool equipajeDeMano;
        private double equipajeDeBodega;

        public Equipaje(bool equipajeDeMano, double equipajeDeBodega)
        {
            this.equipajeDeMano = equipajeDeMano;
            this.equipajeDeBodega = equipajeDeBodega;

        }

        public bool EquipajeDeMano
        {
            get
            {
                return equipajeDeMano;
            }
            set
            {
                equipajeDeMano = value;
            }
        }
       
        public double EquipajeDeBodega
        {
            get
            {
                return equipajeDeBodega;
            }
            set
            {
                if (value <= 25 && 0 < value )
                {
                    equipajeDeBodega = value;
                }
            }
        }

        private void ValidarPesoEquipaje(double peso, out double pesoValido)
        {
            pesoValido = 0;
            if (peso > 25)
            {
                throw new Exception("No se admiten equipaje mayores a 25 KG.");
            }
            pesoValido = peso;
        }

    }
}
