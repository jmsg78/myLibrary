using System.Collections.Generic;
using System.Linq;

namespace MyLibrary.Data
{
    public class AuthorService : IAuthorService
    {
        public void AddAuthor(Author newAuthor)
        {
            Data.Authors.Add(newAuthor);
        }

        public void DeleteAuthor(int id)
        {
            var author = Data.Authors.FirstOrDefault(n => n.Id == id);
            Data.Authors.Remove(author);
        }

        public List<Author> GetAllAuthors()
        {
            return Data.Authors.ToList();
        }

        public Author GetAuthorById(int id)
        {
            return Data.Authors.FirstOrDefault(n => n.Id == id);
        }

        public void UpdateAuthor(int id, Author newAuthor)
        {
            var oldAuthor = Data.Authors.FirstOrDefault(n => n.Id == id);
            if(oldAuthor != null)
            {
                oldAuthor.FirstName = newAuthor.FirstName;
                oldAuthor.LastName = newAuthor.LastName;
                oldAuthor.BirthDate = newAuthor.BirthDate;
            }
        }
  }
}