/**************************************************************************
 *                                                                        *
 *  File:        UserNotFoundException.cs                                 *
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
    /// Clasa UserNotFoundException este o clasa de exceptii personalizata care verifica daca user-ul nu este gasit
    /// </summary>
    public class UserNotFoundException : Exception
    {
        /// <summary>
        /// Constructorul clasei UserNotFoundException
        /// </summary>
        /// <param name="message"></param>
        public UserNotFoundException(string message) : base(message) { }
    }
}
