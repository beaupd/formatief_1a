using System;
using System.Collections.Generic;
using System.Text;

namespace formatief_1a
{
    class Klant
    {
        private string naam;
        private double kortingsPercentage;

        public Klant(string nm)
        {
            this.naam = nm;
        }
        public void setKorting(double kP)
        {
            this.kortingsPercentage = kP;
        }
        public double getKorting()
        {
            return this.kortingsPercentage;
        }
        public string toString()
        {
            return $"Klant{{ naam={this.naam}, kortingsPercentage={this.kortingsPercentage} }}";
        }
    }
}
