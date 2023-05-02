namespace GestionMatériel
{
    partial class FormClient
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
            panel1 = new Panel();
            buttonOk = new Button();
            buttonAnnuler = new Button();
            labelNom = new Label();
            textBoxNom = new TextBox();
            textBoxPrenom = new TextBox();
            labelPrenom = new Label();
            textBoxAdresse = new TextBox();
            labelAdresse = new Label();
            textBoxCodePostal = new TextBox();
            labelCodePostal = new Label();
            textBoxVille = new TextBox();
            labelVille = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxTelephone = new TextBox();
            labelTelephone = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonOk);
            panel1.Controls.Add(buttonAnnuler);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 564);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 92);
            panel1.TabIndex = 3;
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.FlatStyle = FlatStyle.Flat;
            buttonOk.Location = new Point(141, 14);
            buttonOk.Name = "buttonOk";
            buttonOk.Padding = new Padding(10);
            buttonOk.Size = new Size(204, 66);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.DialogResult = DialogResult.Cancel;
            buttonAnnuler.FlatStyle = FlatStyle.Flat;
            buttonAnnuler.Location = new Point(351, 14);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Padding = new Padding(10);
            buttonAnnuler.Size = new Size(204, 66);
            buttonAnnuler.TabIndex = 0;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = true;
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(77, 34);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(76, 30);
            labelNom.TabIndex = 4;
            labelNom.Text = "Nom : ";
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(77, 67);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(414, 35);
            textBoxNom.TabIndex = 5;
            // 
            // textBoxPrenom
            // 
            textBoxPrenom.Location = new Point(77, 139);
            textBoxPrenom.Name = "textBoxPrenom";
            textBoxPrenom.Size = new Size(414, 35);
            textBoxPrenom.TabIndex = 7;
            // 
            // labelPrenom
            // 
            labelPrenom.AutoSize = true;
            labelPrenom.Location = new Point(77, 106);
            labelPrenom.Name = "labelPrenom";
            labelPrenom.Size = new Size(102, 30);
            labelPrenom.TabIndex = 6;
            labelPrenom.Text = "Prenom : ";
            // 
            // textBoxAdresse
            // 
            textBoxAdresse.Location = new Point(77, 211);
            textBoxAdresse.Name = "textBoxAdresse";
            textBoxAdresse.Size = new Size(414, 35);
            textBoxAdresse.TabIndex = 9;
            // 
            // labelAdresse
            // 
            labelAdresse.AutoSize = true;
            labelAdresse.Location = new Point(77, 178);
            labelAdresse.Name = "labelAdresse";
            labelAdresse.Size = new Size(103, 30);
            labelAdresse.TabIndex = 8;
            labelAdresse.Text = "Adresse : ";
            // 
            // textBoxCodePostal
            // 
            textBoxCodePostal.Location = new Point(77, 283);
            textBoxCodePostal.Name = "textBoxCodePostal";
            textBoxCodePostal.Size = new Size(414, 35);
            textBoxCodePostal.TabIndex = 11;
            // 
            // labelCodePostal
            // 
            labelCodePostal.AutoSize = true;
            labelCodePostal.Location = new Point(77, 250);
            labelCodePostal.Name = "labelCodePostal";
            labelCodePostal.Size = new Size(139, 30);
            labelCodePostal.TabIndex = 10;
            labelCodePostal.Text = "Code Postal : ";
            // 
            // textBoxVille
            // 
            textBoxVille.Location = new Point(77, 355);
            textBoxVille.Name = "textBoxVille";
            textBoxVille.Size = new Size(414, 35);
            textBoxVille.TabIndex = 13;
            // 
            // labelVille
            // 
            labelVille.AutoSize = true;
            labelVille.Location = new Point(77, 321);
            labelVille.Name = "labelVille";
            labelVille.Size = new Size(69, 30);
            labelVille.TabIndex = 12;
            labelVille.Text = "Ville : ";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(77, 427);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(414, 35);
            textBoxEmail.TabIndex = 15;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(77, 394);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(81, 30);
            labelEmail.TabIndex = 14;
            labelEmail.Text = "EMail : ";
            // 
            // textBoxTelephone
            // 
            textBoxTelephone.Location = new Point(77, 499);
            textBoxTelephone.Name = "textBoxTelephone";
            textBoxTelephone.Size = new Size(414, 35);
            textBoxTelephone.TabIndex = 17;
            // 
            // labelTelephone
            // 
            labelTelephone.AutoSize = true;
            labelTelephone.Location = new Point(77, 466);
            labelTelephone.Name = "labelTelephone";
            labelTelephone.Size = new Size(125, 30);
            labelTelephone.TabIndex = 18;
            labelTelephone.Text = "Téléphone : ";
            // 
            // FormClient
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 656);
            Controls.Add(labelTelephone);
            Controls.Add(textBoxTelephone);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(textBoxVille);
            Controls.Add(labelVille);
            Controls.Add(textBoxCodePostal);
            Controls.Add(labelCodePostal);
            Controls.Add(textBoxAdresse);
            Controls.Add(labelAdresse);
            Controls.Add(textBoxPrenom);
            Controls.Add(labelPrenom);
            Controls.Add(textBoxNom);
            Controls.Add(labelNom);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonOk;
        private Button buttonAnnuler;
        private Label labelNom;
        private Label labelPrenom;
        private Label labelAdresse;
        private Label labelCodePostal;
        private Label labelVille;
        private Label labelEmail;
        private Label labelTelephone;
        public TextBox textBoxNom;
        public TextBox textBoxPrenom;
        public TextBox textBoxAdresse;
        public TextBox textBoxCodePostal;
        public TextBox textBoxVille;
        public TextBox textBoxEmail;
        public TextBox textBoxTelephone;
    }
}