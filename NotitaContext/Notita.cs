
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieNotite.NotitaContext
{
    /// <summary>
    /// Clasa Notita este responsabilă pentru gestionarea strategiilor de listare și modificare a notițelor în cadrul aplicației.
    /// </summary>
    public class Notita
    {
        private INotitaListStrategy _strategyList; // Strategia pentru listare a notițelor
        private INotitaModifyStrategy _strategyModify; // Strategia pentru modificare a notițelor

        /// <summary>
        /// Proprietatea StrategyList permite setarea strategiei de listare a notițelor.
        /// </summary>
        public INotitaListStrategy StrategyList
        {
            set
            {
                _strategyList = value;
            }
        }

        /// <summary>
        /// Proprietatea StrategyModify permite setarea strategiei de modificare a notițelor.
        /// </summary>
        public INotitaModifyStrategy StrategyModify
        {
            set
            {
                _strategyModify = value;
            }
        }

        /// <summary>
        /// Metoda care execută strategia de listare a notițelor și returnează rezultatul.
        /// </summary>
        /// <returns>O listă de șiruri de caractere care conține rezultatul strategiei de listare a notițelor.</returns>
        public List<String> DoListStrategy(int _user)
        {
            return _strategyList.ExecuteQuery(_user);
        }

        /// <summary>
        /// Metoda care execută strategia de modificare a notițelor.
        /// </summary>
        public void DoModifyStrategy()
        {
            _strategyModify.ExecutUpdate();
        }

    }
}
