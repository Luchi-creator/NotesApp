/**************************************************************************
 *                                                                        *
 *  File:        ListAllStrategy.cs                                       *
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
    /// Clasa ListAllStrategy implementeaza interfata IAdminListStrategy
    /// </summary>
    public class ListAllStrategy : IAdminListStrategy
    {
        private SQLiteConnection _connection; // Conexiunea catre baza de date SQLite
        private SQLiteCommand _command; // Comanda SQL pentru interogare
        private SQLiteDataReader _reader; // Cititorul care stocheaza rezultatele interogarii

        /// <summary>
        /// Constructorul clasei ListAllStrategy - se conecteaza la baza de date
        /// </summary>
        public ListAllStrategy()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory; //  directorul de baza al aplicatiei
            string dbPath = Path.Combine(basePath, "aplicatieNotite.db"); // Concateneaza directorul de bază cu numele bazei de date

            _connection = new SQLiteConnection($"Data Source={dbPath};Version=3;");
            _command = new SQLiteCommand();
            _reader = null;
        }

        /// <summary>
        /// Metoda care executa interogarea pentru a obtine toti utilizatorii din baza de date si returneaza rezultatul sub forma de listă de string-uri
        /// </summary>
        /// <returns>O lista de stringuri care reprezintă randurile rezultate din interogare</returns>

        List<string> IAdminListStrategy.ExecutQuery()
        {

            List<String> rez = new List<string>();
            try
            {
                _connection.Open();
                _command.Connection = _connection;
                _command.CommandText = "SELECT * FROM User";
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
            return rez;
        }
    }
}

