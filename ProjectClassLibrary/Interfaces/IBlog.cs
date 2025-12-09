using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassLibrary.Interfaces
{
    public interface IBlog
    {
        int Id { get; set; }
        string Headline { get; set; }
        string Description { get; set; }
        DateTime Date { get; set; }
        IMember Author { get; set; }
        string Picture { get; set; }
    }
}
