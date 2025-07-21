/**************************************************************************
 *                                                                        *
 *  File:        ListAllStrategy.cs                                       *
 *  Copyright:   (c) 2024, Manea Paula                                    *
 *  E-mail:      paula.manea@student.tuiasi.ro                            *
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

namespace AplicatieNotite.NotitaContext
{
    /// <summary>
    /// Clasa ListAllStrategy implementează interfața INotitaListStrategy și este responsabilă pentru listarea tuturor notițelor din cadrul aplicației.
    /// </summary>
    public class ListAllStrategy : INotitaListStrategy
    {
        private SQLiteConnection _connection;
        private SQLiteCommand _command;
        private SQLiteDataReader _reader;

        /// <summary>
        /// Constructorul clasei ListAllStrategy
        /// </summary>
        public ListAllStrategy()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string dbPath = Path.Combine(basePath, "aplicatieNotite.db");

            _connection = new SQLiteConnection($"Data Source={dbPath};Version=3;");
            _command = new SQLiteCommand();
            _reader = null;
        }

        /// <summary>
        /// Metoda care listeaza toate notitele
        /// </summary>
        /// <param name="_user">ID_ul user-ului care detine notitele</param>
        /// <returns></returns>
        public List<string> ExecuteQuery(int _user)
        {
            List<String> rez = new List<string>();
            try
            {
                _connection.Open();
                _command.Connection = _connection;
                _command.CommandText = "SELECT ID,Date,Name FROM Notita where ID_User=@user";
                _command.Parameters.AddWithValue("@user", _user);
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    string row = "";
                    for (int i = 0; i < _reader.FieldCount; i++)
                    {
                        row += _reader[i].ToString() + " ";
                    }
                    rez.Add(row.Trim());
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
