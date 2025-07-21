/**************************************************************************
 *                                                                        *
 *  File:        INotitaModifyStrategy.cs                                 *
 *  Copyright:   (c) 2024, Padurariu Dumitru                              *
 *  E-mail:      dumitru.padurariu@student.tuiasi.ro                      *
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
    /// Interfața INotitaModifyStrategy pentru strategiila de modificare a notițelor
    /// </summary>
    public interface INotitaModifyStrategy
    {
        /// <summary>
        /// Metoda ExecutUpdate care efectueaza modificări asupra notiței
        /// </summary>
        void ExecutUpdate();
    }
}
