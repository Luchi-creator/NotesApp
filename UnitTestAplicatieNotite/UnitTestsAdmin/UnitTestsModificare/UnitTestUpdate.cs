/**************************************************************************
 *                                                                        *
 *  File:        UnitTestUpdate.cs                                        *
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
using System.Data.SQLite;

namespace UnitTestAplicatieNotite.UnitTestsAdmin.UnitTestsModificare
{
    /// <summary>
    /// Teste pentru modificarea utilizatorilor din baza de date
    /// </summary>
    [TestClass]
    public class UnitTestUpdate
    {
        private IAdminModifyStrategy _strategy;


        /// <summary>
        /// TestMethod care verifica daca se poate modifica utilizator existent
        /// </summary>
        [TestMethod]
        public void test_updateStrategy_existingUser()
        {
            _strategy = new UpdateUserStrategy(6, "oana1234", "oana4321");
            _strategy.ExecutUpdate();
        }


        /// <summary>
        /// TestMethod care verifica daca se poate modifica utilizator inexistent
        /// </summary>
        [TestMethod]
        public void test_updateStrategy_UserInexistent()
        {
            _strategy = new UpdateUserStrategy(12345566, "xenia1234", "12345678");
            _strategy.ExecutUpdate();
        }

        /// <summary>
        /// TestMethod care arunca exceptie SQLiteException si verifica daca se poate modifica utilizator null cu parola valida
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(SQLiteException))]
        public void test_updateStrategy_nullUsername()
        {
            _strategy = new UpdateUserStrategy(12, null, "oanaxenia");
            _strategy.ExecutUpdate();
        }

        /// <summary>
        /// TestMethod care arunca exceptie SQLiteException si verifica daca se poate modifica utilizator valid cu parola null
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(SQLiteException))]
        public void test_updateStrategy_nullPass()
        {
            _strategy = new UpdateUserStrategy(12,"oanaxenia", null);
            _strategy.ExecutUpdate();
        }
    }
}
