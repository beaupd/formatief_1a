using System;
using System.Collections.Generic;
using System.Text;

namespace formatief_1a
{
    class Game
    {
        private string name;
        private int releaseYear;
        private double price;
        private int now = DateTime.Now.Year;

        public Game(string nm, int ry, double pr)
        {
            this.name = nm;
            this.releaseYear = ry;
            this.price = pr;
        } 
        public string getName()
        {
            return this.name;
        }
        public double nieuwPrijs()
        {
            return this.price;
        }
        public double nuPrijs()
        {
            return this.price / Math.Pow(0.7, (this.releaseYear - now));
        }

        public void toString()
        {
            Console.WriteLine( $"{this.name} van {this.price} nu voor {this.nuPrijs()} ");
        }
    }
}
