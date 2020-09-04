using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitectureDemo.Application.Interfaces;
using CleanArchitectureDemo.Application.ViewModels;

namespace CleanArchitectureDemo.Application.Services
{
    public class BookService : IBookService
    {
        public IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public BookViewModel GetBooks()
        {
            return new BookViewModel()
            {
                Books = _bookRepository.GetBooks()
            };
        }
    }
}
