using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class PrWork4
    {
        static void Main() 
        {
            string num = "LVIII";
            int sum = 0;

            for (int i = 0; i < num.Length; ++i)
            {
                if (num[i] == 'I')
                {
                    if (i < num.Length - 1 && num[i + 1] == 'V')
                    {
                        sum += 4;
                        i++;
                    }
                    
                    else if (i < num.Length - 1 && num[i + 1] == 'X')
                    {
                        sum += 9;
                        i++;
                    }
                    
                    else
                    {
                        sum += 1;
                    }
                }
                
                else if (num[i] == 'V')
                {
                    sum += 5;
                }
                
                else if (num[i] == 'X')
                {
                    if (i < num.Length - 1 && num[i + 1] == 'L')
                    {
                        sum += 40;
                        i++;
                    }
                    else if (i < num.Length - 1 && num[i + 1] == 'C')
                    {
                        sum += 90;
                        i++;
                    }
                    
                    else
                    {
                        sum += 10;
                    }
                }
                
                else if (num[i] == 'L')
                {
                    sum += 50;
                }
                
                else if (num[i] == 'C')
                {
                    if (i < num.Length - 1 && num[i + 1] == 'D')
                    {
                        sum += 400;
                        i++;
                    }
                    
                    else if (i < num.Length && num[i + 1] == 'M')
                    {
                        sum += 900;
                        i++;
                    }
                    
                    else
                    {
                        sum += 100;
                    }
                }
                
                else if (num[i] == 'D')
                {
                    sum += 500;
                }
                
                else if (num[i] == 'M')
                {
                    sum += 1000;
                }
            }
           
            Console.WriteLine(sum);
        }
    }
}

