using System;
using CPC2020_2_Lab4.Repositories.Interfaces;

namespace CPC2020_2_Lab4.Repositories
{
    /// <summary>
    /// Klasa definiująca metody związane z komunikacją z bazą danych dla tabeli Users
    /// </summary>
    public class UsersRepository: Repository, IUsersRepository
    {
        /// <summary>
        /// Metoda sprawdzająca czy można się zalogować do aplikacji na podstawie login i password
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string login, string password)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metoda dodająca dodająca opcje 
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Register(string login, string password)
        {
            throw new NotImplementedException();
        }
    }
}
