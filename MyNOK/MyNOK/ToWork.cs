using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNOK.MyNOK
{
    public class ToWork
    {
        public bool logic = false;
        public bool ToWorkMethod()
        {
            
            NOK nok = new NOK();
            //Console.WriteLine("Введите а");
            //var a = Console.ReadLine();
            //Console.WriteLine("Введите б");
            //var b = Console.ReadLine();
            string a = "5";
            string b = "7";

            if (Int32.TryParse(a, out _) && Int32.TryParse(b, out _))
            {
                int val1 = int.Parse(a);
                int val2 = int.Parse(b);

                var to_work = new MyModel<int>();
                    to_work.A = val1;
                to_work.B = val2;
                Console.WriteLine(nok.Result(to_work.A, to_work.B));
                logic = true;
                return logic;
            }
            else
            {
                Console.WriteLine("Error");
                return logic;
            }
        }

        public bool ToWorkMethod2()
        {
            logic = false;
            NOK nok = new NOK();
            //Console.WriteLine("Введите а");
            //var a = Console.ReadLine();
            //Console.WriteLine("Введите б");
            //var b = Console.ReadLine();
            string a = "5.5";
            string b = "7";

            if (Int32.TryParse(a, out _) && Int32.TryParse(b, out _))
            {
                int val1 = int.Parse(a);
                int val2 = int.Parse(b);

                var to_work = new MyModel<int>();
                to_work.A = val1;
                to_work.B = val2;
                Console.WriteLine(nok.Result(to_work.A, to_work.B));
                logic = true;
                return logic;
            }
            else
            {
                Console.WriteLine("Error");
                return logic;
            }
        }
    }
}
