namespace VITAMEALS2
{
    partial class ListePatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListePatient));
            panel1 = new Panel();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            panel2 = new Panel();
            label10 = new Label();
            dateTimePicker1DNAIS = new DateTimePicker();
            textBoxAllergie = new TextBox();
            comboBoxstatut = new ComboBox();
            richTextBox1adresse = new RichTextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            textBoxregime = new TextBox();
            textBoxNumch = new TextBox();
            textBox1 = new TextBox();
            textBox3PRENOM = new TextBox();
            textBoxNOM = new TextBox();
            textBox2 = new TextBox();
            label7 = new Label();
            label1 = new Label();
            label5 = new Label();
            label3 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBoxTel = new TextBox();
            textBox1CIN = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label14 = new Label();
            pictureBox2 = new PictureBox();
            textBox3 = new TextBox();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            label15 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(126, 721);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(18, 176);
            button2.Name = "button2";
            button2.Size = new Size(92, 47);
            button2.TabIndex = 4;
            button2.Text = "Interface administrateur";
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(188, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(826, 321);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button3
            // 
            button3.Location = new Point(294, 381);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "modifier ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(682, 381);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "Supprimer";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PapayaWhip;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(dateTimePicker1DNAIS);
            panel2.Controls.Add(textBoxAllergie);
            panel2.Controls.Add(comboBoxstatut);
            panel2.Controls.Add(richTextBox1adresse);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(textBoxregime);
            panel2.Controls.Add(textBoxNumch);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(textBox3PRENOM);
            panel2.Controls.Add(textBoxNOM);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textBoxTel);
            panel2.Controls.Add(textBox1CIN);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(144, 410);
            panel2.Name = "panel2";
            panel2.Size = new Size(613, 288);
            panel2.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(254, 123);
            label10.Name = "label10";
            label10.Size = new Size(164, 31);
            label10.TabIndex = 63;
            label10.Text = "Num chambre:";
            // 
            // dateTimePicker1DNAIS
            // 
            dateTimePicker1DNAIS.Location = new Point(413, 53);
            dateTimePicker1DNAIS.Name = "dateTimePicker1DNAIS";
            dateTimePicker1DNAIS.Size = new Size(197, 23);
            dateTimePicker1DNAIS.TabIndex = 62;
            // 
            // textBoxAllergie
            // 
            textBoxAllergie.Location = new Point(156, 258);
            textBoxAllergie.Name = "textBoxAllergie";
            textBoxAllergie.Size = new Size(100, 23);
            textBoxAllergie.TabIndex = 61;
            // 
            // comboBoxstatut
            // 
            comboBoxstatut.FormattingEnabled = true;
            comboBoxstatut.Items.AddRange(new object[] { "hospitalisé", "sorti" });
            comboBoxstatut.Location = new Point(313, 258);
            comboBoxstatut.Name = "comboBoxstatut";
            comboBoxstatut.Size = new Size(121, 23);
            comboBoxstatut.TabIndex = 60;
            // 
            // richTextBox1adresse
            // 
            richTextBox1adresse.Location = new Point(137, 157);
            richTextBox1adresse.Name = "richTextBox1adresse";
            richTextBox1adresse.Size = new Size(100, 56);
            richTextBox1adresse.TabIndex = 59;
            richTextBox1adresse.Text = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(338, 224);
            label13.Name = "label13";
            label13.Size = new Size(80, 31);
            label13.TabIndex = 58;
            label13.Text = "Statut:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(159, 224);
            label12.Name = "label12";
            label12.Size = new Size(97, 31);
            label12.TabIndex = 57;
            label12.Text = "Allergie:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(460, 123);
            label11.Name = "label11";
            label11.Size = new Size(95, 31);
            label11.TabIndex = 56;
            label11.Text = "Regime:";
            // 
            // textBoxregime
            // 
            textBoxregime.Location = new Point(455, 175);
            textBoxregime.Name = "textBoxregime";
            textBoxregime.Size = new Size(100, 23);
            textBoxregime.TabIndex = 55;
            // 
            // textBoxNumch
            // 
            textBoxNumch.Location = new Point(285, 175);
            textBoxNumch.Name = "textBoxNumch";
            textBoxNumch.Size = new Size(100, 23);
            textBoxNumch.TabIndex = 54;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 175);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 53;
            // 
            // textBox3PRENOM
            // 
            textBox3PRENOM.Location = new Point(285, 53);
            textBox3PRENOM.Name = "textBox3PRENOM";
            textBox3PRENOM.Size = new Size(100, 23);
            textBox3PRENOM.TabIndex = 52;
            // 
            // textBoxNOM
            // 
            textBoxNOM.Location = new Point(125, 53);
            textBoxNOM.Name = "textBoxNOM";
            textBoxNOM.Size = new Size(100, 23);
            textBoxNOM.TabIndex = 51;
            textBoxNOM.TextChanged += textBoxNOM_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 50;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(137, 123);
            label7.Name = "label7";
            label7.Size = new Size(99, 31);
            label7.TabIndex = 49;
            label7.Text = "Adresse:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 141);
            label1.Name = "label1";
            label1.Size = new Size(51, 31);
            label1.TabIndex = 48;
            label1.Text = "Tel:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(413, 7);
            label5.Name = "label5";
            label5.Size = new Size(197, 31);
            label5.TabIndex = 47;
            label5.Text = "Date de naissance:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(285, 7);
            label3.Name = "label3";
            label3.Size = new Size(99, 31);
            label3.TabIndex = 46;
            label3.Text = "Prenom:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(125, 7);
            label8.Name = "label8";
            label8.Size = new Size(77, 31);
            label8.TabIndex = 45;
            label8.Text = "NOM:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(21, 7);
            label9.Name = "label9";
            label9.Size = new Size(61, 31);
            label9.TabIndex = 44;
            label9.Text = "CIN:";
            // 
            // textBoxTel
            // 
            textBoxTel.Location = new Point(-116, 175);
            textBoxTel.Name = "textBoxTel";
            textBoxTel.Size = new Size(100, 23);
            textBoxTel.TabIndex = 43;
            // 
            // textBox1CIN
            // 
            textBox1CIN.Location = new Point(-116, 53);
            textBox1CIN.Name = "textBox1CIN";
            textBox1CIN.Size = new Size(100, 23);
            textBox1CIN.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(-116, 123);
            label6.Name = "label6";
            label6.Size = new Size(51, 31);
            label6.TabIndex = 38;
            label6.Text = "Tel:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(185, 7);
            label4.Name = "label4";
            label4.Size = new Size(0, 31);
            label4.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(-116, 7);
            label2.Name = "label2";
            label2.Size = new Size(61, 31);
            label2.TabIndex = 34;
            label2.Text = "CIN:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Perpetua", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.SteelBlue;
            label14.Location = new Point(477, 11);
            label14.Name = "label14";
            label14.Size = new Size(246, 36);
            label14.TabIndex = 7;
            label14.Text = "Liste des patients";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(835, 381);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 56);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(888, 417);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(933, 446);
            button1.Name = "button1";
            button1.Size = new Size(23, 23);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(774, 496);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(422, 68);
            dataGridView2.TabIndex = 11;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(871, 450);
            label15.Name = "label15";
            label15.Size = new Size(61, 18);
            label15.TabIndex = 12;
            label15.Text = "Clique ici";
            // 
            // ListePatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1208, 710);
            Controls.Add(label15);
            Controls.Add(dataGridView2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label14);
            Controls.Add(panel2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListePatient";
            Text = "ListePatient";
            Load += ListePatient_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();


        }

        // Add the missing event handler method for textBox2_TextChanged  
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Add your logic here. For now, it's an empty method to resolve the error.  
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel2;
        private TextBox textBoxTel;
        private TextBox textBox1CIN;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label10;
        private DateTimePicker dateTimePicker1DNAIS;
        private TextBox textBoxAllergie;
        private ComboBox comboBoxstatut;
        private RichTextBox richTextBox1adresse;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox textBoxregime;
        private TextBox textBoxNumch;
        private TextBox textBox1;
        private TextBox textBox3PRENOM;
        private TextBox textBoxNOM;
        private TextBox textBox2;
        private Label label7;
        private Label label1;
        private Label label5;
        private Label label3;
        private Label label8;
        private Label label9;
        private Label label14;
        private PictureBox pictureBox2;
        private TextBox textBox3;
        private Button button1;
        private DataGridView dataGridView2;
        private Label label15;
    }
}