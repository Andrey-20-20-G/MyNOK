using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNOK.MyNOK
{
    public class NOK
    {
        public int maxValue = Int32.MaxValue;
        

        public int Result(int value1, int value2)
        {
            try
            {
                int result = 0;
                for (int i = 0; i < (value1 * value2 + 1); i++)
                {
                    if (i % value2 == 0 && i % value1 == 0)
                    {

                        result = i;
                        if (result < maxValue)
                        {
                            maxValue = result;
                        }
                        if (result != 0)
                        {
                            //Console.WriteLine(result);
                            return result;
                        }

                    }


                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }


    
    }
}
