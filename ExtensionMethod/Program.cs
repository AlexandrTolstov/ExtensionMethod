using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Funn with Extension Methods\n");
            int myInt = 12345678;
            myInt.DisplayDefiningAssembly();

            System.Data.DataSet d = new System.Data.DataSet();
            d.DisplayDefiningAssembly();

            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            sp.DisplayDefiningAssembly();

            Console.WriteLine("Value of myInt: {0}", myInt);
            Console.WriteLine("Reversed digits pf myInt: {0}", myInt.ReverseDigits());
        }
    }
}
