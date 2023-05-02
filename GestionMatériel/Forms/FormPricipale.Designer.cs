namespace GestionMatériel
{
    partial class FormPricipale
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            applicationDbContextBindingSource = new BindingSource(components);
            applicationDbContextBindingSource1 = new BindingSource(components);
            applicationDbContextBindingSource3 = new BindingSource(components);
            applicationDbContextBindingSource2 = new BindingSource(components);
            panelBottom = new Panel();
            buttonQuitter = new Button();
            buttonConnexion = new Button();
            buttonClient = new Button();
            buttonMateriel = new Button();
            buttonIntervention = new Button();
            buttonAdministration = new Button();
            labelLogin = new Label();
            panelTop = new Panel();
            panelClient = new Panel();
            listViewClient = new ListView();
            Nom = new ColumnHeader();
            Prénom = new ColumnHeader();
            Adresse = new ColumnHeader();
            CodePostal = new ColumnHeader();
            Ville = new ColumnHeader();
            Email = new ColumnHeader();
            Téléphone = new ColumnHeader();
            panelClientBouton = new Panel();
            buttonClientSupprimer = new Button();
            buttonClientModifier = new Button();
            buttonClientAjouter = new Button();
            ((System.ComponentModel.ISupportInitialize)applicationDbContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)applicationDbContextBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)applicationDbContextBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)applicationDbContextBindingSource2).BeginInit();
            panelBottom.SuspendLayout();
            panelTop.SuspendLayout();
            panelClient.SuspendLayout();
            panelClientBouton.SuspendLayout();
            SuspendLayout();
            // 
            // applicationDbContextBindingSource
            // 
            applicationDbContextBindingSource.DataSource = typeof(DataAccess.ApplicationDbContext);
            // 
            // applicationDbContextBindingSource1
            // 
            applicationDbContextBindingSource1.DataSource = typeof(DataAccess.ApplicationDbContext);
            // 
            // applicationDbContextBindingSource3
            // 
            applicationDbContextBindingSource3.DataSource = typeof(DataAccess.ApplicationDbContext);
            // 
            // applicationDbContextBindingSource2
            // 
            applicationDbContextBindingSource2.DataSource = typeof(DataAccess.ApplicationDbContext);
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonQuitter);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 1044);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1576, 92);
            panelBottom.TabIndex = 1;
            // 
            // buttonQuitter
            // 
            buttonQuitter.FlatStyle = FlatStyle.Flat;
            buttonQuitter.Location = new Point(1362, 14);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Padding = new Padding(10);
            buttonQuitter.Size = new Size(204, 66);
            buttonQuitter.TabIndex = 0;
            buttonQuitter.Text = "Quitter";
            buttonQuitter.UseVisualStyleBackColor = true;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // buttonConnexion
            // 
            buttonConnexion.FlatStyle = FlatStyle.Flat;
            buttonConnexion.Location = new Point(1362, 12);
            buttonConnexion.Name = "buttonConnexion";
            buttonConnexion.Size = new Size(204, 66);
            buttonConnexion.TabIndex = 0;
            buttonConnexion.Text = "Connexion";
            buttonConnexion.UseVisualStyleBackColor = true;
            buttonConnexion.Click += buttonLogin_Click;
            // 
            // buttonClient
            // 
            buttonClient.Enabled = false;
            buttonClient.FlatStyle = FlatStyle.Flat;
            buttonClient.Location = new Point(12, 12);
            buttonClient.Name = "buttonClient";
            buttonClient.Padding = new Padding(10);
            buttonClient.Size = new Size(204, 66);
            buttonClient.TabIndex = 1;
            buttonClient.Text = "Client";
            buttonClient.UseVisualStyleBackColor = true;
            buttonClient.Click += buttonClient_Click;
            // 
            // buttonMateriel
            // 
            buttonMateriel.Enabled = false;
            buttonMateriel.FlatStyle = FlatStyle.Flat;
            buttonMateriel.Location = new Point(222, 12);
            buttonMateriel.Name = "buttonMateriel";
            buttonMateriel.Padding = new Padding(10);
            buttonMateriel.Size = new Size(204, 66);
            buttonMateriel.TabIndex = 2;
            buttonMateriel.Text = "Materiel";
            buttonMateriel.UseVisualStyleBackColor = true;
            buttonMateriel.Click += buttonMateriel_Click;
            // 
            // buttonIntervention
            // 
            buttonIntervention.Enabled = false;
            buttonIntervention.FlatStyle = FlatStyle.Flat;
            buttonIntervention.Location = new Point(432, 12);
            buttonIntervention.Name = "buttonIntervention";
            buttonIntervention.Padding = new Padding(10);
            buttonIntervention.Size = new Size(204, 66);
            buttonIntervention.TabIndex = 3;
            buttonIntervention.Text = "Intervention";
            buttonIntervention.UseVisualStyleBackColor = true;
            buttonIntervention.Click += buttonIntervention_Click;
            // 
            // buttonAdministration
            // 
            buttonAdministration.FlatStyle = FlatStyle.Flat;
            buttonAdministration.Location = new Point(642, 12);
            buttonAdministration.Name = "buttonAdministration";
            buttonAdministration.Padding = new Padding(10);
            buttonAdministration.Size = new Size(204, 66);
            buttonAdministration.TabIndex = 4;
            buttonAdministration.Text = "Administration";
            buttonAdministration.UseVisualStyleBackColor = true;
            buttonAdministration.Visible = false;
            buttonAdministration.Click += buttonAdministration_Click;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(1015, 30);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(0, 30);
            labelLogin.TabIndex = 5;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelLogin);
            panelTop.Controls.Add(buttonAdministration);
            panelTop.Controls.Add(buttonIntervention);
            panelTop.Controls.Add(buttonMateriel);
            panelTop.Controls.Add(buttonClient);
            panelTop.Controls.Add(buttonConnexion);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1576, 92);
            panelTop.TabIndex = 0;
            // 
            // panelClient
            // 
            panelClient.Controls.Add(listViewClient);
            panelClient.Controls.Add(panelClientBouton);
            panelClient.Dock = DockStyle.Fill;
            panelClient.Location = new Point(0, 92);
            panelClient.Name = "panelClient";
            panelClient.Size = new Size(1576, 952);
            panelClient.TabIndex = 2;
            panelClient.Visible = false;
            // 
            // listViewClient
            // 
            listViewClient.Columns.AddRange(new ColumnHeader[] { Nom, Prénom, Adresse, CodePostal, Ville, Email, Téléphone });
            listViewClient.Dock = DockStyle.Fill;
            listViewClient.FullRowSelect = true;
            listViewClient.GridLines = true;
            listViewClient.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewClient.Location = new Point(0, 0);
            listViewClient.Name = "listViewClient";
            listViewClient.Size = new Size(1353, 952);
            listViewClient.TabIndex = 1;
            listViewClient.UseCompatibleStateImageBehavior = false;
            listViewClient.View = View.Details;
            listViewClient.SelectedIndexChanged += listViewClient_SelectedIndexChanged;
            // 
            // Nom
            // 
            Nom.Text = "Nom";
            Nom.Width = 200;
            // 
            // Prénom
            // 
            Prénom.Text = "Prénom";
            Prénom.Width = 200;
            // 
            // Adresse
            // 
            Adresse.Text = "Adresse";
            Adresse.Width = 250;
            // 
            // CodePostal
            // 
            CodePostal.Text = "C. postal";
            CodePostal.Width = 100;
            // 
            // Ville
            // 
            Ville.Text = "Ville";
            Ville.Width = 250;
            // 
            // Email
            // 
            Email.Text = "Email";
            Email.Width = 250;
            // 
            // Téléphone
            // 
            Téléphone.Text = "Téléphone";
            Téléphone.Width = 150;
            // 
            // panelClientBouton
            // 
            panelClientBouton.Controls.Add(buttonClientSupprimer);
            panelClientBouton.Controls.Add(buttonClientModifier);
            panelClientBouton.Controls.Add(buttonClientAjouter);
            panelClientBouton.Dock = DockStyle.Right;
            panelClientBouton.Location = new Point(1353, 0);
            panelClientBouton.Name = "panelClientBouton";
            panelClientBouton.Size = new Size(223, 952);
            panelClientBouton.TabIndex = 0;
            // 
            // buttonClientSupprimer
            // 
            buttonClientSupprimer.FlatStyle = FlatStyle.Flat;
            buttonClientSupprimer.Location = new Point(10, 177);
            buttonClientSupprimer.Name = "buttonClientSupprimer";
            buttonClientSupprimer.Size = new Size(204, 66);
            buttonClientSupprimer.TabIndex = 3;
            buttonClientSupprimer.Text = "Supprimer";
            buttonClientSupprimer.UseVisualStyleBackColor = true;
            buttonClientSupprimer.Click += buttonClientSupprimer_Click;
            // 
            // buttonClientModifier
            // 
            buttonClientModifier.FlatStyle = FlatStyle.Flat;
            buttonClientModifier.Location = new Point(10, 97);
            buttonClientModifier.Name = "buttonClientModifier";
            buttonClientModifier.Size = new Size(204, 66);
            buttonClientModifier.TabIndex = 2;
            buttonClientModifier.Text = "Modifier";
            buttonClientModifier.UseVisualStyleBackColor = true;
            buttonClientModifier.Click += buttonClientModifier_Click;
            // 
            // buttonClientAjouter
            // 
            buttonClientAjouter.FlatStyle = FlatStyle.Flat;
            buttonClientAjouter.Location = new Point(10, 17);
            buttonClientAjouter.Name = "buttonClientAjouter";
            buttonClientAjouter.Size = new Size(204, 66);
            buttonClientAjouter.TabIndex = 1;
            buttonClientAjouter.Text = "Ajouter";
            buttonClientAjouter.UseVisualStyleBackColor = true;
            buttonClientAjouter.Click += buttonClientAjouter_Click;
            // 
            // FormPricipale
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1576, 1136);
            Controls.Add(panelClient);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormPricipale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion Matériels";
            ((System.ComponentModel.ISupportInitialize)applicationDbContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)applicationDbContextBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)applicationDbContextBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)applicationDbContextBindingSource2).EndInit();
            panelBottom.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelClient.ResumeLayout(false);
            panelClientBouton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private BindingSource applicationDbContextBindingSource;
        private BindingSource applicationDbContextBindingSource1;
        private BindingSource applicationDbContextBindingSource3;
        private BindingSource applicationDbContextBindingSource2;
        private Panel panelBottom;
        private Button buttonQuitter;
        private Button buttonConnexion;
        private Button buttonClient;
        private Button buttonMateriel;
        private Button buttonIntervention;
        private Button buttonAdministration;
        private Label labelLogin;
        private Panel panelTop;
        private Panel panelClient;
        private ListView listViewClient;
        private ColumnHeader Nom;
        private ColumnHeader Prénom;
        private ColumnHeader Adresse;
        private ColumnHeader CodePostal;
        private ColumnHeader Ville;
        private ColumnHeader Email;
        private ColumnHeader Téléphone;
        private Panel panelClientBouton;
        private Button buttonClientSupprimer;
        private Button buttonClientModifier;
        private Button buttonClientAjouter;
    }
}