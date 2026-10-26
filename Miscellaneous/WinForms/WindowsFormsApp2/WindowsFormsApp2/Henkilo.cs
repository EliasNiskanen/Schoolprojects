using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Henkilo
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }

        public Henkilo(string etunimi, string sukunimi)
        {

            Etunimi = etunimi;
            Sukunimi = sukunimi;

        }

    }
}
