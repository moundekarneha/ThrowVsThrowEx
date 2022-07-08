using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowVsThrowEx
{
    internal class Program
    {
        static void Method1()
        {
            try
            {
                throw new Exception("this is me");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static void Method2()
        {
            try
            {
                Method1();
            }
            catch (Exception ex)
            {
                throw ex; //throw
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Method2();
            }
            catch(Exception ex)
            { 
                Console.WriteLine(ex.StackTrace.ToString());
            }
            Console.ReadLine();

        }
    }
}
 