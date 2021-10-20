using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prace kontynuowane. Prosze o uwagi.
            double n1, n2, wynik;
            byte n, n3;
            string n4;
            n3 = 0;




            Console.WriteLine("KALKULATOR");
            Console.WriteLine("");
            //Console.WriteLine("Podaj pierwszą liczbę");
            //n1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj drugą liczbę");
            //n2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj numer operacji do wykonania.");
            Console.WriteLine("     1. Dodawanie");
            Console.WriteLine("     2. Odejmowanie");
            Console.WriteLine("     3. Mnożenie");
            Console.WriteLine("     4. Dzielenie");
            Console.WriteLine("     5. Potęgowanie");
            Console.WriteLine("     6. Pierwiastkowanie");
            Console.WriteLine("     7. Procent (np: 30 z 40 = 75%");
            Console.WriteLine("");
            //n = byte.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("Podaj pierwszą liczbę");
                n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj numer operacji do wykonania.");
                n = byte.Parse(Console.ReadLine());

                if (n == 5)
                {
                    wynik = n1 * n1;
                    Console.WriteLine("Otrzymałeś {0}", wynik);
                }
                else if (n == 6)
                {
                    wynik = Math.Sqrt(n1);
                    Console.WriteLine("Otrzymałeś {0}", wynik);
                }
                else
                {
                    Console.WriteLine("Podaj drugą liczbę");
                    n2 = double.Parse(Console.ReadLine());
                    if (n == 1)
                    {
                        wynik = n1 + n2;
                        Console.WriteLine("Otrzyłeś {0}", wynik);
                    }
                    else if (n == 2)
                    {
                        wynik = n1 - n2;
                        Console.WriteLine("Otrzymałeś {0}", wynik);
                    }
                    else if (n == 3)
                    {
                        wynik = n1 * n2;
                        Console.WriteLine("Otrzymałeś {0}", wynik);
                    }
                    else if (n == 4)
                    {
                        if (n2 != 0)
                        {
                            wynik = n1 / n2;
                            Console.WriteLine("Otrzymałeś {0}", wynik);
                        }
                        else
                        {
                            Console.WriteLine("Amewo nie dziel przez ZERO!");
                        }
                    }
                    else if (n == 7)
                    {
                        wynik = n1 / n2 * 100;
                        Console.WriteLine("Otrzymałeś {0}%", wynik);
                    }

                    else
                    {
                        Console.WriteLine("Wać raczy uczyć się czytać???");
                    }
                }
                Console.WriteLine("");

                Console.WriteLine("Aby zakończyć podaj hasło.");

                n4 = Console.ReadLine();

                if (n4 == "end")
                {
                    Console.WriteLine("End of work.");
                    break;
                }
                else
                {
                    Console.WriteLine("ERROR! JEDZIESZ DALEJ!");
                }
                Console.WriteLine("");
                n3++;
            }
        }
    }
}
