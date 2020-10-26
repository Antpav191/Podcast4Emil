namespace POD
{
    partial class Form1
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
            this.dataGridViewPodcast = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamn = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.cmbUppdatering = new System.Windows.Forms.ComboBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.btnLaggTillPodcast = new System.Windows.Forms.Button();
            this.btnAndraPodcast = new System.Windows.Forms.Button();
            this.btnTaBortPodcast = new System.Windows.Forms.Button();
            this.dataGridViewAvsnitt = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBoxKategorier = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamnKategori = new System.Windows.Forms.TextBox();
            this.btnLaggTillKategori = new System.Windows.Forms.Button();
            this.btnAndraKategori = new System.Windows.Forms.Button();
            this.btnTaBortKategori = new System.Windows.Forms.Button();
            this.btnVisaKategori = new System.Windows.Forms.Button();
            this.lblUppdatering = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.txtBeskrivning = new System.Windows.Forms.TextBox();
            this.btnVisaAllaKategori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPodcast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvsnitt)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPodcast
            // 
            this.dataGridViewPodcast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPodcast.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column3,
            this.Column2,
            this.Column5});
            this.dataGridViewPodcast.Location = new System.Drawing.Point(19, 20);
            this.dataGridViewPodcast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewPodcast.Name = "dataGridViewPodcast";
            this.dataGridViewPodcast.ReadOnly = true;
            this.dataGridViewPodcast.RowHeadersWidth = 51;
            this.dataGridViewPodcast.Size = new System.Drawing.Size(844, 345);
            this.dataGridViewPodcast.TabIndex = 0;
            this.dataGridViewPodcast.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPodcast_CellClick);
            this.dataGridViewPodcast.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPodcast_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Namn";
            this.Column1.HeaderText = "Namn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Kategori";
            this.Column4.HeaderText = "Kategori";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Uppdatering";
            this.Column3.HeaderText = "Uppdaterings- intervall";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "antalAvsnitt";
            this.Column2.HeaderText = "Antal avsnitt";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "nyaAvsnitt";
            this.Column5.HeaderText = "Nytt avsnitt finns";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 395);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Namn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 395);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "URL";
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(22, 434);
            this.txtNamn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNamn.Multiline = true;
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(148, 29);
            this.txtNamn.TabIndex = 3;
            this.txtNamn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(197, 434);
            this.txtURL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtURL.Multiline = true;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(235, 29);
            this.txtURL.TabIndex = 4;
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // cmbUppdatering
            // 
            this.cmbUppdatering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUppdatering.FormattingEnabled = true;
            this.cmbUppdatering.Items.AddRange(new object[] {
            "5 minuter",
            "10 minuter",
            "15 minuter",
            "30 minuter"});
            this.cmbUppdatering.Location = new System.Drawing.Point(470, 434);
            this.cmbUppdatering.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbUppdatering.Name = "cmbUppdatering";
            this.cmbUppdatering.Size = new System.Drawing.Size(180, 28);
            this.cmbUppdatering.TabIndex = 5;
            this.cmbUppdatering.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbKategori
            // 
            this.cmbKategori.DisplayMember = "Namn";
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(683, 434);
            this.cmbKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(180, 28);
            this.cmbKategori.TabIndex = 6;
            this.cmbKategori.ValueMember = "Namn";
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnLaggTillPodcast
            // 
            this.btnLaggTillPodcast.Location = new System.Drawing.Point(19, 494);
            this.btnLaggTillPodcast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLaggTillPodcast.Name = "btnLaggTillPodcast";
            this.btnLaggTillPodcast.Size = new System.Drawing.Size(112, 35);
            this.btnLaggTillPodcast.TabIndex = 7;
            this.btnLaggTillPodcast.Text = "Lägg till";
            this.btnLaggTillPodcast.UseVisualStyleBackColor = true;
            this.btnLaggTillPodcast.Click += new System.EventHandler(this.btnLaggTillPodcast_Click);
            // 
            // btnAndraPodcast
            // 
            this.btnAndraPodcast.Location = new System.Drawing.Point(143, 494);
            this.btnAndraPodcast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAndraPodcast.Name = "btnAndraPodcast";
            this.btnAndraPodcast.Size = new System.Drawing.Size(112, 35);
            this.btnAndraPodcast.TabIndex = 8;
            this.btnAndraPodcast.Text = "Ändra";
            this.btnAndraPodcast.UseVisualStyleBackColor = true;
            this.btnAndraPodcast.Click += new System.EventHandler(this.btnAndraPodcast_Click);
            // 
            // btnTaBortPodcast
            // 
            this.btnTaBortPodcast.Location = new System.Drawing.Point(266, 494);
            this.btnTaBortPodcast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaBortPodcast.Name = "btnTaBortPodcast";
            this.btnTaBortPodcast.Size = new System.Drawing.Size(112, 35);
            this.btnTaBortPodcast.TabIndex = 9;
            this.btnTaBortPodcast.Text = "Ta bort";
            this.btnTaBortPodcast.UseVisualStyleBackColor = true;
            this.btnTaBortPodcast.Click += new System.EventHandler(this.btnTaBortPodcast_Click);
            // 
            // dataGridViewAvsnitt
            // 
            this.dataGridViewAvsnitt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvsnitt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7});
            this.dataGridViewAvsnitt.Location = new System.Drawing.Point(19, 566);
            this.dataGridViewAvsnitt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewAvsnitt.Name = "dataGridViewAvsnitt";
            this.dataGridViewAvsnitt.ReadOnly = true;
            this.dataGridViewAvsnitt.RowHeadersWidth = 51;
            this.dataGridViewAvsnitt.Size = new System.Drawing.Size(631, 225);
            this.dataGridViewAvsnitt.TabIndex = 10;
            this.dataGridViewAvsnitt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAvsnitt_CellClick);
            this.dataGridViewAvsnitt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAvsnitt_CellContentClick);
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "Titel";
            this.Column6.HeaderText = "Avsnitt";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "Datum";
            this.Column7.HeaderText = "Datum";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // listBoxKategorier
            // 
            this.listBoxKategorier.DisplayMember = "Namn";
            this.listBoxKategorier.FormattingEnabled = true;
            this.listBoxKategorier.ItemHeight = 20;
            this.listBoxKategorier.Location = new System.Drawing.Point(897, 20);
            this.listBoxKategorier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxKategorier.Name = "listBoxKategorier";
            this.listBoxKategorier.Size = new System.Drawing.Size(234, 244);
            this.listBoxKategorier.TabIndex = 11;
            this.listBoxKategorier.ValueMember = "Namn";
            this.listBoxKategorier.SelectedIndexChanged += new System.EventHandler(this.listBoxKategorier_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(893, 391);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Namn";
            // 
            // txtNamnKategori
            // 
            this.txtNamnKategori.Location = new System.Drawing.Point(897, 434);
            this.txtNamnKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNamnKategori.Multiline = true;
            this.txtNamnKategori.Name = "txtNamnKategori";
            this.txtNamnKategori.Size = new System.Drawing.Size(234, 29);
            this.txtNamnKategori.TabIndex = 13;
            this.txtNamnKategori.TextChanged += new System.EventHandler(this.txtNamnKategori_TextChanged);
            // 
            // btnLaggTillKategori
            // 
            this.btnLaggTillKategori.Location = new System.Drawing.Point(897, 494);
            this.btnLaggTillKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLaggTillKategori.Name = "btnLaggTillKategori";
            this.btnLaggTillKategori.Size = new System.Drawing.Size(112, 35);
            this.btnLaggTillKategori.TabIndex = 14;
            this.btnLaggTillKategori.Text = "Lägg till";
            this.btnLaggTillKategori.UseVisualStyleBackColor = true;
            this.btnLaggTillKategori.Click += new System.EventHandler(this.btnLaggTillKategori_Click);
            // 
            // btnAndraKategori
            // 
            this.btnAndraKategori.Location = new System.Drawing.Point(1018, 494);
            this.btnAndraKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAndraKategori.Name = "btnAndraKategori";
            this.btnAndraKategori.Size = new System.Drawing.Size(112, 35);
            this.btnAndraKategori.TabIndex = 15;
            this.btnAndraKategori.Text = "Ändra";
            this.btnAndraKategori.UseVisualStyleBackColor = true;
            this.btnAndraKategori.Click += new System.EventHandler(this.btnAndraKategori_Click);
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Location = new System.Drawing.Point(1018, 330);
            this.btnTaBortKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(112, 35);
            this.btnTaBortKategori.TabIndex = 16;
            this.btnTaBortKategori.Text = "Ta bort";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            this.btnTaBortKategori.Click += new System.EventHandler(this.btnTaBortKategori_Click);
            // 
            // btnVisaKategori
            // 
            this.btnVisaKategori.Location = new System.Drawing.Point(898, 286);
            this.btnVisaKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVisaKategori.Name = "btnVisaKategori";
            this.btnVisaKategori.Size = new System.Drawing.Size(112, 35);
            this.btnVisaKategori.TabIndex = 17;
            this.btnVisaKategori.Text = "Visa vald";
            this.btnVisaKategori.UseVisualStyleBackColor = true;
            this.btnVisaKategori.Click += new System.EventHandler(this.btnVisaKategori_Click);
            // 
            // lblUppdatering
            // 
            this.lblUppdatering.AutoSize = true;
            this.lblUppdatering.Location = new System.Drawing.Point(469, 392);
            this.lblUppdatering.Name = "lblUppdatering";
            this.lblUppdatering.Size = new System.Drawing.Size(158, 20);
            this.lblUppdatering.TabIndex = 19;
            this.lblUppdatering.Text = "Uppdateringsintervall";
            this.lblUppdatering.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(680, 391);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(68, 20);
            this.lblKategori.TabIndex = 20;
            this.lblKategori.Text = "Kategori";
            // 
            // txtBeskrivning
            // 
            this.txtBeskrivning.Location = new System.Drawing.Point(683, 566);
            this.txtBeskrivning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBeskrivning.Multiline = true;
            this.txtBeskrivning.Name = "txtBeskrivning";
            this.txtBeskrivning.ReadOnly = true;
            this.txtBeskrivning.Size = new System.Drawing.Size(447, 224);
            this.txtBeskrivning.TabIndex = 21;
            // 
            // btnVisaAllaKategori
            // 
            this.btnVisaAllaKategori.Location = new System.Drawing.Point(1018, 286);
            this.btnVisaAllaKategori.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVisaAllaKategori.Name = "btnVisaAllaKategori";
            this.btnVisaAllaKategori.Size = new System.Drawing.Size(112, 35);
            this.btnVisaAllaKategori.TabIndex = 22;
            this.btnVisaAllaKategori.Text = "Visa alla";
            this.btnVisaAllaKategori.UseVisualStyleBackColor = true;
            this.btnVisaAllaKategori.Click += new System.EventHandler(this.btnVisaAllaKategori_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1164, 839);
            this.Controls.Add(this.btnVisaAllaKategori);
            this.Controls.Add(this.txtBeskrivning);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblUppdatering);
            this.Controls.Add(this.btnVisaKategori);
            this.Controls.Add(this.btnTaBortKategori);
            this.Controls.Add(this.btnAndraKategori);
            this.Controls.Add(this.btnLaggTillKategori);
            this.Controls.Add(this.txtNamnKategori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxKategorier);
            this.Controls.Add(this.dataGridViewAvsnitt);
            this.Controls.Add(this.btnTaBortPodcast);
            this.Controls.Add(this.btnAndraPodcast);
            this.Controls.Add(this.btnLaggTillPodcast);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.cmbUppdatering);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtNamn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPodcast);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "PodcastAppen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPodcast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvsnitt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPodcast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamn;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.ComboBox cmbUppdatering;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Button btnLaggTillPodcast;
        private System.Windows.Forms.Button btnAndraPodcast;
        private System.Windows.Forms.Button btnTaBortPodcast;
        private System.Windows.Forms.DataGridView dataGridViewAvsnitt;
        private System.Windows.Forms.ListBox listBoxKategorier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamnKategori;
        private System.Windows.Forms.Button btnLaggTillKategori;
        private System.Windows.Forms.Button btnAndraKategori;
        private System.Windows.Forms.Button btnTaBortKategori;
        private System.Windows.Forms.Button btnVisaKategori;
        private System.Windows.Forms.Label lblUppdatering;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox txtBeskrivning;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnVisaAllaKategori;
    }
}

