namespace Policijska_Uprava
{
    partial class usrDosije
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textJMBG = new System.Windows.Forms.TextBox();
            this.comboBoxKazne = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textDatum = new System.Windows.Forms.TextBox();
            this.butDodaj = new System.Windows.Forms.Button();
            this.pictureBoxNema = new System.Windows.Forms.PictureBox();
            this.pictureBoxChecked = new System.Windows.Forms.PictureBox();
            this.butOsvezi = new System.Windows.Forms.Button();
            this.textIme = new System.Windows.Forms.TextBox();
            this.textPrezime = new System.Windows.Forms.TextBox();
            this.textDatumRodjenja = new System.Windows.Forms.TextBox();
            this.textBoxBrojZnacke = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChecked)).BeginInit();
            this.SuspendLayout();
            // 
            // textJMBG
            // 
            this.textJMBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.textJMBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textJMBG.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textJMBG.ForeColor = System.Drawing.Color.White;
            this.textJMBG.Location = new System.Drawing.Point(224, 81);
            this.textJMBG.MaxLength = 13;
            this.textJMBG.Name = "textJMBG";
            this.textJMBG.Size = new System.Drawing.Size(207, 33);
            this.textJMBG.TabIndex = 4;
            this.textJMBG.Text = "Unesi JMBG";
            this.textJMBG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textJMBG.Enter += new System.EventHandler(this.textJMBG_Enter);
            this.textJMBG.Leave += new System.EventHandler(this.textJMBG_Leave);
            // 
            // comboBoxKazne
            // 
            this.comboBoxKazne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.comboBoxKazne.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.comboBoxKazne.ForeColor = System.Drawing.Color.White;
            this.comboBoxKazne.FormattingEnabled = true;
            this.comboBoxKazne.Location = new System.Drawing.Point(145, 174);
            this.comboBoxKazne.Name = "comboBoxKazne";
            this.comboBoxKazne.Size = new System.Drawing.Size(364, 32);
            this.comboBoxKazne.TabIndex = 14;
            this.comboBoxKazne.SelectedIndexChanged += new System.EventHandler(this.comboBoxKazne_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(189, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Odaberi postojecu kaznu";
            // 
            // textDatum
            // 
            this.textDatum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.textDatum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDatum.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDatum.ForeColor = System.Drawing.Color.White;
            this.textDatum.Location = new System.Drawing.Point(210, 279);
            this.textDatum.MaxLength = 30;
            this.textDatum.Name = "textDatum";
            this.textDatum.Size = new System.Drawing.Size(233, 33);
            this.textDatum.TabIndex = 17;
            this.textDatum.Text = "Unesi Datum";
            this.textDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDatum.Enter += new System.EventHandler(this.textDatum_Enter);
            this.textDatum.Leave += new System.EventHandler(this.textDatum_Leave);
            // 
            // butDodaj
            // 
            this.butDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.butDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butDodaj.FlatAppearance.BorderSize = 0;
            this.butDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDodaj.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDodaj.ForeColor = System.Drawing.Color.White;
            this.butDodaj.Image = global::Policijska_Uprava.Properties.Resources.icons8_plus_48;
            this.butDodaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butDodaj.Location = new System.Drawing.Point(216, 343);
            this.butDodaj.Margin = new System.Windows.Forms.Padding(0);
            this.butDodaj.Name = "butDodaj";
            this.butDodaj.Size = new System.Drawing.Size(220, 58);
            this.butDodaj.TabIndex = 18;
            this.butDodaj.Text = "Dodaj";
            this.butDodaj.UseVisualStyleBackColor = false;
            this.butDodaj.Click += new System.EventHandler(this.butDodaj_Click);
            // 
            // pictureBoxNema
            // 
            this.pictureBoxNema.Image = global::Policijska_Uprava.Properties.Resources.icons8_cancel_48;
            this.pictureBoxNema.Location = new System.Drawing.Point(476, 73);
            this.pictureBoxNema.Name = "pictureBoxNema";
            this.pictureBoxNema.Size = new System.Drawing.Size(49, 50);
            this.pictureBoxNema.TabIndex = 19;
            this.pictureBoxNema.TabStop = false;
            // 
            // pictureBoxChecked
            // 
            this.pictureBoxChecked.Image = global::Policijska_Uprava.Properties.Resources.icons8_checked_48;
            this.pictureBoxChecked.Location = new System.Drawing.Point(476, 73);
            this.pictureBoxChecked.Name = "pictureBoxChecked";
            this.pictureBoxChecked.Size = new System.Drawing.Size(49, 50);
            this.pictureBoxChecked.TabIndex = 20;
            this.pictureBoxChecked.TabStop = false;
            // 
            // butOsvezi
            // 
            this.butOsvezi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.butOsvezi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butOsvezi.FlatAppearance.BorderSize = 0;
            this.butOsvezi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butOsvezi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOsvezi.ForeColor = System.Drawing.Color.White;
            this.butOsvezi.Image = global::Policijska_Uprava.Properties.Resources.icons8_synchronize_48;
            this.butOsvezi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butOsvezi.Location = new System.Drawing.Point(579, 341);
            this.butOsvezi.Margin = new System.Windows.Forms.Padding(0);
            this.butOsvezi.Name = "butOsvezi";
            this.butOsvezi.Size = new System.Drawing.Size(55, 58);
            this.butOsvezi.TabIndex = 21;
            this.butOsvezi.UseVisualStyleBackColor = false;
            this.butOsvezi.Click += new System.EventHandler(this.butOsvezi_Click);
            // 
            // textIme
            // 
            this.textIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.textIme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textIme.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIme.ForeColor = System.Drawing.Color.White;
            this.textIme.Location = new System.Drawing.Point(3, 3);
            this.textIme.MaxLength = 13;
            this.textIme.Name = "textIme";
            this.textIme.ReadOnly = true;
            this.textIme.Size = new System.Drawing.Size(207, 33);
            this.textIme.TabIndex = 22;
            this.textIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPrezime
            // 
            this.textPrezime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.textPrezime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPrezime.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrezime.ForeColor = System.Drawing.Color.White;
            this.textPrezime.Location = new System.Drawing.Point(224, 3);
            this.textPrezime.MaxLength = 13;
            this.textPrezime.Name = "textPrezime";
            this.textPrezime.ReadOnly = true;
            this.textPrezime.Size = new System.Drawing.Size(207, 33);
            this.textPrezime.TabIndex = 23;
            this.textPrezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDatumRodjenja
            // 
            this.textDatumRodjenja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.textDatumRodjenja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDatumRodjenja.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDatumRodjenja.ForeColor = System.Drawing.Color.White;
            this.textDatumRodjenja.Location = new System.Drawing.Point(446, 3);
            this.textDatumRodjenja.MaxLength = 13;
            this.textDatumRodjenja.Name = "textDatumRodjenja";
            this.textDatumRodjenja.ReadOnly = true;
            this.textDatumRodjenja.Size = new System.Drawing.Size(207, 33);
            this.textDatumRodjenja.TabIndex = 24;
            this.textDatumRodjenja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBrojZnacke
            // 
            this.textBoxBrojZnacke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.textBoxBrojZnacke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBrojZnacke.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBrojZnacke.ForeColor = System.Drawing.Color.White;
            this.textBoxBrojZnacke.Location = new System.Drawing.Point(224, 223);
            this.textBoxBrojZnacke.MaxLength = 30;
            this.textBoxBrojZnacke.Name = "textBoxBrojZnacke";
            this.textBoxBrojZnacke.Size = new System.Drawing.Size(207, 33);
            this.textBoxBrojZnacke.TabIndex = 25;
            this.textBoxBrojZnacke.Text = "Unesi Broj Znacke";
            this.textBoxBrojZnacke.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBrojZnacke.Enter += new System.EventHandler(this.textBoxBrojZnacke_Enter);
            this.textBoxBrojZnacke.Leave += new System.EventHandler(this.textBoxBrojZnacke_Leave);
            // 
            // usrDosije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.textBoxBrojZnacke);
            this.Controls.Add(this.textDatumRodjenja);
            this.Controls.Add(this.textPrezime);
            this.Controls.Add(this.textIme);
            this.Controls.Add(this.butOsvezi);
            this.Controls.Add(this.pictureBoxChecked);
            this.Controls.Add(this.pictureBoxNema);
            this.Controls.Add(this.butDodaj);
            this.Controls.Add(this.textDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxKazne);
            this.Controls.Add(this.textJMBG);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "usrDosije";
            this.Size = new System.Drawing.Size(658, 455);
            this.Load += new System.EventHandler(this.Dosije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChecked)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textJMBG;
        private System.Windows.Forms.ComboBox comboBoxKazne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDatum;
        private System.Windows.Forms.Button butDodaj;
        private System.Windows.Forms.PictureBox pictureBoxNema;
        private System.Windows.Forms.PictureBox pictureBoxChecked;
        private System.Windows.Forms.Button butOsvezi;
        private System.Windows.Forms.TextBox textIme;
        private System.Windows.Forms.TextBox textPrezime;
        private System.Windows.Forms.TextBox textDatumRodjenja;
        private System.Windows.Forms.TextBox textBoxBrojZnacke;
    }
}
