namespace Modern_User_Control
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.panelKfz = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.pictureBoxEuro = new System.Windows.Forms.PictureBox();
            this.labelGesamtkosten = new System.Windows.Forms.Label();
            this.pictureBoxLine = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelDatumZulassung = new System.Windows.Forms.Label();
            this.labelKennzeichen = new System.Windows.Forms.Label();
            this.labelModell = new System.Windows.Forms.Label();
            this.labelMarke = new System.Windows.Forms.Label();
            this.panelKfz.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelKfz
            // 
            this.panelKfz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.panelKfz.Controls.Add(this.buttonDelete);
            this.panelKfz.Controls.Add(this.panelBottom);
            this.panelKfz.Controls.Add(this.pictureBoxLine);
            this.panelKfz.Controls.Add(this.pictureBoxLogo);
            this.panelKfz.Controls.Add(this.labelDatumZulassung);
            this.panelKfz.Controls.Add(this.labelKennzeichen);
            this.panelKfz.Controls.Add(this.labelModell);
            this.panelKfz.Controls.Add(this.labelMarke);
            this.panelKfz.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelKfz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panelKfz.Location = new System.Drawing.Point(2, 2);
            this.panelKfz.Name = "panelKfz";
            this.panelKfz.Padding = new System.Windows.Forms.Padding(1);
            this.panelKfz.Size = new System.Drawing.Size(180, 215);
            this.panelKfz.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImage = global::Modern_User_Control.Properties.Resources.delete_25px;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(153, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(25, 25);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.panelBottom.Controls.Add(this.pictureBoxEuro);
            this.panelBottom.Controls.Add(this.labelGesamtkosten);
            this.panelBottom.Location = new System.Drawing.Point(1, 167);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(178, 46);
            this.panelBottom.TabIndex = 4;
            // 
            // pictureBoxEuro
            // 
            this.pictureBoxEuro.BackgroundImage = global::Modern_User_Control.Properties.Resources.receipt_euro_35px;
            this.pictureBoxEuro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxEuro.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxEuro.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEuro.Name = "pictureBoxEuro";
            this.pictureBoxEuro.Size = new System.Drawing.Size(50, 46);
            this.pictureBoxEuro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxEuro.TabIndex = 0;
            this.pictureBoxEuro.TabStop = false;
            // 
            // labelGesamtkosten
            // 
            this.labelGesamtkosten.AutoSize = true;
            this.labelGesamtkosten.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGesamtkosten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(121)))), ((int)(((byte)(140)))));
            this.labelGesamtkosten.Location = new System.Drawing.Point(56, 13);
            this.labelGesamtkosten.Name = "labelGesamtkosten";
            this.labelGesamtkosten.Size = new System.Drawing.Size(84, 19);
            this.labelGesamtkosten.TabIndex = 0;
            this.labelGesamtkosten.Text = "SL-585-SH";
            // 
            // pictureBoxLine
            // 
            this.pictureBoxLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pictureBoxLine.Location = new System.Drawing.Point(16, 77);
            this.pictureBoxLine.Name = "pictureBoxLine";
            this.pictureBoxLine.Size = new System.Drawing.Size(150, 2);
            this.pictureBoxLine.TabIndex = 3;
            this.pictureBoxLine.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxLogo.Location = new System.Drawing.Point(1, 1);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(178, 44);
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelDatumZulassung
            // 
            this.labelDatumZulassung.AutoSize = true;
            this.labelDatumZulassung.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatumZulassung.Location = new System.Drawing.Point(13, 125);
            this.labelDatumZulassung.Name = "labelDatumZulassung";
            this.labelDatumZulassung.Size = new System.Drawing.Size(90, 21);
            this.labelDatumZulassung.TabIndex = 0;
            this.labelDatumZulassung.Text = "22.10.2019";
            // 
            // labelKennzeichen
            // 
            this.labelKennzeichen.AutoSize = true;
            this.labelKennzeichen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKennzeichen.Location = new System.Drawing.Point(13, 104);
            this.labelKennzeichen.Name = "labelKennzeichen";
            this.labelKennzeichen.Size = new System.Drawing.Size(81, 21);
            this.labelKennzeichen.TabIndex = 0;
            this.labelKennzeichen.Text = "SL-585-SH";
            // 
            // labelModell
            // 
            this.labelModell.AutoSize = true;
            this.labelModell.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModell.Location = new System.Drawing.Point(13, 83);
            this.labelModell.Name = "labelModell";
            this.labelModell.Size = new System.Drawing.Size(54, 21);
            this.labelModell.TabIndex = 0;
            this.labelModell.Text = "CX 60";
            // 
            // labelMarke
            // 
            this.labelMarke.AutoSize = true;
            this.labelMarke.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarke.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(99)))), ((int)(((byte)(36)))));
            this.labelMarke.Location = new System.Drawing.Point(13, 56);
            this.labelMarke.Name = "labelMarke";
            this.labelMarke.Size = new System.Drawing.Size(53, 19);
            this.labelMarke.TabIndex = 0;
            this.labelMarke.Text = "Volvo";
            // 
            // UserControl1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelKfz);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(863, 348);
            this.panelKfz.ResumeLayout(false);
            this.panelKfz.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelKfz;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelMarke;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelDatumZulassung;
        private System.Windows.Forms.Label labelKennzeichen;
        private System.Windows.Forms.Label labelModell;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.PictureBox pictureBoxEuro;
        private System.Windows.Forms.PictureBox pictureBoxLine;
        private System.Windows.Forms.Label labelGesamtkosten;
    }
}
