/**************************************************************************
 *                                                                        *
 *  File:        ListUserStrategy.cs                                      *
 *  Copyright:   (c) 2024, Minciuna Oana-Xenia                            *
 *  E-mail:      oana-xenia.minciuna@student.tuiasi.ro                    *
 *  Description: TBD                                                      *
 *                                                                        *
 **************************************************************************/

using AplicatieNotite. AdminContext;
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
    /// Clasa ListUserStrategy implementează interfata IAdminListStrategy si este responsabila pentru obtinerea informatiilor despre un utilizator specific din baza de date
    /// </summary>
    public class ListUserStrategy : IAdminListStrategy
    {
        private SQLiteConnection _connection;
        private SQLiteCommand _command;
        private SQLiteDataReader _reader;
        private int _idUser;

        /// <summary>
        /// Constructorul clasei ListUserStrategy - se conecteaza la baza de date si initializeaza ID-ul utilizatorului pentru cautare
        /// </summary>
        /// <param name="id">ID-ul utilizatorului pentru cautare</param>
        public ListUserStrategy(int id)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory; // Obține directorul de bază al aplicației
            string dbPath = Path.Combine(basePath, "aplicatieNotite.db"); // Concatenează directorul de bază cu numele bazei de date
            
            _connection = new SQLiteConnection($"Data Source={dbPath};Version=3;");
            _command = new SQLiteCommand();
            _reader = null;
            _idUser = id;
        }

        /// <summary>
        /// Metoda care execută interogarea pentru a obține informațiile despre utilizatorul cu ID-ul specificat și returnează rezultatul sub formă de listă de șiruri
        /// </summary>
        /// <returns>O listă de șiruri care conțin numele și parola utilizatorului cu ID-ul specificat</returns>
        List<string> IAdminListStrategy.ExecutQuery()
        {

            List<String> rez = new List<string>();
            try
            {
                _connection.Open();
                _command.Connection = _connection;
                _command.CommandText = "SELECT username, password FROM User WHERE id=" + _idUser.ToString();
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
                throw (ex);
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
            return rez;
        }
    }

}
