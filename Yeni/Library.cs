using System;
using System.Collections.Generic;


namespace Yeni
{
    class Library
    {

        
        public List<Book> BookList => _booklist;

        private List<Book> _booklist { get; set; }


        public Library()
        {
            _booklist = new List<Book> { };
        }

        public List<Book> FindAllBooksByName(string value) =>
            BookList.FindAll(q => q.Name.ToLower().Contains(value.ToLower()));

        public List<Book> FindAllBooksByCode(string code) =>
            BookList.FindAll(q => q.Code.Contains(code.ToUpper()));



        public void RemoveAllBookByName(string value)
        {
            foreach (var book in FindAllBooksByName(value))
            {
                BookList.Remove(book);
            }
        }

        public List<Book> SearchBooks(string value) =>
            BookList.FindAll(q => q.Name.ToLower().Contains(value.ToLower()) || q.AuthorName.ToLower().Contains(value.ToLower()));
        
        
        public List<Book> FindAllBooksByPageCountRange(int minCount, int maxCount )
        {
            return BookList.FindAll(q => q.PageCount > minCount && q.PageCount < maxCount);
        }



        public void RemoveByNo(string code)
        {
            foreach (var book in FindAllBooksByCode(code))
            {
                BookList.Remove(book);
            }
        }

        
    }
}

