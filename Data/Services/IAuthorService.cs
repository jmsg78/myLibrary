using System.Collections.Generic;
using MyLibrary.Data;

namespace MyLibrary.Data
{
    public interface IAuthorService
    {
        List<Author> GetAllAuthors();
        Author GetAuthorById(int id);
        void UpdateAuthor(int id, Author newAuthor);
        void DeleteAuthor(int id);
        void AddAuthor(Author newAuthor);
    }
}