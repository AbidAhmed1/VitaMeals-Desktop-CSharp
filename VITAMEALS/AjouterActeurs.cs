using MySql.Data.MySqlClient;

namespace VITAMEALS2
{
    public partial class AjouterActeurs : Form
    {
        public AjouterActeurs()
        {
            InitializeComponent();
            InitializeFormComponents();
        }

        private void InitializeFormComponents()
        {
            // Calculate center positions
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            int controlWidth = 200;
            int controlHeight = 30;
            int startX = (formWidth - controlWidth) / 2;
            int spacing = 20;

            // Label and TextBox for Nom  
            Label lblNom = new Label { Text = "Nom:", Location = new System.Drawing.Point(startX, formHeight / 2 - 2 * (controlHeight + spacing)) };
            TextBox txtNom = new TextBox { Name = "txtNom", Location = new System.Drawing.Point(startX, formHeight / 2 - 2 * (controlHeight + spacing) + controlHeight), Width = controlWidth };

            // Label and TextBox for Mot de passe  
            Label lblMdp = new Label { Text = "Mot de passe:", Location = new System.Drawing.Point(startX, formHeight / 2 - (controlHeight + spacing)) };
            TextBox txtMdp = new TextBox { Name = "txtMdp", Location = new System.Drawing.Point(startX, formHeight / 2 - (controlHeight + spacing) + controlHeight), Width = controlWidth, PasswordChar = '*' };

            // Label and ComboBox for Role  
            Label lblRole = new Label { Text = "Rôle:", Location = new System.Drawing.Point(startX, formHeight / 2) };
            ComboBox cmbRole = new ComboBox
            {
                Name = "cmbRole",
                Location = new System.Drawing.Point(startX, formHeight / 2 + controlHeight),
                Width = controlWidth,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbRole.Items.AddRange(new string[] { "Médecin", "Administrateur", "Cuisinier" });

            // Label and TextBox for CIN  
            Label lblCin = new Label { Text = "CIN:", Location = new System.Drawing.Point(startX, formHeight / 2 + (controlHeight + spacing)) };
            TextBox txtCin = new TextBox { Name = "txtCin", Location = new System.Drawing.Point(startX, formHeight / 2 + (controlHeight + spacing) + controlHeight), Width = controlWidth };

            // Button to Submit  
            Button btnSubmit = new Button
            {
                Text = "Ajouter",
                Location = new System.Drawing.Point(startX, formHeight / 2 + 3 * (controlHeight + spacing)),
                Width = controlWidth
            };
            btnSubmit.Click += (sender, e) => AjouterUtilisateur(txtNom.Text, txtMdp.Text, cmbRole.SelectedItem?.ToString(), txtCin.Text);

            // Add controls to the form  
            this.Controls.Add(lblNom);
            this.Controls.Add(txtNom);
            this.Controls.Add(lblMdp);
            this.Controls.Add(txtMdp);
            this.Controls.Add(lblRole);
            this.Controls.Add(cmbRole);
            this.Controls.Add(lblCin);
            this.Controls.Add(txtCin);
            this.Controls.Add(btnSubmit);
        }

        private void AjouterUtilisateur(string nom, string mdp, string role, string cin)
        {
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(mdp) || string.IsNullOrWhiteSpace(role) || string.IsNullOrWhiteSpace(cin))
            {
                MessageBox.Show("Tous les champs sont obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string Mysqlconn = "server=127.0.0.1;user=root;database=hopital;password=";
                using (MySqlConnection mySqlConnection = new MySqlConnection(Mysqlconn))
                {
                    mySqlConnection.Open();
                    string query = "INSERT INTO Utilisateur (nom, mdp, role, cin) VALUES (@nom, @mdp, @role, @cin)";
                    using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
                    {
                        command.Parameters.AddWithValue("@nom", nom);
                        command.Parameters.AddWithValue("@mdp", mdp);
                        command.Parameters.AddWithValue("@role", role);
                        command.Parameters.AddWithValue("@cin", cin);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Utilisateur ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Échec de l'ajout de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
