namespace Policijska_Uprava
{
    partial class frmPolicijskaUprava
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHead = new System.Windows.Forms.Panel();
            this.butnExit = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblPolicijskaUprava = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butPolicajac = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panelAktivni = new System.Windows.Forms.Panel();
            this.butKazne = new System.Windows.Forms.Button();
            this.butDosije = new System.Windows.Forms.Button();
            this.butRegistar = new System.Windows.Forms.Button();
            this.butPocetna = new System.Windows.Forms.Button();
            this.textPretraga = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usrcKazne2 = new Policijska_Uprava.usrcKazne();
            this.osnovniPodaci1 = new Policijska_Uprava.OsnovniPodaci();
            this.usrPolicajac1 = new Policijska_Uprava.usrPolicajac();
            this.dosije1 = new Policijska_Uprava.usrDosije();
            this.usrcKazne1 = new Policijska_Uprava.usrcKazne();
            this.registar1 = new Policijska_Uprava.Registar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butTrazi = new System.Windows.Forms.Button();
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(10)))), ((int)(((byte)(19)))));
            this.panelHead.Controls.Add(this.butnExit);
            this.panelHead.Controls.Add(this.picLogo);
            this.panelHead.Controls.Add(this.lblPolicijskaUprava);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(890, 64);
            this.panelHead.TabIndex = 0;
            this.panelHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHead_MouseDown);
            this.panelHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHead_MouseMove);
            this.panelHead.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHead_MouseUp);
            // 
            // butnExit
            // 
            this.butnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(10)))), ((int)(((byte)(19)))));
            this.butnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butnExit.FlatAppearance.BorderSize = 0;
            this.butnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butnExit.Image = global::Policijska_Uprava.Properties.Resources.icons8_exit_65;
            this.butnExit.Location = new System.Drawing.Point(818, 0);
            this.butnExit.Margin = new System.Windows.Forms.Padding(0);
            this.butnExit.Name = "butnExit";
            this.butnExit.Size = new System.Drawing.Size(72, 64);
            this.butnExit.TabIndex = 2;
            this.butnExit.UseVisualStyleBackColor = false;
            this.butnExit.Click += new System.EventHandler(this.butnExit_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Policijska_Uprava.Properties.Resources.icons8_police_64;
            this.picLogo.Location = new System.Drawing.Point(12, -1);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(65, 61);
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // lblPolicijskaUprava
            // 
            this.lblPolicijskaUprava.AutoSize = true;
            this.lblPolicijskaUprava.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolicijskaUprava.ForeColor = System.Drawing.Color.White;
            this.lblPolicijskaUprava.Location = new System.Drawing.Point(83, 16);
            this.lblPolicijskaUprava.Name = "lblPolicijskaUprava";
            this.lblPolicijskaUprava.Size = new System.Drawing.Size(213, 30);
            this.lblPolicijskaUprava.TabIndex = 0;
            this.lblPolicijskaUprava.Text = "Policijska Uprava";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.butPolicajac);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.panelAktivni);
            this.panel2.Controls.Add(this.butKazne);
            this.panel2.Controls.Add(this.butDosije);
            this.panel2.Controls.Add(this.butRegistar);
            this.panel2.Controls.Add(this.butPocetna);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 455);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // butPolicajac
            // 
            this.butPolicajac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.butPolicajac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butPolicajac.FlatAppearance.BorderSize = 0;
            this.butPolicajac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPolicajac.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPolicajac.ForeColor = System.Drawing.Color.White;
            this.butPolicajac.Image = global::Policijska_Uprava.Properties.Resources.icons8_police_48;
            this.butPolicajac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butPolicajac.Location = new System.Drawing.Point(12, 276);
            this.butPolicajac.Margin = new System.Windows.Forms.Padding(0);
            this.butPolicajac.Name = "butPolicajac";
            this.butPolicajac.Size = new System.Drawing.Size(220, 58);
            this.butPolicajac.TabIndex = 7;
            this.butPolicajac.Text = "Policajac";
            this.butPolicajac.UseVisualStyleBackColor = false;
            this.butPolicajac.Click += new System.EventHandler(this.butPolicajac_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // panelAktivni
            // 
            this.panelAktivni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(29)))), ((int)(((byte)(70)))));
            this.panelAktivni.Location = new System.Drawing.Point(2, 42);
            this.panelAktivni.Name = "panelAktivni";
            this.panelAktivni.Size = new System.Drawing.Size(10, 62);
            this.panelAktivni.TabIndex = 3;
            // 
            // butKazne
            // 
            this.butKazne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.butKazne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butKazne.FlatAppearance.BorderSize = 0;
            this.butKazne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butKazne.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butKazne.ForeColor = System.Drawing.Color.White;
            this.butKazne.Image = global::Policijska_Uprava.Properties.Resources.icons8_document_48;
            this.butKazne.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butKazne.Location = new System.Drawing.Point(12, 218);
            this.butKazne.Margin = new System.Windows.Forms.Padding(0);
            this.butKazne.Name = "butKazne";
            this.butKazne.Size = new System.Drawing.Size(220, 58);
            this.butKazne.TabIndex = 6;
            this.butKazne.Text = "Kazne";
            this.butKazne.UseVisualStyleBackColor = false;
            this.butKazne.Click += new System.EventHandler(this.butKazne_Click);
            // 
            // butDosije
            // 
            this.butDosije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.butDosije.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butDosije.FlatAppearance.BorderSize = 0;
            this.butDosije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDosije.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDosije.ForeColor = System.Drawing.Color.White;
            this.butDosije.Image = global::Policijska_Uprava.Properties.Resources.icons8_folder_48;
            this.butDosije.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butDosije.Location = new System.Drawing.Point(12, 160);
            this.butDosije.Margin = new System.Windows.Forms.Padding(0);
            this.butDosije.Name = "butDosije";
            this.butDosije.Size = new System.Drawing.Size(220, 58);
            this.butDosije.TabIndex = 5;
            this.butDosije.Text = "Dosije";
            this.butDosije.UseVisualStyleBackColor = false;
            this.butDosije.Click += new System.EventHandler(this.butDosije_Click);
            // 
            // butRegistar
            // 
            this.butRegistar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.butRegistar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butRegistar.FlatAppearance.BorderSize = 0;
            this.butRegistar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRegistar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRegistar.ForeColor = System.Drawing.Color.White;
            this.butRegistar.Image = global::Policijska_Uprava.Properties.Resources.icons8_user_male_48;
            this.butRegistar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butRegistar.Location = new System.Drawing.Point(12, 102);
            this.butRegistar.Margin = new System.Windows.Forms.Padding(0);
            this.butRegistar.Name = "butRegistar";
            this.butRegistar.Size = new System.Drawing.Size(220, 58);
            this.butRegistar.TabIndex = 4;
            this.butRegistar.Text = "Registar";
            this.butRegistar.UseVisualStyleBackColor = false;
            this.butRegistar.Click += new System.EventHandler(this.butRegistar_Click);
            // 
            // butPocetna
            // 
            this.butPocetna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.butPocetna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butPocetna.FlatAppearance.BorderSize = 0;
            this.butPocetna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPocetna.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPocetna.ForeColor = System.Drawing.Color.White;
            this.butPocetna.Image = global::Policijska_Uprava.Properties.Resources.icons8_home_48;
            this.butPocetna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butPocetna.Location = new System.Drawing.Point(12, 44);
            this.butPocetna.Margin = new System.Windows.Forms.Padding(0);
            this.butPocetna.Name = "butPocetna";
            this.butPocetna.Size = new System.Drawing.Size(220, 58);
            this.butPocetna.TabIndex = 3;
            this.butPocetna.Text = "Pocetna";
            this.butPocetna.UseVisualStyleBackColor = false;
            this.butPocetna.Click += new System.EventHandler(this.butPocetna_Click);
            // 
            // textPretraga
            // 
            this.textPretraga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.textPretraga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPretraga.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPretraga.ForeColor = System.Drawing.Color.White;
            this.textPretraga.Location = new System.Drawing.Point(178, 232);
            this.textPretraga.MaxLength = 13;
            this.textPretraga.Name = "textPretraga";
            this.textPretraga.Size = new System.Drawing.Size(294, 33);
            this.textPretraga.TabIndex = 2;
            this.textPretraga.Text = "Unesi JMBG";
            this.textPretraga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPretraga.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textPretraga_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.usrcKazne2);
            this.panel1.Controls.Add(this.osnovniPodaci1);
            this.panel1.Controls.Add(this.usrPolicajac1);
            this.panel1.Controls.Add(this.dosije1);
            this.panel1.Controls.Add(this.usrcKazne1);
            this.panel1.Controls.Add(this.registar1);
            this.panel1.Controls.Add(this.textPretraga);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.butTrazi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(232, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 455);
            this.panel1.TabIndex = 6;
            // 
            // usrcKazne2
            // 
            this.usrcKazne2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.usrcKazne2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.usrcKazne2.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.usrcKazne2.Location = new System.Drawing.Point(206, 101);
            this.usrcKazne2.MaximumSize = new System.Drawing.Size(658, 455);
            this.usrcKazne2.Name = "usrcKazne2";
            this.usrcKazne2.Size = new System.Drawing.Size(8, 8);
            this.usrcKazne2.TabIndex = 11;
            // 
            // osnovniPodaci1
            // 
            this.osnovniPodaci1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.osnovniPodaci1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.osnovniPodaci1.Location = new System.Drawing.Point(0, 0);
            this.osnovniPodaci1.Name = "osnovniPodaci1";
            this.osnovniPodaci1.Size = new System.Drawing.Size(658, 452);
            this.osnovniPodaci1.TabIndex = 10;
            // 
            // usrPolicajac1
            // 
            this.usrPolicajac1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.usrPolicajac1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.usrPolicajac1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.usrPolicajac1.ForeColor = System.Drawing.Color.White;
            this.usrPolicajac1.Location = new System.Drawing.Point(0, -4);
            this.usrPolicajac1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usrPolicajac1.Name = "usrPolicajac1";
            this.usrPolicajac1.Size = new System.Drawing.Size(658, 455);
            this.usrPolicajac1.TabIndex = 9;
            // 
            // dosije1
            // 
            this.dosije1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.dosije1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dosije1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.dosije1.ForeColor = System.Drawing.Color.White;
            this.dosije1.Location = new System.Drawing.Point(0, 0);
            this.dosije1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dosije1.Name = "dosije1";
            this.dosije1.Size = new System.Drawing.Size(658, 455);
            this.dosije1.TabIndex = 8;
            // 
            // usrcKazne1
            // 
            this.usrcKazne1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.usrcKazne1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.usrcKazne1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.usrcKazne1.Location = new System.Drawing.Point(3, 3);
            this.usrcKazne1.MaximumSize = new System.Drawing.Size(658, 455);
            this.usrcKazne1.Name = "usrcKazne1";
            this.usrcKazne1.Size = new System.Drawing.Size(658, 455);
            this.usrcKazne1.TabIndex = 7;
            // 
            // registar1
            // 
            this.registar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.registar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registar1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.registar1.ForeColor = System.Drawing.Color.White;
            this.registar1.Location = new System.Drawing.Point(0, 3);
            this.registar1.MaximumSize = new System.Drawing.Size(658, 455);
            this.registar1.Name = "registar1";
            this.registar1.Size = new System.Drawing.Size(658, 455);
            this.registar1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Policijska_Uprava.Properties.Resources.icons8_user_male_48;
            this.pictureBox1.Location = new System.Drawing.Point(307, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // butTrazi
            // 
            this.butTrazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.butTrazi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butTrazi.FlatAppearance.BorderSize = 0;
            this.butTrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butTrazi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTrazi.ForeColor = System.Drawing.Color.White;
            this.butTrazi.Image = global::Policijska_Uprava.Properties.Resources.icons8_search_48;
            this.butTrazi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butTrazi.Location = new System.Drawing.Point(220, 296);
            this.butTrazi.Margin = new System.Windows.Forms.Padding(0);
            this.butTrazi.Name = "butTrazi";
            this.butTrazi.Size = new System.Drawing.Size(220, 58);
            this.butTrazi.TabIndex = 4;
            this.butTrazi.Text = "Trazi";
            this.butTrazi.UseVisualStyleBackColor = false;
            this.butTrazi.Click += new System.EventHandler(this.butTrazi_Click);
            // 
            // frmPolicijskaUprava
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(890, 519);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelHead);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPolicijskaUprava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Policijska Uprava";
            this.Load += new System.EventHandler(this.frmPolicijskaUprava_Load);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblPolicijskaUprava;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butnExit;
        private System.Windows.Forms.Button butPocetna;
        private System.Windows.Forms.Button butKazne;
        private System.Windows.Forms.Button butDosije;
        private System.Windows.Forms.Button butRegistar;
        private System.Windows.Forms.Panel panelAktivni;
        private System.Windows.Forms.TextBox textPretraga;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button butTrazi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Registar registar1;
        private usrcKazne usrcKazne1;
        private usrDosije dosije1;
        private System.Windows.Forms.Button butPolicajac;
        private usrPolicajac usrPolicajac1;
        private uscPocetna uscPocetna1;
        private uscPocetna uscPocetna2;
        private OsnovniPodaci osnovniPodaci1;
        private usrcKazne usrcKazne2;
    }
}

