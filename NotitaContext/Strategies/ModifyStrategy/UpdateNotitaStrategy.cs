/**************************************************************************
 *                                                                        *
 *  File:        UpdateNotitaStrategy.cs                                  *
 *  Copyright:   (c) 2024, Padurariu Dumitru                              *
 *  E-mail:      dumitru.padurariu@student.tuiasi.ro                      *
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
    /// Clasa UpdateNotitaStrategy implementează interfata INotitaModifyStrategy și este responsabilă pentru actualizarea unei notițe în cadrul aplicației.
    /// </summary>
    public class UpdateNotitaStrategy : INotitaModifyStrategy
    {
        private SQLiteConnection _connection;
        private SQLiteCommand _command;
        private string _idnote;
        private String _name;
        private String _text;
        /// <summary>
        /// Metoda care trebuie implementată conform interfeței INotitaModifyStrategy pentru a actualiza o notiță.
        /// </summary>
        /// 
        public UpdateNotitaStrategy(string idnote, string title, string note)

        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory; // Obține directorul de bază al aplicației
            string dbPath = Path.Combine(basePath, "aplicatieNotite.db"); // Concatenează directorul de bază cu numele bazei de date

            _connection = new SQLiteConnection($"Data Source={dbPath};Version=3;");
            _command = new SQLiteCommand();
            if (idnote == ""  || idnote == null)
                throw new Exception("invalid id.");
            if (title == "")
                throw new Exception("invalid titlu.");
            _name = title;
            _text = note;
            _idnote = idnote;

        }
        void INotitaModifyStrategy.ExecutUpdate()
        {
            try
            {
                _connection.Open();
                _command.Connection = _connection;
                string data = DateTime.Now.ToString("dd/MM/yyyy");
                _command.CommandText = "UPDATE Notita SET Date=@data, Name=@name,Text=@text WHERE id = @Id";
                _command.Parameters.AddWithValue("@data", data);
                _command.Parameters.AddWithValue("@name", _name);
                _command.Parameters.AddWithValue("@text", _text);
                _command.Parameters.AddWithValue("@Id", _idnote);
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
