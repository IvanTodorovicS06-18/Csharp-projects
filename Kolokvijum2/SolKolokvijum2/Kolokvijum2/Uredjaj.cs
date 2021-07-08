using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokvijum2
{
    public class Uredjaj : Iuredjaj
    {
        private string _proizvodjac;

        public string proizvodjac
        {
            get { return _proizvodjac; }
            set 
            {
                if (value.Trim().Length > 0 && value.Length <= 20)
                {
                    _proizvodjac = value;
                }
                else
                {
                    throw new Exception("Proizvodjac ne sme biti prazan");
                }
               
            }
        }

        private string _model;

        public string model
        {
            get { return _model; }
            set
            {
                if(value.Trim().Length > 0 && value.Length <= 20)
                {
                    _model = value; 
                }
                else
                {
                    throw new Exception("Model ne sme biti prazan");
                }
            }
        }

        private double _cena;

        public double cena
        {
            get { return _cena; }
            set 
            {
                if (value <= 0)
                {
                    throw new Exception("Unos cene ne sme biti ispod ili jednak 0"); 
                }
                else
                {
                    _cena = value;
                }

            }
        }

        private string _procesor;

        public string procesor
        {
            get { return _procesor; }
            set 
            {
               
                if (value.ToLower() == "amd" || value.ToLower() == "intel")
                {
                    _procesor = value;
                }
                else
                {
                    throw new Exception("procesor mora biti AMD ili Intel");
                }
            }
        }

        private int _ramMemorija;

        public int ramMemorija
        {
            get { return _ramMemorija; }
            set 
            {
                if(value >= 2 && value <= 32)
                {
                    _ramMemorija = value;
                }
                else
                {
                    throw new Exception("Unesi te  kolicinu radne memorije iz opsega (2 gb - 32 gb)");
                }
            }
        }

        private int _memorijaSkladista;

        public int memorijaSkladista
        {
            get { return _memorijaSkladista; }
            set 
            {
                if (value >= 50 && value <= 1000)
                {
                    _memorijaSkladista = value;
                }
                else
                {
                    throw new Exception("Unesi te kolicinu memorije iz opsega (50 gb - 1000 gb)");
                }
            }
        }

        public virtual string UnosTeksta()
        {
            return "Uredjaj-UnosTeksta";
        }

       
        public string Prodaja()
        {
            return "Uredjaj-Prodaja";
        }

    }
}
