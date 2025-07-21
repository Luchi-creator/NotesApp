/**************************************************************************
 *                                                                        *
 *  File:        ListNotitaStrategy.cs                                    *
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
    /// Clasa ListNotitaStrategy implementează interfața INotitaListStrategy și este responsabilă pentru listarea notițelor în cadrul aplicației.
    /// </summary>
    public class ListNotitaStrategy : INotitaListStrategy
    {
        private SQLiteConnection _connection;
        private SQLiteCommand _command;
        private SQLiteDataReader _reader;
        private int _id;

        /// <summary>
        /// Metoda care implementează executarea interogarii și listarea notițelor
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
                _command.CommandText = "SELECT Name, Text FROM Notita WHERE ID = @id";
                _command.Parameters.AddWithValue("@id", _id);
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    string name = _reader["Name"].ToString();
                    string text = _reader["Text"].ToString();
                    rez.Add(name);
                    rez.Add(text);
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                _reader?.Close();
                _command?.Dispose();
                if (_connection != null && _connection.State != System.Data.ConnectionState.Closed)
                {
                    _connection.Close();
                    _connection.Dispose();
                }
            }
            return rez;
        }

        /// <summary>
        /// Constructorul clasei ListNotitaStrategy
        /// </summary>
        /// <param name="id">ID-ul utilizatorului pentru care se listează notițele</param>
        public ListNotitaStrategy(int id)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string dbPath = Path.Combine(basePath, "aplicatieNotite.db");

            _connection = new SQLiteConnection($"Data Source={dbPath};Version=3;");
            _command = new SQLiteCommand();
            _reader = null;
            _id = id;
        }

    }
}
