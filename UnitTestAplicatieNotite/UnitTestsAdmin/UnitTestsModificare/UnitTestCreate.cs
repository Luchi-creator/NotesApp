/**************************************************************************
 *                                                                        *
 *  File:        UnitTestCreate.cs                                        *
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
    /// Teste pentru verificarea utilizarilor creati de admin
    /// </summary>
    [TestClass]
    public class UnitTestCreate
    {
        private IAdminModifyStrategy _strategy;

        /// <summary>
        /// TestMethod care arunca exceptie SQLiteException si verifica daca se poate adauga utilizator existent
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(SQLiteException))]
        public void test_addStrategy_existingUser()
        {
            _strategy = new AddUserStrategy("fsfs_133", "fsfsrsrsr21");
            _strategy.ExecutUpdate();
        }

        /// <summary>
        /// TestMethod care arunca exceptie SQLiteException si verifica daca se poate adauga utilizator valid cu parola null
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(SQLiteException))]
        public void test_addStrategy_nullPass()
        {
            _strategy = new AddUserStrategy("oanaxenia123", null);
            _strategy.ExecutUpdate();
        }


        /// <summary>
        /// TestMethod care arunca exceptie SQLiteException si verifica daca se poate adauga utilizator null cu parola valida
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(SQLiteException))]
        public void test_addStrategy_nullUsername()
        {
            _strategy = new AddUserStrategy(null,"1234567");
            _strategy.ExecutUpdate();
        }
        /// <summary>
        /// TestMethod care arunca exceptie SQLiteException si verifica daca se poate adauga utilizator null cu parola null
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(SQLiteException))]
        public void test_addStrategy_nullnull()
        {
            _strategy = new AddUserStrategy(null, null);
            _strategy.ExecutUpdate();
        }

        /// <summary>
        /// TestMethod care arunca exceptie SQLiteException si verifica daca se poate adauga utilizator si parola valide amandoua
        /// </summary>
        [TestMethod]
        public void test_addStrategy_validUser()
        {
            _strategy = new AddUserStrategy("oanaxenia123", "1234678");
            _strategy.ExecutUpdate();
        }
    }
}
