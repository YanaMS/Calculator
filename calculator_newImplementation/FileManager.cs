using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace calculator_newImplementation
{
    class FileManager: IPrint, IRead
    {
        public string SourceType => "file";
        public void Print(Results result)
        {
            if (result.Message == null)
            {
                WriteToFile(result.Result.ToString());
            }
            else
            {
                WriteToFile(result.Message);

            }
        }

        public Source ReadData()
        {
            string dataForCalculate = ReadDataFromFile();
            string[] splitDataForCalculate = dataForCalculate.Split(new [] { ',' });
            return new Source()
            {
                Operand1 = Convert.ToDouble(splitDataForCalculate[0]),
                Operand2 = Convert.ToDouble(splitDataForCalculate[1]),
                Operation =  splitDataForCalculate[2]
            };

        }

        public string ReadDataFromFile()
        {
            try
            {
                using (StreamReader reader = new StreamReader("ReadData.txt"))
                {
                    return reader.ReadLine();
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private static void WriteToFile(string message)
        {
            try
            {
                using (StreamWriter reader = new StreamWriter("WriteResult.txt", true))
                {
                    reader.WriteLine(message);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
