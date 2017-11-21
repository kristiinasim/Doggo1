using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            Note n1 = new Note();
            Console.WriteLine("Sisestage oma nimi: ");
            n1.Author = Console.ReadLine();
            Console.WriteLine("Sisestage märge:");
            n1.NoteText = Console.ReadLine();
            n1.ModificationDate = DateTime.Now;

            Note n2 = new Note();
            Console.WriteLine("Sisestage oma nimi: ");
            n2.Author = Console.ReadLine();
            Console.WriteLine("Sisestage märge:");
            n2.NoteText = Console.ReadLine();
            n2.ModificationDate = DateTime.Now;

            List<Note> NoteList = new List<Note>();
            NoteList.Add(n1);
            NoteList.Add(n2);


            var test2 = NoteList[0];
            var test = NoteList[1]; //toob välja koha poolest esimese note (ehk teise, sest lugemist alustatakse 0-st)

            foreach (Note element in NoteList)
            {
                Console.WriteLine("Author: " + element.Author);
                Console.WriteLine("Note Text: " + element.NoteText);
                Console.WriteLine("ModificationDate: " + element.ModificationDate);
            }

           

            Console.ReadLine();
        }
    }
}
