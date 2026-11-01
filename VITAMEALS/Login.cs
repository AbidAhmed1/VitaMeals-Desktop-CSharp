using MySql.Data.MySqlClient;

namespace VITAMEALS2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Mysqlconn = "server=127.0.0.1;user=root;database=hopital;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(Mysqlconn);
            string login = textboxlogin.Text.ToString();
            string Mdp = textboxmdp.Text.ToString();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(Mdp))
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return;
            }

            try
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(
                    "SELECT role FROM utilisateur WHERE nom = @nom AND mdp = @mdp",
                    mySqlConnection
                );
                mySqlCommand.Parameters.AddWithValue("@nom", login);
                mySqlCommand.Parameters.AddWithValue("@mdp", Mdp);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    string? roleFromDb = reader["role"]?.ToString();

                    switch (roleFromDb)
                    {
                        case "medecin":
                            MessageBox.Show("Connexion réussie en tant que Médecin");
                            this.Hide();
                            InterfaceMedecin medecinInterface = new InterfaceMedecin();
                            medecinInterface.Show();
                            break;

                        case "cuisinier":
                            MessageBox.Show("Connexion réussie en tant que Cuisinier");
                            this.Hide();
                            InterfaceCuisinier cuisinierInterface = new InterfaceCuisinier();
                            cuisinierInterface.Show();
                            break;

                        case "admin":
                            MessageBox.Show("Connexion réussie en tant qu'Admin");
                            this.Hide();
                            DashboardAdmin interfaceAdmin = new DashboardAdmin();
                            interfaceAdmin.Show();
                            break;

                        case "administrateur":
                            MessageBox.Show("Connexion réussie en tant qu'Administrateur");
                            this.Hide();
                            InterfaceAdministrateur interfaceAdministrateur = new InterfaceAdministrateur();
                            interfaceAdministrateur.Show();
                            break;

                        default:
                            MessageBox.Show("Rôle non reconnu");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
    }

}
