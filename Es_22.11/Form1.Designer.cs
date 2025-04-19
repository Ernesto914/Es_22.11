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
            this.Differenza = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button_agg = new System.Windows.Forms.Button();
            this.button_rm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtp_DATA1
            // 
            this.dtp_DATA1.Location = new System.Drawing.Point(35, 25);
            this.dtp_DATA1.Name = "dtp_DATA1";
            this.dtp_DATA1.Size = new System.Drawing.Size(177, 20);
            this.dtp_DATA1.TabIndex = 0;
            // 
            // dtp_DATA2
            // 
            this.dtp_DATA2.Location = new System.Drawing.Point(217, 25);
            this.dtp_DATA2.Name = "dtp_DATA2";
            this.dtp_DATA2.Size = new System.Drawing.Size(176, 20);
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
            this.Richiesta2.Location = new System.Drawing.Point(240, 9);
            this.Richiesta2.Name = "Richiesta2";
            this.Richiesta2.Size = new System.Drawing.Size(124, 13);
            this.Richiesta2.TabIndex = 3;
            this.Richiesta2.Text = "Inserisci la seconda data";
            // 
            // Differenza
            // 
            this.Differenza.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Differenza.Location = new System.Drawing.Point(35, 51);
            this.Differenza.Name = "Differenza";
            this.Differenza.Size = new System.Drawing.Size(504, 20);
            this.Differenza.TabIndex = 5;
            this.Differenza.Text = "Calcola";
            this.Differenza.UseVisualStyleBackColor = false;
            this.Differenza.Click += new System.EventHandler(this.Differenza_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inserisci la prima data";
            // 
            // button_agg
            // 
            this.button_agg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_agg.Location = new System.Drawing.Point(35, 136);
            this.button_agg.Name = "button_agg";
            this.button_agg.Size = new System.Drawing.Size(258, 31);
            this.button_agg.TabIndex = 8;
            this.button_agg.Text = "Aggiungi";
            this.button_agg.UseVisualStyleBackColor = false;
            this.button_agg.Click += new System.EventHandler(this.button_agg_Click);
            // 
            // button_rm
            // 
            this.button_rm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_rm.Location = new System.Drawing.Point(299, 136);
            this.button_rm.Name = "button_rm";
            this.button_rm.Size = new System.Drawing.Size(240, 31);
            this.button_rm.TabIndex = 9;
            this.button_rm.Text = "Rimuovi";
            this.button_rm.UseVisualStyleBackColor = false;
            this.button_rm.Click += new System.EventHandler(this.button_rm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Scegli se aggiungere o rimuovere dalla data i giorni inseriti";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Inserisci un numero di giorni";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(399, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Risultato";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(358, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(181, 20);
            this.textBox3.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nuova Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 179);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_rm);
            this.Controls.Add(this.button_agg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Differenza);
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
        private System.Windows.Forms.Button Differenza;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_agg;
        private System.Windows.Forms.Button button_rm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
    }
}

