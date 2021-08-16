using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Wojna
{
    class Card
    {
        private string name;
        private int value;
        private string colour;

        public Card(int name, int value, int colour)
        {
            switch (name)
            {
                case 1:
                    this.name = "As";
                    break;
                case 2:
                    this.name = "Dwójka";
                    break;
                case 3:
                    this.name = "Trójka";
                    break;
                case 4:
                    this.name = "Czwórka";
                    break;
                case 5:
                    this.name = "Piątka";
                    break;
                case 6:
                    this.name = "Szóstka";
                    break;
                case 7:
                    this.name = "Siódemka";
                    break;
                case 8:
                    this.name = "Ósemka";
                    break;
                case 9:
                    this.name = "Dziewiątka";
                    break;
                case 10:
                    this.name = "Dziesiątka";
                    break;
                case 11:
                    this.name = "Walet";
                    break;
                case 12:
                    this.name = "Dama";
                    break;
                case 13:
                    this.name = "Król";
                    break;
            }
            this.value = value;
            switch (colour)
            {
                case 1:
                    this.colour = "Pik";
                    break;
                case 2:
                    this.colour = "Kier";
                    break;
                case 3:
                    this.colour = "Trefl";
                    break;
                case 4:
                    this.colour = "Karo";
                    break;
            }

        }
        public int GetValue()
        {
            return value;
        }
        public override string ToString()
        {
            return (name + " " + colour);
        }
    }
}
