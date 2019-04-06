using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            Console.WriteLine(start);

            MainPresenter mp = new MainPresenter();
            int result = mp.Refresh();
            Console.WriteLine($"Amount new posts {result}");

            DateTime finish = DateTime.Now;
            Console.WriteLine(finish);
            Console.WriteLine(finish - start);

            Console.ReadLine();
        }
    }
}
