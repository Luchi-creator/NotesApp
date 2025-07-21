/**************************************************************************
 *                                                                        *
 *  File:        DeleteUserStrategy.cs                                    *
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
using System.Text;
using System.Threading.Tasks;

namespace AplicatieNotite.AdminContext
{
    /// <summary>
    /// Clasa DeleteUserStrategy implementează interfata IAdminModifyStrategy și este responsabilă pentru ștergerea unui utilizator din baza de date
    /// </summary>
    public class DeleteUserStrategy: IAdminModifyStrategy
    {
        private SQLiteConnection _connection;
        private SQLiteCommand _command;
        private int _idUser;

        /// <summary>
        /// Constructorul clasei DeleteUserStrategy - se conectează la baza de date și inițializează ID-ul utilizatorului pentru ștergere
        /// </summary>
        /// <param name="idUser">ID-ul utilizatorului de șters</param>
        public DeleteUserStrategy(int idUser)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory; // Obține directorul de bază al aplicației
            string dbPath = Path.Combine(basePath, "aplicatieNotite.db"); // Concatenează directorul de bază cu numele bazei de date

            _connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"); 
            _command = new SQLiteCommand();
            _idUser = idUser;
        }

        /// <summary>
        /// Metoda care execută ștergerea utilizatorului din baza de date
        /// </summary>
        void IAdminModifyStrategy.ExecutUpdate()
        {
            try
            {
                _connection.Open();
                _command.Connection = _connection;

                _command.CommandText = "PRAGMA foreign_keys = ON";
                _command.ExecuteNonQuery();

                _command.CommandText = "DELETE FROM User WHERE id=@Id";
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
