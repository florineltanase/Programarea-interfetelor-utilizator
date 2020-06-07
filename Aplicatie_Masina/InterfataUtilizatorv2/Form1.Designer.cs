namespace InterfataUtilizatorv2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.dataGridMasina = new System.Windows.Forms.DataGridView();
            this.lstAfisare = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnFiltrare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMasina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdauga.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdauga.Image = ((System.Drawing.Image)(resources.GetObject("btnAdauga.Image")));
            this.btnAdauga.Location = new System.Drawing.Point(128, 2);
            this.btnAdauga.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(152, 68);
            this.btnAdauga.TabIndex = 51;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdauga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCauta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCauta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCauta.Image = ((System.Drawing.Image)(resources.GetObject("btnCauta.Image")));
            this.btnCauta.Location = new System.Drawing.Point(357, 0);
            this.btnCauta.Margin = new System.Windows.Forms.Padding(2);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(152, 68);
            this.btnCauta.TabIndex = 56;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCauta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCauta.UseVisualStyleBackColor = false;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // dataGridMasina
            // 
            this.dataGridMasina.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridMasina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMasina.Location = new System.Drawing.Point(128, 322);
            this.dataGridMasina.Name = "dataGridMasina";
            this.dataGridMasina.Size = new System.Drawing.Size(653, 133);
            this.dataGridMasina.TabIndex = 57;
            // 
            // lstAfisare
            // 
            this.lstAfisare.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lstAfisare.ForeColor = System.Drawing.SystemColors.Menu;
            this.lstAfisare.FormattingEnabled = true;
            this.lstAfisare.ItemHeight = 17;
            this.lstAfisare.Location = new System.Drawing.Point(128, 141);
            this.lstAfisare.Name = "lstAfisare";
            this.lstAfisare.Size = new System.Drawing.Size(653, 157);
            this.lstAfisare.TabIndex = 58;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(27, 428);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 68);
            this.button2.TabIndex = 53;
            this.button2.Text = "Afisare";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(27, 254);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 68);
            this.button1.TabIndex = 52;
            this.button1.Text = "Acasa";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 123);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCheckout.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckout.Image")));
            this.btnCheckout.Location = new System.Drawing.Point(592, 0);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(152, 68);
            this.btnCheckout.TabIndex = 60;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.btnCheckout);
            this.panelChildForm.Controls.Add(this.dataGridMasina);
            this.panelChildForm.Controls.Add(this.lstAfisare);
            this.panelChildForm.Controls.Add(this.btnAdauga);
            this.panelChildForm.Controls.Add(this.btnCauta);
            this.panelChildForm.Location = new System.Drawing.Point(253, 41);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(908, 486);
            this.panelChildForm.TabIndex = 61;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(1070, 561);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(91, 24);
            this.btnSignOut.TabIndex = 0;
            this.btnSignOut.Text = "SIGN OUT";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnFiltrare
            // 
            this.btnFiltrare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrare.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiltrare.Location = new System.Drawing.Point(27, 12);
            this.btnFiltrare.Name = "btnFiltrare";
            this.btnFiltrare.Size = new System.Drawing.Size(152, 23);
            this.btnFiltrare.TabIndex = 62;
            this.btnFiltrare.Text = "FiltrareAnFabricatie";
            this.btnFiltrare.UseVisualStyleBackColor = true;
            this.btnFiltrare.Click += new System.EventHandler(this.btnFiltrare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1207, 655);
            this.Controls.Add(this.btnFiltrare);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelChildForm);
            this.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMasina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.DataGridView dataGridMasina;
        private System.Windows.Forms.ListBox lstAfisare;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnFiltrare;
    }
}

