namespace Policijska_Uprava
{
    partial class usrcKazne
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
            this.textPoene = new System.Windows.Forms.TextBox();
            this.textZatvor = new System.Windows.Forms.TextBox();
            this.textIznos = new System.Windows.Forms.TextBox();
            this.textTip = new System.Windows.Forms.TextBox();
            this.comboBoxKazne = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butOsvezi = new System.Windows.Forms.Button();
            this.butUpdejtuj = new System.Windows.Forms.Button();
            this.butIzbrisi = new System.Windows.Forms.Button();
            this.butDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textPoene
            // 
            this.textPoene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.textPoene.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPoene.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPoene.ForeColor = System.Drawing.Color.White;
            this.textPoene.Location = new System.Drawing.Point(77, 336);
            this.textPoene.MaxLength = 30;
            this.textPoene.Name = "textPoene";
            this.textPoene.Size = new System.Drawing.Size(222, 33);
            this.textPoene.TabIndex = 10;
            this.textPoene.Text = "Unesi Poene";
            this.textPoene.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPoene.Enter += new System.EventHandler(this.textPoene_Enter);
            this.textPoene.Leave += new System.EventHandler(this.textPoene_Leave);
            // 
            // textZatvor
            // 
            this.textZatvor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.textZatvor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textZatvor.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textZatvor.ForeColor = System.Drawing.Color.White;
            this.textZatvor.Location = new System.Drawing.Point(77, 297);
            this.textZatvor.MaxLength = 13;
            this.textZatvor.Name = "textZatvor";
            this.textZatvor.Size = new System.Drawing.Size(222, 33);
            this.textZatvor.TabIndex = 9;
            this.textZatvor.Text = "Unesi Sluzenje";
            this.textZatvor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textZatvor.Enter += new System.EventHandler(this.textZatvor_Enter);
            this.textZatvor.Leave += new System.EventHandler(this.textZatvor_Leave);
            // 
            // textIznos
            // 
            this.textIznos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.textIznos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textIznos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIznos.ForeColor = System.Drawing.Color.White;
            this.textIznos.Location = new System.Drawing.Point(77, 258);
            this.textIznos.MaxLength = 30;
            this.textIznos.Name = "textIznos";
            this.textIznos.Size = new System.Drawing.Size(222, 33);
            this.textIznos.TabIndex = 12;
            this.textIznos.Text = "Unesi Iznos";
            this.textIznos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textIznos.Enter += new System.EventHandler(this.textIznos_Enter);
            this.textIznos.Leave += new System.EventHandler(this.textIznos_Leave);
            // 
            // textTip
            // 
            this.textTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.textTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTip.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTip.ForeColor = System.Drawing.Color.White;
            this.textTip.Location = new System.Drawing.Point(3, 219);
            this.textTip.MaxLength = 30;
            this.textTip.Name = "textTip";
            this.textTip.Size = new System.Drawing.Size(364, 33);
            this.textTip.TabIndex = 11;
            this.textTip.Text = "Unesi Tip Kazne";
            this.textTip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textTip.Enter += new System.EventHandler(this.textTip_Enter);
            this.textTip.Leave += new System.EventHandler(this.textTip_Leave);
            // 
            // comboBoxKazne
            // 
            this.comboBoxKazne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.comboBoxKazne.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.comboBoxKazne.ForeColor = System.Drawing.Color.White;
            this.comboBoxKazne.FormattingEnabled = true;
            this.comboBoxKazne.Location = new System.Drawing.Point(3, 126);
            this.comboBoxKazne.Name = "comboBoxKazne";
            this.comboBoxKazne.Size = new System.Drawing.Size(364, 32);
            this.comboBoxKazne.TabIndex = 13;
            this.comboBoxKazne.SelectedValueChanged += new System.EventHandler(this.comboBoxKazne_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(123, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nove kazne";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Odaberi postojecu kaznu";
            // 
            // butOsvezi
            // 
            this.butOsvezi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.butOsvezi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butOsvezi.FlatAppearance.BorderSize = 0;
            this.butOsvezi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butOsvezi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOsvezi.ForeColor = System.Drawing.Color.White;
            this.butOsvezi.Image = global::Policijska_Uprava.Properties.Resources.icons8_synchronize_48;
            this.butOsvezi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butOsvezi.Location = new System.Drawing.Point(395, 233);
            this.butOsvezi.Margin = new System.Windows.Forms.Padding(0);
            this.butOsvezi.Name = "butOsvezi";
            this.butOsvezi.Size = new System.Drawing.Size(220, 58);
            this.butOsvezi.TabIndex = 19;
            this.butOsvezi.Text = "Osvezi";
            this.butOsvezi.UseVisualStyleBackColor = false;
            this.butOsvezi.Click += new System.EventHandler(this.butOsvezi_Click);
            // 
            // butUpdejtuj
            // 
            this.butUpdejtuj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.butUpdejtuj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butUpdejtuj.FlatAppearance.BorderSize = 0;
            this.butUpdejtuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butUpdejtuj.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUpdejtuj.ForeColor = System.Drawing.Color.White;
            this.butUpdejtuj.Image = global::Policijska_Uprava.Properties.Resources.icons8_edit_48;
            this.butUpdejtuj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butUpdejtuj.Location = new System.Drawing.Point(395, 155);
            this.butUpdejtuj.Margin = new System.Windows.Forms.Padding(0);
            this.butUpdejtuj.Name = "butUpdejtuj";
            this.butUpdejtuj.Size = new System.Drawing.Size(220, 58);
            this.butUpdejtuj.TabIndex = 18;
            this.butUpdejtuj.Text = "Updejtuj";
            this.butUpdejtuj.UseVisualStyleBackColor = false;
            this.butUpdejtuj.Click += new System.EventHandler(this.butUpdejtuj_Click);
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
            this.butIzbrisi.Location = new System.Drawing.Point(395, 311);
            this.butIzbrisi.Margin = new System.Windows.Forms.Padding(0);
            this.butIzbrisi.Name = "butIzbrisi";
            this.butIzbrisi.Size = new System.Drawing.Size(220, 58);
            this.butIzbrisi.TabIndex = 17;
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
            this.butDodaj.Location = new System.Drawing.Point(395, 80);
            this.butDodaj.Margin = new System.Windows.Forms.Padding(0);
            this.butDodaj.Name = "butDodaj";
            this.butDodaj.Size = new System.Drawing.Size(220, 58);
            this.butDodaj.TabIndex = 16;
            this.butDodaj.Text = "Dodaj";
            this.butDodaj.UseVisualStyleBackColor = false;
            this.butDodaj.Click += new System.EventHandler(this.butDodaj_Click);
            // 
            // usrcKazne
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.butOsvezi);
            this.Controls.Add(this.butUpdejtuj);
            this.Controls.Add(this.butIzbrisi);
            this.Controls.Add(this.butDodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxKazne);
            this.Controls.Add(this.textPoene);
            this.Controls.Add(this.textZatvor);
            this.Controls.Add(this.textIznos);
            this.Controls.Add(this.textTip);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.MaximumSize = new System.Drawing.Size(658, 455);
            this.Name = "usrcKazne";
            this.Size = new System.Drawing.Size(658, 455);
            this.Load += new System.EventHandler(this.usrcKazne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPoene;
        private System.Windows.Forms.TextBox textZatvor;
        private System.Windows.Forms.TextBox textIznos;
        private System.Windows.Forms.TextBox textTip;
        private System.Windows.Forms.ComboBox comboBoxKazne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butIzbrisi;
        private System.Windows.Forms.Button butDodaj;
        private System.Windows.Forms.Button butUpdejtuj;
        private System.Windows.Forms.Button butOsvezi;
    }
}
