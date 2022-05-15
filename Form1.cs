using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesideneme
{
    public partial class Form1 : Form
    {
        char _islem;
        bool _EkranTemizlenecekMi;
        double _ilksayi;

        public Form1()
        {
            InitializeComponent();
        }

        private void EkranLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void Rakam1Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi) 
            { 
                EkranLabel.Text = "0"; 
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "1";
        }

        private void Rakam2Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel.Text = "0";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "2";
        }

        private void Rakam3Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel.Text = "0";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "3";
        }

        private void Rakam4Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel.Text = "0";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "4";
        }

        private void Rakam5Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel.Text = "0";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "5";
        }

        private void Rakam6Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel.Text = "0";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "6";
        }

        private void Rakam7Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel.Text = "0";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "7";
        }

        private void Rakam8Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel.Text = "0";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "8";
        }

        private void Rakam9Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel.Text = "0";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "9";
        }

        private void Rakam0Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel.Text = "0";
                _EkranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0") EkranLabel.Text = "";
            EkranLabel.Text += "0";
        }

        private void ToplaButton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _EkranTemizlenecekMi = true;
            _ilksayi = Convert.ToInt32(EkranLabel.Text);
            ButunIslemLabel.Text = Convert.ToString(_ilksayi + " + ");
        }

        private void CikartButton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _EkranTemizlenecekMi = true;
            _ilksayi = Convert.ToDouble(EkranLabel.Text);
            ButunIslemLabel.Text = Convert.ToString(_ilksayi + " - ");
        }

        private void CarpButton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _EkranTemizlenecekMi = true;
            _ilksayi = Convert.ToDouble(EkranLabel.Text);
            ButunIslemLabel.Text = Convert.ToString(_ilksayi + " * ");
        }

        private void BolButton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _EkranTemizlenecekMi = true;
            _ilksayi = Convert.ToDouble(EkranLabel.Text);
            ButunIslemLabel.Text = Convert.ToString(_ilksayi + " / ");
        }

        private void EsittirButton_Click(object sender, EventArgs e)
        {
            double ikincisayi = Convert.ToDouble(EkranLabel.Text);
            double sonuc;

            switch(_islem)
            {
                case '+':
                    sonuc = _ilksayi + ikincisayi;
                    break;
                case '-':
                    sonuc = _ilksayi - ikincisayi;
                    break;
                case '*':
                    sonuc = _ilksayi * ikincisayi;
                    break;
                case '/':
                    sonuc = _ilksayi / ikincisayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            EkranLabel.Text = Convert.ToString(sonuc);
            ButunIslemLabel.Text = Convert.ToString(_ilksayi + $" {_islem} " + ikincisayi + "=");
            _EkranTemizlenecekMi = true;

        }

        private void SilButton_Click(object sender, EventArgs e)
        {
            EkranLabel.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                EkranLabel.Text = "0";
                _EkranTemizlenecekMi = false;
            }
            EkranLabel.Text += ",";
        }

        private void TekSilButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ButunIslemLabel_Click(object sender, EventArgs e)
        {
            
        }        
    }
}
