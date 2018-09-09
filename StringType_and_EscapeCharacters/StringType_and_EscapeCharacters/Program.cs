using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringType_and_EscapeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            // \' \" \\ \0 \a \b \n \r \t \v \f
            // @ 

            string myString = "Nazar said This is a good cours, and I think\0";
            string myString2 = "Yes it's";
            string myString3 = myString + myString2;


            Console.WriteLine("{0}", myString3);
            Console.ReadKey();



        }
    }
}
