using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectors
{
    internal class Program
    {
        static void DispayElements(List<int> list)
        {
            Console.WriteLine("** List **");
            foreach (int i in list)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            //Dictionary , HashTable       klucz, wartość
            //List                         dodawanie usuwanie filtrowanie sortowanie grupowanie
            //queue , Stack                First in first Out,    First in last Out

            List<int> intList = new List<int>() { 6, 1, 20, 3, 45, 60, 100, 2, 6, 1, 20, 3, 45, 60, 100, 2 };

            Console.Write("New Element: ");
            intList.Add(int.Parse(Console.ReadLine()));      //dodawanie z parsowaniem

            intList.RemoveAt(0); //  usuwa element z pozycji 0


            // Usuwa wszystkie spełniające warunek zwracany przez funkcje bool (testowany jest  na każdm elemencie)
            bool IsGreaterThan5(int i)
            {
                return i > 5;
            }

            intList.RemoveAll(IsGreaterThan5);

            intList.Remove(1);  // usuwa jedną konkretna wartosc. lista {1,2,1}   po zastosowanie funkcji => {2,1}

            intList.RemoveRange(1, 2);   // ( numer indexu, ilosc elementow do usuniecia)

            intList.Sort(); // sortuje liste

            DispayElements(intList);

        }
    }
}
