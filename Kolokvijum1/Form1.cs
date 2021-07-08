using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kolok1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        public string otvaranjeFajla(string putanja)
        {
            string cuvanjeTeksta = ""; 
            StreamReader fajl = new StreamReader(putanja);
            cuvanjeTeksta = fajl.ReadToEnd();
            fajl.Close();
            return pregledTxt.Text = cuvanjeTeksta;
        }
        private void fileOpen_Click(object sender, EventArgs e)
        {
            dlgOpen.Title = "Otvori fajl";
            dlgOpen.Filter = "Tekst fajlovi|*.txt|Csv fajlovi|*.csv";
           

            if (dlgOpen.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                otvaranjeFajla(dlgOpen.FileName);

            }
        }

        public bool snimanjeFajla(string imeFajla, string sadrzaj)
        {
           StreamWriter streamW = new StreamWriter(imeFajla);
            streamW.Write(sadrzaj);
            streamW.Flush();
            streamW.Close();

            return true;
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            if (pregledTxt.Text.Trim() == "") 
            {
                MessageBox.Show("Molimo vas da unesete tekst", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pregledTxt.Focus();
                return;
            }

            dlgSave.DefaultExt = "txt";
            dlgSave.InitialDirectory = @"Desktop";
            dlgSave.Filter = "Tekst fajlovi|*.txt|csv fajlovi|.*csv";

          
            if (dlgSave.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                if (snimanjeFajla(dlgSave.FileName, pregledTxt.Text) == true)
                {
                    MessageBox.Show("Fajl sacuvan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("Snimanje fajla neuspelo!");
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }


        }

        private void PronadjiIZameni_Click(object sender, EventArgs e)
        {
            string nadjiRec = txtNadji.Text;
            string zameniRec = txtZameni.Text;

            try
            {
                if (pregledTxt.Text.Trim() == "")
                {
                    throw new Exception("Polje sa tekstom ne sme biti prazno");
                }
                if (txtNadji.Text == "" || txtZameni.Text == "")
                {
                    throw new Exception("Molim vas popunite sva polja");
                }

                if (pregledTxt.Text.Contains(nadjiRec))
                {
                    pregledTxt.Text = pregledTxt.Text.Replace(nadjiRec, zameniRec);
                }
                else
                {
                    throw new Exception("Trazena rec nije pronadjena");
                }
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void endProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
