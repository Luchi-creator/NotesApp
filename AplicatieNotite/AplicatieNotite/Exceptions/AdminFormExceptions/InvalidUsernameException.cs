/**************************************************************************
 *                                                                        *
 *  File:        InvalidUsernameException.cs                              *
 *  Copyright:   (c) 2024, Minciuna Oana-Xenia                            *
 *  E-mail:      oana-xenia.minciuna@student.tuiasi.ro                    *
 *  Description: TBD                                                      *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieNotite.Exceptions.AdminFormExceptions
{
    /// <summary>
    /// Clasa InvalidUsernameException este o clasa de exceptii personalizata care verifica daca username-ul este invalid
    /// </summary>
    public class InvalidUsernameException:Exception
    {
        public String _info; // informație suplimentară

        /// <summary>
        /// Constructorul clasei InvalidUsernameException
        /// </summary>
        /// <param name="info"></param>
        public InvalidUsernameException(String info):base() {
            _info = info;
        }   
    }
}
