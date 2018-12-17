using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBarQixToolkit
{
    public class FooBarQix
    {
        public string Compute(string Number)
        {
            int integer;
            if(!Int32.TryParse(Number,out integer))
            {
                return string.Empty;
            }
            else
            {
                if (!Number.Contains("3")
                   && !Number.Contains("5")
                   && !Number.Contains("7")
                   && integer % 3 != 0
                   && integer % 5 != 0
                   && integer % 7 != 0)
                {
                    return Number;
                }
                else
                {
                    return string.Empty;
                }
                    
            }  
        }

    }
}
