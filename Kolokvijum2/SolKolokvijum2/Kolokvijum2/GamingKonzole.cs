using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokvijum2
{
    public class GamingKonzole : Uredjaj, IgamingKonzole
    {
        private string _graficka;

        public string graficka
        {
            get { return _graficka; }
            set { _graficka = value; }
        }

        private string _Dzojstik;

        public string Dzojstik
        {
            get { return _Dzojstik; }
            set { _Dzojstik = value; }
        }
        public override string UnosTeksta()
        {
            return "Unos teksta preko dzojstika";
        }

        public string UpaliIgricu()
        {
            return "Uspesno upaljena igrica";
        }
    }
}
