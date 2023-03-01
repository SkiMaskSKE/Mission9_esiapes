using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_esiapes.Models
{
    public class EFBooksoreRepository : IBookstoreRepository //Inheritance
    {
        private BookstoreContext context { get; set; }

        public EFBooksoreRepository (BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Book> Books => context.Books;
    }
}
