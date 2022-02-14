using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson12.Models
{
    public class TVPrograme
    {
        public List<TVShow> TVShows { get; set; }

        public TVPrograme()
        {
            TVShows = new List<TVShow>();
        }
       
    }
}
