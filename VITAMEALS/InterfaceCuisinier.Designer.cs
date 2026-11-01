namespace VITAMEALS2
{
    partial class InterfaceCuisinier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfaceCuisinier));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(linkLabel1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(124, 600);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Sylfaen", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Turquoise;
            linkLabel1.Location = new Point(18, 299);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(87, 27);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Log out";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(391, 13);
            label1.Name = "label1";
            label1.Size = new Size(269, 36);
            label1.TabIndex = 1;
            label1.Text = "Interface Cuisinier";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(143, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(758, 266);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SlateGray;
            label3.Location = new Point(459, 49);
            label3.Name = "label3";
            label3.Size = new Size(125, 18);
            label3.TabIndex = 7;
            label3.Text = "Total des Quantités ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(128, 398);
            label2.Name = "label2";
            label2.Size = new Size(312, 28);
            label2.TabIndex = 8;
            label2.Text = "Total des Quantités par jour :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(162, 429);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 10;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(375, 431);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 11;
            label4.Text = "Total?";
            label4.Click += label4_Click;
            // 
            // InterfaceCuisinier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 517);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(panel1);
            ForeColor = Color.SteelBlue;
            Name = "InterfaceCuisinier";
            Text = "Interface Cuisinier";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label3;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
    }
}