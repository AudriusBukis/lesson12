using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson12.Models
{
    public class TVProgramServices
    {
        public void RemuveTVShowByName(string name, TVPrograme listTVShows)
        {
            // foreach (var tvShow in listTVShows.TVShows)
            // {
            //    if (tvShow.Title == name)
            //     {
            //         listTVShows.TVShows.Remove(tvShow);
            //         break;
            //     }
            // }
            //List<TVShow> delateItem = listTVShows.TVShows.Where(i => i.Title == name).ToList();
            listTVShows.TVShows.Remove(listTVShows.TVShows.FirstOrDefault(i => i.Title == name));// sitoks variantas ismeta pati pirma surasta elementas 


        }
        public void RemuveTVShowById(int id, TVPrograme listTVShows)
        {
            /*foreach (var tvShow in listTVShows.TVShows)
            {
                if (tvShow.Id == id)
                {
                    listTVShows.TVShows.Remove(tvShow);
                    break;
                }
            }*/
            listTVShows.TVShows.Remove(listTVShows.TVShows.SingleOrDefault(i => i.Id == id)); // sitoks variantas naudotinas kai yra vienas elementas sarase  bet ismeta error exeption jai ju yra daugiau 
        }
        public void PrintPrograme(TVPrograme listTVShows)
        {
            foreach (var item in listTVShows.TVShows)
            {
                Console.WriteLine(item);
            }
        }
        public void DelateePrograme(TVPrograme listTVShows)
        {
            listTVShows.TVShows.Clear();
        }


    }
}
