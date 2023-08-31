namespace Policijska_Uprava
{
    partial class usrPolicajac
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.butIzbrisi = new System.Windows.Forms.Button();
            this.butDodaj = new System.Windows.Forms.Button();
            this.textDatumRodjenja = new System.Windows.Forms.TextBox();
            this.textPol = new System.Windows.Forms.TextBox();
            this.textJMBG = new System.Windows.Forms.TextBox();
            this.textPrezime = new System.Windows.Forms.TextBox();
            this.textIme = new System.Windows.Forms.TextBox();
            this.dataGridViewPolicija = new System.Windows.Forms.DataGridView();
            this.textBoxBrojZnacke = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolicija)).BeginInit();
            this.SuspendLayout();
            // 
            // butIzbrisi
            // 
            this.butIzbrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.butIzbrisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butIzbrisi.FlatAppearance.BorderSize = 0;
            this.butIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butIzbrisi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butIzbrisi.ForeColor = System.Drawing.Color.White;
            this.butIzbrisi.Image = global::Policijska_Uprava.Properties.Resources.icons8_trash_48;
            this.butIzbrisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butIzbrisi.Location = new System.Drawing.Point(385, 361);
            this.butIzbrisi.Margin = new System.Windows.Forms.Padding(0);
            this.butIzbrisi.Name = "butIzbrisi";
            this.butIzbrisi.Size = new System.Drawing.Size(220, 58);
            this.butIzbrisi.TabIndex = 20;
            this.butIzbrisi.Text = "Izbrisi";
            this.butIzbrisi.UseVisualStyleBackColor = false;
            this.butIzbrisi.Click += new System.EventHandler(this.butIzbrisi_Click);
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
            this.butDodaj.Location = new System.Drawing.Point(52, 361);
            this.butDodaj.Margin = new System.Windows.Forms.Padding(0);
            this.butDodaj.Name = "butDodaj";
            this.butDodaj.Size = new System.Drawing.Size(220, 58);
            this.butDodaj.TabIndex = 18;
            this.butDodaj.Text = "Dodaj";
            this.butDodaj.UseVisualStyleBackColor = false;
            this.butDodaj.Click += new System.EventHandler(this.butDodaj_Click);
            // 
            // textDatumRodjenja
            // 
            this.textDatumRodjenja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.textDatumRodjenja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDatumRodjenja.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDatumRodjenja.ForeColor = System.Drawing.Color.White;
            this.textDatumRodjenja.Location = new System.Drawing.Point(17, 230);
            this.textDatumRodjenja.MaxLength = 30;
            this.textDatumRodjenja.Name = "textDatumRodjenja";
            this.textDatumRodjenja.Size = new System.Drawing.Size(233, 33);
            this.textDatumRodjenja.TabIndex = 16;
            this.textDatumRodjenja.Text = "Unesi Datum Rodjenja";
            this.textDatumRodjenja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textDatumRodjenja.Enter += new System.EventHandler(this.textDatumRodjenja_Enter);
            this.textDatumRodjenja.Leave += new System.EventHandler(this.textDatumRodjenja_Leave);
            // 
            // textPol
            // 
            this.textPol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.textPol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPol.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPol.ForeColor = System.Drawing.Color.White;
            this.textPol.Location = new System.Drawing.Point(28, 191);
            this.textPol.MaxLength = 30;
            this.textPol.Name = "textPol";
            this.textPol.Size = new System.Drawing.Size(207, 33);
            this.textPol.TabIndex = 15;
            this.textPol.Text = "Unesi Pol";
            this.textPol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPol.Enter += new System.EventHandler(this.textPol_Enter);
            this.textPol.Leave += new System.EventHandler(this.textPol_Leave);
            // 
            // textJMBG
            // 
            this.textJMBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.textJMBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textJMBG.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textJMBG.ForeColor = System.Drawing.Color.White;
            this.textJMBG.Location = new System.Drawing.Point(28, 152);
            this.textJMBG.MaxLength = 13;
            this.textJMBG.Name = "textJMBG";
            this.textJMBG.Size = new System.Drawing.Size(207, 33);
            this.textJMBG.TabIndex = 14;
            this.textJMBG.Text = "Unesi JMBG";
            this.textJMBG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textJMBG.Enter += new System.EventHandler(this.textJMBG_Enter);
            this.textJMBG.Leave += new System.EventHandler(this.textJMBG_Leave);
            // 
            // textPrezime
            // 
            this.textPrezime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.textPrezime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPrezime.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrezime.ForeColor = System.Drawing.Color.White;
            this.textPrezime.Location = new System.Drawing.Point(28, 113);
            this.textPrezime.MaxLength = 30;
            this.textPrezime.Name = "textPrezime";
            this.textPrezime.Size = new System.Drawing.Size(207, 33);
            this.textPrezime.TabIndex = 21;
            this.textPrezime.Text = "Unesi Prezime";
            this.textPrezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPrezime.Enter += new System.EventHandler(this.textPrezime_Enter);
            this.textPrezime.Leave += new System.EventHandler(this.textPrezime_Leave);
            // 
            // textIme
            // 
            this.textIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.textIme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textIme.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIme.ForeColor = System.Drawing.Color.White;
            this.textIme.Location = new System.Drawing.Point(28, 74);
            this.textIme.MaxLength = 30;
            this.textIme.Name = "textIme";
            this.textIme.Size = new System.Drawing.Size(207, 33);
            this.textIme.TabIndex = 19;
            this.textIme.Text = "Unesi Ime";
            this.textIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textIme.Enter += new System.EventHandler(this.textIme_Enter);
            this.textIme.Leave += new System.EventHandler(this.textIme_Leave);
            // 
            // dataGridViewPolicija
            // 
            this.dataGridViewPolicija.AllowUserToAddRows = false;
            this.dataGridViewPolicija.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dataGridViewPolicija.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPolicija.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.dataGridViewPolicija.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPolicija.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewPolicija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPolicija.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewPolicija.EnableHeadersVisualStyles = false;
            this.dataGridViewPolicija.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridViewPolicija.Location = new System.Drawing.Point(270, 35);
            this.dataGridViewPolicija.Name = "dataGridViewPolicija";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPolicija.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewPolicija.Size = new System.Drawing.Size(372, 228);
            this.dataGridViewPolicija.TabIndex = 13;
            // 
            // textBoxBrojZnacke
            // 
            this.textBoxBrojZnacke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.textBoxBrojZnacke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBrojZnacke.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBrojZnacke.ForeColor = System.Drawing.Color.White;
            this.textBoxBrojZnacke.Location = new System.Drawing.Point(28, 35);
            this.textBoxBrojZnacke.MaxLength = 30;
            this.textBoxBrojZnacke.Name = "textBoxBrojZnacke";
            this.textBoxBrojZnacke.Size = new System.Drawing.Size(207, 33);
            this.textBoxBrojZnacke.TabIndex = 22;
            this.textBoxBrojZnacke.Text = "Unesi Broj Znacke";
            this.textBoxBrojZnacke.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBrojZnacke.Enter += new System.EventHandler(this.textBoxBrojZnacke_Enter);
            this.textBoxBrojZnacke.Leave += new System.EventHandler(this.textBoxBrojZnacke_Leave);
            // 
            // usrPolicajac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.textBoxBrojZnacke);
            this.Controls.Add(this.butIzbrisi);
            this.Controls.Add(this.butDodaj);
            this.Controls.Add(this.textDatumRodjenja);
            this.Controls.Add(this.textPol);
            this.Controls.Add(this.textJMBG);
            this.Controls.Add(this.textPrezime);
            this.Controls.Add(this.textIme);
            this.Controls.Add(this.dataGridViewPolicija);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "usrPolicajac";
            this.Size = new System.Drawing.Size(658, 455);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolicija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butIzbrisi;
        private System.Windows.Forms.Button butDodaj;
        private System.Windows.Forms.TextBox textDatumRodjenja;
        private System.Windows.Forms.TextBox textPol;
        private System.Windows.Forms.TextBox textJMBG;
        private System.Windows.Forms.TextBox textPrezime;
        private System.Windows.Forms.TextBox textIme;
        private System.Windows.Forms.DataGridView dataGridViewPolicija;
        private System.Windows.Forms.TextBox textBoxBrojZnacke;
    }
}
