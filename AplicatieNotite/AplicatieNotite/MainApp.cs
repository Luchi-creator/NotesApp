/**************************************************************************
 *                                                                        *
 *  File:        MainApp.cs                                               *
 *  Copyright:   (c) 2024, Manea Paula, Padurariu Dumitru                 *
 *  E-mail:      paula.manea@student.tuiasi.ro                            *
 *               dumitru.padurariu@student.tuiasi.ro                      *
 *  Description: TBD                                                      *
 *                                                                        *
 **************************************************************************/

using AplicatieNotite.NotitaContext;
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

namespace AplicatieNotite
{
    /// <summary>
    /// Clasa MainApp reprezintă fereastra principală a aplicației și gestionarea interacțiunilor utilizatorului
    /// </summary>
    public partial class MainApp : Form
    {
      
        private int _user; // ID-ul utilizatorului curent
        private Notita _notiteUser; // Obiect pentru gestionarea notițelor utilizatorului

        /// <summary>
        /// Constructorul clasei MainApp
        /// </summary>
        /// <param name="user">ID-ul utilizatorului curent</param>
        public MainApp(int user)
        {
            _notiteUser = new Notita();
            _user = user;
            InitializeComponent();
            InitializeNotiteList();
        }

        /// <summary>
        /// Metoda pentru inițializarea listei de notițe
        /// </summary>
        private void InitializeNotiteList()
        {
            comboBoxNotita.Items.Clear();

            // Utilizați strategia ListAllStrategy pentru a obține lista de notițe
            _notiteUser.StrategyList = new ListAllStrategy();
            try
            {
                List<String> notiteList = _notiteUser.DoListStrategy(_user);

                // Adăugați fiecare notiță din listă în ComboBox
                foreach (String notita in notiteList)
                {
                    // Adăugați titlul notiței în ComboBox, iar valoarea elementului să fie ID-ul notiței
                    comboBoxNotita.Items.Add(notita);
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Nu s-a putut afisa lista de notite a utilizatorului!\r\n" + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nu s-a putut afisa lista de notite a utilizatorului!\r\n" + ex.Message);
            }
        
        }

        /// <summary>
        /// Butonul de iesire din aplicatie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Buton de help pentru fereastra main
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpMenuViewHelpOption_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Notita help.chm");
        }

        /// <summary>
        /// Submeniul din meniul Format de text normal 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxNotita.SelectionFont = new Font(richTextBoxNotita.Font, FontStyle.Regular);
        }

        /// <summary>
        /// Submeniul din meniul Format de text italic 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxNotita.SelectionFont = new Font(richTextBoxNotita.Font, FontStyle.Italic);
        }

        /// <summary>
        /// Submeniul din meniul Format de text bold 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxNotita.SelectionFont = new Font(richTextBoxNotita.Font, FontStyle.Bold);
            
        }

        /// <summary>
        /// Submeniul din meniul Format de alegere a culorii fontului
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileMenuFontColorOption_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                SetTextColor(colorDialog.Color);
            }
        }

        /// <summary>
        /// Functie de setare culoare 
        /// </summary>
        /// <param name="color"></param>
        private void SetTextColor(Color color)
        {
            richTextBoxNotita.SelectionColor = color;
        }

        /// <summary>
        /// Submeniul din meniul Edit de copy text 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editMenuCopyOption_Click(object sender, EventArgs e)
        {
            richTextBoxNotita.Copy();
        }

        /// <summary>
        /// Submeniul din meniul Edit de cut text 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editMenuCutOption_Click(object sender, EventArgs e)
        {
            richTextBoxNotita.Cut();
        }

        /// <summary>
        /// Submeniul din meniul Edit de paste text 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editMenuPasteOption_Click(object sender, EventArgs e)
        {
            richTextBoxNotita.Paste();
        }

        /// <summary>
        /// Combobox-ul din care se afiseaza lista de notite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxNotita_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNotita.SelectedIndex >= 0)
            {
                List<String> selectedNotita;
                _notiteUser.StrategyList = new ListNotitaStrategy(Convert.ToInt32(comboBoxNotita.SelectedItem.ToString().Split(' ')[0]));
                try
                {
                    selectedNotita = _notiteUser.DoListStrategy(_user);
                    titleTextBox.Text = selectedNotita[0];
                    richTextBoxNotita.Text = selectedNotita[1];
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Nu s-a putut afisa notita!\r\n" + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nu s-a putut afisa notita!\r\n" + ex.Message);
                }

            }
        }

        /// <summary>
        /// Submeniu din meniul File de creare notita 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileMenuCreateOption_Click(object sender, EventArgs e)
        {
            _notiteUser.StrategyModify = new AddNotitaStrategy(_user, titleTextBox.Text, richTextBoxNotita.Text);
            try { 
                _notiteUser.DoModifyStrategy();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Nu s-a putut crea notita!\r\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nu s-a putut crea notita!\r\n" + ex.Message);
            }
            InitializeNotiteList();
            titleTextBox.Text = "";
            richTextBoxNotita.Text = "";

        }

        /// <summary>
        /// Submeniu din meniul File de stergere notita
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void fileMenuDeleteOption_Click(object sender, EventArgs e)
        {
            string idnum = comboBoxNotita.Text.ToString();
            string []idnum2 = idnum.Split(' ');
            string idnote = idnum2.Length > 0 ? idnum2[0] : string.Empty;
           
            _notiteUser.StrategyModify = new DeleteNotitaStrategy(idnote);
            _notiteUser.DoModifyStrategy();
            try
            {
                InitializeNotiteList();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Nu s-a putut sterge notita!\r\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nu s-a putut sterge notita!\r\n" + ex.Message);
            }
            titleTextBox.Text = "";
            richTextBoxNotita.Text = "";
            comboBoxNotita.Text = "";



        }

        /// <summary>
        /// Submeniu din meniul File de actualizare notita
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string idnum = comboBoxNotita.Text.ToString();
            string[] idnum2 = idnum.Split(' ');
            string idnote = idnum2.Length > 0 ? idnum2[0] : string.Empty;

            _notiteUser.StrategyModify = new UpdateNotitaStrategy(idnote, titleTextBox.Text, richTextBoxNotita.Text);
            try
            {
                _notiteUser.DoModifyStrategy();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Nu s-a putut modifica notita!\r\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nu s-a putut modifica notita!\r\n" + ex.Message);
            }
            InitializeNotiteList();
            titleTextBox.Text = "";
            richTextBoxNotita.Text = "";
            comboBoxNotita.Text = "";
        }

        /// <summary>
        /// Buton de logout si reintrare pe pagina de login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logOutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
