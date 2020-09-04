using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ISBN { get; set; }
        public string AuthorName { get; set; }
    }
}
