using System;
using System.Collections.Generic;
using System.Text;

namespace calculator_newImplementation
{
    class ConsoleManager: IPrint, IRead
    {
        public void Print(Results result)
        {
            {
                if (result.Message == null)
                {
                    Console.WriteLine(result.Result);
                }
                else
                {
                    Console.Write(result.Message);
                }
            }
        }

        public Source ReadData()
        {
            return new Source
            {
                Operand1 = InputNumber(1),
                Operand2 = InputNumber(2),
                Operation = InputOperator()
            };
        }

        private double InputNumber(int operandNumber)
        {
            double number;
            Console.WriteLine($"Input number {operandNumber}");
            while (!(double.TryParse(Console.ReadLine(), out number)))
            {
                Console.WriteLine("It's not a number. Please input number");
            }

            return number;
        }

        private string InputOperator()
        {
            Source operation = new Source();
            Console.WriteLine($"Input operator");
            return Console.ReadLine();
        }

        public string SourceType => "console";
    }
}
