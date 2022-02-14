using lesson12.Models;
using System;
using System.Collections.Generic;

namespace Lesson12
{
    internal class Program
    {
        
       
        static void Main(string[] args)
        {
            TVShow band = new TVShow();
            band.Test.Add("jkgjfyr");
            TVPrograme tVPrograme = new TVPrograme();
            TVProgramServices TVShowSercice = new TVProgramServices();
            Console.WriteLine("lesson 12 task 1");
            tVPrograme.TVShows.Add(new TVShow(1, TimeSpan.FromHours(1.2), "Liutas Karalius", "Animacinis filmukas", DateTime.Now.AddDays(1).AddHours(1)));
            tVPrograme.TVShows.Add(new TVShow(2, TimeSpan.FromHours(1.5), "Madagaskaras", "Animacinis filmukas", DateTime.Now.AddDays(1).AddHours(3)));
            tVPrograme.TVShows.Add(new TVShow(3, TimeSpan.FromHours(1.3), "Matrica", "Fantastinis filmas", DateTime.Now.AddDays(2).AddHours(4)));
            tVPrograme.TVShows.Add(new TVShow(4, TimeSpan.FromHours(2.2), "Liutas Karalius", "Animacinis filmukas", DateTime.Now.AddDays(3).AddHours(8)));
            tVPrograme.TVShows.Add(new TVShow(5, TimeSpan.FromHours(3.1), "Madagaskaras", "Animacinis filmukas", DateTime.Now.AddDays(5).AddHours(2)));
            Console.WriteLine();
            TVShowSercice.PrintPrograme(tVPrograme);
            Console.WriteLine();
            TVShowSercice.RemuveTVShowById(4, tVPrograme);
            Console.WriteLine();
            TVShowSercice.PrintPrograme(tVPrograme);
            Console.WriteLine();
            TVShowSercice.RemuveTVShowByName("Madagaskaras", tVPrograme);
            Console.WriteLine();
            TVShowSercice.PrintPrograme(tVPrograme);
            Console.WriteLine();
            TVShowSercice.DelateePrograme(tVPrograme);
            Console.WriteLine("---------------");
            TVShowSercice.PrintPrograme(tVPrograme);
            Console.WriteLine("----------------");
        }
    }
}
