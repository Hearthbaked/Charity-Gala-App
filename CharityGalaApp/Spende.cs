using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityGalaApp
{
    class Spende
    {
        long id;
        string spenderName;
        double spendeBetrag;

        public Spende(long id, string spenderName, double spendeBetrag)
        {
            this.id = id;
            this.spenderName = spenderName;
            this.spendeBetrag = spendeBetrag;
        }

        public override string ToString()
        {
            return spenderName + " " + spendeBetrag + "€";
        }
    }
}
