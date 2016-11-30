using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] table = new int[2];

            int liczba1;
            int liczba2 = 30;
            int liczba3 = 0;
            
            try
            {
                //liczba1=liczba2/liczba3;
                //int[25]=2;
                //int[13]=liczba2/liczba3;
                throw new NaszWyjatekException("nasz własny wyjatek");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch
            {
                Console.WriteLine("inny wyjątek");
            }
            finally
            {
                Console.WriteLine("finally");
            }

            Console.ReadKey();
        }
    }
}
