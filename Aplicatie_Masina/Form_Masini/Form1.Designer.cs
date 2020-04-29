namespace Form_Masini
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
            this.lblNumeVanzator = new System.Windows.Forms.Label();
            this.lblNumeCumparator = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblCuloare = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblAnFabricatie = new System.Windows.Forms.Label();
            this.lblDotari = new System.Windows.Forms.Label();
            this.txtNumeVanzator = new System.Windows.Forms.TextBox();
            this.txtNumeCumparator = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtCuloare = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtDotari = new System.Windows.Forms.TextBox();
            this.txtAnFabricatie = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.rtbAfisare = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblNumeVanzator
            // 
            this.lblNumeVanzator.AutoSize = true;
            this.lblNumeVanzator.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeVanzator.Location = new System.Drawing.Point(59, 2);
            this.lblNumeVanzator.Name = "lblNumeVanzator";
            this.lblNumeVanzator.Size = new System.Drawing.Size(102, 16);
            this.lblNumeVanzator.TabIndex = 0;
            this.lblNumeVanzator.Text = "NumeVanzator";
            this.lblNumeVanzator.Click += new System.EventHandler(this.lblNumeVanzator_Click);
            // 
            // lblNumeCumparator
            // 
            this.lblNumeCumparator.AutoSize = true;
            this.lblNumeCumparator.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeCumparator.Location = new System.Drawing.Point(59, 49);
            this.lblNumeCumparator.Name = "lblNumeCumparator";
            this.lblNumeCumparator.Size = new System.Drawing.Size(123, 16);
            this.lblNumeCumparator.TabIndex = 1;
            this.lblNumeCumparator.Text = "Nume Cumparator";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(364, 9);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(47, 16);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(364, 56);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(47, 16);
            this.lblModel.TabIndex = 3;
            this.lblModel.Text = "Model";
            this.lblModel.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCuloare
            // 
            this.lblCuloare.AutoSize = true;
            this.lblCuloare.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuloare.Location = new System.Drawing.Point(59, 110);
            this.lblCuloare.Name = "lblCuloare";
            this.lblCuloare.Size = new System.Drawing.Size(56, 16);
            this.lblCuloare.TabIndex = 4;
            this.lblCuloare.Text = "Culoare";
            this.lblCuloare.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPret.Location = new System.Drawing.Point(59, 181);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(34, 16);
            this.lblPret.TabIndex = 5;
            this.lblPret.Text = "Pret";
            // 
            // lblAnFabricatie
            // 
            this.lblAnFabricatie.AutoSize = true;
            this.lblAnFabricatie.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnFabricatie.Location = new System.Drawing.Point(364, 117);
            this.lblAnFabricatie.Name = "lblAnFabricatie";
            this.lblAnFabricatie.Size = new System.Drawing.Size(89, 16);
            this.lblAnFabricatie.TabIndex = 6;
            this.lblAnFabricatie.Text = "AnFabricatie";
            // 
            // lblDotari
            // 
            this.lblDotari.AutoSize = true;
            this.lblDotari.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDotari.Location = new System.Drawing.Point(364, 188);
            this.lblDotari.Name = "lblDotari";
            this.lblDotari.Size = new System.Drawing.Size(47, 16);
            this.lblDotari.TabIndex = 7;
            this.lblDotari.Text = "Dotari";
            this.lblDotari.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtNumeVanzator
            // 
            this.txtNumeVanzator.Location = new System.Drawing.Point(192, 1);
            this.txtNumeVanzator.Multiline = true;
            this.txtNumeVanzator.Name = "txtNumeVanzator";
            this.txtNumeVanzator.Size = new System.Drawing.Size(132, 30);
            this.txtNumeVanzator.TabIndex = 8;
            // 
            // txtNumeCumparator
            // 
            this.txtNumeCumparator.Location = new System.Drawing.Point(192, 46);
            this.txtNumeCumparator.Multiline = true;
            this.txtNumeCumparator.Name = "txtNumeCumparator";
            this.txtNumeCumparator.Size = new System.Drawing.Size(132, 30);
            this.txtNumeCumparator.TabIndex = 9;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(192, 181);
            this.txtPret.Multiline = true;
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(132, 30);
            this.txtPret.TabIndex = 12;
            // 
            // txtCuloare
            // 
            this.txtCuloare.Location = new System.Drawing.Point(192, 110);
            this.txtCuloare.Multiline = true;
            this.txtCuloare.Name = "txtCuloare";
            this.txtCuloare.Size = new System.Drawing.Size(132, 30);
            this.txtCuloare.TabIndex = 13;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(500, 2);
            this.txtMarca.Multiline = true;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(132, 30);
            this.txtMarca.TabIndex = 16;
            // 
            // txtDotari
            // 
            this.txtDotari.Location = new System.Drawing.Point(500, 181);
            this.txtDotari.Multiline = true;
            this.txtDotari.Name = "txtDotari";
            this.txtDotari.Size = new System.Drawing.Size(132, 30);
            this.txtDotari.TabIndex = 17;
            // 
            // txtAnFabricatie
            // 
            this.txtAnFabricatie.Location = new System.Drawing.Point(500, 117);
            this.txtAnFabricatie.Multiline = true;
            this.txtAnFabricatie.Name = "txtAnFabricatie";
            this.txtAnFabricatie.Size = new System.Drawing.Size(132, 30);
            this.txtAnFabricatie.TabIndex = 18;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(500, 53);
            this.txtModel.Multiline = true;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(132, 30);
            this.txtModel.TabIndex = 19;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(62, 323);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 20;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(62, 396);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(75, 23);
            this.btnAfiseaza.TabIndex = 21;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            // 
            // rtbAfisare
            // 
            this.rtbAfisare.Location = new System.Drawing.Point(424, 323);
            this.rtbAfisare.Name = "rtbAfisare";
            this.rtbAfisare.Size = new System.Drawing.Size(276, 141);
            this.rtbAfisare.TabIndex = 22;
            this.rtbAfisare.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 659);
            this.Controls.Add(this.rtbAfisare);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtAnFabricatie);
            this.Controls.Add(this.txtDotari);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtCuloare);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtNumeCumparator);
            this.Controls.Add(this.txtNumeVanzator);
            this.Controls.Add(this.lblDotari);
            this.Controls.Add(this.lblAnFabricatie);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblCuloare);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblNumeCumparator);
            this.Controls.Add(this.lblNumeVanzator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeVanzator;
        private System.Windows.Forms.Label lblNumeCumparator;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblCuloare;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lblAnFabricatie;
        private System.Windows.Forms.Label lblDotari;
        private System.Windows.Forms.TextBox txtNumeVanzator;
        private System.Windows.Forms.TextBox txtNumeCumparator;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtCuloare;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtDotari;
        private System.Windows.Forms.TextBox txtAnFabricatie;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.RichTextBox rtbAfisare;
    }
}