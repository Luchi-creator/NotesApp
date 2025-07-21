/**************************************************************************
 *                                                                        *
 *  File:        AddUserStrategy.cs                                       *
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
using System.Text;
using System.Threading.Tasks;

namespace AplicatieNotite.AdminContext
{
    /// <summary>
    /// Clasa AddUserStrategy implementează interfata IAdminModifyStrategy si este responsabila pentru adaugarea de noi useri in baza de date
    /// </summary>
    public class AddUserStrategy : IAdminModifyStrategy
    {
        private SQLiteConnection _connection;
        private SQLiteCommand _command;
        private String _username;
        private String _password;

        /// <summary>
        /// Constructorul clasei AddUserStrategy
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public AddUserStrategy(String username, String password)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory; // Obține directorul de bază al aplicației
            string dbPath = Path.Combine(basePath, "aplicatieNotite.db"); // Concatenează directorul de bază cu numele bazei de date

            _connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"); 
            _command = new SQLiteCommand();
            _username = username;
            _password = password;
        }


        /// <summary>
        /// Metoda care execută inserarea utilizatorului în baza de date
        /// </summary>
        void IAdminModifyStrategy.ExecutUpdate()
        {
            try
            {
                _connection.Open();
                _command.Connection = _connection;
                _command.CommandText = "INSERT INTO User (username,password) VALUES (@Username, @Password)";
                _command.Parameters.AddWithValue("@Username", _username);
                _command.Parameters.AddWithValue("@Password", _password);
                _command.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                throw(ex);
            }
            finally
            {
                if (_command != null)
                {
                    _command.Dispose();
                }
                // Închideți resursele corect
                if (_connection.State != System.Data.ConnectionState.Closed)
                {
                    _connection.Close();
                }
            }
        }
    }
}
        
    

