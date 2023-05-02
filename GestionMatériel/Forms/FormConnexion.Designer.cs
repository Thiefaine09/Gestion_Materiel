namespace GestionMatériel
{
    partial class FormConnexion
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
            buttonQuitter = new Button();
            panelBottom = new Panel();
            panel1 = new Panel();
            buttonOk = new Button();
            buttonAnnuler = new Button();
            labelLogin = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            panelBottom.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonQuitter
            // 
            buttonQuitter.FlatStyle = FlatStyle.Flat;
            buttonQuitter.Location = new Point(1408, 14);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Padding = new Padding(10);
            buttonQuitter.Size = new Size(204, 66);
            buttonQuitter.TabIndex = 0;
            buttonQuitter.Text = "Quitter";
            buttonQuitter.UseVisualStyleBackColor = true;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(panel1);
            panelBottom.Controls.Add(buttonQuitter);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 358);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(684, 92);
            panelBottom.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonOk);
            panel1.Controls.Add(buttonAnnuler);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 92);
            panel1.TabIndex = 2;
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.FlatStyle = FlatStyle.Flat;
            buttonOk.Location = new Point(254, 14);
            buttonOk.Name = "buttonOk";
            buttonOk.Padding = new Padding(10);
            buttonOk.Size = new Size(204, 66);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.DialogResult = DialogResult.Cancel;
            buttonAnnuler.FlatStyle = FlatStyle.Flat;
            buttonAnnuler.Location = new Point(464, 14);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Padding = new Padding(10);
            buttonAnnuler.Size = new Size(204, 66);
            buttonAnnuler.TabIndex = 0;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(147, 82);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(142, 30);
            labelLogin.TabIndex = 3;
            labelLogin.Text = "Adresse mail :";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(147, 131);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(401, 35);
            textBoxLogin.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(147, 245);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(401, 35);
            textBoxPassword.TabIndex = 6;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(147, 196);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(149, 30);
            labelPassword.TabIndex = 5;
            labelPassword.Text = "Mot de passe :";
            // 
            // FormConnexion
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 450);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(labelLogin);
            Controls.Add(panelBottom);
            Name = "FormConnexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connexion";
            panelBottom.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonQuitter;
        private Panel panelBottom;
        private Panel panel1;
        private Button buttonOk;
        private Button buttonAnnuler;
        private Label labelLogin;
        private Label labelPassword;
        public TextBox textBoxLogin;
        public TextBox textBoxPassword;
    }
}