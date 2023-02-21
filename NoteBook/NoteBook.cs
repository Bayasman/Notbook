using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook
{
    internal class NoteBook
    {
        DateTime dateTime;
        string Nameof;
        string Description;
       
        public NoteBook(string nameof, string descrition, DateTime date)
        {
            Nameof = nameof;
            Description = descrition;
            dateTime = date;
        }
    }
}
