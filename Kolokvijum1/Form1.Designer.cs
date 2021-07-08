namespace kolok1
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
            this.fileOpen = new System.Windows.Forms.Button();
            this.txtNadji = new System.Windows.Forms.TextBox();
            this.txtZameni = new System.Windows.Forms.TextBox();
            this.endProgram = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.Button();
            this.PronadjiIZameni = new System.Windows.Forms.Button();
            this.pregledTxt = new System.Windows.Forms.TextBox();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileOpen
            // 
            this.fileOpen.Location = new System.Drawing.Point(12, 18);
            this.fileOpen.Name = "fileOpen";
            this.fileOpen.Size = new System.Drawing.Size(81, 39);
            this.fileOpen.TabIndex = 0;
            this.fileOpen.Text = "Otvori fajl";
            this.fileOpen.UseVisualStyleBackColor = true;
            this.fileOpen.Click += new System.EventHandler(this.fileOpen_Click);
            // 
            // txtNadji
            // 
            this.txtNadji.Location = new System.Drawing.Point(160, 15);
            this.txtNadji.Name = "txtNadji";
            this.txtNadji.Size = new System.Drawing.Size(100, 20);
            this.txtNadji.TabIndex = 1;
            // 
            // txtZameni
            // 
            this.txtZameni.Location = new System.Drawing.Point(160, 44);
            this.txtZameni.Name = "txtZameni";
            this.txtZameni.Size = new System.Drawing.Size(100, 20);
            this.txtZameni.TabIndex = 2;
            // 
            // endProgram
            // 
            this.endProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endProgram.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.endProgram.Location = new System.Drawing.Point(675, 15);
            this.endProgram.Name = "endProgram";
            this.endProgram.Size = new System.Drawing.Size(89, 42);
            this.endProgram.TabIndex = 3;
            this.endProgram.Text = "Zavrsi program";
            this.endProgram.UseVisualStyleBackColor = true;
            this.endProgram.Click += new System.EventHandler(this.endProgram_Click);
            // 
            // saveFile
            // 
            this.saveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveFile.Location = new System.Drawing.Point(431, 15);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(75, 42);
            this.saveFile.TabIndex = 4;
            this.saveFile.Text = "Snimi fajl (Save As..)";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // PronadjiIZameni
            // 
            this.PronadjiIZameni.Location = new System.Drawing.Point(318, 15);
            this.PronadjiIZameni.Name = "PronadjiIZameni";
            this.PronadjiIZameni.Size = new System.Drawing.Size(75, 42);
            this.PronadjiIZameni.TabIndex = 5;
            this.PronadjiIZameni.Text = "Pronadi i zameni";
            this.PronadjiIZameni.UseVisualStyleBackColor = true;
            this.PronadjiIZameni.Click += new System.EventHandler(this.PronadjiIZameni_Click);
            // 
            // pregledTxt
            // 
            this.pregledTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pregledTxt.Location = new System.Drawing.Point(4, 70);
            this.pregledTxt.Multiline = true;
            this.pregledTxt.Name = "pregledTxt";
            this.pregledTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pregledTxt.Size = new System.Drawing.Size(780, 368);
            this.pregledTxt.TabIndex = 6;
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pronadji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Zameni";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.endProgram;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pregledTxt);
            this.Controls.Add(this.PronadjiIZameni);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.endProgram);
            this.Controls.Add(this.txtZameni);
            this.Controls.Add(this.txtNadji);
            this.Controls.Add(this.fileOpen);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileOpen;
        private System.Windows.Forms.TextBox txtNadji;
        private System.Windows.Forms.TextBox txtZameni;
        private System.Windows.Forms.Button endProgram;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Button PronadjiIZameni;
        private System.Windows.Forms.TextBox pregledTxt;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

