using System;
using System.Collections.Generic;

namespace MyLibrary.Data
{
    public class LibraryModel
    {
          public class Book
            {
                public string Id { get; set; }
                public string Title { get; set; }
                public string Description { get; set; }
                public string Isbn { get; set; }
                public string AuthorId { get; set; }
                public string CategoryId { get; set; }
                public Author Author { get; set; }
                public ICollection<Category> Categories { get; set; }
            }

            public class Author
            {
                public int Id { get; set; }
                public string FirstName { get; set; }
                public string LastName { get; set; }
                public DateTime BirthDate { get; set; }
                public ICollection<Book> Books { get; set; }
            }

             public class Category
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public string Description { get; set; }
                public ICollection<Book> Books { get; set; }
            }
    }
}