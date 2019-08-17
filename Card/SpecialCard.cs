using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902.Card
{
    public class SpecialCard : Card
    {
        //Atributos
        private string buffType;

        //Constructor
        public SpecialCard(): base(name, type, effect) {
            BuffType = null;
        }
       
        //Propiedades
        public string BuffType
        {
            get
            {
                return this.buffType;
            }
            set
            {
                this.buffType = value;
            }
        }
    }
}
