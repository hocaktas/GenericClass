using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class Liste<L>
    {
        private L deger;

        public L Islem
        {
            get { return deger; }
            set { deger = value; }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            Liste<string> stringNesne = new Liste<string>();
            stringNesne.Islem = "Kemalettin AKTAŞ";
            Console.WriteLine(stringNesne.Islem);
            Liste<int> intNesne = new Liste<int>();
            intNesne.Islem = 1987;
            Console.WriteLine(intNesne.Islem);
        }
    }
}
