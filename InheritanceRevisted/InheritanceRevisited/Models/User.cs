using System;
using System.Collections.Generic;
using System.Linq;

namespace InheritanceRevisited.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<iMedia> Collection { get; set; }
        public string Email { get; set; }
        public virtual void GenerateEmail()
        {
            this.Email = this.Id.ToString() + Name + "@gmail.com";
        }
        public void Binge()
        {
            Collection.ForEach(media => media.Play());
        }
    }

    public class Artist : User
    {
        public List<Song> Songs { get; set; }
        public override void GenerateEmail()
        {
            this.Email = "A" + this.Id.ToString() + Name + "@gmail.com";
        }
    }

    public class Customer : User
    {
        public List<Song> PurchasedSongs { get; set; }
    }
}