using System;
using System.Collections.Generic;

namespace Tryparse_och_klasser
{
    class Program
    {
        static void Main(string[] args)
        {

            //Try Parse
            Console.WriteLine("SKriv ett tal");
            int resultat = 10;
            bool lyckad = false;
            while (!lyckad)
            {
                string tal = Console.ReadLine();
                lyckad = int.TryParse(tal, out resultat);
                if(!lyckad)
                {
                    Console.WriteLine("Skriv ett tal");
                }
            }
            Console.WriteLine("Du skrev : " + resultat);
            Console.ReadLine();

            //Generiska klasser
            
            //Lista
            //Skapa lista
            List<int> nummer = new List<int>();
            //Lägga till nummer
            nummer.Add(1);
            //SKriva ut nummer
            Console.WriteLine(nummer[0]);
            //Ta bort plats i listan 
            nummer.Remove(0);
            Console.ReadLine();

            //Stack

            //Skapar en hög
            Stack<int> telefonNummer = new Stack<int>();
            //Lägger till i toppen av högen
            telefonNummer.Push(123);
            telefonNummer.Push(456);
            telefonNummer.Push(789);
            //kollar vilken som ligger i toppen
            Console.WriteLine(telefonNummer.Peek());

            for (int i = 0; i < 3; i++)
            {
                int a = telefonNummer.Pop();
                Console.WriteLine(a);
            }

            Console.ReadLine();


            //Dictionary
            //Skapar en
            Dictionary<string, int> ok = new Dictionary<string, int>();
            //sätter name som index
            ok.Add("name", 3);
            Console.WriteLine(ok["name"]);
            Console.ReadLine();

            //kort förklaring av de generiska klasserna
            //Lista: Det är som en array med ett obestämdt antal platser, man kan lägga till och ta bort.
            //Stack: Ungefär som en lista där man endast lägga till saker i toppen och ta bort saker i toppen, fungerar ungefär som en hög/kortlek
            //Dictionary: Fungerar som en lista där man istället för att använda en int som index, kan man använda andra datatyper.
        }
    }
}
