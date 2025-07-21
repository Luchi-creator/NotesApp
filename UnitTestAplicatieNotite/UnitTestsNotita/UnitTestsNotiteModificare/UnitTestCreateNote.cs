/**************************************************************************
 *                                                                        *
 *  File:        UnitTestCreateNote.cs                                    *
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
    /// Testele ce asigura buna functionare a crearii de notite
    /// </summary>
    [TestClass]
    public class UnitTestCreateNote
    {
        private INotitaModifyStrategy _strategy;
        [TestMethod]

        /// <summary>
        /// TestMethod care adauga notita valida unui utilizator
        /// </summary>
        public void test_addStrategy_valideNote()
        {
            _strategy = new AddNotitaStrategy(1,"ytest","testfall");
            _strategy.ExecutUpdate();
        }

        /// <summary>
        /// TestMethod care arunca exceptie Exception si adauga notita invalida unui utilizator
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void test_addStrategy_idnull2()
        {
            _strategy = new AddNotitaStrategy(1, "", "testfall");
            _strategy.ExecutUpdate();
        }

    }
}
