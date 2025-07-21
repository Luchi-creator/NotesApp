/**************************************************************************
 *                                                                        *
 *  File:        INotitaListStrategy.cs                                   *
 *  Copyright:   (c) 2024, Manea Paula                                    *
 *  E-mail:      paula.manea@student.tuiasi.ro                            *
 *  Description: TBD                                                      *
 *                                                                        *
 **************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieNotite.NotitaContext
{
    /// <summary>
    /// Interfața INotitaListStrategy definește metoda ExecuteQuery(), care trebuie implementată pentru a executa interogările legate de listarea notițelor.
    /// </summary>
    public interface INotitaListStrategy
    {
        /// <summary>
        /// Metoda care trebuie implementată pentru a executa interogarea și a lista notițele în cadrul aplicației
        /// </summary>
        /// <param name="_user">ID_ul user-ului care detine notitele</param>
        /// <returns>O listă de stringuri care conțin informații despre notițe</returns>
        List<String> ExecuteQuery(int _user);

    }
}
