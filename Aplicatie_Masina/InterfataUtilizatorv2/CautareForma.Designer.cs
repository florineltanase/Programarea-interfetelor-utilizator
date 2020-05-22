namespace InterfataUtilizatorv2
{
    partial class CautareForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CautareForma));
            this.lblNumeVanzator = new System.Windows.Forms.Label();
            this.lblNumeCumparator = new System.Windows.Forms.Label();
            this.txtNumeVanzator = new System.Windows.Forms.TextBox();
            this.txtNumeCumparator = new System.Windows.Forms.TextBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeVanzator
            // 
            this.lblNumeVanzator.AutoSize = true;
            this.lblNumeVanzator.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeVanzator.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumeVanzator.Location = new System.Drawing.Point(102, 120);
            this.lblNumeVanzator.Name = "lblNumeVanzator";
            this.lblNumeVanzator.Size = new System.Drawing.Size(109, 17);
            this.lblNumeVanzator.TabIndex = 35;
            this.lblNumeVanzator.Text = "Nume_Vanzator";
            // 
            // lblNumeCumparator
            // 
            this.lblNumeCumparator.AutoSize = true;
            this.lblNumeCumparator.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeCumparator.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumeCumparator.Location = new System.Drawing.Point(102, 182);
            this.lblNumeCumparator.Name = "lblNumeCumparator";
            this.lblNumeCumparator.Size = new System.Drawing.Size(129, 17);
            this.lblNumeCumparator.TabIndex = 39;
            this.lblNumeCumparator.Text = "Nume_Cumparator";
            // 
            // txtNumeVanzator
            // 
            this.txtNumeVanzator.Location = new System.Drawing.Point(243, 117);
            this.txtNumeVanzator.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeVanzator.Name = "txtNumeVanzator";
            this.txtNumeVanzator.Size = new System.Drawing.Size(209, 20);
            this.txtNumeVanzator.TabIndex = 53;
            // 
            // txtNumeCumparator
            // 
            this.txtNumeCumparator.Location = new System.Drawing.Point(243, 179);
            this.txtNumeCumparator.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeCumparator.Name = "txtNumeCumparator";
            this.txtNumeCumparator.Size = new System.Drawing.Size(209, 20);
            this.txtNumeCumparator.TabIndex = 54;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMesaj.Location = new System.Drawing.Point(102, 269);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 13);
            this.lblMesaj.TabIndex = 55;
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifica.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModifica.Image = ((System.Drawing.Image)(resources.GetObject("btnModifica.Image")));
            this.btnModifica.Location = new System.Drawing.Point(550, 120);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(152, 68);
            this.btnModifica.TabIndex = 57;
            this.btnModifica.Text = "Cauta";
            this.btnModifica.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModifica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(654, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 48);
            this.btnExit.TabIndex = 60;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CautareForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(749, 342);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.txtNumeCumparator);
            this.Controls.Add(this.txtNumeVanzator);
            this.Controls.Add(this.lblNumeCumparator);
            this.Controls.Add(this.lblNumeVanzator);
            this.Name = "CautareForma";
            this.Text = "CautareForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeVanzator;
        private System.Windows.Forms.Label lblNumeCumparator;
        private System.Windows.Forms.TextBox txtNumeVanzator;
        private System.Windows.Forms.TextBox txtNumeCumparator;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnExit;
    }
}