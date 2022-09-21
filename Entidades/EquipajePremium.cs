using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipajePremium : Equipaje
    {
        private double equipajeDeBodegaExtra;

        public EquipajePremium(bool equipajeDeMano, double equipajeDeBodega)
            : base(equipajeDeMano, equipajeDeBodega)
        {
            this.equipajeDeBodegaExtra = 0;
        }
        public EquipajePremium(bool equipajeDeMano, double equipajeDeBodega, double equipajeDeBodegaExtra) 
            : this(equipajeDeMano, equipajeDeBodega)
        {
            this.equipajeDeBodegaExtra = equipajeDeBodegaExtra;
        }

        public double EquipajeDeBodegaExtra
        {
            get
            {
                return this.equipajeDeBodegaExtra;
            }
            set
            {
                if (value > 0 && value <= 21)
                {
                    this.equipajeDeBodegaExtra = value;
                }
            }
        }
    }
}
