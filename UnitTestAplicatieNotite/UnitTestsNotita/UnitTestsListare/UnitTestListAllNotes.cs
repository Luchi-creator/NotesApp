/**************************************************************************
 *                                                                        *
 *  File:        UnitTestListAllNotes.cs                                  *
 *  Copyright:   (c) 2024, Manea Paula                                    *
 *  E-mail:      paula.manea@student.tuiasi.ro                            *
 *  Description: TBD                                                      *
 *                                                                        *
 **************************************************************************/


using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using AplicatieNotite.NotitaContext;

namespace UnitTestAplicatieNotite.UnitTestsNotita.UnitTestsListare
{
    /// <summary>
    /// Teste ce verifica existenta notitelor
    /// </summary>
    [TestClass]
    public class UnitTestListAllNotes
    {
        /// <summary>
        /// TestMethod care returneaza toate notitele unui utilizator
        /// </summary>
        [TestMethod]
        public void TestExecuteQuery_ReturnsAllNotesForUser()
        {
    
            ListAllStrategy strategy = new ListAllStrategy();
            List<string> result = strategy.ExecuteQuery(1);

            Assert.AreEqual(1, result.Count);
            Assert.IsTrue(result[0].Contains("Notita mea"));
            Assert.IsTrue(result[0].Contains("Lorem ipsum sit anet."));
            Assert.IsTrue(result[1].Contains("cumparaturi"));
            Assert.IsTrue(result[1].Contains("ardei,rosii"));
        }
    }
}
