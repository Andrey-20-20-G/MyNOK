using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyNOK.MyNOK;

namespace MyNOK
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var run = new ToWork();
            run.ToWorkMethod();
            run.ToWorkMethod2();

            

            Console.ReadKey();

        }
    }
}
