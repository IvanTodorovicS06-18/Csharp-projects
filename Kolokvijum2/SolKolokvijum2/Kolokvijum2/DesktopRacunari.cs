using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokvijum2
{
    public class DesktopRacunari : Uredjaj, IdesktopRacunari 
    {
        private string _OperativniSistem;

        public string OperativniSistem
        {
           

            get { return _OperativniSistem; }
            set
            {
                if (value.Trim().Length > 0)
                {
                    _OperativniSistem = value;
                }
                else
                {
                    throw new Exception("Unesite Operativni sistem");
                }
            }
        }

        private string _graficka;

        public string graficka
        {
            get { return _graficka; }
            set 
            {
                if(value.Trim().Length > 0)
                {
                    _graficka = value; 
                }
                else
                {
                    throw new Exception("Unesite graficku kartu");
                }
            }
        }

      
        public override string UnosTeksta()
        {
            return "Unos teksta preko tastature";
        }

    }
}
