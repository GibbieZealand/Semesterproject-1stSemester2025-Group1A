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
        #region Fields
        private static int _counter;
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Headline { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }
        public string Picture { get; set; }
        #endregion

        #region Constructors
        public Blog(string headline, string description, DateTime date, string author, string picture)
        {
            Headline = headline;
            Description = description;
            Date = date;
            Author = author;
            Picture = picture;
            Id = _counter++;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id: {Id}, \nHeadline: {Headline}, \nDescription: {Description}, \nDate: {Date}, \nAuthor: {Author}, \nPicture: {Picture}";
        }
        #endregion
    }
}
