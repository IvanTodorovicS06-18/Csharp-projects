namespace Kolokvijum2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.txtGraficka = new System.Windows.Forms.TextBox();
            this.txtMemorijaSkladista = new System.Windows.Forms.TextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnSerijalizacija = new System.Windows.Forms.Button();
            this.listInformacija = new System.Windows.Forms.ListBox();
            this.txtProcesor = new System.Windows.Forms.TextBox();
            this.Proizvodjac = new System.Windows.Forms.Label();
            this.txtProizvodjac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Procesor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "RAM memorija:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Graficka kartica:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Memorija skladista:";
            // 
            // txtRam
            // 
            this.txtRam.Location = new System.Drawing.Point(85, 95);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(151, 20);
            this.txtRam.TabIndex = 2;
            // 
            // txtGraficka
            // 
            this.txtGraficka.Location = new System.Drawing.Point(85, 141);
            this.txtGraficka.Name = "txtGraficka";
            this.txtGraficka.Size = new System.Drawing.Size(151, 20);
            this.txtGraficka.TabIndex = 3;
            // 
            // txtMemorijaSkladista
            // 
            this.txtMemorijaSkladista.Location = new System.Drawing.Point(99, 191);
            this.txtMemorijaSkladista.Name = "txtMemorijaSkladista";
            this.txtMemorijaSkladista.Size = new System.Drawing.Size(137, 20);
            this.txtMemorijaSkladista.TabIndex = 4;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(113, 342);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(86, 31);
            this.btnUnesi.TabIndex = 5;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnSerijalizacija
            // 
            this.btnSerijalizacija.Location = new System.Drawing.Point(610, 395);
            this.btnSerijalizacija.Name = "btnSerijalizacija";
            this.btnSerijalizacija.Size = new System.Drawing.Size(95, 33);
            this.btnSerijalizacija.TabIndex = 6;
            this.btnSerijalizacija.Text = "Serijalizacija";
            this.btnSerijalizacija.UseVisualStyleBackColor = true;
            this.btnSerijalizacija.Click += new System.EventHandler(this.btnSerijalizacija_Click);
            // 
            // listInformacija
            // 
            this.listInformacija.FormattingEnabled = true;
            this.listInformacija.Location = new System.Drawing.Point(322, 31);
            this.listInformacija.Name = "listInformacija";
            this.listInformacija.Size = new System.Drawing.Size(383, 342);
            this.listInformacija.TabIndex = 12;
            // 
            // txtProcesor
            // 
            this.txtProcesor.Location = new System.Drawing.Point(59, 48);
            this.txtProcesor.Name = "txtProcesor";
            this.txtProcesor.Size = new System.Drawing.Size(177, 20);
            this.txtProcesor.TabIndex = 1;
            // 
            // Proizvodjac
            // 
            this.Proizvodjac.AutoSize = true;
            this.Proizvodjac.Location = new System.Drawing.Point(2, 12);
            this.Proizvodjac.Name = "Proizvodjac";
            this.Proizvodjac.Size = new System.Drawing.Size(65, 13);
            this.Proizvodjac.TabIndex = 7;
            this.Proizvodjac.Text = "Proizvodjac:";
            // 
            // txtProizvodjac
            // 
            this.txtProizvodjac.Location = new System.Drawing.Point(73, 9);
            this.txtProizvodjac.Name = "txtProizvodjac";
            this.txtProizvodjac.Size = new System.Drawing.Size(164, 20);
            this.txtProizvodjac.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(99, 224);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(137, 20);
            this.txtModel.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cena";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(98, 287);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(138, 20);
            this.txtCena.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Operativni sistem";
            // 
            // txtOp
            // 
            this.txtOp.Location = new System.Drawing.Point(99, 257);
            this.txtOp.Name = "txtOp";
            this.txtOp.Size = new System.Drawing.Size(138, 20);
            this.txtOp.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProizvodjac);
            this.Controls.Add(this.Proizvodjac);
            this.Controls.Add(this.txtProcesor);
            this.Controls.Add(this.listInformacija);
            this.Controls.Add(this.btnSerijalizacija);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.txtMemorijaSkladista);
            this.Controls.Add(this.txtGraficka);
            this.Controls.Add(this.txtRam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Desktop Racunari";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.TextBox txtGraficka;
        private System.Windows.Forms.TextBox txtMemorijaSkladista;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnSerijalizacija;
        private System.Windows.Forms.ListBox listInformacija;
        private System.Windows.Forms.TextBox txtProcesor;
        private System.Windows.Forms.Label Proizvodjac;
        private System.Windows.Forms.TextBox txtProizvodjac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOp;
    }
}

