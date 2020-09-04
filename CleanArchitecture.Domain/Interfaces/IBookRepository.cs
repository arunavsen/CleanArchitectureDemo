using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Model;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
    }
}
