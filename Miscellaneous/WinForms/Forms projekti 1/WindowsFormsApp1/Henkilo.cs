using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public struct Henkilo
    {
        public string Nimi;
        public int Ika;
        public bool Elakkeella;
        public string Siviilisaaty;

        public string PalautaTiedot()
        {
            if (Elakkeella)
                return Nimi + " " + Ika.ToString() + " Eläkkeellä " + Siviilisaaty;
            else
                return Nimi + " " + Ika.ToString() + " Töissä " + Siviilisaaty;


        }
    }
}
