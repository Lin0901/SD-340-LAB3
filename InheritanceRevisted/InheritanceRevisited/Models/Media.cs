using System;
using System.Collections.Generic;

namespace InheritanceRevisited.Models
{
    public interface iMedia
    {
        public string Title { get; set; }
        public int RunTime { get; set; }
        public void Play();
    }

    public class Song : iMedia
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int RunTime { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
        public List<Customer> Customers { get; set; }
        public void Play()
        {
            Console.WriteLine("Playing the song " + Title + " on your favourate music platform for " + RunTime);
        }
    }

    public class Video : iMedia
    {
        public string Title { get; set; }
        public int RunTime { get; set; }

        public void Play()
        {
            Console.WriteLine("Watching " + Title + " on your inadequate viewing screen for " + RunTime);
        }
    }
}
