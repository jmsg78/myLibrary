using System;
using System.Collections.Generic;
using System.Linq;

namespace MyLibrary.Data
{
    public class BookService : LibraryContext, IBookService
    {
        LibraryContext ctx = new LibraryContext();
        public void AddBook(Book newBook)
        {
            ctx.Books.Add(newBook);
            ctx.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            var book = ctx.Books.FirstOrDefault(n => n.Id == id);
            ctx.Books.Remove(book);
            ctx.SaveChanges();
        }

        public List<Book> GetAllBooks()
        {
            return ctx.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            return ctx.Books.FirstOrDefault(n => n.Id == id);
        }

        public void UpdateBook(int id, Book newBook)
        {
            var oldBook = ctx.Books.FirstOrDefault(n => n.Id == id);
            if(oldBook != null)
            {
                oldBook.Title = newBook.Title;
                oldBook.Author = newBook.Author;
                oldBook.Description = newBook.Description;
                oldBook.Category = newBook.Category;
                oldBook.Isbn = newBook.Isbn;
            }
            ctx.SaveChanges();
        }
    }
}