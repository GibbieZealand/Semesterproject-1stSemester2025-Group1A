using ProjectClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Models
{
    public class Blog : IBlog
    {
        private static int _counter;

        public int Id { get; set; }
        public string Headline { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }
        public string Picture { get; set; }

        public Blog(string headline, string description, DateTime date, string author, string picture)
        {
            Headline = headline;
            Description = description;
            Date = date;
            Author = author;
            Picture = picture;
            Id = _counter++;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
