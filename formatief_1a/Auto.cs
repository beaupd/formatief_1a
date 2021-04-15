using System;
using System.Collections.Generic;
using System.Text;

namespace formatief_1a
{
    class Auto
    {
        private string type;
        private double prijsPerDag;
        public Auto(string tp, double prPd)
        {
            this.type = tp;
            this.prijsPerDag = prPd;
        }
        public void setPrijsPerDag(double prPd)
        {
            this.prijsPerDag = prPd;
        }
        public double getPrijsPerDag()
        {
            return this.prijsPerDag;
        }
        public string toString()
        {
            return $"Auto{{ type={this.type}, prijsPerDag={this.prijsPerDag} }}";
        }
    }
}
