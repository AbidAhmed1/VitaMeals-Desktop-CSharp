using System.Data;
using MySql.Data.MySqlClient;

namespace VITAMEALS2
{
    public partial class InterfaceCuisinier : Form
    {
        private MySqlConnection mySqlConnection;
        private String server;
        private String database;
        private String uid;
        private String password;
        public string? idrepas { get; set; }
        public string? nomrepas { get; set; }
        public string? description { get; set; }
        public string? categorie { get; set; }
        public string? regime { get; set; }
        public int? quantite { get; set; }

        public InterfaceCuisinier()
        {
            InitializeComponent();

            server = "localhost";
            database = "hopital";
            uid = "root";
            password = "";
            string connexionS = "server=" + server + ";database=" + database + ";uid=" + uid + ";password=" + password;
            mySqlConnection = new MySqlConnection(connexionS);
            this.Load += ListePatient_Load;

        }

        private bool VerifConnexion()
        {
            try
            {
                mySqlConnection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message);
                return false;
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private bool CloseConnexion()
        {
            try
            {
                mySqlConnection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur de fermeture de la connexion : " + ex.Message);
                return false;
            }
        }
        private void ListePatient_Load(object sender, EventArgs e)
        {
            if (this.VerifConnexion())
            {
                try
                {
                    string query = "SELECT * FROM repas";
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
                    DataSet dataSet = new DataSet();
                    mySqlDataAdapter.Fill(dataSet);

                    if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dataSet.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("Aucune donnée trouvée dans la table 'repas'.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
                }
                finally
                {
                    this.CloseConnexion();
                }
            }
            else
            {
                MessageBox.Show("Connexion échouée !");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.VerifConnexion())
            {
                try
                {
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM repas", mySqlConnection);
                    DataSet dataSet = new DataSet();
                    mySqlDataAdapter.Fill(dataSet);
                    if (dataSet.Tables.Count > 0)
                    {
                        dataGridView1.DataSource = dataSet.Tables[0];

                        // Désactiver l'édition globale  
                        dataGridView1.ReadOnly = true;

                        // Désactiver l'édition pour les colonnes spécifiques  
                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            column.ReadOnly = true;
                        }

                        // Activer l'édition uniquement pour la colonne "statut"  
                        if (dataGridView1.Columns.Contains("statut"))
                        {
                            dataGridView1.Columns["statut"].ReadOnly = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aucune donnée trouvée dans la table 'patients'.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
                }
                finally
                {
                    this.CloseConnexion();
                }
            }
            else
            {
                MessageBox.Show("Connexion échouée !");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Clear existing controls in the InterfaceAdministrateur form
            this.Controls.Clear();

            // Create an instance of the ListePatient form
            Login listePatientForm = new Login();

            // Set the ListePatient form to fill the parent form
            listePatientForm.TopLevel = false;
            listePatientForm.FormBorderStyle = FormBorderStyle.None;
            listePatientForm.Dock = DockStyle.Fill;

            // Add the ListePatient form to the InterfaceAdministrateur controls
            this.Controls.Add(listePatientForm);

            // Display the ListePatient form
            listePatientForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (this.VerifConnexion())
            {
                try
                {
                    // Ouvrir explicitement la connexion
                    mySqlConnection.Open();

                    // Récupérer la date sélectionnée dans le DateTimePicker
                    DateTime selectedDate = dateTimePicker1.Value;

                    // Requête SQL pour calculer le total des quantités pour la date sélectionnée
                    string query = @"
                    SELECT SUM(quantite) AS TotalQuantite
                    FROM repas
                    WHERE DATE(date_ajout) = @SelectedDate"; // Remplacez 'date_ajout' par le nom réel de la colonne de date dans votre table

                    MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                    command.Parameters.AddWithValue("@SelectedDate", selectedDate.ToString("yyyy-MM-dd"));

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int totalQuantite = Convert.ToInt32(result);
                        label4.Text = totalQuantite.ToString(); // Afficher le total dans label4
                    }
                    else
                    {
                        label4.Text = "0"; // Si aucune donnée n'est trouvée, afficher 0
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du calcul des quantités : " + ex.Message);
                }
                finally
                {
                    // Fermer explicitement la connexion
                    this.CloseConnexion();
                }
            }
            else
            {
                MessageBox.Show("Connexion échouée !");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

