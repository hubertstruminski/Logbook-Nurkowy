namespace LogbookNurkowy
{
    partial class Historia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historia));
            this.label1 = new System.Windows.Forms.Label();
            this.btnWyswietl = new System.Windows.Forms.Button();
            this.dgHistoria = new System.Windows.Forms.DataGridView();
            this.btnPowrot = new System.Windows.Forms.Button();
            this.txtWyszukaj = new System.Windows.Forms.TextBox();
            this.btnHWyszukaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistoria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(377, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historia nurkowań";
            // 
            // btnWyswietl
            // 
            this.btnWyswietl.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnWyswietl.Location = new System.Drawing.Point(477, 65);
            this.btnWyswietl.Name = "btnWyswietl";
            this.btnWyswietl.Size = new System.Drawing.Size(120, 52);
            this.btnWyswietl.TabIndex = 1;
            this.btnWyswietl.Text = "wyświetl";
            this.btnWyswietl.UseVisualStyleBackColor = false;
            this.btnWyswietl.Click += new System.EventHandler(this.btnWyswietl_Click);
            // 
            // dgHistoria
            // 
            this.dgHistoria.AllowUserToAddRows = false;
            this.dgHistoria.AllowUserToOrderColumns = true;
            this.dgHistoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistoria.Location = new System.Drawing.Point(52, 130);
            this.dgHistoria.Name = "dgHistoria";
            this.dgHistoria.RowTemplate.Height = 24;
            this.dgHistoria.Size = new System.Drawing.Size(971, 316);
            this.dgHistoria.TabIndex = 2;
            // 
            // btnPowrot
            // 
            this.btnPowrot.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPowrot.Location = new System.Drawing.Point(12, 454);
            this.btnPowrot.Name = "btnPowrot";
            this.btnPowrot.Size = new System.Drawing.Size(121, 53);
            this.btnPowrot.TabIndex = 3;
            this.btnPowrot.Text = "Powrót";
            this.btnPowrot.UseVisualStyleBackColor = false;
            this.btnPowrot.Click += new System.EventHandler(this.btnPowrot_Click);
            // 
            // txtWyszukaj
            // 
            this.txtWyszukaj.Location = new System.Drawing.Point(743, 467);
            this.txtWyszukaj.Name = "txtWyszukaj";
            this.txtWyszukaj.Size = new System.Drawing.Size(154, 22);
            this.txtWyszukaj.TabIndex = 4;
            // 
            // btnHWyszukaj
            // 
            this.btnHWyszukaj.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnHWyszukaj.Location = new System.Drawing.Point(903, 452);
            this.btnHWyszukaj.Name = "btnHWyszukaj";
            this.btnHWyszukaj.Size = new System.Drawing.Size(120, 52);
            this.btnHWyszukaj.TabIndex = 5;
            this.btnHWyszukaj.Text = "wyszukaj";
            this.btnHWyszukaj.UseVisualStyleBackColor = false;
            this.btnHWyszukaj.Click += new System.EventHandler(this.btnHWyszukaj_Click);
            // 
            // Historia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1070, 519);
            this.Controls.Add(this.btnHWyszukaj);
            this.Controls.Add(this.txtWyszukaj);
            this.Controls.Add(this.btnPowrot);
            this.Controls.Add(this.dgHistoria);
            this.Controls.Add(this.btnWyswietl);
            this.Controls.Add(this.label1);
            this.Name = "Historia";
            this.Text = "Historia";
            ((System.ComponentModel.ISupportInitialize)(this.dgHistoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWyswietl;
        private System.Windows.Forms.DataGridView dgHistoria;
        private System.Windows.Forms.Button btnPowrot;
        private System.Windows.Forms.TextBox txtWyszukaj;
        private System.Windows.Forms.Button btnHWyszukaj;
    }
}