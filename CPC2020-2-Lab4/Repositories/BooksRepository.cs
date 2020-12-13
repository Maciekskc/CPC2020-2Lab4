using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using CPC2020_2_Lab3.Repositories;
using CPC2020_2_Lab3.Repositories.Interfaces;

namespace CPC2020_2_Lab3.Repositories{

    /// <summary>
    /// Klasa definiująca metody związane z komunikacją z bazą danych dla tabeli Books
    /// </summary>
    public class BooksRepository : Repository, IBooksRepository
    {
        public bool AddBook(string title, int yearOfPublish, float price, string genre, string authorFirstName, string authorLastName)
        {
            throw new NotImplementedException();
        }

        public bool DeleteBook(int bookId)
        {
            throw new NotImplementedException();
        }

        public bool EditBook(int bookId, string title, int yearOfPublish, float price, string genre, string authorFirstName, string authorLastName)
        {
            throw new NotImplementedException();
        }
    }
}
