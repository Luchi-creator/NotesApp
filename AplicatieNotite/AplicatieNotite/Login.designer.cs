namespace AplicatieNotite
{
    partial class LoginForm
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
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.textBoxPasswordLogIn = new System.Windows.Forms.TextBox();
            this.textBoxUsernameLogIn = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.groupBoxLogIn = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(39, 121);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(97, 24);
            this.passwordLabel.TabIndex = 14;
            this.passwordLabel.Text = "Password:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(39, 41);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(102, 24);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "Username:";
            // 
            // textBoxPasswordLogIn
            // 
            this.textBoxPasswordLogIn.Location = new System.Drawing.Point(43, 146);
            this.textBoxPasswordLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPasswordLogIn.Name = "textBoxPasswordLogIn";
            this.textBoxPasswordLogIn.PasswordChar = '*';
            this.textBoxPasswordLogIn.Size = new System.Drawing.Size(244, 29);
            this.textBoxPasswordLogIn.TabIndex = 12;
            // 
            // textBoxUsernameLogIn
            // 
            this.textBoxUsernameLogIn.Location = new System.Drawing.Point(43, 66);
            this.textBoxUsernameLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsernameLogIn.Name = "textBoxUsernameLogIn";
            this.textBoxUsernameLogIn.Size = new System.Drawing.Size(244, 29);
            this.textBoxUsernameLogIn.TabIndex = 11;
            this.textBoxUsernameLogIn.TextChanged += new System.EventHandler(this.textBoxUserLogIn_TextChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(488, 362);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 34);
            this.buttonLogin.TabIndex = 10;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // groupBoxLogIn
            // 
            this.groupBoxLogIn.Controls.Add(this.passwordLabel);
            this.groupBoxLogIn.Controls.Add(this.nameLabel);
            this.groupBoxLogIn.Controls.Add(this.textBoxPasswordLogIn);
            this.groupBoxLogIn.Controls.Add(this.textBoxUsernameLogIn);
            this.groupBoxLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLogIn.Location = new System.Drawing.Point(372, 140);
            this.groupBoxLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxLogIn.Name = "groupBoxLogIn";
            this.groupBoxLogIn.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxLogIn.Size = new System.Drawing.Size(333, 202);
            this.groupBoxLogIn.TabIndex = 15;
            this.groupBoxLogIn.TabStop = false;
            this.groupBoxLogIn.Text = "User";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(951, 503);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 36);
            this.buttonExit.TabIndex = 16;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.Location = new System.Drawing.Point(16, 503);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(100, 36);
            this.buttonHelp.TabIndex = 43;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBoxLogIn);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.groupBoxLogIn.ResumeLayout(false);
            this.groupBoxLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox textBoxPasswordLogIn;
        private System.Windows.Forms.TextBox textBoxUsernameLogIn;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.GroupBox groupBoxLogIn;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonHelp;
    }
}