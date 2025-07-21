/**************************************************************************
 *                                                                        *
 *  File:        User.cs                                                  *
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

namespace AplicatieNotite.UserContext
{
    /// <summary>
    /// Clasa User este responsabilă pentru gestionarea strategiilor de autentificare a utilizatorilor în cadrul aplicației.
    /// </summary>
    public class User
    {
        private ILoginStrategy _strategy; // Strategia de autentificare a utilizatorului


        public int IsAuthenticated { get; private set; }
        /// <summary>
        /// Proprietatea StrategyUser permite setarea strategiei de autentificare a utilizatorului.
        /// </summary>
        /// 
        public ILoginStrategy StrategyUser
        {
            set
            {
                _strategy = value;
            }
        }


        /// <summary>
        /// Metoda care execută strategia de autentificare a utilizatorului cu numele de utilizator și parola specificate.
        /// </summary>
        /// <param name="username">Numele de utilizator introdus.</param>
        /// <param name="password">Parola introdusă.</param>
        public void DoStrategy(string username, string password)
        {
            IsAuthenticated = _strategy.Authenticate(username, password);
        }
    }
}
