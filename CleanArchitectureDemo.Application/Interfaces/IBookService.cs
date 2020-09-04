using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitectureDemo.Application.ViewModels;

namespace CleanArchitectureDemo.Application.Interfaces
{
    public interface IBookService
    {
        BookViewModel GetBooks();
    }
}
