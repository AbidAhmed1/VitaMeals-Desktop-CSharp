using System.Data;
using MySql.Data.MySqlClient;


namespace VITAMEALS2
{
    public partial class ListePatient : Form
    {
        private MySqlConnection mySqlConnection;
        private String server;
        private String database;
        private String uid;
        private String password;
        public string? cin { get; set; }
        public string? prenom { get; set; }
        public string? nom { get; set; }
        public DateTime? date_naissance { get; set; }
        public string? tel { get; set; } // Doit être une chaîne numérique de 8 chiffres
        public int? num_chambre { get; set; } // Doit être un entier composé de 8 chiffres
        public string? regime { get; set; }
        public string? allergie { get; set; }
        public string? statut { get; set; }

        public ListePatient()
        {
            InitializeComponent();
            server = "localhost";
            database = "hopital";
            uid = "root";
            password = "";
            string connexionS = "server=" + server + ";database=" + database + ";uid=" + uid + ";password=" + password;
            mySqlConnection = new MySqlConnection(connexionS);
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
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM patients", mySqlConnection);
                DataSet dataSet = new DataSet();
                mySqlDataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                this.CloseConnexion();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.VerifConnexion())
            {
                try
                {
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM patients", mySqlConnection);
                    DataSet dataSet = new DataSet();
                    mySqlDataAdapter.Fill(dataSet);
                    if (dataSet.Tables.Count > 0)
                    {
                        dataGridView1.DataSource = dataSet.Tables[0];
                        dataGridView1.ReadOnly = true;

                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            column.ReadOnly = true;
                        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InterfaceAdministrateur listePatientForm = new InterfaceAdministrateur
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            this.Controls.Add(listePatientForm);
            listePatientForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox2.Text) && dataGridView1.SelectedRows.Count > 0)
                {
                    string updatedCin = textBox2.Text;
                    string query = "UPDATE patients SET cin = @updatedCin, nom = @nom, prenom = @prenom, date_naissance = @date_naissance, tel = @tel, num_chambre = @num_chambre, regime = @regime, allergies = @allergies, statut = @statut, adresse = @adresse WHERE cin = @originalCin";

                    using (MySqlCommand cmd = new MySqlCommand(query, mySqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@updatedCin", updatedCin);
                        cmd.Parameters.AddWithValue("@originalCin", dataGridView1.SelectedRows[0].Cells["cin"].Value?.ToString() ?? string.Empty);
                        cmd.Parameters.AddWithValue("@nom", textBoxNOM.Text);
                        cmd.Parameters.AddWithValue("@prenom", textBox3PRENOM.Text);
                        cmd.Parameters.AddWithValue("@date_naissance", dateTimePicker1DNAIS.Value);
                        cmd.Parameters.AddWithValue("@tel", textBox1.Text);
                        cmd.Parameters.AddWithValue("@num_chambre", textBoxNumch.Text);
                        cmd.Parameters.AddWithValue("@regime", textBoxregime.Text);
                        cmd.Parameters.AddWithValue("@allergies", textBoxAllergie.Text);
                        cmd.Parameters.AddWithValue("@statut", comboBoxstatut.Text);
                        cmd.Parameters.AddWithValue("@adresse", richTextBox1adresse.Text);

                        mySqlConnection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Mise à jour des données dans le DataGridView  
                            dataGridView1.SelectedRows[0].Cells["cin"].Value = updatedCin;
                            dataGridView1.SelectedRows[0].Cells["nom"].Value = textBoxNOM.Text;
                            dataGridView1.SelectedRows[0].Cells["prenom"].Value = textBox3PRENOM.Text;
                            dataGridView1.SelectedRows[0].Cells["date_naissance"].Value = dateTimePicker1DNAIS.Value;
                            dataGridView1.SelectedRows[0].Cells["tel"].Value = textBox1.Text;
                            dataGridView1.SelectedRows[0].Cells["num_chambre"].Value = textBoxNumch.Text;
                            dataGridView1.SelectedRows[0].Cells["regime"].Value = textBoxregime.Text;
                            dataGridView1.SelectedRows[0].Cells["allergies"].Value = textBoxAllergie.Text;
                            dataGridView1.SelectedRows[0].Cells["statut"].Value = comboBoxstatut.Text;
                            dataGridView1.SelectedRows[0].Cells["adresse"].Value = richTextBox1adresse.Text;

                            MessageBox.Show("Modification réussie !");
                        }
                        else
                        {
                            MessageBox.Show("Aucune ligne n'a été modifiée. Veuillez vérifier vos données.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez entrer une valeur valide dans le TextBox et sélectionner une ligne.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification : " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    string cin = selectedRow.Cells["cin"].Value?.ToString() ?? string.Empty;

                    if (!string.IsNullOrEmpty(cin))
                    {
                        // Désactiver temporairement la vérification des contraintes de clé étrangère  
                        string disableForeignKeyChecks = "SET FOREIGN_KEY_CHECKS=0;";
                        string enableForeignKeyChecks = "SET FOREIGN_KEY_CHECKS=1;";

                        string query = "DELETE FROM patients WHERE cin = @cin";

                        using (MySqlCommand cmd = new MySqlCommand(disableForeignKeyChecks, mySqlConnection))
                        {
                            mySqlConnection.Open();
                            cmd.ExecuteNonQuery();
                        }

                        using (MySqlCommand cmd = new MySqlCommand(query, mySqlConnection))
                        {
                            cmd.Parameters.AddWithValue("@cin", cin);
                            cmd.ExecuteNonQuery();
                        }

                        using (MySqlCommand cmd = new MySqlCommand(enableForeignKeyChecks, mySqlConnection))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        dataGridView1.Rows.Remove(selectedRow);
                        MessageBox.Show("Ligne supprimée avec succès !");
                    }
                    else
                    {
                        MessageBox.Show("La clé primaire (cin) est invalide.");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une ligne à supprimer.");
                }
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "cin")
                {
                    string selectedCin = dataGridView1.Rows[e.RowIndex].Cells["cin"].Value?.ToString() ?? string.Empty;
                    textBox2.Text = selectedCin;
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "nom")
                {
                    string selectedNom = dataGridView1.Rows[e.RowIndex].Cells["nom"].Value?.ToString() ?? string.Empty;
                    textBoxNOM.Text = selectedNom;
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "prenom")
                {
                    string selectedPrenom = dataGridView1.Rows[e.RowIndex].Cells["prenom"].Value?.ToString() ?? string.Empty;
                    textBox3PRENOM.Text = selectedPrenom;
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "date_naissance")
                {
                    if (DateTime.TryParse(dataGridView1.Rows[e.RowIndex].Cells["date_naissance"].Value?.ToString(), out DateTime selectedDateNaissance))
                    {
                        dateTimePicker1DNAIS.Value = selectedDateNaissance;
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "tel")
                {
                    string selectedTel = dataGridView1.Rows[e.RowIndex].Cells["tel"].Value?.ToString() ?? string.Empty;
                    textBox1.Text = selectedTel;
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "adresse")
                {
                    string selectedAdresse = dataGridView1.Rows[e.RowIndex].Cells["adresse"].Value?.ToString() ?? string.Empty;
                    richTextBox1adresse.Text = selectedAdresse;
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "num_chambre")
                {
                    string selectedNumChambre = dataGridView1.Rows[e.RowIndex].Cells["num_chambre"].Value?.ToString() ?? string.Empty;
                    textBoxNumch.Text = selectedNumChambre;
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "regime")
                {
                    string selectedRegime = dataGridView1.Rows[e.RowIndex].Cells["regime"].Value?.ToString() ?? string.Empty;
                    textBoxregime.Text = selectedRegime;
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "allergie")
                {
                    string selectedAllergie = dataGridView1.Rows[e.RowIndex].Cells["allergie"].Value?.ToString() ?? string.Empty;
                    textBoxAllergie.Text = selectedAllergie;
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "statut")
                {
                    string selectedStatut = dataGridView1.Rows[e.RowIndex].Cells["statut"].Value?.ToString() ?? string.Empty;
                    comboBoxstatut.Text = selectedStatut;
                }
            }
        }

        private void textBoxNOM_TextChanged(object sender, EventArgs e)
        {
            // Logique à ajouter si nécessaire
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchValue = textBox3.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchValue))
            {
                MessageBox.Show("Veuillez entrer un critère de recherche.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (this.VerifConnexion())
                {
                    // Requête SQL pour rechercher par CIN ou nom
                    string query = @"
                SELECT * 
                FROM patients 
                WHERE cin LIKE @searchValue OR nom LIKE @searchValue";

                    using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
                    {
                        command.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");

                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);

                        if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                        {
                            dataGridView2.DataSource = dataSet.Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("Aucun résultat trouvé.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la recherche : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.CloseConnexion();
            }

        }
    }
}

