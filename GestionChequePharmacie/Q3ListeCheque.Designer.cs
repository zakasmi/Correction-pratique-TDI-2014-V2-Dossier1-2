namespace GestionChequePharmacie
{
    partial class Q3ListeCheque
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
            this.CB_Code_Motif = new System.Windows.Forms.ComboBox();
            this.CB_Numero_Magazine = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Liste_Cheque = new System.Windows.Forms.DataGridView();
            this.BTN_Afficher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Liste_Cheque)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_Code_Motif
            // 
            this.CB_Code_Motif.FormattingEnabled = true;
            this.CB_Code_Motif.Location = new System.Drawing.Point(82, 24);
            this.CB_Code_Motif.Name = "CB_Code_Motif";
            this.CB_Code_Motif.Size = new System.Drawing.Size(121, 21);
            this.CB_Code_Motif.TabIndex = 0;
            // 
            // CB_Numero_Magazine
            // 
            this.CB_Numero_Magazine.FormattingEnabled = true;
            this.CB_Numero_Magazine.Location = new System.Drawing.Point(299, 24);
            this.CB_Numero_Magazine.Name = "CB_Numero_Magazine";
            this.CB_Numero_Magazine.Size = new System.Drawing.Size(121, 21);
            this.CB_Numero_Magazine.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Magazine";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Motif";
            // 
            // DGV_Liste_Cheque
            // 
            this.DGV_Liste_Cheque.AllowUserToAddRows = false;
            this.DGV_Liste_Cheque.AllowUserToDeleteRows = false;
            this.DGV_Liste_Cheque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Liste_Cheque.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV_Liste_Cheque.Location = new System.Drawing.Point(0, 81);
            this.DGV_Liste_Cheque.Name = "DGV_Liste_Cheque";
            this.DGV_Liste_Cheque.ReadOnly = true;
            this.DGV_Liste_Cheque.Size = new System.Drawing.Size(634, 274);
            this.DGV_Liste_Cheque.TabIndex = 3;
            // 
            // BTN_Afficher
            // 
            this.BTN_Afficher.Location = new System.Drawing.Point(470, 21);
            this.BTN_Afficher.Name = "BTN_Afficher";
            this.BTN_Afficher.Size = new System.Drawing.Size(75, 23);
            this.BTN_Afficher.TabIndex = 4;
            this.BTN_Afficher.Text = "Afficher";
            this.BTN_Afficher.UseVisualStyleBackColor = true;
            this.BTN_Afficher.Click += new System.EventHandler(this.BTN_Afficher_Click);
            // 
            // Q3ListeCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 355);
            this.Controls.Add(this.BTN_Afficher);
            this.Controls.Add(this.DGV_Liste_Cheque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CB_Numero_Magazine);
            this.Controls.Add(this.CB_Code_Motif);
            this.Name = "Q3ListeCheque";
            this.Text = "Q3ListeCheque";
            this.Load += new System.EventHandler(this.Q3ListeCheque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Liste_Cheque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Code_Motif;
        private System.Windows.Forms.ComboBox CB_Numero_Magazine;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Liste_Cheque;
        private System.Windows.Forms.Button BTN_Afficher;
    }
}