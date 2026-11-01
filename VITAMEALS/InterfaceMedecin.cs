using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VITAMEALS2
{
    public partial class InterfaceMedecin : Form
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



        public InterfaceMedecin()
        {

            InitializeComponent();
            server = "localhost";
            database = "hopital";
            uid = "root";
            password = "";
            string connexionS = "server=" + server + ";database=" + database + ";uid=" + uid + ";password=" + password;
            mySqlConnection = new MySqlConnection(connexionS);
        }
        // verificaation 

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


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ListePatient_Load(object sender, EventArgs e)
        {
            if (this.VerifConnexion() == true)
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
            if (this.VerifConnexion() == true)
            {
                try
                {
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM patients", mySqlConnection);
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



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ""
                || textBox2.Text == ""
                || textBox3.Text == ""
                || textBox4.Text == ""
                || textBox5.Text == ""
                || textBox6.Text == ""
                || textBox7.Text == ""
                || textBox8.Text == ""
                || dateTimePicker1.Value == new DateTime(1900, 1, 1))
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
            else
            {
                if (mySqlConnection.State == ConnectionState.Closed)

                    try
                    {
                        mySqlConnection.Open();
                        string query = "INSERT INTO patients (cin, prenom, nom, date_naissance, tel, num_chambre, regime, allergies) VALUES (@cin, @prenom, @nom, @date_naissance, @tel, @num_chambre, @regime, @allergies)";
                        MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                        cmd.Parameters.AddWithValue("@cin", textBox1.Text);
                        cmd.Parameters.AddWithValue("@prenom", textBox3.Text);
                        cmd.Parameters.AddWithValue("@nom", textBox2.Text);
                        cmd.Parameters.AddWithValue("@date_naissance", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@tel", textBox5.Text);
                        cmd.Parameters.AddWithValue("@num_chambre", textBox7.Text);
                        cmd.Parameters.AddWithValue("@regime", textBox6.Text);
                        cmd.Parameters.AddWithValue("@allergies", textBox8.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Patient ajouté avec succès !");
                            dataGridView1.Refresh();
                            dataGridView1.Update();
                            dataGridView1.Refresh();
                            dataGridView1.Update();
                            dataGridView1.Refresh();
                            dataGridView1.Update();
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erreur lors de l'ajout du patient : " + ex.Message);
                    }
                    finally
                    {
                        mySqlConnection.Close();
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                        cmd.Parameters.AddWithValue("@nom", textBox2.Text);
                        cmd.Parameters.AddWithValue("@prenom", textBox3.Text);
                        cmd.Parameters.AddWithValue("@date_naissance", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@tel", textBox5.Text);
                        cmd.Parameters.AddWithValue("@num_chambre", textBox7.Text);
                        cmd.Parameters.AddWithValue("@regime", textBox6.Text);
                        cmd.Parameters.AddWithValue("@allergies", textBox8.Text);
                        cmd.Parameters.AddWithValue("@statut", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@adresse", textBox4.Text);

                        mySqlConnection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Mise à jour des données dans le DataGridView  
                            dataGridView1.SelectedRows[0].Cells["cin"].Value = updatedCin;
                            dataGridView1.SelectedRows[0].Cells["nom"].Value = textBox2.Text;
                            dataGridView1.SelectedRows[0].Cells["prenom"].Value = textBox3.Text;
                            dataGridView1.SelectedRows[0].Cells["date_naissance"].Value = dateTimePicker1.Value;
                            dataGridView1.SelectedRows[0].Cells["tel"].Value = textBox5.Text;
                            dataGridView1.SelectedRows[0].Cells["num_chambre"].Value = textBox7.Text;
                            dataGridView1.SelectedRows[0].Cells["regime"].Value = textBox6.Text;
                            dataGridView1.SelectedRows[0].Cells["allergies"].Value = textBox8.Text;
                            dataGridView1.SelectedRows[0].Cells["statut"].Value = comboBox1.Text;
                            dataGridView1.SelectedRows[0].Cells["adresse"].Value = textBox4.Text;

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Clear existing controls in the InterfaceAdministrateur form
            this.Controls.Clear();

            // Create an instance of the ListePatient form
            AjouterRepas listePatientForm = new AjouterRepas();

            // Set the ListePatient form to fill the parent form
            listePatientForm.TopLevel = false;
            listePatientForm.FormBorderStyle = FormBorderStyle.None;
            listePatientForm.Dock = DockStyle.Fill;

            // Add the ListePatient form to the InterfaceAdministrateur controls
            this.Controls.Add(listePatientForm);

            // Display the ListePatient form
            listePatientForm.Show();
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
    }
}
