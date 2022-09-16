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

        public bool EquipajeDeMano
        {
            get => equipajeDeMano;
            set => equipajeDeMano = value;
        }
        public double EquipajeDeBodega
        {
            get => equipajeDeBodega;
            set => equipajeDeBodega = value;
        }
    }
}
