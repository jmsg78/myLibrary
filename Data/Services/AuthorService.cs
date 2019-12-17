using System.Collections.Generic;
using System.Linq;

namespace MyLibrary.Data
{
    public class AuthorService : LibraryContext, IAuthorService
    {
        LibraryContext ctx = new LibraryContext();
        public void AddAuthor(Author newAuthor)
        {
            ctx.Authors.Add(newAuthor);
            ctx.SaveChanges();
        }

        public void DeleteAuthor(int id)
        {
            var author = ctx.Authors.FirstOrDefault(n => n.Id == id);
            ctx.Authors.Remove(author);
            ctx.SaveChanges();
        }

        public List<Author> GetAllAuthors()
        {
            return ctx.Authors.ToList();
        }

        public Author GetAuthorById(int id)
        {
            return ctx.Authors.FirstOrDefault(n => n.Id == id);
        }

        public void UpdateAuthor(int id, Author newAuthor)
        {
            var oldAuthor = ctx.Authors.FirstOrDefault(n => n.Id == id);
            if(oldAuthor != null)
            {
                oldAuthor.FirstName = newAuthor.FirstName;
                oldAuthor.LastName = newAuthor.LastName;
                oldAuthor.BirthDate = newAuthor.BirthDate;
            }
            ctx.SaveChanges();
        }
  }
}