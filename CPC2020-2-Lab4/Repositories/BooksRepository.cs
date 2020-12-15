using System;
using System.Collections.Generic;
using CPC2020_2_Lab4.Models.Entities;
using CPC2020_2_Lab4.Repositories.Interfaces;

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
        public List<Book> GetBooks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metoda pobierania książek z bazy danych
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Book GetBookById(int id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metoda usuwania ksiązki z bazy danych
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public bool DeleteBook(int bookId)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
