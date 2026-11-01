using MySql.Data.MySqlClient;

namespace VITAMEALS2
{
    public partial class DashboardAdmin : Form
    {
        private MySqlConnection mySqlConnection;
        private String server;
        private String database;
        private String uid;
        private String password;
        public DashboardAdmin()
        {
            InitializeComponent();
            server = "localhost";
            database = "hopital";
            uid = "root";
            password = "";
            string connexionS = "server=" + server + ";database=" + database + ";uid=" + uid + ";password=" + password;
            mySqlConnection = new MySqlConnection(connexionS);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=localhost;database=hopital;uid=root;password=";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Requête pour le nombre d'utilisateurs
                    string queryUtilisateurs = "SELECT COUNT(*) AS count FROM utilisateur";
                    MySqlCommand commandUtilisateurs = new MySqlCommand(queryUtilisateurs, connection);
                    int nombreUtilisateurs = Convert.ToInt32(commandUtilisateurs.ExecuteScalar());
                    label5.Text = $"{nombreUtilisateurs:N0}";

                    // Requête pour le nombre de patients
                    string queryPatients = "SELECT COUNT(*) AS count FROM patients";
                    MySqlCommand commandPatients = new MySqlCommand(queryPatients, connection);
                    int nombrePatients = Convert.ToInt32(commandPatients.ExecuteScalar());
                    label6.Text = $"{nombrePatients:N0}";

                    // Requête pour le nombre de réclamations
                    string queryReclamations = "SELECT COUNT(*) AS count FROM reclamation";
                    MySqlCommand commandReclamations = new MySqlCommand(queryReclamations, connection);
                    int nombreReclamations = Convert.ToInt32(commandReclamations.ExecuteScalar());
                    label7.Text = $"{nombreReclamations:N0}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'actualisation des données : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
