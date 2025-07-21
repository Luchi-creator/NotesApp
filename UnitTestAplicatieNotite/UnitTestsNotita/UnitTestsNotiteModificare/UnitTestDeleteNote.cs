/**************************************************************************
 *                                                                        *
 *  File:        UnitTestDeleteNote.cs                                    *
 *  Copyright:   (c) 2024, Padurariu Dumitru                              *
 *  E-mail:      dumitru.padurariu@student.tuiasi.ro                      *
 *  Description: TBD                                                      *
 *                                                                        *
 **************************************************************************/

using AplicatieNotite.NotitaContext;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace UnitTestAplicatieNotite.UnitTestsNotita.UnitTestsNotiteModificare
{
    /// <summary>
    /// Testele ce asigura buna functionare a stergerii unei  notite
    /// </summary>
    [TestClass]
    public class UnitTestDeleteNote
    {
        private INotitaModifyStrategy _strategy;

        /// <summary>
        /// TestMethod care verifica stergerea notitei utilizatorului 1
        /// </summary>
        [TestMethod]
        public void test_deleteStrategy_validwork()
        {
            
            _strategy = new DeleteNotitaStrategy("1");
            _strategy.ExecutUpdate();
        }

        /// <summary>
        /// TestMethod care arunca exceptie Exception si verifica daca se poate sterge notita la utilizator vid
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void test_deleteStrategy_idnull1()
        {
            _strategy = new DeleteNotitaStrategy("");
            _strategy.ExecutUpdate();
        }

        /// <summary>
        /// TestMethod care arunca exceptie Exception si verifica daca se poate sterge notita la utilizator null
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void test_deleteStrategy_idnull3()
        {
            _strategy = new DeleteNotitaStrategy(null);
            _strategy.ExecutUpdate();
        }
    }
}
