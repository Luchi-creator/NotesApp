/**************************************************************************
 *                                                                        *
 *  File:        DeleteNotitaStrategy.cs                                  *
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
    /// Clasa DeleteNotitaStrategy implementează interfața INotitaModifyStrategy și este responsabilă pentru ștergerea unei notițe din cadrul aplicației.
    /// </summary>
    public class DeleteNotitaStrategy : INotitaModifyStrategy
    {
        private SQLiteConnection _connection;
        private SQLiteCommand _command;
        
        private String _name;
        
        public DeleteNotitaStrategy(string note)

        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory; // Obține directorul de bază al aplicației
            string dbPath = Path.Combine(basePath, "aplicatieNotite.db"); // Concatenează directorul de bază cu numele bazei de date

            _connection = new SQLiteConnection($"Data Source={dbPath};Version=3;");
            _command = new SQLiteCommand();
            if(note == ""|| note == null)
                    throw new Exception("invalid id.");
            _name = note;
            

        }
        /// <summary>
        /// Metoda implementeaza ștergerea unei notițe
        /// </summary>
        void INotitaModifyStrategy.ExecutUpdate()
        {
            try
            {   
                _connection.Open();
                _command.Connection = _connection;
                _command.CommandText = "DELETE FROM Notita WHERE id = @id" ;
                _command.Parameters.AddWithValue("@id", _name);
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
