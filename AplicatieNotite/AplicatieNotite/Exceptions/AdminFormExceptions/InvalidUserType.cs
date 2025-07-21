/**************************************************************************
 *                                                                        *
 *  File:        InvalidUserType.cs                                       *
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
    ///  este o clasa de exceptii personalizata care verifica daca tipul user-ului este invalid
    /// </summary>
    public class InvalidUserType:Exception
    {
        public String _info; // informație suplimentară

        /// <summary>
        /// Constructorul clasei InvalidUserType
        /// </summary>
        /// <param name="info"></param>
        public InvalidUserType(String info) : base()
        {
            _info = info;
        }
    }
}
