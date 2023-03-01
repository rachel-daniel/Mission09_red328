﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_red328.Models
{
    public class EfBookstoreRepository : IBookstoreRepository
    {
        private BookstoreContext context { get; set; }

        public EfBookstoreRepository (BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Book> Books => context.Books;
    }
}
