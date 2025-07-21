/**************************************************************************
 *                                                                        *
 *  File:        IAdminModifyStrategy.cs                                  *
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
    /// Interfata IAdminModifyStrategy pentru strategia de modificare a admin-ilor
    /// </summary>
    public interface IAdminModifyStrategy
    {
        void ExecutUpdate();
    }
}
