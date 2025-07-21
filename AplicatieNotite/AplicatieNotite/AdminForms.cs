/**************************************************************************
 *                                                                        *
 *  File:        AdminForms.cs                                            *
 *  Copyright:   (c) 2024, Minciuna Oana-Xenia                            *
 *  E-mail:      oana-xenia.minciuna@student.tuiasi.ro                    *
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using AplicatieNotite.AdminContext;
using AplicatieNotite.Exceptions.AdminFormExceptions;

namespace AplicatieNotite
{
    /// <summary>
    /// Clasa AdminForm reprezintă fereastra de administrare a utilizatorilor din aplicație.
    /// </summary>
    public partial class AdminForm : Form
    {
        public Admin admin;

        /// <summary>
        /// Constructorul clasei AdminForm
        /// </summary>
        public AdminForm()
        {
            InitializeComponent();
            admin = new Admin();
            InitializeUserList();

        }

        /// <summary>
        /// Metoda pentru inițializarea listei de utilizatori
        /// </summary>
        private void InitializeUserList()
        {
            comboBoxUsers.Items.Clear();

            admin.StrategyList = new ListAllStrategy();
            // Clear existing items in the ComboBox

            // Obțineți lista de utilizatori (presupunând că aveți deja o listă de utilizatori definită undeva)
            try
            {
                List<String> userList = admin.DoListStrategy();
                // Adăugați fiecare utilizator din listă în ComboBox
                foreach (String user in userList)
                {
                    // Adăugați numele utilizatorului în ComboBox, iar valoarea elementului să fie ID-ul utilizatorului
                    comboBoxUsers.Items.Add(user);
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Nu s-a putut initializa lista de useri! \r\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nu s-a putut initializa lista de useri! \r\n" + ex.Message);
            }

        }

        /// <summary>
        /// Metoda care gestioneaza evenimentului de selectare a unui utilizator din combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUsers.SelectedIndex >= 0)
            {
                List<String> selectedUser;
                admin.StrategyList = new ListUserStrategy(Convert.ToInt32(comboBoxUsers.SelectedItem.ToString().Split(' ')[0]));
                try
                {
                    selectedUser = admin.DoListStrategy();
                    textBoxUsernameAdmin.Text = selectedUser[0];
                    textBoxPasswordAdmin.Text = selectedUser[1];
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Nu s-a putut selecta utilizatorul! \r\n" + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nu s-a putut selecta utilizatorul! \r\n" + ex.Message);
                }

                buttonClear.Enabled = true;
                buttonDeleteUser.Enabled = true;
                buttonUpdateUser.Enabled = true;
            }
            else
            {
                buttonClear.Enabled = false;
                buttonDeleteUser.Enabled = false;
                buttonUpdateUser.Enabled = false;
            }
        }

        private void validUser(String username, String password)
        {
            if (!Regex.IsMatch(textBoxUsernameAdmin.Text, @"^[a-zA-Z0-9_]{5,15}$"))
            {
                throw (new InvalidUsernameException("Username-ul contine caractere nepermise sau nu are lungimea potrivita(minim 5 si maxim 15 caractere)!"));
            }
            if (!Regex.IsMatch(textBoxPasswordAdmin.Text, @"^[a-zA-Z0-9]{5,15}$"))
            {
                throw (new InvalidPasswordException("Parola contine caractere nepermise sau nu are lungimea potrivita(minim 5 si maxim 15 caractere)!"));
            }
            if(username.ToLower() == "admin" || password.ToLower() == "admin")
            {
                throw (new InvalidUserType("Numele de utilizator si/sau parola sunt rezervate! "));
            }

        }
        /// <summary>
        /// Buton de adaugare user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddUser_Click(object sender, EventArgs e)
        {

            try
            {
                validUser(textBoxUsernameAdmin.Text, textBoxPasswordAdmin.Text);
                //verificare existenta user
                admin.StrategyList = new FindUserStrategy(textBoxUsernameAdmin.Text, textBoxPasswordAdmin.Text);
                try
                {
                    if (admin.DoListStrategy() == null)
                    {
                        admin.StrategyModify = new AddUserStrategy(textBoxUsernameAdmin.Text, textBoxPasswordAdmin.Text);
                        admin.DoModifyStrategy();
                        InitializeUserList();
                        textBoxUsernameAdmin.Text = "";
                        textBoxPasswordAdmin.Text = "";
                        comboBoxUsers.SelectedIndex = -1;
                        comboBoxUsers.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Sunteti deja inregistrat");
                        textBoxUsernameAdmin.Text = "";
                        textBoxPasswordAdmin.Text = "";
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Nu sa putut adauga utilizatorul!\r\n" + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nu sa putut adauga utilizatorul!\r\n" + ex.Message);
                }
            }
            catch (InvalidUsernameException ex)
            {
                MessageBox.Show(ex._info);
            }
            catch (InvalidPasswordException ex)
            {
                MessageBox.Show(ex._info);
            }
            catch (InvalidUserType ex)
            {
                MessageBox.Show(ex._info);
            }
        }


        /// <summary>
        /// Buton de update user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateUser_Click(object sender, EventArgs e)
        {

            admin.StrategyModify = new UpdateUserStrategy(Convert.ToInt32(comboBoxUsers.SelectedItem.ToString().Split(' ')[0]), textBoxUsernameAdmin.Text, textBoxPasswordAdmin.Text);
            try
            {
                admin.DoModifyStrategy();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Nu sa putut modifica utilizatorul!\r\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nu sa putut modifica utilizatorul!\r\n" + ex.Message);
            }
            InitializeUserList();
            textBoxUsernameAdmin.Text = "";
            textBoxPasswordAdmin.Text = "";
            comboBoxUsers.SelectedIndex = -1;
            comboBoxUsers.Text = "";
            buttonClear.Enabled = false;
            buttonDeleteUser.Enabled = false;
            buttonUpdateUser.Enabled = false;
        }

        /// <summary>
        /// Buton de delete user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            admin.StrategyModify = new DeleteUserStrategy(Convert.ToInt32(comboBoxUsers.SelectedItem.ToString().Split(' ')[0]));
            try
            {
                admin.DoModifyStrategy();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Nu sa putut sterge utilizatorul!\r\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nu sa putut sterge utilizatorul!\r\n" + ex.Message);
            }
            InitializeUserList();
            textBoxUsernameAdmin.Text = "";
            textBoxPasswordAdmin.Text = "";
            comboBoxUsers.SelectedIndex = -1;
            comboBoxUsers.Text = "";
            buttonClear.Enabled = false;
            buttonDeleteUser.Enabled = false;
            buttonUpdateUser.Enabled = false;
        }

        /// <summary>
        /// Buton de curatare date de pe ecran
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUsernameAdmin.Text = "";
            textBoxPasswordAdmin.Text = "";
            comboBoxUsers.SelectedIndex = -1;
            comboBoxUsers.Text = "";
            buttonClear.Enabled = false;
            buttonDeleteUser.Enabled = false;
            buttonUpdateUser.Enabled = false;
        }

        /// <summary>
        /// Buton de revenire la fereastra principala de logare
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBackAdmin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Buton de iesire din aplicatie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonExitAdmin_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        /// <summary>
        /// Buton de help
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHelpAdmin_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Admin help.chm");
        }
    }
}
