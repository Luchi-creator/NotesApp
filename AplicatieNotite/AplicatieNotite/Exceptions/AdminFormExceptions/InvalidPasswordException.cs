/**************************************************************************
 *                                                                        *
 *  File:        InvalidPasswordException.cs                              *
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
    /// Clasa InvalidPasswordException este o clasa de exceptii personalizata care verifica daca parola este invalida
    /// </summary>
    public class InvalidPasswordException:Exception
    {
        public String _info; // informație suplimentară

        /// <summary>
        /// Constructorul clasei InvalidPasswordException
        /// </summary>
        /// <param name="info"></param>
        public InvalidPasswordException(String info):base()
        {
            _info = info;
        }
    }
}
