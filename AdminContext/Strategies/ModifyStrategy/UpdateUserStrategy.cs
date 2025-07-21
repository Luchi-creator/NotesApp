/**************************************************************************
 *                                                                        *
 *  File:        UpdateUserStrategy.cs                                    *
 *  Copyright:   (c) 2024, Minciuna Oana-Xenia                            *
 *  E-mail:      oana-xenia.minciuna@student.tuiasi.ro                    *
 *  Description: TBD                                                      *
 *                                                                        *
 **************************************************************************/


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
    /// Clasa UpdateUserStrategy implementează interfata IAdminModifyStrategy și este responsabilă pentru actualizarea informațiilor despre un utilizator din baza de date
    /// </summary>
    public class UpdateUserStrategy : IAdminModifyStrategy
    {
        private SQLiteConnection _connection;
        private SQLiteCommand _command;
        private int _idUser;
        private String _username;
        private String _password;

        /// <summary>
        /// Constructorul clasei UpdateUserStrategy - se conectează la baza de date și inițializează informațiile necesare pentru actualizare
        /// </summary>
        /// <param name="idUser">ID-ul utilizatorului de actualizat</param>
        /// <param name="username">Noul nume al utilizatorului</param>
        /// <param name="password">Noua parolă a utilizatorului</param>
        public UpdateUserStrategy(int idUser,String username,String password)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory; // Obține directorul de bază al aplicației
            string dbPath = Path.Combine(basePath, "aplicatieNotite.db"); // Concatenează directorul de bază cu numele bazei de date

            _connection = new SQLiteConnection($"Data Source={dbPath};Version=3;");
            _command = new SQLiteCommand();

            _username = username;
            _password = password;
            _idUser = idUser;   
        }

        /// <summary>
        /// Metoda care execută actualizarea informațiilor despre utilizatorul din baza de date.
        /// </summary>
        void IAdminModifyStrategy.ExecutUpdate()
        {
            try
            {
                _connection.Open();
                _command.Connection = _connection;
                _command.CommandText = "UPDATE User SET username=@Username, password=@Password WHERE id=@Id";
                _command.Parameters.AddWithValue("@Username", _username);
                _command.Parameters.AddWithValue("@Password", _password);
                _command.Parameters.AddWithValue("@Id", _idUser);
                _command.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                throw (ex);
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
