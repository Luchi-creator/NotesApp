namespace AplicatieNotite
{
    partial class AdminForm
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
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonUpdateUser = new System.Windows.Forms.Button();
            this.laberUsers = new System.Windows.Forms.Label();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.textBoxPasswordAdmin = new System.Windows.Forms.TextBox();
            this.textBoxUsernameAdmin = new System.Windows.Forms.TextBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.groupBoxAdmin = new System.Windows.Forms.GroupBox();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonHelpAdmin = new System.Windows.Forms.Button();
            this.buttonExitAdmin = new System.Windows.Forms.Button();
            this.buttonBackAdmin = new System.Windows.Forms.Button();
            this.groupBoxAdmin.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Enabled = false;
            this.buttonDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteUser.Location = new System.Drawing.Point(47, 217);
            this.buttonDeleteUser.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(100, 41);
            this.buttonDeleteUser.TabIndex = 38;
            this.buttonDeleteUser.Text = "Delete";
            this.buttonDeleteUser.UseMnemonic = false;
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonUpdateUser
            // 
            this.buttonUpdateUser.Enabled = false;
            this.buttonUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateUser.Location = new System.Drawing.Point(47, 132);
            this.buttonUpdateUser.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdateUser.Name = "buttonUpdateUser";
            this.buttonUpdateUser.Size = new System.Drawing.Size(100, 44);
            this.buttonUpdateUser.TabIndex = 37;
            this.buttonUpdateUser.Text = "Update";
            this.buttonUpdateUser.UseMnemonic = false;
            this.buttonUpdateUser.UseVisualStyleBackColor = true;
            this.buttonUpdateUser.Click += new System.EventHandler(this.buttonUpdateUser_Click);
            // 
            // laberUsers
            // 
            this.laberUsers.AutoSize = true;
            this.laberUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laberUsers.Location = new System.Drawing.Point(491, 343);
            this.laberUsers.Name = "laberUsers";
            this.laberUsers.Size = new System.Drawing.Size(58, 24);
            this.laberUsers.TabIndex = 36;
            this.laberUsers.Text = "Users";
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(437, 368);
            this.comboBoxUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(175, 24);
            this.comboBoxUsers.TabIndex = 35;
            this.comboBoxUsers.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsers_SelectedIndexChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(36, 119);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(97, 24);
            this.passwordLabel.TabIndex = 34;
            this.passwordLabel.Text = "Password:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(36, 39);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(102, 24);
            this.nameLabel.TabIndex = 33;
            this.nameLabel.Text = "Username:";
            // 
            // textBoxPasswordAdmin
            // 
            this.textBoxPasswordAdmin.Location = new System.Drawing.Point(40, 150);
            this.textBoxPasswordAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPasswordAdmin.Name = "textBoxPasswordAdmin";
            this.textBoxPasswordAdmin.Size = new System.Drawing.Size(244, 29);
            this.textBoxPasswordAdmin.TabIndex = 32;
            // 
            // textBoxUsernameAdmin
            // 
            this.textBoxUsernameAdmin.Location = new System.Drawing.Point(40, 70);
            this.textBoxUsernameAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsernameAdmin.Name = "textBoxUsernameAdmin";
            this.textBoxUsernameAdmin.Size = new System.Drawing.Size(244, 29);
            this.textBoxUsernameAdmin.TabIndex = 31;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUser.Location = new System.Drawing.Point(47, 52);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(100, 47);
            this.buttonAddUser.TabIndex = 30;
            this.buttonAddUser.Text = "Add";
            this.buttonAddUser.UseMnemonic = false;
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // groupBoxAdmin
            // 
            this.groupBoxAdmin.Controls.Add(this.passwordLabel);
            this.groupBoxAdmin.Controls.Add(this.nameLabel);
            this.groupBoxAdmin.Controls.Add(this.textBoxPasswordAdmin);
            this.groupBoxAdmin.Controls.Add(this.textBoxUsernameAdmin);
            this.groupBoxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAdmin.Location = new System.Drawing.Point(365, 96);
            this.groupBoxAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAdmin.Name = "groupBoxAdmin";
            this.groupBoxAdmin.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAdmin.Size = new System.Drawing.Size(329, 215);
            this.groupBoxAdmin.TabIndex = 39;
            this.groupBoxAdmin.TabStop = false;
            this.groupBoxAdmin.Text = "Admin";
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.buttonClear);
            this.groupBoxOptions.Controls.Add(this.buttonDeleteUser);
            this.groupBoxOptions.Controls.Add(this.buttonUpdateUser);
            this.groupBoxOptions.Controls.Add(this.buttonAddUser);
            this.groupBoxOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOptions.Location = new System.Drawing.Point(817, 96);
            this.groupBoxOptions.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxOptions.Size = new System.Drawing.Size(208, 361);
            this.groupBoxOptions.TabIndex = 41;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // buttonClear
            // 
            this.buttonClear.Enabled = false;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(47, 296);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 41);
            this.buttonClear.TabIndex = 39;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseMnemonic = false;
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonHelpAdmin
            // 
            this.buttonHelpAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelpAdmin.Location = new System.Drawing.Point(16, 503);
            this.buttonHelpAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHelpAdmin.Name = "buttonHelpAdmin";
            this.buttonHelpAdmin.Size = new System.Drawing.Size(100, 36);
            this.buttonHelpAdmin.TabIndex = 42;
            this.buttonHelpAdmin.Text = "Help";
            this.buttonHelpAdmin.UseVisualStyleBackColor = true;
            this.buttonHelpAdmin.Click += new System.EventHandler(this.buttonHelpAdmin_Click);
            // 
            // buttonExitAdmin
            // 
            this.buttonExitAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitAdmin.Location = new System.Drawing.Point(925, 503);
            this.buttonExitAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExitAdmin.Name = "buttonExitAdmin";
            this.buttonExitAdmin.Size = new System.Drawing.Size(100, 36);
            this.buttonExitAdmin.TabIndex = 47;
            this.buttonExitAdmin.Text = "Exit";
            this.buttonExitAdmin.UseVisualStyleBackColor = true;
            this.buttonExitAdmin.Click += new System.EventHandler(this.buttonExitAdmin_Click);
            // 
            // buttonBackAdmin
            // 
            this.buttonBackAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackAdmin.Location = new System.Drawing.Point(817, 503);
            this.buttonBackAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBackAdmin.Name = "buttonBackAdmin";
            this.buttonBackAdmin.Size = new System.Drawing.Size(100, 36);
            this.buttonBackAdmin.TabIndex = 48;
            this.buttonBackAdmin.Text = "Back";
            this.buttonBackAdmin.UseVisualStyleBackColor = true;
            this.buttonBackAdmin.Click += new System.EventHandler(this.buttonBackAdmin_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonBackAdmin);
            this.Controls.Add(this.buttonExitAdmin);
            this.Controls.Add(this.buttonHelpAdmin);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.groupBoxAdmin);
            this.Controls.Add(this.laberUsers);
            this.Controls.Add(this.comboBoxUsers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.groupBoxAdmin.ResumeLayout(false);
            this.groupBoxAdmin.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonUpdateUser;
        private System.Windows.Forms.Label laberUsers;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox textBoxPasswordAdmin;
        private System.Windows.Forms.TextBox textBoxUsernameAdmin;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.GroupBox groupBoxAdmin;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.Button buttonHelpAdmin;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.Button buttonExitAdmin;
        private System.Windows.Forms.Button buttonBackAdmin;
    }
}