using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOLO
{
    class Druzyna:IDruzyna
    {
       
        private Pilkarz[,] druzyna = new Pilkarz[2, 4];
        druzyna[0,0] = ("Adam","Nowak",12);
        druzyna[0,1] = ("Andrzej","Tamal",2);
        private string nazwa;

       public bool CzyOK()
        {
           if(druzyna != null)
           {
               return true;
           }
           else
           {
               return false;
           }
       }
        public void UstawNazwe(string nazwa)
        {
            this.nazwa=nazwa;
        }
    
        public string ToString()
        {
            return druzyna;
        }
}
}