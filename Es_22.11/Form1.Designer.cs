namespace Es_22._11
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
            this.dtp_DATA1 = new System.Windows.Forms.DateTimePicker();
            this.dtp_DATA2 = new System.Windows.Forms.DateTimePicker();
            this.Richiesta1 = new System.Windows.Forms.Label();
            this.Richiesta2 = new System.Windows.Forms.Label();
            this.lbl_DIFF = new System.Windows.Forms.Label();
            this.Differenza = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button_agg = new System.Windows.Forms.Button();
            this.button_rm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_RISULTATO = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtp_DATA1
            // 
            this.dtp_DATA1.Location = new System.Drawing.Point(35, 25);
            this.dtp_DATA1.Name = "dtp_DATA1";
            this.dtp_DATA1.Size = new System.Drawing.Size(200, 20);
            this.dtp_DATA1.TabIndex = 0;
            // 
            // dtp_DATA2
            // 
            this.dtp_DATA2.Location = new System.Drawing.Point(241, 25);
            this.dtp_DATA2.Name = "dtp_DATA2";
            this.dtp_DATA2.Size = new System.Drawing.Size(200, 20);
            this.dtp_DATA2.TabIndex = 1;
            // 
            // Richiesta1
            // 
            this.Richiesta1.AutoSize = true;
            this.Richiesta1.Location = new System.Drawing.Point(79, 9);
            this.Richiesta1.Name = "Richiesta1";
            this.Richiesta1.Size = new System.Drawing.Size(108, 13);
            this.Richiesta1.TabIndex = 2;
            this.Richiesta1.Text = "Inserisci la prima data";
            // 
            // Richiesta2
            // 
            this.Richiesta2.AutoSize = true;
            this.Richiesta2.Location = new System.Drawing.Point(269, 9);
            this.Richiesta2.Name = "Richiesta2";
            this.Richiesta2.Size = new System.Drawing.Size(124, 13);
            this.Richiesta2.TabIndex = 3;
            this.Richiesta2.Text = "Inserisci la seconda data";
            // 
            // lbl_DIFF
            // 
            this.lbl_DIFF.AutoSize = true;
            this.lbl_DIFF.Location = new System.Drawing.Point(540, 29);
            this.lbl_DIFF.Name = "lbl_DIFF";
            this.lbl_DIFF.Size = new System.Drawing.Size(0, 13);
            this.lbl_DIFF.TabIndex = 4;
            // 
            // Differenza
            // 
            this.Differenza.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Differenza.Location = new System.Drawing.Point(447, 25);
            this.Differenza.Name = "Differenza";
            this.Differenza.Size = new System.Drawing.Size(87, 20);
            this.Differenza.TabIndex = 5;
            this.Differenza.Text = "Calcola";
            this.Differenza.UseVisualStyleBackColor = false;
            this.Differenza.Click += new System.EventHandler(this.Differenza_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inserisci la prima data";
            // 
            // button_agg
            // 
            this.button_agg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_agg.Location = new System.Drawing.Point(55, 141);
            this.button_agg.Name = "button_agg";
            this.button_agg.Size = new System.Drawing.Size(87, 20);
            this.button_agg.TabIndex = 8;
            this.button_agg.Text = "Aggiungi";
            this.button_agg.UseVisualStyleBackColor = false;
            this.button_agg.Click += new System.EventHandler(this.button_agg_Click);
            // 
            // button_rm
            // 
            this.button_rm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_rm.Location = new System.Drawing.Point(148, 141);
            this.button_rm.Name = "button_rm";
            this.button_rm.Size = new System.Drawing.Size(87, 20);
            this.button_rm.TabIndex = 9;
            this.button_rm.Text = "Rimuovi";
            this.button_rm.UseVisualStyleBackColor = false;
            this.button_rm.Click += new System.EventHandler(this.button_rm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Scegli se aggiungere o rimuovere dalla data i giorni inseriti";
            // 
            // lbl_RISULTATO
            // 
            this.lbl_RISULTATO.AutoSize = true;
            this.lbl_RISULTATO.Location = new System.Drawing.Point(316, 141);
            this.lbl_RISULTATO.Name = "lbl_RISULTATO";
            this.lbl_RISULTATO.Size = new System.Drawing.Size(0, 13);
            this.lbl_RISULTATO.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Inserisci un numero di giorni";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 179);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_RISULTATO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_rm);
            this.Controls.Add(this.button_agg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Differenza);
            this.Controls.Add(this.lbl_DIFF);
            this.Controls.Add(this.Richiesta2);
            this.Controls.Add(this.Richiesta1);
            this.Controls.Add(this.dtp_DATA2);
            this.Controls.Add(this.dtp_DATA1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_DATA1;
        private System.Windows.Forms.DateTimePicker dtp_DATA2;
        private System.Windows.Forms.Label Richiesta1;
        private System.Windows.Forms.Label Richiesta2;
        private System.Windows.Forms.Label lbl_DIFF;
        private System.Windows.Forms.Button Differenza;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_agg;
        private System.Windows.Forms.Button button_rm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_RISULTATO;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}

