using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBarQixToolkit
{
    public class FooBarQix
    {
        public string Compute(string number)
        {
            long integer;
            var result = string.Empty;
            try
            {
                if (!Int64.TryParse(number, out integer))
                {
                    return string.Empty;
                }
                else
                {
                    result = ApplytheDeviderRule(integer);
                    result += ApplytheContainsRule(number);

                    if (string.IsNullOrEmpty(result))
                    {
                        result = number.ToString();
                    }
                    
                    return result;                  
                }
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

        public string ApplytheContainsRule(string number)
        {
            string result = string.Empty;
            try
            {

                if (!number.Contains("3")
                    && !number.Contains("5")
                    && !number.Contains("7"))
                {
                    return string.Empty;
                }
                else
                {
                    foreach (char c in number)
                    {
                        if(c =='3')
                        {
                            result += "Foo";
                        }
                        if(c=='5')
                        {
                            result += "Bar";
                        }
                        if (c == '7')
                        {
                            result += "Qix";
                        }
                    }
                    return result;                 
                }
            }
            catch(Exception ex)
            {
                return string.Empty;
            }
        }

        public string ApplytheDeviderRule(long number)
        {
            string result=string.Empty;
            try
            {
                if(number % 3 != 0
                       && number % 5 != 0
                       && number % 7 != 0)
                {
                    return string.Empty;
                }
                else
                {
                    if(number % 3 == 0)
                    {
                        result += "Foo";
                    }
                    if (number % 5 == 0)
                    {
                        result += "Bar";
                    }
                    if (number % 7 == 0)
                    {
                        result += "Qix";
                    }

                    return result;
                }
            }
            catch(Exception ex)
            {
                return string.Empty;
            }
        }
    }
}
