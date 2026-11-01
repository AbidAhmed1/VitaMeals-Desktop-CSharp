namespace VITAMEALS2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textboxlogin = new TextBox();
            textboxmdp = new TextBox();
            button1 = new Button();
            label4 = new Label();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-6, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(126, 461);
            panel1.TabIndex = 0;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(356, 12);
            label1.Name = "label1";
            label1.Size = new Size(213, 60);
            label1.TabIndex = 1;
            label1.Text = "Connexion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(154, 68);
            label2.Name = "label2";
            label2.Size = new Size(75, 31);
            label2.TabIndex = 2;
            label2.Text = "Login:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(154, 149);
            label3.Name = "label3";
            label3.Size = new Size(151, 31);
            label3.TabIndex = 3;
            label3.Text = "Mot de passe:";
            // 
            // textboxlogin
            // 
            textboxlogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textboxlogin.Location = new Point(214, 102);
            textboxlogin.Name = "textboxlogin";
            textboxlogin.Size = new Size(152, 29);
            textboxlogin.TabIndex = 4;
            // 
            // textboxmdp
            // 
            textboxmdp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textboxmdp.Location = new Point(214, 198);
            textboxmdp.Name = "textboxmdp";
            textboxmdp.Size = new Size(152, 29);
            textboxmdp.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Location = new Point(393, 297);
            button1.Name = "button1";
            button1.Size = new Size(131, 42);
            button1.TabIndex = 6;
            button1.Text = "Se connecter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(154, 230);
            label4.Name = "label4";
            label4.Size = new Size(65, 31);
            label4.TabIndex = 7;
            label4.Text = "Role:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "medecin", "admin", "cuisinier", "administrateur" });
            comboBox1.Location = new Point(214, 265);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(152, 23);
            comboBox1.TabIndex = 8;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 340);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textboxmdp);
            Controls.Add(textboxlogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Name = "Login";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textboxlogin;
        private TextBox textboxmdp;
        private Button button1;
        private Label label4;
        private ComboBox comboBox1;
    }
}