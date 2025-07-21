/**************************************************************************
 *                                                                        *
 *  File:        UnitTestListAll.cs                                       *
 *  Copyright:   (c) 2024, Minciuna Oana-Xenia                            *
 *  E-mail:      oana-xenia.minciuna@student.tuiasi.ro                    *
 *  Description: TBD                                                      *
 *                                                                        *
 **************************************************************************/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using AplicatieNotite.AdminContext;

namespace UnitTestAplicatieNotite.UnitTestsAdmin.UnitTestsListare
{
    /// <summary>
    /// Teste pentru listare utilizatori creati de admin
    /// </summary>
    [TestClass]
    class UnitTestListAll
    {
        private IAdminListStrategy _strategy;

        /// <summary>
        /// Metoda care returneaza 1 sau 0 in functie de cum se executa query-ul
        /// </summary>
        /// <returns>1 daca query nu e null, 0 in caz contrar</returns>
        private string EvaluateStrategy()
        {
            if (_strategy.ExecutQuery() != null)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }

        /// <summary>
        /// TestMethod pentru listare strategie
        /// </summary>
        [TestMethod]
        public void test_listAllStrategy()
        {
            _strategy = new FindUserStrategy("oanaxenia", "oanaxenia");
            Assert.AreEqual("1", EvaluateStrategy(), "oanaxenia-oanaxenia");
        }
    }
}
