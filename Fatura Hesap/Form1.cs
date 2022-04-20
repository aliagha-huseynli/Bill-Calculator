using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatura_Hesap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region Kod Blokları

        private void Form1_Load(object sender, EventArgs e)
        {
            txTekZaman.Enabled = false;
            txT1.Enabled = false;
            txT2.Enabled = false;
            txT3.Enabled = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Tek Zaman")
            {
                txT1.Clear();
                txT2.Clear();
                txT3.Clear();

                txTekZaman.Enabled = true;
                txT1.Enabled = false;
                txT2.Enabled = false;
                txT3.Enabled = false;
            }

            else if (comboBox1.SelectedItem.ToString() == "Üç Zaman")
            {
                txTekZaman.Clear();

                txTekZaman.Enabled = false;
                txT1.Enabled = true;
                txT2.Enabled = true;
                txT3.Enabled = true;
            }
        }



        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBox1.SelectedItem.ToString() == "Üç Zaman")
                {
              
                    double sayac1 = 0.0;
                    double sayac2 = 0.0;
                    double sayac3 = 0.0;
                    double tuketim = 0.0;
                    double dagitim = 0.0;
                    double Fon = 0.01;
                    double trtP = 0.02;
                    double btvv = 0.05;
                    double kdv = 0.18;
                    double Total = 0.0;
                    double GuvenceBed = 26.63;

                    sayac1 = Convert.ToDouble(txT1.Text);
                    sayac2 = Convert.ToDouble(txT2.Text);
                    sayac3 = Convert.ToDouble(txT3.Text);

                    tuketim = (sayac1 + sayac2 + sayac3) * 0.204;
                    dagitim = (sayac1 + sayac2 + sayac3) * 0.11777500;
                    Fon = tuketim * Fon;
                    trtP = tuketim * trtP;
                    btvv = tuketim * btvv;
                    kdv = (Fon + trtP + btvv + tuketim + dagitim) * kdv;
                    Total = (tuketim + dagitim + Fon + trtP + btvv + kdv + GuvenceBed);

                    lblTuketim.Text = tuketim.ToString("#.##") + "TL";
                    lblDağıtım.Text = dagitim.ToString("#.##") + "TL";
                    lblEnerjiFonu.Text = Fon.ToString("#.##") + "TL";
                    lblTRT.Text = trtP.ToString("#.##") + "TL";
                    lblBTV.Text = btvv.ToString("#.##") + "TL";
                    lblKDV.Text = kdv.ToString("#.##") + "TL";
                    lblTOPLAM.Text = Total.ToString("#.##") + "TL";

                }

                else if (comboBox1.SelectedItem.ToString() == "Tek Zaman")
                {
                    double TekZaman = 0.0;
                    double tuketim = 0.0;
                    double dagitim = 0.0;
                    double Fon = 0.01;
                    double trtP = 0.02;
                    double btvv = 0.05;
                    double kdv = 0.18;
                    double Total = 0.0;
                    double GuvenceBed = 26.63;


                    TekZaman = Convert.ToDouble(txTekZaman.Text);

                    tuketim = TekZaman * 0.204;
                    dagitim = TekZaman * 0.11777500;
                    Fon = tuketim * Fon;
                    trtP = tuketim * trtP;
                    btvv = tuketim * btvv;
                    kdv = (Fon + trtP + btvv + tuketim + dagitim) * kdv;
                    Total = (tuketim + dagitim + Fon + trtP + btvv + kdv + GuvenceBed);


                    lblTuketim.Text = tuketim.ToString("#.##") + "TL";
                    lblDağıtım.Text = dagitim.ToString("#.##") + "TL";
                    lblEnerjiFonu.Text = Fon.ToString("#.##") + "TL";
                    lblTRT.Text = trtP.ToString("#.##") + "TL";
                    lblBTV.Text = btvv.ToString("#.##") + "TL";
                    lblKDV.Text = kdv.ToString("#.##") + "TL";
                    lblTOPLAM.Text = Total.ToString("#.##") + "TL";

                }

            }
            catch (Exception)
            {
                
            }
        }

        

    }
}
