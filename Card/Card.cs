using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902.Card
{
    public class Card
    {
        // Atributos
        private string name;
        private string type;
        private string effect;

        public Card(string name, string type, string effect)
        {
            Name = name;
            Type = type;
            Effect = effect;
        }

        // Propiedades
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public string Effect
        {
            get
            {
                return this.effect;
            }
            set
            {
                this.effect = value;
            }
        }
    }
}
