using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_esiapes.Models
{
    public interface IBookstoreRepository //forcing that when you use this interface you must implement these methods....basically setting up template 
    {
        IQueryable<Book> Books { get; }// can only read not write
    }
}
