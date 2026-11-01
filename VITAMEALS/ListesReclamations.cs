using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace VITAMEALS2
{
    public partial class ListesReclamations : Form
    {
        private MySqlConnection mySqlConnection;
        private String server;
        private String database;
        private String uid;
        private String password;

        public ListesReclamations()
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

        private void dataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Vérifiez si la colonne en cours d'édition est autre que "statut"
            if (dataGridView2.Columns[e.ColumnIndex].Name != "statut")
            {
                e.Cancel = true; // Annule l'édition
            }
        }
        private void ListesReclamations_Load(object sender, EventArgs e)
        {
            if (this.VerifConnexion() == true)
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM reclamation", mySqlConnection);
                DataSet dataSet = new DataSet();
                mySqlDataAdapter.Fill(dataSet);
                dataGridView2.DataSource = dataSet.Tables[0];
                this.CloseConnexion();

                // Désactiver l'édition globale
                dataGridView2.ReadOnly = true;

                // Activer l'édition uniquement pour la colonne "statut"
                dataGridView2.Columns["statut"].ReadOnly = false;

                // Désactiver l'édition pour les autres colonnes
                dataGridView2.Columns["id_reclamation"].ReadOnly = true;
                dataGridView2.Columns["cin"].ReadOnly = true;
                dataGridView2.Columns["nom"].ReadOnly = true;
                dataGridView2.Columns["prenom"].ReadOnly = true;
                dataGridView2.Columns["date_reclamation"].ReadOnly = true;
                dataGridView2.Columns["description"].ReadOnly = true;

                // Abonner l'événement CellBeginEdit
                dataGridView2.CellBeginEdit += dataGridView2_CellBeginEdit;

                // Optionnel : Ajuster la largeur des colonnes pour une meilleure lisibilité
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Connexion échouée !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.IsNewRow) continue;

                    string idReclamation = row.Cells["id_reclamation"].Value?.ToString() ?? string.Empty;
                    string statut = row.Cells["statut"].Value?.ToString() ?? string.Empty;

                    // Construire la requête pour mettre à jour uniquement le statut
                    string query = @"UPDATE reclamation  
                                    SET statut = @statut  
                                    WHERE id_reclamation = @idReclamation";

                    using (MySqlCommand cmd = new MySqlCommand(query, mySqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@idReclamation", idReclamation);
                        cmd.Parameters.AddWithValue("@statut", statut);

                        try
                        {
                            mySqlConnection.Open();
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erreur lors de l'exécution de la commande : " + ex.Message);
                        }
                        finally
                        {
                            mySqlConnection.Close();
                        }
                    }
                }

                MessageBox.Show("Modifications sauvegardées avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la sauvegarde : " + ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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



   
       
