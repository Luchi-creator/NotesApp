/**************************************************************************
 *                                                                        *
 *  File:        UnitTestDelete.cs                                        *
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

namespace UnitTestAplicatieNotite.UnitTestsAdmin.UnitTestsModificare
{
    /// <summary>
    /// Teste pentru stergerea utilizatorilor existenti sau inexistenti in baza de date
    /// </summary>
    [TestClass]
    public class UnitTestDelete
    {
        private IAdminModifyStrategy _strategy;

        /// <summary>
        /// TestMethod care verifica daca se poate sterge utilizator existent
        /// </summary>
        [TestMethod]
        public void test_deleteStrategy_existingUser()
        {
            _strategy = new DeleteUserStrategy(8);
            _strategy.ExecutUpdate();
        }


        /// <summary>
        /// TestMethod care verifica daca se poate sterge utilizator inexistent
        /// </summary>
        [TestMethod]
        public void test_deleteStrategy_UserInexistent()
        {
            _strategy = new DeleteUserStrategy(12345566);
            _strategy.ExecutUpdate();
        }


        /// <summary>
        /// TestMethod care verifica daca se poate sterge utilizator invalid
        /// </summary>
        [TestMethod]
        public void test_deleteStrategy_invalidUser2PWNeg()
        {
            _strategy = new DeleteUserStrategy(-35232);
            _strategy.ExecutUpdate();
        }
    }
}
