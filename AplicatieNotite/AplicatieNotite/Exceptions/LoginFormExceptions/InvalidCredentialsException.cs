/**************************************************************************
 *                                                                        *
 *  File:        InvalidCredentialsException.cs                           *
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
    /// Clasa InvalidCredentialsException este o clasa de exceptii personalizata care verifica daca sunt credentialele invalide
    /// </summary>
    public class InvalidCredentialsException : Exception
    {
        /// <summary>
        /// Constructorul clasei InvalidCredentialsException
        /// </summary>
        /// <param name="message"></param>
        public InvalidCredentialsException(string message) : base(message) { }
    }   
}
