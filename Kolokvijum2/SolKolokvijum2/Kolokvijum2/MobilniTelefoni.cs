using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokvijum2
{
    public class MobilniTelefoni : Uredjaj, ImobilniTelefoni
    {
        private string _OperativniSistem;

        public string OperativniSistem
        {
            get { return _OperativniSistem; }
            set { _OperativniSistem = value; }
        }
        private string _baterija;

        public string baterija
        {
            get { return _baterija; }
            set { _baterija = value; }
        }

        private string _kamera;

        public string kamera
        {
            get { return _kamera; }
            set { _kamera = value; }
        }
        public override string UnosTeksta()
        {
            return "Unos teksta preko ekrana na dodir(telefoni)";
        }
        public string SMS()
        {
            return "Uspesno poslata poruka";
        }

        public string Poziv()
        {
            return "Uspesno izvrsen poziv";
        }
    }
}
