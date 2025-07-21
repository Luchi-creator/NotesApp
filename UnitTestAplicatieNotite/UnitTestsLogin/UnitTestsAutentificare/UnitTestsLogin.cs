/**************************************************************************
 *                                                                        *
 *  File:        UnitTestsLogin.cs                                        *
 *  Copyright:   (c) 2024, Luchian Ionut-Grigore                          *
 *  E-mail:      ionut-grigore.luchian@student.tuiasi.ro                  *
 *  Description: TBD                                                      *
 *                                                                        *
 **************************************************************************/


using AplicatieNotite.UserContext;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestAplicatieNotite.UnitTestsUser.UnitTestsLogin
{
    [TestClass]
    public class UsernamePasswordLoginStrategyTests
    {
        private string connectionString = "Data Source=|DataDirectory|\\aplicatieNotite.db;Version=3;";

        [TestMethod]
        public void Authenticate_ValidCredentials_ReturnsUserId()
        {
            UsernamePasswordLoginStrategy loginStrategy = new UsernamePasswordLoginStrategy(connectionString);
            string validUsername = "ana";
            string validPassword = "maria";

            int userId = loginStrategy.Authenticate(validUsername, validPassword);

            Assert.IsTrue(userId > 0); 
        }

        [TestMethod]
        public void Authenticate_InvalidCredentials_ReturnsZero()
        {
            UsernamePasswordLoginStrategy loginStrategy = new UsernamePasswordLoginStrategy(connectionString);
            string invalidUsername = "asd";
            string invalidPassword = "asd";

            int userId = loginStrategy.Authenticate(invalidUsername, invalidPassword);

            Assert.AreEqual(0, userId);
        }

        [TestMethod]
        [ExpectedException(typeof(SQLiteException))]
        public void Authenticate_DatabaseConnectionError_ThrowsException()
        {
            string invalidConnectionString = "stringInvalid";
            UsernamePasswordLoginStrategy loginStrategy = new UsernamePasswordLoginStrategy(invalidConnectionString);
            string validUsername = "valid_username";
            string validPassword = "valid_password";

            int userId = loginStrategy.Authenticate(validUsername, validPassword);

        }
    }
}