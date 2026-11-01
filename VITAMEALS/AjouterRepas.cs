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
    public partial class AjouterRepas : Form
    {
        private MySqlConnection mySqlConnection;

        public AjouterRepas()
        {
            InitializeComponent();

            // Initialiser la connexion à la base de données
            string server = "localhost";
            string database = "hopital";
            string uid = "root";
            string password = "";
            string connexionS = $"server={server};database={database};uid={uid};password={password}";
            mySqlConnection = new MySqlConnection(connexionS);

            // Ajouter un gestionnaire d'événements pour comboBox1
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Effacer les éléments existants dans comboBox3 et comboBox4
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();

            // Récupérer le régime sélectionné
            string regimeType = comboBox1.SelectedItem?.ToString() ?? string.Empty;

            // Ajouter les options correspondantes pour nom_repas et description
            if (regimeType == "normal")
            {
                comboBox3.Items.AddRange(new[] { "Petit déjeuner normal", "Déjeuner normal", "Dîner normal" });
                comboBox4.Items.AddRange(new[]
                {
                        "Un petit déjeuner composé de pain, beurre, confiture.",
                        "Plat principal avec viande, légumes, et riz.",
                        "Dîner léger avec du poisson, salade et légumes."
                    });
            }
            else if (regimeType == "sans sel")
            {
                comboBox3.Items.AddRange(new[] { "Petit déjeuner sans sel", "Déjeuner sans sel", "Dîner sans sel" });
                comboBox4.Items.AddRange(new[]
                {
                        "Petit déjeuner sans sel avec des fruits frais et de l'eau.",
                        "Plat principal sans sel, avec légumes cuits et riz complet.",
                        "Dîner léger avec poisson grillé et légumes."
                    });
            }
            else if (regimeType == "végétarien")
            {
                comboBox3.Items.AddRange(new[] { "Petit déjeuner végétarien", "Déjeuner végétarien", "Dîner végétarien" });
                comboBox4.Items.AddRange(new[]
                {
                        "Un petit déjeuner adapté avec des fruits frais, du pain complet et du thé.",
                        "Plat principal végétarien avec légumes cuits et riz.",
                        "Dîner léger avec légumes grillés, salade et riz."
                    });
            }
            else if (regimeType == "diabétique")
            {
                comboBox3.Items.AddRange(new[] { "Petit déjeuner diabétique", "Déjeuner diabétique", "Dîner diabétique" });
                comboBox4.Items.AddRange(new[]
                {
                        "Petit déjeuner adapté pour diabétiques avec du pain.",
                        "Plat principal avec viande maigre, légumes cuits.",
                        "Dîner léger avec du poisson grillé, légumes et riz brun."
                    });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Vérifier que tous les champs sont remplis
            if (string.IsNullOrWhiteSpace(textBox1.Text) || comboBox1.SelectedItem == null ||
                comboBox3.SelectedItem == null || comboBox4.SelectedItem == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            try
            {
                mySqlConnection.Open();

                // Récupérer les informations du formulaire
                int idRepas = int.Parse(textBox1.Text);
                string regimeType = comboBox1.SelectedItem?.ToString() ?? string.Empty;
                string nomRepas = comboBox3.SelectedItem?.ToString() ?? string.Empty;
                string description = comboBox4.SelectedItem?.ToString() ?? string.Empty;
                string categorie = GetCategorieFromNomRepas(nomRepas);

                // Vérifier si une entrée existe déjà dans la table repas
                string checkQuery = @"
                        SELECT id_repas 
                        FROM repas 
                        WHERE id_repas = @IdRepas";
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, mySqlConnection);
                checkCommand.Parameters.AddWithValue("@IdRepas", idRepas);
                object existingId = checkCommand.ExecuteScalar();

                if (existingId != null)
                {
                    MessageBox.Show("Un repas avec cet ID existe déjà. Veuillez utiliser un ID unique.");
                    return;
                }

                // Insérer une nouvelle ligne
                string insertQuery = @"
                        INSERT INTO repas (id_repas, nom_repas, description, categorie, regime, quantite) 
                        VALUES (@IdRepas, @NomRepas, @Description, @Categorie, @Regime, @Quantite)";
                MySqlCommand insertCommand = new MySqlCommand(insertQuery, mySqlConnection);
                insertCommand.Parameters.AddWithValue("@IdRepas", idRepas);
                insertCommand.Parameters.AddWithValue("@NomRepas", nomRepas);
                insertCommand.Parameters.AddWithValue("@Description", description);
                insertCommand.Parameters.AddWithValue("@Categorie", categorie);
                insertCommand.Parameters.AddWithValue("@Regime", regimeType);
                insertCommand.Parameters.AddWithValue("@Quantite", 1); // Quantité initiale fixée à 1
                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Ajout réussi dans la base de données !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }
        }

        private string GetCategorieFromNomRepas(string nomRepas)
        {
            if (nomRepas.Contains("Petit déjeuner")) return "petit déjeuner";
            if (nomRepas.Contains("Déjeuner")) return "dejeuner";
            if (nomRepas.Contains("Dîner")) return "diner";
            return string.Empty;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Vérifier que tous les champs sont remplis  
            if (string.IsNullOrWhiteSpace(textBox1.Text) || comboBox1.SelectedItem == null ||
                comboBox3.SelectedItem == null || comboBox4.SelectedItem == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            try
            {
                mySqlConnection.Open();

                // Récupérer les informations du formulaire  
                int idRepas = int.Parse(textBox1.Text);
                string regimeType = comboBox1.SelectedItem.ToString();
                string nomRepas = comboBox3.SelectedItem.ToString();
                string description = comboBox4.SelectedItem.ToString();
                string categorie = GetCategorieFromNomRepas(nomRepas);

                // Vérifier si une entrée existe déjà dans la table repas  
                string checkQuery = @"  
                       SELECT quantite   
                       FROM repas   
                       WHERE id_repas = @IdRepas AND nom_repas = @NomRepas AND categorie = @Categorie AND regime = @Regime";
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, mySqlConnection);
                checkCommand.Parameters.AddWithValue("@IdRepas", idRepas);
                checkCommand.Parameters.AddWithValue("@NomRepas", nomRepas);
                checkCommand.Parameters.AddWithValue("@Categorie", categorie);
                checkCommand.Parameters.AddWithValue("@Regime", regimeType);
                object quantiteObj = checkCommand.ExecuteScalar();

                if (quantiteObj != null)
                {
                    // Si une entrée existe, incrémenter la quantité  
                    int quantite = Convert.ToInt32(quantiteObj) + 1;
                    string updateQuery = @"  
                           UPDATE repas   
                           SET quantite = @Quantite   
                           WHERE id_repas = @IdRepas AND nom_repas = @NomRepas AND categorie = @Categorie AND regime = @Regime";
                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, mySqlConnection);
                    updateCommand.Parameters.AddWithValue("@Quantite", quantite);
                    updateCommand.Parameters.AddWithValue("@IdRepas", idRepas);
                    updateCommand.Parameters.AddWithValue("@NomRepas", nomRepas);
                    updateCommand.Parameters.AddWithValue("@Categorie", categorie);
                    updateCommand.Parameters.AddWithValue("@Regime", regimeType);
                    updateCommand.ExecuteNonQuery();
                }
                else
                {
                    // Si aucune entrée n'existe, insérer une nouvelle ligne  
                    string insertQuery = @"  
                           INSERT INTO repas (id_repas, nom_repas, description, categorie, regime, quantite)   
                           VALUES (@IdRepas, @NomRepas, @Description, @Categorie, @Regime, @Quantite)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, mySqlConnection);
                    insertCommand.Parameters.AddWithValue("@IdRepas", idRepas);
                    insertCommand.Parameters.AddWithValue("@NomRepas", nomRepas);
                    insertCommand.Parameters.AddWithValue("@Description", description);
                    insertCommand.Parameters.AddWithValue("@Categorie", categorie);
                    insertCommand.Parameters.AddWithValue("@Regime", regimeType);
                    insertCommand.Parameters.AddWithValue("@Quantite", 1); // Quantité initiale fixée à 1  
                    insertCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Ajout ou mise à jour réussie dans la base de données !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
            finally
            {
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear existing controls in the InterfaceAdministrateur form
            this.Controls.Clear();

            // Create an instance of the ListesReclamations form
            InterfaceMedecin listeReclamationForm = new InterfaceMedecin();

            // Set the ListesReclamations form to fill the parent form
            listeReclamationForm.TopLevel = false;
            listeReclamationForm.FormBorderStyle = FormBorderStyle.None;
            listeReclamationForm.Dock = DockStyle.Fill;

            // Add the ListesReclamations form to the InterfaceAdministrateur controls
            this.Controls.Add(listeReclamationForm);

            // Display the ListesReclamations form
            listeReclamationForm.Show();
        }
    }
}

