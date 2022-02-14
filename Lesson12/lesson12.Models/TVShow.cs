using System;
using System.Collections.Generic;

namespace lesson12.Models
{
    public class TVShow
    {
        public int Id { get; set; }
        public TimeSpan Duration { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
       // public List<string> Test = new List<string>(); galimas ir tesioginis list deklaravimas
        public TVShow()
        {

        }
        public TVShow(int id, TimeSpan duration, string title, string description, DateTime startTime)
        {
            Id = id;
            Duration = duration;
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            StartTime = startTime;
        }

        public override string ToString()
        {
            return $"Show Id:{Id} title of show:{Title} - Description ({Description}) Duration: {Duration}, Start time - {StartTime}";
        }
    }
}
