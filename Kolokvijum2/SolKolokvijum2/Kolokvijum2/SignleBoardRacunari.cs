using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokvijum2
{
    public class SignleBoardRacunari: Uredjaj, IsignleBoardRacunari
    {
        private string _portovi;

        public string portovi
        {
            get { return _portovi; }
            set { _portovi = value; }
        }

        public override string UnosTeksta()
        {
            return "Unos teksta preko tastature(SingleBoardRacunari)";
        }
    }
}
