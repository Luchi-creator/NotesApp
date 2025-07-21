/**************************************************************************
 *                                                                        *
 *  File:        Login.cs                                                 *
 *  Copyright:   (c) 2024, Luchian Ionut-Grigore                          *
 *  E-mail:      ionut-grigore.luchian@student.tuiasi.ro                  *
 *  Description: TBD                                                      *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicatieNotite.Exceptions.LoginFormExceptions;
using AplicatieNotite.UserContext;

namespace AplicatieNotite
{
    /// <summary>
    /// Clasa LoginForm reprezintă fereastra de autentificare a utilizatorului.
    /// </summary>
    public partial class LoginForm : Form
    {

        private string connectionString = "Data Source=|DataDirectory|\\aplicatieNotite.db;Version=3;";
        public User user;

        /// <summary>
        /// Constructorul clasei LoginForm
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            user = new User();
        }

        /// <summary>
        /// Buton de logare fie in fereastra Notita fie in Admin depinzand de user si parola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = textBoxUsernameLogIn.Text;
            string password = textBoxPasswordLogIn.Text;

            user.StrategyUser = new UsernamePasswordLoginStrategy(connectionString);

            try
            {
                user.DoStrategy(username, password);
            }
            catch (DatabaseConnectionException ex)
            {
                MessageBox.Show("Eroare de conectare la baza de date: " + ex.Message);
            }
            catch (InvalidCredentialsException ex)
            {
                MessageBox.Show("Credențiale invalide: " + ex.Message);
            }
            catch (SqlQueryException ex)
            {
                MessageBox.Show("Eroare la executarea interogării SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Utilizatorul nu s-a putut autentifica\r\n" + ex.Message);
            }
            finally
            {
                if (username.ToLower() == "admin" && password.ToLower() == "admin")
                {
                    AdminForm admin = new AdminForm();
                    admin.Show();
                    this.Hide();
                }
                else if (user.IsAuthenticated != 0)
                {
                    MainApp main = new MainApp(user.IsAuthenticated);
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Autentificare eșuată!");
                }
            }
        }

        /// <summary>
        /// Buton de iesire din aplicatie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Buton de help
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Login Help.chm");
        }

        /// <summary>
        /// Afisare daca s-a schimbat ceva in textbox-ul user login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxUserLogIn_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
