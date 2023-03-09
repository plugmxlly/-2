using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class PrWork3_3
    {
        public class Calculation
        {
            private string calculationLine;

            public void setCalculationLine(string line)
            {
                calculationLine = line;
            }
            
            public string GetCalculationLine()
            {
                return calculationLine;
            }

            public void setLastSymbolCalculationLine(char letter)
            {
                calculationLine = calculationLine + letter;
            }

            public char getLastSymbol()
            {
                return calculationLine[calculationLine.Length - 1];
            }

            public void deleteLastSymbol()
            {
                calculationLine = calculationLine.Remove(calculationLine.Length - 1);
            }
        }
        
        static void Main()
        {
            Calculation calc = new Calculation();
            
            calc.setCalculationLine("621Белодед");
            Console.WriteLine(calc.GetCalculationLine());
            
            calc.setLastSymbolCalculationLine('E');
            Console.WriteLine(calc.GetCalculationLine());
            Console.WriteLine(calc.getLastSymbol());
            
            calc.deleteLastSymbol();
            Console.WriteLine(calc.GetCalculationLine());
        }
    }
}

