﻿using System.Collections.Generic;
using System.Linq;
using CPC2020_2_Lab4.Models.Entities;
using CPC2020_2_Lab4.Repositories.Interfaces;
using CPC2020_2_Lab4.ViewModels;

namespace CPC2020_2_Lab4.Repositories{

    /// <summary>
    /// Klasa definiująca metody związane z komunikacją z bazą danych dla tabeli Books
    /// </summary>
    public class BooksRepository : Repository, IBooksRepository
    {
        /// <summary>
        /// Metoda pobierania książek z bazy danych
        /// </summary>
        /// <returns></returns>
        public List<BookViewModel> GetBooks()
        {
            List<Book> books = DbContext.Books.ToList();
            return Mapper.Map<List<Book>, List<BookViewModel>>(books);
        }

        /// <summary>
        /// Metoda pobierania książek z bazy danych w uproszczonym view modelu
        /// </summary>
        /// <returns></returns>
        public List<BookSimpleViewModel> GetBooksSimpleViewModel()
        {
            List<Book> books = DbContext.Books.ToList();
            return Mapper.Map<List<Book>, List<BookSimpleViewModel>>(books);
        }


        /// <summary>
        /// Metoda pobierania książek z bazy danych
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Book GetBookById(int id)
        {
            return DbContext.Books.SingleOrDefault(b => b.Id == id);
        }

        /// <summary>
        /// Medoda dodawania książki do bazy danych
        /// </summary>
        /// <param name="title"></param>
        /// <param name="yearOfPublish"></param>
        /// <param name="price"></param>
        /// <param name="genre"></param>
        /// <param name="authorFirstName"></param>
        /// <param name="authorLastName"></param>
        /// <returns></returns>
        public bool AddBook(string title, int yearOfPublish, float price, string genre, string authorFirstName, string authorLastName)
        {
            Genre genreOfBook = DbContext.Genres.SingleOrDefault(g => g.Name == genre);
            Author authorOfBook =
                DbContext.Authors.SingleOrDefault(a => a.FirstName == authorFirstName && a.LastName == authorLastName);
            if (genreOfBook == null || authorOfBook == null)
                return false;
            Book bookToAdd = new Book()
            {
                Title = title,
                YearOfPublish = yearOfPublish,
                Price = price,
                Author = authorOfBook,
                GenreId = genreOfBook.Id
            };

            DbContext.Books.Add(bookToAdd);

            return DbContext.SaveChanges() > 0;
        }

        /// <summary>
        /// Metoda usuwania ksiązki z bazy danych
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public bool DeleteBook(int bookId)
        {
            Book book = DbContext.Books.SingleOrDefault(b => b.Id == bookId);
            DbContext.Books.Remove(book);
            return DbContext.SaveChanges() > 0;
        }

        /// <summary>
        /// Metoda Edytowania wybranej pozycji w bazie danych
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="title"></param>
        /// <param name="yearOfPublish"></param>
        /// <param name="price"></param>
        /// <param name="genre"></param>
        /// <param name="authorFirstName"></param>
        /// <param name="authorLastName"></param>
        /// <returns></returns>
        public bool EditBook(int bookId, string title, int yearOfPublish, float price, string genre, string authorFirstName, string authorLastName)
        {
            //znajdujemy obiekt do edycji
            Book book = DbContext.Books.SingleOrDefault(b => b.Id == bookId);
            if (book == null)
                return false;

            //znajdujemy gatunek i autora
            Genre genreOfBook = DbContext.Genres.SingleOrDefault(g => g.Name == genre);
            Author authorOfBook =
                DbContext.Authors.SingleOrDefault(a => a.FirstName == authorFirstName && a.LastName == authorLastName);
            if (genreOfBook == null || authorOfBook == null)
                return false;

            //zmieniamy właściwości
            book.Title = title;
            book.YearOfPublish = yearOfPublish;
            book.Price = price;
            book.Genre = genreOfBook;
            book.Author = authorOfBook;

            //zapisujemy zmiane
            return DbContext.SaveChanges() > 0;
        }
    }
}
