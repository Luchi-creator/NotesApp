/**************************************************************************
 *                                                                        *
 *  File:        LoginStrategy.cs                                         *
 *  Copyright:   (c) 2024, Luchian Ionut-Grigore                          *
 *  E-mail:      ionut-grigore.luchian@student.tuiasi.ro                  *
 *  Description: TBD                                                      *
 *                                                                        *
 **************************************************************************/


using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieNotite.UserContext
{
    // Implementare pentru autentificarea cu nume de utilizator si parola

    /// <summary>
    /// Clasa UsernamePasswordLoginStrategy implementeaza interfata ILoginStrategy si este responsabila pentru autentificarea cu nume de utilizator și parolă.
    /// </summary>
    public class UsernamePasswordLoginStrategy : ILoginStrategy
    {
        private string _connectionString;

        /// <summary>
        /// Constructorul clasei UsernamePasswordLoginStrategy
        /// </summary>
        /// <param name="connectionString">Stringul de conexiune către baza de date.</param>
        public UsernamePasswordLoginStrategy(string connectionString)
        {
            _connectionString = connectionString;
        }

        /// <summary>
        /// Metoda de autentificare care verifică numele de utilizator și parola în baza de date și returnează ID-ul utilizatorului autentificat.
        /// </summary>
        /// <param name="username">Numele de utilizator introdus.</param>
        /// <param name="password">Parola introdusă.</param>
        /// <returns>Returnează ID-ul utilizatorului autentificat sau 0 în caz de eroare sau autentificare eșuată.</returns>
        public int Authenticate(string username, string password)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    int cnt;
                    string query = "SELECT id FROM User WHERE Username = @username AND Password = @password";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password); string count;
                        if (command.ExecuteScalar() == null)
                        {
                            count = "0";
                        }
                        else
                            count = command.ExecuteScalar().ToString();

                        cnt = int.Parse(count);
                        return cnt;
                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
