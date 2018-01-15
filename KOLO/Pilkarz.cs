using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOLO
{
    abstract class Pilkarz
    {
        protected string imie;
        protected string nazwisko;
        protected int numerNaKoszulce;

       
        public string ToString()
        {
            {
                return "Imię i Nazwisko: " + imie + " " + nazwisko + "Numer na koszulce: " + numerNaKoszulce;
            }
        }
    }
}
