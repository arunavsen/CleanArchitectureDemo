using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Model;
using CleanArchitecture.Infra.Data.Context;

namespace CleanArchitecture.Infra.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        public LibraryDbContext _context;

        public BookRepository(LibraryDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Book> GetBooks()
        {
            return _context.Books;
        }
    }
}
