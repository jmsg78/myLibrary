using System;
using System.Collections.Generic;

namespace MyLibrary.Data
{
    public static class Data
    {
    public static List<Book> Books => allBooks;
    public static List<Category> Categories => allCategories;
    public static List<Author> Authors => allAuthors;
    static List<Book> allBooks = new List<Book>()
    { 
        new Book()
        {
            Id=1,
            Title="Managing Oneself",
            Description="We live in an age of unprecedented opportunity: with ambition, drive, and talent, you can rise to the top of your chosen profession, regardless of where you started out...",
            Author= 1,
            Category= 1,
            Isbn = "978-3-16-148410-0"
        },
        new Book()
        {
            Id=2,
            Title="Evolutionary Psychology",
            Description="Evolutionary Psychology: The New Science of the Mind, 5th edition provides students with the conceptual tools of evolutionary psychology, and applies them to empirical research on the human mind...",
            Author= 1,
            Category= 2,
            Isbn = "978-3-16-148410-2"
        },
        new Book()
        {
            Id=3,
            Title="How to Win Friends & Influence People",
            Description="Millions of people around the world have improved their lives based on the teachings of Dale Carnegie. In How to Win Friends and Influence People, he offers practical advice and techniques for how to get out of a mental rut and make life more rewarding...",
            Author= 1,
            Category= 2,
            Isbn = "978-3-16-148410-X"
        },
        new Book()
        {
            Id = 4,
            Title = "The Selfish Gene",
            Description = "Professor Dawkins articulates a gene’s eye view of evolution. A view giving center stage to these persistent units of information, and in which organisms can be seen as vehicles for their replication. This imaginative, powerful, and stylistically brilliant work not only brought the insights of Neo-Darwinism to a wide audience. But galvanized the biology community, generating much debate and stimulating whole new areas of research...",
            Author= 1,
            Category= 2,
            Isbn = "978-3-16-148419-9"
        },
        new Book()
        {
            Id = 5,
            Title = "The Lessons of History",
            Description = "Will and Ariel Durant have succeeded in distilling for the reader the accumulated store of knowledge and experience from their five decades of work on the eleven monumental volumes of The Story of Civilization...",
            Author= 2,
            Category= 2,
            Isbn = "978-3-16-148487-X"
        },
        new Book()
        {
            Id = 6,
            Title = "Kon Tiki",
            Description = "“Kon-Tiki” is the record of an astonishing adventure across the Pacific Ocean. Intrigued by Polynesian folklore, biologist Thor Heyerdahl suspected that the South Sea Islands had been settled by an ancient race from thousands of miles to the east...",
            Author= 1,
            Category= 2,
            Isbn = "978-3-16-148415-5"
        },
        new Book()
        {
            Id = 7,
            Title = "Civilization & It’s Discontents",
            Description = "Sigmund Freud enumerates the fundamental tensions between civilization and the individual. The primary friction stems from the individual’s quest for instinctual freedom and civilization’s contrary demand for conformity and instinctual repression...",
            Author= 2,
            Category= 1,
            Isbn = "978-3-16-132410-2"
        },
        new Book()
        {
            Id = 8,
            Title = "The Story of The Human Body",
            Description = "This ground-breaking book of popular science explores how the way we use our bodies is all wrong...",
            Author= 1,
            Category= 2,
            Isbn = "978-4-16-148410-2"
        },
        new Book()
        {
            Id = 9,
            Title = "The Story of The Human Body",
            Description = "You want fewer distractions and less on your plate. The daily barrage of e-mails, texts, tweets, messages, and meetings distract you and stress you out. The simultaneous demands of work and family are taking a toll. And what’s the cost? Second-rate work, missed deadlines, smaller paycheques, fewer promotions and lots of stress...",
            Author= 2,
            Category= 2,
            Isbn = "979-3-16-148410-2"
        },
        new Book()
        {
            Id = 10,
            Title = "Riveted",
            Description = "Professor Jim Davies’ fascinating and highly accessible book, Riveted, reveals the evolutionary underpinnings of why we find things compelling, from art to religion and from sports to superstition...",
            Author= 1,
            Category= 2,
            Isbn = "975-3-16-148410-2"
        }
    };
    static List<Category> allCategories = new List<Category>()
    {
        new Category()
        {
            Id = 1,
            Name = "Fiction",
            Description = "Description of Fiction: Action and adventure, Alternate history, Anthology, Comic book, etc"
        },
        new Category()
        {
            Id = 2,
            Name = "Non-Fiction",
            Description = "Description of Non-Fiction: Art, Autobiography, Biography, CookBook, etc"
        }
    };
    static List<Author> allAuthors = new List<Author>()
    {
        new Author()
        {
            Id = 1,
            FirstName = "Jose",
            LastName = "Salazar",
            BirthDate = new DateTime(2019,10,20)
        },
        new Author()
        {
            Id = 2,
            FirstName = "Manuel",
            LastName = "Verdi",
            BirthDate = new DateTime(2019,10,25)
        }
    };

}
}