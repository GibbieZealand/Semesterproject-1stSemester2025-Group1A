using ProjectClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-- Lavet af Frederik --//

namespace ProjectClassLibrary.Models
{
    /// <summary>
    /// Generic Class for Constructing Blog Objects using the interface
    /// </summary>
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
        //TODO: Change Author from string to Member
        public IMember Author { get; set; }
        public string Picture { get; set; }
        #endregion

        #region Constructors
        public Blog(string headline, string description, DateTime date, IMember member, string picture)
        {
            Headline = headline;
            Description = description;
            Date = date;
            Author = member;
            Picture = picture;
            Id = _counter++;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns a writeline featuring the contents of the object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Id: {Id} " +
                $"\nOverskrift: {Headline} " +
                $"\nBeskrivelse: {Description} " +
                $"\nDato: {Date} " +
                $"\nForfatter: {Author.FirstName + " " + Author.SurName} " +
                $"\nBillede: {Picture}";
        }
        #endregion
    }
}
