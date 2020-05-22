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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.dataGridMasina = new System.Windows.Forms.DataGridView();
            this.lstAfisare = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMasina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 555);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1207, 100);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdauga.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdauga.Image = ((System.Drawing.Image)(resources.GetObject("btnAdauga.Image")));
            this.btnAdauga.Location = new System.Drawing.Point(398, 41);
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
            this.btnCauta.Location = new System.Drawing.Point(849, 41);
            this.btnCauta.Margin = new System.Windows.Forms.Padding(2);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(152, 68);
            this.btnCauta.TabIndex = 55;
            this.btnCauta.Text = "Modifica";
            this.btnCauta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCauta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCauta.UseVisualStyleBackColor = false;
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifica.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModifica.Image = ((System.Drawing.Image)(resources.GetObject("btnModifica.Image")));
            this.btnModifica.Location = new System.Drawing.Point(625, 41);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(152, 68);
            this.btnModifica.TabIndex = 56;
            this.btnModifica.Text = "Cauta";
            this.btnModifica.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModifica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // dataGridMasina
            // 
            this.dataGridMasina.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridMasina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMasina.Location = new System.Drawing.Point(212, 364);
            this.dataGridMasina.Name = "dataGridMasina";
            this.dataGridMasina.Size = new System.Drawing.Size(946, 176);
            this.dataGridMasina.TabIndex = 57;
            // 
            // lstAfisare
            // 
            this.lstAfisare.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lstAfisare.ForeColor = System.Drawing.SystemColors.Menu;
            this.lstAfisare.FormattingEnabled = true;
            this.lstAfisare.ItemHeight = 17;
            this.lstAfisare.Location = new System.Drawing.Point(212, 182);
            this.lstAfisare.Name = "lstAfisare";
            this.lstAfisare.Size = new System.Drawing.Size(946, 140);
            this.lstAfisare.TabIndex = 58;
            this.lstAfisare.SelectedIndexChanged += new System.EventHandler(this.lstAfisare_SelectedIndexChanged);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1207, 655);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstAfisare);
            this.Controls.Add(this.dataGridMasina);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMasina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.DataGridView dataGridMasina;
        private System.Windows.Forms.ListBox lstAfisare;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

