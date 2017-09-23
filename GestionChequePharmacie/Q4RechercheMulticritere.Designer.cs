namespace GestionChequePharmacie
{
    partial class Q4RechercheMulticritere
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CB_Numero_Magazine = new System.Windows.Forms.ComboBox();
            this.CB_Code_Motif = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Montant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_CIN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DTP_DateEmission = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTN_Afficher = new System.Windows.Forms.Button();
            this.CB_Banque = new System.Windows.Forms.ComboBox();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.Supprimer_cheque = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Date Emission",
            "Montant",
            "Motif de Rejet",
            "CIN",
            "Client Banque",
            "Magasin"});
            this.checkedListBox1.Location = new System.Drawing.Point(31, 43);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(165, 179);
            this.checkedListBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Motif de rejet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Magazine";
            // 
            // CB_Numero_Magazine
            // 
            this.CB_Numero_Magazine.FormattingEnabled = true;
            this.CB_Numero_Magazine.Location = new System.Drawing.Point(326, 177);
            this.CB_Numero_Magazine.Name = "CB_Numero_Magazine";
            this.CB_Numero_Magazine.Size = new System.Drawing.Size(121, 21);
            this.CB_Numero_Magazine.TabIndex = 3;
            // 
            // CB_Code_Motif
            // 
            this.CB_Code_Motif.FormattingEnabled = true;
            this.CB_Code_Motif.Location = new System.Drawing.Point(326, 101);
            this.CB_Code_Motif.Name = "CB_Code_Motif";
            this.CB_Code_Motif.Size = new System.Drawing.Size(121, 21);
            this.CB_Code_Motif.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Banque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Montant";
            // 
            // TB_Montant
            // 
            this.TB_Montant.Location = new System.Drawing.Point(326, 75);
            this.TB_Montant.Name = "TB_Montant";
            this.TB_Montant.Size = new System.Drawing.Size(100, 20);
            this.TB_Montant.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CIN";
            // 
            // TB_CIN
            // 
            this.TB_CIN.Location = new System.Drawing.Point(326, 125);
            this.TB_CIN.Name = "TB_CIN";
            this.TB_CIN.Size = new System.Drawing.Size(100, 20);
            this.TB_CIN.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date Emission";
            // 
            // DTP_DateEmission
            // 
            this.DTP_DateEmission.CustomFormat = "dd/MM/yyyy";
            this.DTP_DateEmission.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_DateEmission.Location = new System.Drawing.Point(326, 47);
            this.DTP_DateEmission.Name = "DTP_DateEmission";
            this.DTP_DateEmission.Size = new System.Drawing.Size(200, 20);
            this.DTP_DateEmission.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Supprimer_cheque});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(772, 140);
            this.dataGridView1.TabIndex = 11;
            // 
            // BTN_Afficher
            // 
            this.BTN_Afficher.Location = new System.Drawing.Point(326, 215);
            this.BTN_Afficher.Name = "BTN_Afficher";
            this.BTN_Afficher.Size = new System.Drawing.Size(121, 23);
            this.BTN_Afficher.TabIndex = 12;
            this.BTN_Afficher.Text = "Afficher";
            this.BTN_Afficher.UseVisualStyleBackColor = true;
            this.BTN_Afficher.Click += new System.EventHandler(this.BTN_Afficher_Click);
            // 
            // CB_Banque
            // 
            this.CB_Banque.FormattingEnabled = true;
            this.CB_Banque.Location = new System.Drawing.Point(326, 149);
            this.CB_Banque.Name = "CB_Banque";
            this.CB_Banque.Size = new System.Drawing.Size(121, 21);
            this.CB_Banque.TabIndex = 13;
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Location = new System.Drawing.Point(326, 407);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(121, 23);
            this.BTN_Supprimer.TabIndex = 12;
            this.BTN_Supprimer.Text = "Supprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = true;
            this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // Supprimer_cheque
            // 
            this.Supprimer_cheque.FalseValue = "F";
            this.Supprimer_cheque.HeaderText = "Supprimer";
            this.Supprimer_cheque.Name = "Supprimer_cheque";
            this.Supprimer_cheque.TrueValue = "T";
            this.Supprimer_cheque.Width = 60;
            // 
            // Q4RechercheMulticritere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 442);
            this.Controls.Add(this.CB_Banque);
            this.Controls.Add(this.BTN_Supprimer);
            this.Controls.Add(this.BTN_Afficher);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DTP_DateEmission);
            this.Controls.Add(this.TB_CIN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_Montant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CB_Numero_Magazine);
            this.Controls.Add(this.CB_Code_Motif);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Q4RechercheMulticritere";
            this.Text = "Q4RechercheMulticritere";
            this.Load += new System.EventHandler(this.Q4RechercheMulticritere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CB_Numero_Magazine;
        private System.Windows.Forms.ComboBox CB_Code_Motif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Montant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_CIN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTP_DateEmission;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_Afficher;
        private System.Windows.Forms.ComboBox CB_Banque;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Supprimer_cheque;
    }
}