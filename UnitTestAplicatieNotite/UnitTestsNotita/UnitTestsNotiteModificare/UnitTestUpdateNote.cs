/**************************************************************************
 *                                                                        *
 *  File:        UnitTestUpdateNote.cs                                    *
 *  Copyright:   (c) 2024, Padurariu Dumitru                              *
 *  E-mail:      dumitru.padurariu@student.tuiasi.ro                      *
 *  Description: TBD                                                      *
 *                                                                        *
 **************************************************************************/

using AplicatieNotite.NotitaContext;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestAplicatieNotite.UnitTestsNotita.UnitTestsNotiteModificare
{
    /// <summary>
    ///Testele ce asigura buna functionare a actualizarii unei  notite
    /// </summary>
    [TestClass]
    public class UnitTestUpdateNote
    {
        private INotitaModifyStrategy _strategy;

        /// <summary>
        /// TestMethod care verifica daca se poate modicia notita la utilizator valid
        /// </summary>
        [TestMethod]
        public void test_UpdateStrategy_validwork()
        {

            _strategy = new UpdateNotitaStrategy("1","titlu","text");
            _strategy.ExecutUpdate();
        }

        /// <summary>
        /// TestMethod care arunca exceptie Exception si verifica daca se poate modifica notita la utilizator vid
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void test_addStrategy_idnull1()
        {
            _strategy = new UpdateNotitaStrategy("", "titlu", "text");
            _strategy.ExecutUpdate();
        }

        /// <summary>
        /// TestMethod care arunca exceptie Exception si verifica daca se poate modifica notita la utilizator null
        /// </summary>
        /// 
        ///
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void test_addStrategy_idnull2()
        {
            _strategy = new UpdateNotitaStrategy(null, "titlu", "text");
            _strategy.ExecutUpdate();
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void test_addStrategy_idnull3()
        {
            _strategy = new UpdateNotitaStrategy("1", "", "text");
            _strategy.ExecutUpdate();
        }
    }
}
