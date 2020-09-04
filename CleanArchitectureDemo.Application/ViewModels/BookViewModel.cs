using CleanArchitecture.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Application.ViewModels
{
    public class BookViewModel
    {
        public IEnumerable<Book> Books { get; set; }
    }
}
