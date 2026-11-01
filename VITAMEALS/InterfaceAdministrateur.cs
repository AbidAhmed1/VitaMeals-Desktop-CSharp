namespace VITAMEALS2
{
    public partial class InterfaceAdministrateur : Form
    {
        public InterfaceAdministrateur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear existing controls in the InterfaceAdministrateur form
            this.Controls.Clear();

            // Create an instance of the ListePatient form
            ListePatient listePatientForm = new ListePatient();

            // Set the ListePatient form to fill the parent form
            listePatientForm.TopLevel = false;
            listePatientForm.FormBorderStyle = FormBorderStyle.None;
            listePatientForm.Dock = DockStyle.Fill;

            // Add the ListePatient form to the InterfaceAdministrateur controls
            this.Controls.Add(listePatientForm);

            // Display the ListePatient form
            listePatientForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear existing controls in the InterfaceAdministrateur form
            this.Controls.Clear();

            // Create an instance of the ListesReclamations form
            ListesReclamations listeReclamationForm = new ListesReclamations();

            // Set the ListesReclamations form to fill the parent form
            listeReclamationForm.TopLevel = false;
            listeReclamationForm.FormBorderStyle = FormBorderStyle.None;
            listeReclamationForm.Dock = DockStyle.Fill;

            // Add the ListesReclamations form to the InterfaceAdministrateur controls
            this.Controls.Add(listeReclamationForm);

            // Display the ListesReclamations form
            listeReclamationForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Clear existing controls in the InterfaceAdministrateur form
            this.Controls.Clear();

            // Create an instance of the AjouterPatient form
            AjouterPatient ajouterPatientForm = new AjouterPatient();

            // Set the AjouterPatient form to fill the parent form
            ajouterPatientForm.TopLevel = false;
            ajouterPatientForm.FormBorderStyle = FormBorderStyle.None;
            ajouterPatientForm.Dock = DockStyle.Fill;

            // Add the AjouterPatient form to the InterfaceAdministrateur controls
            this.Controls.Add(ajouterPatientForm);

            // Display the AjouterPatient form
            ajouterPatientForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Clear existing controls in the InterfaceAdministrateur form
            this.Controls.Clear();

            // Create an instance of the AjouterPatient form
            AjouterActeurs ajouterActeursForm = new AjouterActeurs();

            // Set the AjouterPatient form to fill the parent form
            ajouterActeursForm.TopLevel = false;
            ajouterActeursForm.FormBorderStyle = FormBorderStyle.None;
            ajouterActeursForm.Dock = DockStyle.Fill;

            // Add the AjouterPatient form to the InterfaceAdministrateur controls
            this.Controls.Add(ajouterActeursForm);

            // Display the AjouterPatient form
            ajouterActeursForm.Show();
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
