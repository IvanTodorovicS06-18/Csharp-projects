using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.IO;
using System.Diagnostics;

namespace Kolokvijum2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        JavaScriptSerializer serlizacija = new JavaScriptSerializer();
        List<DesktopRacunari> dRac = new List<DesktopRacunari>();

     
        

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try 
             {
                DesktopRacunari racunar = new DesktopRacunari()
                {
                    proizvodjac = txtProizvodjac.Text,
                    procesor = txtProcesor.Text,
                    model = txtModel.Text,
                    OperativniSistem = txtOp.Text,
                    ramMemorija = Convert.ToInt32(txtRam.Text),
                    graficka = txtGraficka.Text,
                    memorijaSkladista = Convert.ToInt32(txtMemorijaSkladista.Text),
                    cena = Convert.ToDouble(txtCena.Text)
                };
                listInformacija.Items.Add("Proizvodjac: " + racunar.proizvodjac);
                listInformacija.Items.Add("Procesor: " + racunar.procesor);
                listInformacija.Items.Add("Model: " + racunar.model);
                listInformacija.Items.Add("RAM: " + racunar.ramMemorija + " gb");
                listInformacija.Items.Add("Graficka: " + racunar.graficka);
                listInformacija.Items.Add("Memorija skladista: " + racunar.memorijaSkladista);
                listInformacija.Items.Add("Operativni sistem : " + racunar.OperativniSistem);
                listInformacija.Items.Add("Cena: " + racunar.cena);
                listInformacija.Items.Add("-------------------------------------");

              
                dRac.Add(racunar);
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSerijalizacija_Click(object sender, EventArgs e)
        {
            int brojClanova = dRac.Count();
            if (brojClanova > 0)
            {
                string strJSON = serlizacija.Serialize(dRac);
                StreamWriter Json = new StreamWriter(@"C:\Users\todor\OneDrive\Desktop\Kolokvijum2\DatotekaUpisa.json", true);
                Json.Write(strJSON);
                Json.Flush();
                Json.Close();

                Process.Start("notepad.exe", @"C:\Users\todor\OneDrive\Desktop\Kolokvijum2\DatotekaUpisa.json");

                dRac.Clear();
            }
            else
            {
                MessageBox.Show("Lista ne moze biti prazna!");
            }
        }

       
    }
}
