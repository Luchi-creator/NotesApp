/**************************************************************************
 *                                                                        *
 *  File:        UnitTestFind.cs                                          *
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
    /// Teste pentru gasirea utilizatorilor creati de admin
    /// </summary>
    [TestClass]
    public class UnitTestFind
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
        /// TestMethod pentru utilizator existent
        /// </summary>
        [TestMethod]
        public void test_findStrategy_existingUser()
        {
            _strategy = new FindUserStrategy("oanaxenia", "oanaxenia");
            Assert.AreEqual("1", EvaluateStrategy(), "oanaxenia-oanaxenia");
        }

        /// <summary>
        /// TestMethod pentru utilizator inexistent
        /// </summary>
        [TestMethod]
        public void test_findStrategy_nonexistentUser()
        {
            _strategy = new FindUserStrategy("oana", "oana");
            Assert.AreEqual("0", EvaluateStrategy(), "oana-oana");
        }
    }
}
