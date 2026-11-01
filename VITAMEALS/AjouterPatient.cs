using MySql.Data.MySqlClient;

namespace VITAMEALS2
{
    public partial class AjouterPatient : Form
    {
        private MySqlConnection mySqlConnection;
        private String server;
        private String database;
        private String uid;
        private String password;
        public AjouterPatient()
        {
            InitializeComponent();
            server = "localhost";
            database = "hopital";
            uid = "root";
            password = "";
            string connexionS = "server=" + server + ";database=" + database + ";uid=" + uid + ";password=" + password;
            mySqlConnection = new MySqlConnection(connexionS);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Récupérer les données du formulaire
            string cin = textBox1CIN.Text.Trim();
            string nom = textBoxNOM.Text.Trim();
            string prenom = textBox3PRENOM.Text.Trim();
            DateTime dateNaissance = dateTimePicker1DNAIS.Value.Date;
            string tel = textBoxTel.Text.Trim();
            string adresse = richTextBox1adresse.Text.Trim();
            string numChambre = textBoxNumch.Text.Trim();
            string regime = textBoxregime.Text.Trim();
            string allergies = textBoxAllergie.Text.Trim();
            string statut = comboBoxstatut.SelectedItem?.ToString() ?? string.Empty;

            // Vérifier que tous les champs obligatoires sont remplis
            if (string.IsNullOrWhiteSpace(cin) || string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) ||
                string.IsNullOrWhiteSpace(tel) || string.IsNullOrWhiteSpace(adresse) || string.IsNullOrWhiteSpace(numChambre) ||
                string.IsNullOrWhiteSpace(regime) || string.IsNullOrWhiteSpace(statut))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vérifier que le CIN contient exactement 8 chiffres
            if (cin.Length != 8 || !cin.All(char.IsDigit))
            {
                MessageBox.Show("Le CIN doit contenir exactement 8 chiffres.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Connexion à la base de données
            string connexionS = "server=" + server + ";database=" + database + ";uid=" + uid + ";password=" + password;
            using (MySqlConnection mySqlConnection = new MySqlConnection(connexionS))
            {
                try
                {
                    mySqlConnection.Open();

                    // Requête d'insertion
                    string query = "INSERT INTO patients (cin, nom, prenom, date_naissance, tel, adresse, num_chambre, regime, allergies, statut) " +
                                   "VALUES (@cin, @nom, @prenom, @date_naissance, @tel, @adresse, @num_chambre, @regime, @allergies, @statut)";

                    using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
                    {
                        // Ajouter les paramètres
                        command.Parameters.AddWithValue("@cin", cin);
                        command.Parameters.AddWithValue("@nom", nom);
                        command.Parameters.AddWithValue("@prenom", prenom);
                        command.Parameters.AddWithValue("@date_naissance", dateNaissance);
                        command.Parameters.AddWithValue("@tel", tel);
                        command.Parameters.AddWithValue("@adresse", adresse);
                        command.Parameters.AddWithValue("@num_chambre", numChambre);
                        command.Parameters.AddWithValue("@regime", regime);
                        command.Parameters.AddWithValue("@allergies", allergies);
                        command.Parameters.AddWithValue("@statut", statut);

                        // Exécuter la commande
                        command.ExecuteNonQuery();
                        MessageBox.Show("Patient ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Réinitialiser les champs du formulaire
                        ResetForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de l'ajout du patient : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Méthode pour réinitialiser les champs du formulaire
        private void ResetForm()
        {
            textBox1CIN.Clear();
            textBoxNOM.Clear();
            textBox3PRENOM.Clear();
            dateTimePicker1DNAIS.Value = DateTime.Now;
            textBoxTel.Clear();
            richTextBox1adresse.Clear();
            textBoxNumch.Clear();
            textBoxregime.Clear();
            textBoxAllergie.Clear();
            comboBoxstatut.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            // Create an instance of the ListePatient form
            InterfaceAdministrateur listePatientForm = new InterfaceAdministrateur();

            // Set the ListePatient form to fill the parent form
            listePatientForm.TopLevel = false;
            listePatientForm.FormBorderStyle = FormBorderStyle.None;
            listePatientForm.Dock = DockStyle.Fill;

            // Add the ListePatient form to the InterfaceAdministrateur controls
            this.Controls.Add(listePatientForm);

            // Display the ListePatient form
            listePatientForm.Show();
        }
    }
}

