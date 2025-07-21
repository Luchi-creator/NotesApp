/**************************************************************************
 *                                                                        *
 *  File:        IAdminListStrategy.cs                                    *
 *  Copyright:   (c) 2024, Minciuna Oana-Xenia                            *
 *  E-mail:      oana-xenia.minciuna@student.tuiasi.ro                    *
 *  Description: TBD                                                      *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieNotite.AdminContext
{
    /// <summary>
    /// Interfata IAdminListStrategy pentru strategia de  listare a admin-ilor
    /// </summary>
    public interface IAdminListStrategy
    {
        /// <summary>
        /// Metoda care trebuie implementată pentru a executa interogarea și a lista adminii
        /// </summary>
        /// <returns>O listă de stringuri care conțin informații despre admini</returns>
        List<String> ExecutQuery(); 
    }
}
