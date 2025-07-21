/**************************************************************************
 *                                                                        *
 *  File:        ILoginStrategy.cs                                        *
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
    /// <summary>
    /// Interfata IAdminListStrategy pentru strategia de autentificare
    /// </summary>
    public interface ILoginStrategy
    {
        /// <summary>
        /// Metoda Authenticate care autentifica utilizatorul cu parola asociata
        /// </summary>
        int Authenticate(string username, string password);
    }
}
