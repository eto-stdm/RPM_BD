using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPM_BD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Details> det = Core.Context.Details.ToList();
            foreach (Details d in det)
            {
                Console.WriteLine($"{d.id}\t{d.DetailName}");
            }
            Console.WriteLine("\n");
        }
    }
}
