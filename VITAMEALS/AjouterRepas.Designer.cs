namespace VITAMEALS2
{
    partial class AjouterRepas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterRepas));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(406, 84);
            label1.Name = "label1";
            label1.Size = new Size(91, 14);
            label1.TabIndex = 0;
            label1.Text = "Id du patient";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(401, 159);
            label2.Name = "label2";
            label2.Size = new Size(96, 14);
            label2.TabIndex = 1;
            label2.Text = "Type régimes";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(376, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(422, 398);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Enregistrer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(126, 539);
            panel1.TabIndex = 6;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.DarkSlateGray;
            button2.Location = new Point(28, 165);
            button2.Name = "button2";
            button2.Size = new Size(75, 60);
            button2.TabIndex = 8;
            button2.Text = "Interface Medecin";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(362, 14);
            label3.Name = "label3";
            label3.Size = new Size(157, 28);
            label3.TabIndex = 7;
            label3.Text = "Ajouter Repas";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "petit_dejeuner", "dejeuner", "diner" });
            comboBox2.Location = new Point(376, 234);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(159, 23);
            comboBox2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(409, 272);
            label4.Name = "label4";
            label4.Size = new Size(98, 14);
            label4.TabIndex = 10;
            label4.Text = "Nom du repas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(415, 335);
            label5.Name = "label5";
            label5.Size = new Size(82, 14);
            label5.TabIndex = 11;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(399, 217);
            label6.Name = "label6";
            label6.Size = new Size(115, 14);
            label6.TabIndex = 13;
            label6.Text = "Categorie Repas";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "végétarien", "normal", "sans sel ", "diabétique " });
            comboBox1.Location = new Point(393, 179);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 14;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Petit déjeuner diabétique", "Déjeuner diabétique", "Dîner diabétique", "Petit déjeuner normal", "Déjeuner normal", "Dîner normal", "Petit déjeuner sans sel ", "Déjeuner sans sel ", "Dîner sans sel ", "Petit déjeuner végétarien", "Déjeuner végétarien", "Dîner végétarien" });
            comboBox3.Location = new Point(376, 299);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(159, 23);
            comboBox3.TabIndex = 15;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "", "Un petit déjeuner composé de pain, beurre, confiture.", "Plat principal avec viande, légumes, et riz.", "Dîner léger avec du poisson, salade et légumes.", "Petit déjeuner adapté pour diabétiques avec du pain.", "Plat principal avec viande maigre, légumes cuits.", "Dîner léger avec du poisson grillé, légumes et riz brun.", "Petit déjeuner sans sel avec des fruits frais et de l'eau.", "Plat principal sans sel, avec légumes cuits et riz complet.", "Dîner léger avec poisson grillé et légumes.", "Un petit déjeuner adapté avec des fruits frais,du pain complet et du thé.", "Plat principal végétarien avec légumes cuits et riz.", "Dîner léger avec légumes grillés, salade et riz." });
            comboBox4.Location = new Point(376, 352);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(159, 23);
            comboBox4.TabIndex = 16;
            // 
            // AjouterRepas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AjouterRepas";
            Text = "Ajouter Repas";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private Button button2;
        private ComboBox comboBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
    }
}