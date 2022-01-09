using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeni
{
    class Book
    {
        private static int counter = 0;
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        private string _Code { get; set; }
        public string Code { get; set; }



        public Book(string name, string authorName, int pageCount)
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            counter++;
            Code = Name.ToUpper().Substring(0, 2) + counter; 

        }
        public override string ToString()
        {
            return $"{Code} {Name} {AuthorName} {PageCount}";
        }
    }
}
