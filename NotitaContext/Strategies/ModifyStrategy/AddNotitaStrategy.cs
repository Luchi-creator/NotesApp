/**************************************************************************
 *                                                                        *
 *  File:        AddNotitaStrategy.cs                                     *
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
    /// Clasa AddNotitaStrategy implementează interfața INotitaModifyStrategy și este responsabilă pentru adăugarea unei notițe în cadrul aplicației.
    /// </summary>
    public class AddNotitaStrategy : INotitaModifyStrategy
    {
        private SQLiteConnection _connection;
        private SQLiteCommand _command;
        private int _iduser;
        private String _name;
        private String _text;

        /// <summary>
        /// Constructorul clasei AddNotitaStrategy.
        /// </summary>
        /// <param name="user">ID-ul utilizatorului asociat notiței.</param>
        /// <param name="title">Titlul notiței.</param>
        /// <param name="note">Conținutul notiței.</param>
        public AddNotitaStrategy(int user, string title, string note)

        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory; // Obține directorul de bază al aplicației
            string dbPath = Path.Combine(basePath, "aplicatieNotite.db"); // Concatenează directorul de bază cu numele bazei de date

            _connection = new SQLiteConnection($"Data Source={dbPath};Version=3;");
            _command = new SQLiteCommand();
            if (title == "")
                throw new Exception("invalid titlu.");
            _name = title;
            _text = note;
            _iduser = user;

        }

        /// <summary>
        /// Metoda care implementează adăugarea unei notițe
        /// </summary>
        void INotitaModifyStrategy.ExecutUpdate()
        {


            try
            {
                
                _connection.Open();
                _command.Connection = _connection;
                string data = DateTime.Now.ToString("dd/MM/yyyy");
                _command.CommandText = "INSERT INTO Notita(ID_User, Date, Name, Text) VALUES(@ID_User, @data, @Name, @Text)";
                _command.Parameters.AddWithValue("@ID_User", _iduser);
                _command.Parameters.AddWithValue("@Name", _name);
                _command.Parameters.AddWithValue("@Text", _text);
                _command.Parameters.AddWithValue("@data", data);
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
