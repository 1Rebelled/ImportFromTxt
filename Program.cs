using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Continue;
            string[] plik = System.IO.File.ReadAllLines(@"C:\Users\Rebelled\Desktop\list.txt");


            void wypiszanny()
            {

                foreach (string linia in plik)
                {


                    if (linia.Contains("Anna"))
                    {
                        Console.WriteLine(linia);
                    }

                }

            }
            do
            {
                Console.WriteLine("Jaka opcje wybierasz");
                Console.WriteLine("[1] \t Wypisanie wszystkich kobiet o imieniu Anna");
                Console.WriteLine("[2] \t Chcesz zobaczyc co kryje sie pod elementem 246");
                Console.WriteLine("[3] \t Chcesz zobaczyc zawartosc calego pliku");

                int wybor = int.Parse(Console.ReadLine());



                switch (wybor)
                {

                    case 1:
                        wypiszanny();
                        break;
                    case 2:
                        Console.WriteLine("Element 246 to \t" + plik[246]);
                        break;
                    case 3:
                        foreach (string linia in plik)
                        {
                            Console.WriteLine(linia);
                        }
                        break;

                    default:
                        break;
                }

                Console.Write("Czy chcesz kontynuować (t/n) : ");
                Continue = Console.ReadLine();
                Console.Clear();
            } while (Continue != "N" && Continue != "n");

        }

    }
}
