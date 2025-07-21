/**************************************************************************
 *                                                                        *
 *  File:        DatabaseConnectionException.cs                           *
 *  Copyright:   (c) 2024, Luchian Ionut-Grigore                          *
 *  E-mail:      ionut-grigore.luchian@student.tuiasi.ro                  *
 *  Description: TBD                                                      *
 *                                                                        *
 **************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieNotite.Exceptions.LoginFormExceptions
{
    /// <summary>
    /// Clasa DatabaseConnectionException este o clasa de exceptii personalizata care verifica existenta conexiunii la baza de date
    /// </summary>
    public class DatabaseConnectionException : Exception
    {
        /// <summary>
        /// Constructorul clasei DatabaseConnectionException
        /// </summary>
        /// <param name="message"></param>
        public DatabaseConnectionException(string message) : base(message) { }
    }
}
