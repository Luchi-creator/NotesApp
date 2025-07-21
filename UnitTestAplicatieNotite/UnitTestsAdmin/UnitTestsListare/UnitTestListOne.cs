/**************************************************************************
 *                                                                        *
 *  File:        UnitTestListOne.cs                                       *
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
using System.Linq;

namespace UnitTestAplicatieNotite.UnitTestsAdmin.UnitTestsListare
{
    /// <summary>
    /// Teste pentru verificare existenta utilizatori
    /// </summary>
    [TestClass]
    public class UnitTestListOne
    {
        private IAdminListStrategy _strategy;

        /// <summary>
        /// Metoda care returneaza 1 sau 0 in functie de cum se executa query-ul
        /// </summary>
        /// <returns>1 daca query nu e null, 0 in caz contrar</returns>
        private string EvaluateStrategy()
        {
            if (_strategy.ExecutQuery().Count() != 0)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }
        [TestMethod]
        public void test_listStrategy_existingUser()
        {
            _strategy = new ListUserStrategy(5);
            Assert.AreEqual("1", EvaluateStrategy(), "5");
        }

        [TestMethod]
        public void test_listStrategy_nonexistentUser()
        {
            _strategy = new ListUserStrategy(12345);
            Assert.AreEqual("0", EvaluateStrategy(), "12345");
        }
        [TestMethod]

        public void test_listStrategy_nonexistentUser2()
        {
            _strategy = new ListUserStrategy(-12345);
            Assert.AreEqual("0", EvaluateStrategy(), "-12345");
        }
    }
}
