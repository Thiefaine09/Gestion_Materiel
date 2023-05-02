using GestionMatériel.DataAccess;
using GestionMatériel.Models;
using GestionMatériel.Utils;
using Microsoft.VisualBasic.ApplicationServices;

namespace GestionMatériel
{
    public partial class FormPricipale : Form
    {
        //DbContext
        ApplicationDbContext db = new ApplicationDbContext();
        //Email du client selectionné dans le listViewClient
        string SelectedEmail;



        public FormPricipale()
        {
            InitializeComponent();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            //fermeture de l'application
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (buttonConnexion.Text != "Deconnexion")
            {
                //affiche la boite de dialogue FormConnexion
                var Frm = new FormConnexion();
                //click sur le bouton Ok (si click sur le bouton annuler, ne rien faire
                if (Frm.ShowDialog() == DialogResult.OK)
                {
                    //recupère la string du champ Login
                    string Str = Frm.textBoxLogin.Text;
                    //cherche dans la table Utilisateur le login
                    var User = db.Utilisateur.SingleOrDefault(u => u.Login == Str);
                    //si l'utilisateur est trouvé
                    if (User != null)
                    {
                        //vérification du mot de passe
                        byte[] salt;
                        var PasswordTmp = new Password();
                        var StrPassword = PasswordTmp.HashPasword(User.Password, out salt);
                        //si le mot de passe est incorrecte affiche un message d'erreur
                        if (!PasswordTmp.VerifyPassword(User.Password, StrPassword, salt))
                        {
                            MessageBox.Show("Utilisateur : " + User.Login + " erreur de mot de passe", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            //initialise les variables globales
                            Global.Login = User.Login;
                            Global.Role = User.Role;
                            //affiche le login de la personne connecté
                            labelLogin.Text = "Bonjour " + User.Login;
                            buttonConnexion.Text = "Deconnexion";
                            //pour tous les utilisateurs
                            buttonClient.Enabled = true;
                            buttonMateriel.Enabled = true;
                            buttonIntervention.Enabled = true;
                            //affiche le bouton Administration si la variable Role = admin
                            if (Global.Role == "admin")
                            {
                                buttonAdministration.Visible = true;
                            }
                        }
                    }
                    //si l'utilisateur n'existe pas
                    else
                    {
                        MessageBox.Show("Utilisateur : " + Str + " n'existe pas", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                //
                Global.Login = "";
                Global.Role = "";
                //
                panelClient.Visible = false;
                //
                labelLogin.Text = "";
                buttonClient.Enabled = false;
                buttonMateriel.Enabled = false;
                buttonIntervention.Enabled = false;
                buttonAdministration.Visible = false;
                buttonConnexion.Text = "Connexion";
            }
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            //affiche le panel
            panelClient.Visible = true;
            //efface la listViewClient
            listViewClient.Items.Clear();
            //recherche les clients dans la base
            var Clients = db.Client.ToList();
            //affiche les clients dans le listViewClient
            if (Clients.Count > 0)
            {
                foreach (var Client in Clients)
                {
                    ListViewItem ClientItem = new ListViewItem(Client.Nom);
                    ClientItem.SubItems.Add(Client.Prenom);
                    ClientItem.SubItems.Add(Client.Adresse);
                    ClientItem.SubItems.Add(Client.CodePostal);
                    ClientItem.SubItems.Add(Client.Ville);
                    ClientItem.SubItems.Add(Client.Email);
                    ClientItem.SubItems.Add(Client.Telephone);
                    listViewClient.Items.Add(ClientItem);
                }
            }
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection index = listViewClient.SelectedIndices;
            //
            foreach (int i in index)
            {
                //recherche par email
                SelectedEmail = listViewClient.Items[i].SubItems[5].Text;
            }
        }

        private void buttonClientAjouter_Click(object sender, EventArgs e)
        {
            //affiche la boite de dialogue FormConnexion
            var Frm = new FormClient();
            //click sur le bouton Ok (si click sur le bouton annuler, ne rien faire
            if (Frm.ShowDialog() == DialogResult.OK)
            {
                //creation d'un obj Client
                Client ClientTmp = new Client();
                //assigne les champs d formulaire a l'obj Client
                ClientTmp.Nom = Frm.textBoxNom.Text;
                ClientTmp.Prenom = Frm.textBoxPrenom.Text;
                ClientTmp.Adresse = Frm.textBoxAdresse.Text;
                ClientTmp.CodePostal = Frm.textBoxCodePostal.Text;
                ClientTmp.Ville = Frm.textBoxVille.Text;
                ClientTmp.Email = Frm.textBoxEmail.Text;
                ClientTmp.Telephone = Frm.textBoxTelephone.Text;
                //ajoute le client dans la base
                db.Client.Add(ClientTmp);
                db.SaveChanges();
                //Ajoute les données a la listViewClient
                ListViewItem ClientItem = new ListViewItem(ClientTmp.Nom);
                ClientItem.SubItems.Add(ClientTmp.Prenom);
                ClientItem.SubItems.Add(ClientTmp.Adresse);
                ClientItem.SubItems.Add(ClientTmp.CodePostal);
                ClientItem.SubItems.Add(ClientTmp.Ville);
                ClientItem.SubItems.Add(ClientTmp.Email);
                ClientItem.SubItems.Add(ClientTmp.Telephone);
                listViewClient.Items.Add(ClientItem);
            }
        }

        private void buttonMateriel_Click(object sender, EventArgs e)
        {
            panelClient.Visible = false;
        }

        private void buttonIntervention_Click(object sender, EventArgs e)
        {
            panelClient.Visible = false;
        }

        private void buttonAdministration_Click(object sender, EventArgs e)
        {
            panelClient.Visible = false;
        }

        private void buttonClientModifier_Click(object sender, EventArgs e)
        {
            if (SelectedEmail != "")
            {
                //affiche la boite de dialogue FormConnexion
                var Frm = new FormClient();
                //
                var ClientTmp = db.Client.SingleOrDefault(c => c.Email == SelectedEmail);
                if (ClientTmp != null)
                {
                    //initialise les champs
                    Frm.textBoxNom.Text = ClientTmp.Nom;
                    Frm.textBoxPrenom.Text = ClientTmp.Prenom;
                    Frm.textBoxAdresse.Text = ClientTmp.Adresse;
                    Frm.textBoxCodePostal.Text = ClientTmp.CodePostal;
                    Frm.textBoxVille.Text = ClientTmp.Ville;
                    Frm.textBoxEmail.Text = ClientTmp.Email;
                    Frm.textBoxTelephone.Text = ClientTmp.Telephone;
                    //click sur le bouton Ok (si click sur le bouton annuler, ne rien faire
                    if (Frm.ShowDialog() == DialogResult.OK)
                    {
                        ClientTmp.Nom = Frm.textBoxNom.Text;
                        ClientTmp.Prenom = Frm.textBoxPrenom.Text;
                        ClientTmp.Adresse = Frm.textBoxAdresse.Text;
                        ClientTmp.CodePostal = Frm.textBoxCodePostal.Text;
                        ClientTmp.Ville = Frm.textBoxVille.Text;
                        ClientTmp.Email = Frm.textBoxEmail.Text;
                        ClientTmp.Telephone = Frm.textBoxTelephone.Text;
                        //sauvegarde des modifications dans la base
                        db.Client.Update(ClientTmp);
                        db.SaveChanges();

                        //mise a jour des données dans le listViewClient
                        ListView.SelectedIndexCollection index = listViewClient.SelectedIndices;
                        foreach (int i in index)
                        {
                            //recherche par email
                            listViewClient.Items[i].SubItems[0].Text = ClientTmp.Nom;
                            listViewClient.Items[i].SubItems[1].Text = ClientTmp.Prenom;
                            listViewClient.Items[i].SubItems[2].Text = ClientTmp.Adresse;
                            listViewClient.Items[i].SubItems[3].Text = ClientTmp.CodePostal;
                            listViewClient.Items[i].SubItems[4].Text = ClientTmp.Ville;
                            listViewClient.Items[i].SubItems[5].Text = ClientTmp.Email;
                            listViewClient.Items[i].SubItems[6].Text = ClientTmp.Telephone;
                        }
                    }
                }
            }
        }

        private void buttonClientSupprimer_Click(object sender, EventArgs e)
        {
            if (SelectedEmail != "")
            {
                DialogResult = MessageBox.Show("Utilisateur : " + SelectedEmail + " n'existe pas", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    //suppression de la base
                    var ClientTmp = db.Client.SingleOrDefault(c => c.Email == SelectedEmail);
                    if (ClientTmp != null)
                    {
                        db.Client.Remove(ClientTmp);
                        db.SaveChanges();
                    }
                    //suppresion du listViewClient
                    ListView.SelectedIndexCollection index = listViewClient.SelectedIndices;
                    foreach (int i in index)
                    {
                        listViewClient.Items.RemoveAt(i);
                    }
                }
            }
        }
    }
}