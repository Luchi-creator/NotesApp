
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieNotite.AdminContext
{
    /// <summary>
    /// Clasa Admin este responsabilă pentru gestionarea strategiilor de listare și modificare a datelor din cadrul aplicației.
    /// </summary>
    public class Admin
    {
        private IAdminListStrategy _strategyList; // Strategia pentru listare
        private IAdminModifyStrategy _strategyModify; // Strategia pentru modificare

        /// <summary>
        /// Proprietatea StrategyList permite setarea strategiei de listare.
        /// </summary>
        public IAdminListStrategy StrategyList
        {
            set
            {
                _strategyList = value;
            }
        }

        /// <summary>
        /// Proprietatea StrategyModify permite setarea strategiei de modificare.
        /// </summary>
        public IAdminModifyStrategy StrategyModify
        {
            set
            {
                _strategyModify = value;
            }
        }

        /// <summary>
        /// Metoda care execută strategia de listare și returnează rezultatul
        /// </summary>
        /// <returns>O listă de stringuri de caractere care conține rezultatul strategiei de listare</returns>
        public List<String> DoListStrategy()
        {
            return _strategyList.ExecutQuery();
        }

        /// <summary>
        /// Metoda care execută strategia de modificare
        /// </summary>
        public void DoModifyStrategy()
        {
            _strategyModify.ExecutUpdate();
        }
    }
}
