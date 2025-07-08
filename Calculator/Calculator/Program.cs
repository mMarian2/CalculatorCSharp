using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definim o variabila pe care o setam ca "y"
            string continua = "y";
            
            //Facem un loop
            while (continua == "y")
            {
                //Citim primul numar de la tastatura
                Console.Write("Introduceti primul numar: ");
                double a = Convert.ToDouble(Console.ReadLine());

                //Citim al doilea numar de la tastatura
                Console.Write("Introduceti al doilea numar :");
                double b = Convert.ToDouble(Console.ReadLine());

                //Citim operatorul de la tastatura
                Console.Write("Operator (+, -, *, /) : ");
                string op = Console.ReadLine();

                //Declaram o variabila "rezultat", o setam ca fiind 0
                double rezultat = 0;

                //Scriem actiunea pentru fiecare operator
                if (op == "+") rezultat = a + b;
                else if (op == "-") rezultat = a - b;
                else if (op == "*") rezultat = a * b;
                else if (op == "/")
                {
                    //Conditie pentru impartire la 0
                    if (b == 0)
                    {
                        Console.WriteLine("Nu se poate imparti la 0!");
                        return;
                    }

                    rezultat = a / b;
                }
                else Console.WriteLine("Operator invalid. ");

                //Setam culoarea
                Console.ForegroundColor = ConsoleColor.Red;

                //Afisam rezultatul
                Console.WriteLine("Rezultatul este: " + rezultat);

                Console.ResetColor();

                //Vrem daca utilizatorul vrea sa continue sa calculeze sau nu.
                Console.Write("Vrei sa continui? y/n ");
                continua = Console.ReadLine();

            }
        }
    }
}
