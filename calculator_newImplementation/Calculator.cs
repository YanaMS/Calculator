using System;
using System.Collections.Generic;
using System.Text;

namespace calculator_newImplementation
{
    class Calculator
    {
        public Results Calculate (Source source)
        {
            Results result = new Results();
            switch (source.Operation)
            {
                case "+":
                    {
                        result.Message = null;
                        result.Result = source.Operand1 + source.Operand2;
                        return result;
                    }
                case "-":
                    {
                        result.Message = null;
                        result.Result = source.Operand1 - source.Operand2;
                        return result;
                    }
                case "*":
                    {
                        result.Message = null;
                        result.Result = source.Operand1 * source.Operand2;
                        return result;
                    }
                case "/":
                    {
                        result.Message = null;
                        result.Result = source.Operand1 / source.Operand2;
                        return result;
                    }
                default:
                    {
                        result.Message = "Invalid operator";
                        result.Result = 0;
                        return result;
                    }


            }
        }
    }
}
