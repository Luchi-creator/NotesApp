/**************************************************************************
 *                                                                        *
 *  File:        SqlQueryException.cs                                     *
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
    /// CLasa SqlQueryException este o clasa de exceptii personalizata care verifica query-ul SQL utilizat
    /// </summary>
    public class SqlQueryException : Exception
    {
        /// <summary>
        /// Constructorul clasei SqlQueryException
        /// </summary>
        /// <param name="message"></param>
        public SqlQueryException(string message) : base(message) { }
    }
}
