using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    static class DaneLogowania
    {
        static private string imie;
        static private string nazwisko;
        static private bool pracownik;
        static private int id;

        static public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }

        static public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        static public bool CzyPracownik
        {
            get { return pracownik; }
            set { pracownik = value; }
        }

        static public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
