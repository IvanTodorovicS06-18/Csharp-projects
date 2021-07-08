using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokvijum2
{
    interface Iuredjaj
    {
        string proizvodjac { get; set; }
        string model { get; set; }
        double cena { get; set; }

        string procesor { get; set; }
        int ramMemorija { get; set; }
        int memorijaSkladista { get; set; }

        string UnosTeksta();
        string Prodaja();
    }

    interface IdesktopRacunari
    {
        string graficka { get; set; }
        string OperativniSistem { get; set; }
    }

    interface IlaptopRacunari
    {
        string baterija { get; set; }
        string kamera { get; set; }
        string OperativniSistem { get; set; }
        string graficka { get; set; }

        string NapuniBateriju();
    }

    interface IsignleBoardRacunari
    {
        string portovi { get; set; }
    }

    interface Itablet
    {
        string baterija { get; set; }
        string kamera { get; set; }
        string OperativniSistem { get; set; }

        string CitajEKnjigu();
    }

    interface IgamingKonzole
    {
        string graficka { get; set; }
        string Dzojstik { get; set; }

        string UpaliIgricu();
    }

    interface ImobilniTelefoni
    {
        string OperativniSistem { get; set; }
        string baterija { get; set; }
        string kamera { get; set; }
       

        string SMS();
        string Poziv();

    }




}
