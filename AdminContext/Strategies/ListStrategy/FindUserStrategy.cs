/**************************************************************************
 *                                                                        *
 *  File:        FindUserStrategy.cs                                      *
 *  Copyright:   (c) 2024, Minciuna Oana-Xenia                            *
 *  E-mail:      oana-xenia.minciuna@student.tuiasi.ro                    *
 *  Description: TBD                                                      *
 *                                                                        *
 **************************************************************************/

using AplicatieNotite.AdminContext;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieNotite.AdminContext
{
    /// <summary>
    /// Clasa FindUserStrategy implementeaza interfata IAdminListStrategy si este responsabila pentru gasirea user-ului
    /// </summary>
    public class FindUserStrategy : IAdminListStrategy
    {
        private SQLiteConnection _connection; // Conexiunea catre baza de date SQLite
        private SQLiteCommand _command; // Comanda SQL pentru interogare
        private SQLiteDataReader _reader; // Cititorul care stochează rezultatele interogării
        private String _username; // Numele utilizatorului pentru căutare
        private String _password; // Parola utilizatorului pentru căutare


        /// <summary>
        /// Constructorul clasei FindUserStrategy
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public FindUserStrategy(String username, String password)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory; // Obține directorul de bază al aplicației
            string dbPath = Path.Combine(basePath, "aplicatieNotite.db"); // Concatenează directorul de bază cu numele bazei de date
            _connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"); // Inițializează conexiunea la baza de date

            _command = new SQLiteCommand(); // Inițializează comanda SQL
            _username = username; // Inițializează numele utilizatorului pentru căutare
            _password = password; // Inițializează parola utilizatorului pentru căutare

        }

        /// <summary>
        /// Metoda care executa interogarea pentru a gasi utilizatorul in baza de date
        /// </summary>
        /// <returns>O lista care contine numele si parola utilizatorului dcaa acesta s-a gasit sau null in caz contrar</returns>
        List<string> IAdminListStrategy.ExecutQuery()
        {

            List<String> rez = new List<string>();
            try
            {
                _connection.Open();
                _command.Connection = _connection;
                _command.CommandText = "SELECT username, password FROM User WHERE username=@Username and password=@Password;";
                _command.Parameters.AddWithValue("@Username", _username);
                _command.Parameters.AddWithValue("@Password", _password);
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    // Extrageți numele și parola utilizatorului din cititorul de date și adăugați-le la listă
                    string name = _reader["username"].ToString();
                    string password = _reader["password"].ToString();
                    rez.Add(name);
                    rez.Add(password);
                }
            }

            catch (Exception ex)
            {
                throw(ex);
            }
            finally
            {
                if (_reader != null)
                {
                    _reader.Close();
                    _reader.Dispose();
                }
                if (_command != null)
                {
                    _command.Dispose();
                }
                if (_connection != null && _connection.State != System.Data.ConnectionState.Closed)
                {
                    _connection.Close();
                    _connection.Dispose();
                }
            }
            if (rez.Count > 0)
            {
                return rez;
            }
            else
                return null ;
        }
    }

}
