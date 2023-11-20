namespace EjercicioIntegrador2_YouTify
{
    partial class LoginPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlCredenciales = new Panel();
            lblError = new Label();
            btnSignUp = new Button();
            btnLogin = new Button();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            lblLogin = new Label();
            lblLogo = new Label();
            pnlCredenciales.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCredenciales
            // 
            pnlCredenciales.BorderStyle = BorderStyle.FixedSingle;
            pnlCredenciales.Controls.Add(lblError);
            pnlCredenciales.Controls.Add(btnSignUp);
            pnlCredenciales.Controls.Add(btnLogin);
            pnlCredenciales.Controls.Add(tbPassword);
            pnlCredenciales.Controls.Add(tbUsername);
            pnlCredenciales.Location = new Point(37, 160);
            pnlCredenciales.Name = "pnlCredenciales";
            pnlCredenciales.Size = new Size(305, 352);
            pnlCredenciales.TabIndex = 6;
            // 
            // lblError
            // 
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(29, 194);
            lblError.Name = "lblError";
            lblError.Size = new Size(256, 63);
            lblError.TabIndex = 7;
            lblError.Text = "Username or password was incorrect. Try again.";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            lblError.Visible = false;
            // 
            // btnSignUp
            // 
            btnSignUp.ForeColor = Color.Black;
            btnSignUp.Location = new Point(113, 295);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(75, 23);
            btnSignUp.TabIndex = 4;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnLogin
            // 
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(113, 260);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbPassword
            // 
            tbPassword.ForeColor = Color.Black;
            tbPassword.Location = new Point(48, 156);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.PlaceholderText = "Password";
            tbPassword.Size = new Size(209, 23);
            tbPassword.TabIndex = 2;
            // 
            // tbUsername
            // 
            tbUsername.ForeColor = Color.Black;
            tbUsername.Location = new Point(48, 88);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Username";
            tbUsername.Size = new Size(209, 23);
            tbUsername.TabIndex = 1;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Roboto", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.Black;
            lblLogin.Location = new Point(19, 76);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(341, 48);
            lblLogin.TabIndex = 5;
            lblLogin.Text = "Ingrese su cuenta";
            // 
            // lblLogo
            // 
            lblLogo.ImageAlign = ContentAlignment.TopLeft;
            lblLogo.ImageIndex = 0;
            lblLogo.Location = new Point(134, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(107, 78);
            lblLogo.TabIndex = 4;
            // 
            // LoginPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlCredenciales);
            Controls.Add(lblLogin);
            Controls.Add(lblLogo);
            ForeColor = Color.White;
            Name = "LoginPanel";
            Size = new Size(393, 524);
            pnlCredenciales.ResumeLayout(false);
            pnlCredenciales.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCredenciales;
        private Button btnSignUp;
        private Button btnLogin;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private Label lblLogin;
        private Label lblLogo;
        private Label lblError;
    }
}
