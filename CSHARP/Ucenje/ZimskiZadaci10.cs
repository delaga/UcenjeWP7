using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class ZimskiZadaci10
    {
        public static void Run()
        {
            Console.WriteLine("****DIGITRON****");
            Console.Write("Unesi prvi broj: ");
            float a=float.Parse(Console.ReadLine());
            Console.WriteLine("Unesi operaciju (+,-,*,/):");
            char op = Console.ReadLine()[0];

            Console.Write("Unesi drugi broj: ");
            float b=float.Parse(Console.ReadLine());

            float rez = 0;

            switch (op)
            { 
                case '+':
                    rez = a+b;
                    Console.WriteLine("Zbroj je: {0}",rez);
                    break;
                case '-':
                    rez = a - b;
                    Console.WriteLine("Razlika je: {0}", rez);
                    break;
                case '*':
                    rez = a * b;
                    Console.WriteLine("Umnožak je: {0}", rez);
                    break;
                case '/':
                    if (b != 0) 
                    {
                        rez = a / b;
                        Console.WriteLine("Količnik (da, stvarno se tako zove) je: {0}", rez);
                    }
                    else
                    {    //ovo je totalno od kineza (DeepSeek)
                        string url = "https://youtu.be/kPqyDm7FFug?si=quiSny1Mf5DkOCAV&t=16";

                        // Output the URL for reference
                        Console.WriteLine("Opening the following link in your default browser: " + url);

                        // Open the URL in the default browser
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = url,
                            UseShellExecute = true
                        });
                        //kinezi over and out
                    }
                   
                    break;
                default:
                    Console.WriteLine("Lupetaš, bro!");
                    break;

            }


        }
    }
}
