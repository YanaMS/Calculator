using System;
using System.IO;
using System.Linq;

namespace calculator_newImplementation
{
    class Program
    {
        static void Main()
        {
            try
            {
                FileManager fileManager = new FileManager();
                Source data = new Source();
                data = fileManager.ReadData();
                Calculator calculator = new Calculator();
                Results result = new Results();
                result = calculator.Calculate(data);
                IPrint consoleManager = new ConsoleManager();
                consoleManager.Print(result);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("No data for calculating, the file is empty. Please input data to file and press Enter");
                Console.ReadKey();
                Main();
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format. Please input correct data to file and press Enter");
                Console.ReadKey();
                Main();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Not all data present in the file. Please input  data to file and press Enter");
                Console.ReadKey();
                Main();
            }
            Console.ReadKey();
            
           
            

            

             //var source = "file";
            //IPrint[] printProvidres = new IPrint[]
            //{
            //    consoleManager,
            //    new SaveResultFile()
            //};

            //foreach (var printProvider in printProvidres
            //    .Where(element => element.SourceType == source))
            //{
            //    printProvider.Print(res);
            //}
        }
    }
}
