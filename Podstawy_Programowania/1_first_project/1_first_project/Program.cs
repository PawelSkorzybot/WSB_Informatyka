using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_first_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //komentarz
            Console.Write("Imie: "); // wyswietli Imie: Janusz
            Console.WriteLine("Janusz");

            /*Komentarz
             * w wielu
             * liniach
             */

            //wyswietlanie haszy w liniach jedne pod drugimi najpierw 1 potem 2 nastepnie 3 i 4

            Console.WriteLine();
            Console.WriteLine("#");
            Console.WriteLine("##");
            Console.WriteLine("###");
            Console.WriteLine("####");

            // lub

            Console.WriteLine();
            Console.WriteLine("\n#\n##\n###\n####");


            //zmienna

            string name;
            name = "Bożena";
            string name1;
            name1 = "Ksawery";

            Console.WriteLine("\nMasz na imie: " + name); //konkatenacja czyli ten plus + w php to jest . kropka

            Console.WriteLine("\nMasz na imie: {1}",name, name1); //interpolacja

            int age = 20;

            Console.WriteLine("\nMasz na imie: {0}, wiek: {1} lat", name1, age);

            sbyte age1 = 20;

            Console.WriteLine("Wiek: {0}",age1);

            /*Uzytkowanik podaje z klawiatury dlugosc boku
             * oblicz pole kwadratu lub prostokata
             */


            Console.Write("\nPodaj dlugosc a: ");
            string a = Console.ReadLine();

            Console.Write("Podaj dlugosc b: ");
            string b = Console.ReadLine();
            //Console.WriteLine("a = {0}", a);
            //Console.WriteLine("b = {0}", b);

            //decimal i double, decimal jest 10 razy wolniejsze niż double no i nie jest obslugiwane bezposrednio przez komputer (decimal jest wolny ale ma duzy zakres) (double szybki ale maly zakres)
            // jeszcze jest float

            double result = double.Parse(a) * double.Parse(b); //parsowanie czyli zamiana na typ  danych inny

            Console.WriteLine("Pole wynosi: {0}",result);

            /*
             * oblicz pole trojkata
             * dane podaje uzytkownik z klawiatury
             */

            Console.Write("\nPodaj dlugosc a: ");
            string a1 = Console.ReadLine();

            Console.Write("Podaj dlugosc h: ");
            string h = Console.ReadLine();


            double result1 = (double.Parse(a1) * double.Parse(h))/2; //parsowanie czyli zamiana na typ  danych inny

            Console.WriteLine("Pole wynosi: {0}", result1);


            Console.ReadKey();

        }
    }
}
