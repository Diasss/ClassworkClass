using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            People p = new People();
            Console.WriteLine(p.Age);
            p.DOB = new DateTime(2002, 11, 01);
            Console.WriteLine(p.Age);
        }
    }

    
}
    