using System;
using System.Collections.Generic;
using System.Text;

namespace formatief_1a
{
    class Autohuur
    {
        private int aantalDagen;
        private Klant huurder;
        private Auto gehuurdeAuto;

        public Autohuur()
        {
        }
        public void setAantalDagen(int aD)
        {
            this.aantalDagen = aD;
        }
        public void setGehuurdeAuto(Auto gA)
        {
            this.gehuurdeAuto = gA;
        }
        public Auto getGehuurdeAuto()
        {
            return this.gehuurdeAuto;
        }
        public void setHuurder(Klant k)
        {
            this.huurder = k;
        }
        public Klant getHuurder()
        {
            return this.huurder;
        }
        public double totaalPrijs()
        {
            return this.aantalDagen * (this.gehuurdeAuto.getPrijsPerDag() * ((100 - this.huurder.getKorting()) / 100));
        }
        public string toString()
        {
            if (huurder == null) {
                if (gehuurdeAuto == null)
                {
                    return $"Autohuur{{ aantalDagen={this.aantalDagen}, huurder=Er is geen huurder, gehuurdeAuto=Er is geen auto, prijs=0.0";
                } else
                {
                    return $"Autohuur{{ aantalDagen={this.aantalDagen}, huurder=Er is geen huurder, gehuurdeAuto={this.gehuurdeAuto.toString()}, prijs=0.0 }}";
                }
            } else
            {
                if (gehuurdeAuto == null)
                {
                    return $"Autohuur{{ aantalDagen={this.aantalDagen}, huurder={this.huurder.toString()}, gehuurdeAuto=Er is geen auto, prijs=0.0 }}";
                } else
                {
                    return $"Autohuur{{ aantalDagen={this.aantalDagen}, huurder={this.huurder.toString()}, gehuurdeAuto={this.gehuurdeAuto.toString()}, prijs={this.totaalPrijs()} }}";
                }
            }
            
        }
    }
}
