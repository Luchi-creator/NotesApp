namespace AplicatieNotite
{
    partial class MainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.noteAppFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuCreateOption = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuDeleteOption = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteAppEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuCopyOption = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuCutOption = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuPasteOption = new System.Windows.Forms.ToolStripMenuItem();
            this.noteAppFormatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.formatMenuFontOption = new System.Windows.Forms.ToolStripMenuItem();
            this.regularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuFontColorOption = new System.Windows.Forms.ToolStripMenuItem();
            this.noteAppHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuViewHelpOption = new System.Windows.Forms.ToolStripMenuItem();
            this.noteAppMenu = new System.Windows.Forms.MenuStrip();
            this.labelNotiteCombo = new System.Windows.Forms.Label();
            this.comboBoxNotita = new System.Windows.Forms.ComboBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.titleLabelNotita = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.richTextBoxNotita = new System.Windows.Forms.RichTextBox();
            this.logOutButton = new System.Windows.Forms.Button();
            this.noteAppMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(694, 372);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 29);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // noteAppFileMenu
            // 
            this.noteAppFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuCreateOption,
            this.fileMenuDeleteOption,
            this.updateToolStripMenuItem});
            this.noteAppFileMenu.Name = "noteAppFileMenu";
            this.noteAppFileMenu.Size = new System.Drawing.Size(37, 20);
            this.noteAppFileMenu.Text = "File";
            // 
            // fileMenuCreateOption
            // 
            this.fileMenuCreateOption.Name = "fileMenuCreateOption";
            this.fileMenuCreateOption.Size = new System.Drawing.Size(112, 22);
            this.fileMenuCreateOption.Text = "Create";
            this.fileMenuCreateOption.Click += new System.EventHandler(this.fileMenuCreateOption_Click);
            // 
            // fileMenuDeleteOption
            // 
            this.fileMenuDeleteOption.Name = "fileMenuDeleteOption";
            this.fileMenuDeleteOption.Size = new System.Drawing.Size(112, 22);
            this.fileMenuDeleteOption.Text = "Delete";
            this.fileMenuDeleteOption.Click += new System.EventHandler(this.fileMenuDeleteOption_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // noteAppEditMenu
            // 
            this.noteAppEditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMenuCopyOption,
            this.editMenuCutOption,
            this.editMenuPasteOption});
            this.noteAppEditMenu.Name = "noteAppEditMenu";
            this.noteAppEditMenu.Size = new System.Drawing.Size(39, 20);
            this.noteAppEditMenu.Text = "Edit";
            // 
            // editMenuCopyOption
            // 
            this.editMenuCopyOption.Name = "editMenuCopyOption";
            this.editMenuCopyOption.Size = new System.Drawing.Size(102, 22);
            this.editMenuCopyOption.Text = "Copy";
            this.editMenuCopyOption.Click += new System.EventHandler(this.editMenuCopyOption_Click);
            // 
            // editMenuCutOption
            // 
            this.editMenuCutOption.Name = "editMenuCutOption";
            this.editMenuCutOption.Size = new System.Drawing.Size(102, 22);
            this.editMenuCutOption.Text = "Cut";
            this.editMenuCutOption.Click += new System.EventHandler(this.editMenuCutOption_Click);
            // 
            // editMenuPasteOption
            // 
            this.editMenuPasteOption.Name = "editMenuPasteOption";
            this.editMenuPasteOption.Size = new System.Drawing.Size(102, 22);
            this.editMenuPasteOption.Text = "Paste";
            this.editMenuPasteOption.Click += new System.EventHandler(this.editMenuPasteOption_Click);
            // 
            // noteAppFormatMenu
            // 
            this.noteAppFormatMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatMenuFontOption,
            this.fileMenuFontColorOption});
            this.noteAppFormatMenu.Name = "noteAppFormatMenu";
            this.noteAppFormatMenu.Size = new System.Drawing.Size(57, 20);
            this.noteAppFormatMenu.Text = "Format";
            // 
            // formatMenuFontOption
            // 
            this.formatMenuFontOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regularToolStripMenuItem,
            this.italicToolStripMenuItem,
            this.boldToolStripMenuItem});
            this.formatMenuFontOption.Name = "formatMenuFontOption";
            this.formatMenuFontOption.Size = new System.Drawing.Size(130, 22);
            this.formatMenuFontOption.Text = "Font";
            // 
            // regularToolStripMenuItem
            // 
            this.regularToolStripMenuItem.Name = "regularToolStripMenuItem";
            this.regularToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.regularToolStripMenuItem.Text = "Regular";
            this.regularToolStripMenuItem.Click += new System.EventHandler(this.regularToolStripMenuItem_Click);
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            this.italicToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.italicToolStripMenuItem.Text = "Italic";
            this.italicToolStripMenuItem.Click += new System.EventHandler(this.italicToolStripMenuItem_Click);
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.boldToolStripMenuItem.Text = "Bold";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
            // 
            // fileMenuFontColorOption
            // 
            this.fileMenuFontColorOption.Name = "fileMenuFontColorOption";
            this.fileMenuFontColorOption.Size = new System.Drawing.Size(130, 22);
            this.fileMenuFontColorOption.Text = "Font Color";
            this.fileMenuFontColorOption.Click += new System.EventHandler(this.fileMenuFontColorOption_Click);
            // 
            // noteAppHelpMenu
            // 
            this.noteAppHelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMenuViewHelpOption});
            this.noteAppHelpMenu.Name = "noteAppHelpMenu";
            this.noteAppHelpMenu.Size = new System.Drawing.Size(44, 20);
            this.noteAppHelpMenu.Text = "Help";
            // 
            // helpMenuViewHelpOption
            // 
            this.helpMenuViewHelpOption.Name = "helpMenuViewHelpOption";
            this.helpMenuViewHelpOption.Size = new System.Drawing.Size(127, 22);
            this.helpMenuViewHelpOption.Text = "View Help";
            this.helpMenuViewHelpOption.Click += new System.EventHandler(this.helpMenuViewHelpOption_Click);
            // 
            // noteAppMenu
            // 
            this.noteAppMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.noteAppMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noteAppFileMenu,
            this.noteAppEditMenu,
            this.noteAppFormatMenu,
            this.noteAppHelpMenu});
            this.noteAppMenu.Location = new System.Drawing.Point(0, 0);
            this.noteAppMenu.Name = "noteAppMenu";
            this.noteAppMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.noteAppMenu.Size = new System.Drawing.Size(799, 24);
            this.noteAppMenu.TabIndex = 0;
            this.noteAppMenu.Text = "noteAppMenu";
            // 
            // labelNotiteCombo
            // 
            this.labelNotiteCombo.AutoSize = true;
            this.labelNotiteCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotiteCombo.Location = new System.Drawing.Point(306, 42);
            this.labelNotiteCombo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNotiteCombo.Name = "labelNotiteCombo";
            this.labelNotiteCombo.Size = new System.Drawing.Size(55, 20);
            this.labelNotiteCombo.TabIndex = 31;
            this.labelNotiteCombo.Text = "Notite:";
            // 
            // comboBoxNotita
            // 
            this.comboBoxNotita.FormattingEnabled = true;
            this.comboBoxNotita.Location = new System.Drawing.Point(310, 71);
            this.comboBoxNotita.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxNotita.Name = "comboBoxNotita";
            this.comboBoxNotita.Size = new System.Drawing.Size(339, 21);
            this.comboBoxNotita.TabIndex = 30;
            this.comboBoxNotita.SelectedIndexChanged += new System.EventHandler(this.comboBoxNotita_SelectedIndexChanged);
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.Location = new System.Drawing.Point(33, 104);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(55, 20);
            this.noteLabel.TabIndex = 29;
            this.noteLabel.Text = "Notita:";
            // 
            // titleLabelNotita
            // 
            this.titleLabelNotita.AutoSize = true;
            this.titleLabelNotita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabelNotita.Location = new System.Drawing.Point(33, 42);
            this.titleLabelNotita.Name = "titleLabelNotita";
            this.titleLabelNotita.Size = new System.Drawing.Size(42, 20);
            this.titleLabelNotita.TabIndex = 28;
            this.titleLabelNotita.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(37, 71);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(246, 20);
            this.titleTextBox.TabIndex = 27;
            // 
            // richTextBoxNotita
            // 
            this.richTextBoxNotita.Location = new System.Drawing.Point(37, 127);
            this.richTextBoxNotita.Name = "richTextBoxNotita";
            this.richTextBoxNotita.Size = new System.Drawing.Size(612, 274);
            this.richTextBoxNotita.TabIndex = 26;
            this.richTextBoxNotita.Text = "";
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(694, 325);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 29);
            this.logOutButton.TabIndex = 32;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 428);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.labelNotiteCombo);
            this.Controls.Add(this.comboBoxNotita);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.titleLabelNotita);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.richTextBoxNotita);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.noteAppMenu);
            this.MainMenuStrip = this.noteAppMenu;
            this.Name = "MainApp";
            this.Text = "Aplicatie Notite";
            this.noteAppMenu.ResumeLayout(false);
            this.noteAppMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolStripMenuItem noteAppFileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuCreateOption;
        private System.Windows.Forms.ToolStripMenuItem fileMenuDeleteOption;
        private System.Windows.Forms.ToolStripMenuItem noteAppEditMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenuCopyOption;
        private System.Windows.Forms.ToolStripMenuItem editMenuCutOption;
        private System.Windows.Forms.ToolStripMenuItem editMenuPasteOption;
        private System.Windows.Forms.ToolStripMenuItem noteAppFormatMenu;
        private System.Windows.Forms.ToolStripMenuItem formatMenuFontOption;
        private System.Windows.Forms.ToolStripMenuItem fileMenuFontColorOption;
        private System.Windows.Forms.ToolStripMenuItem noteAppHelpMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenuViewHelpOption;
        private System.Windows.Forms.MenuStrip noteAppMenu;
        private System.Windows.Forms.Label labelNotiteCombo;
        private System.Windows.Forms.ComboBox comboBoxNotita;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Label titleLabelNotita;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.RichTextBox richTextBoxNotita;
        private System.Windows.Forms.ToolStripMenuItem regularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.Button logOutButton;
    }
}

