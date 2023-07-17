using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_makinesi1
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekrantemizlenecekmi;
        int _ilksayi;
        int _ikincisayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void rakam1_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "1";
        }
        private void rakam2_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "2";
        }
        private void rakam3_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "3";
        }
        private void toplama_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(label1.Text);
        }
        private void rakam4_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "4";
        }
        private void rakam5_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "5";
        }
        private void rakam6_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "6";
        }
        private void çıkartma_Click(object sender, EventArgs e)
        {

            _islem = '-';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(label1.Text);           
        }
        private void rakam7_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "7";
        }
        private void rakam8_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "8";
        }
        private void rakam9_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "9";
        }
        private void çarpma_Click(object sender, EventArgs e)
        {

            _islem = '*';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(label1.Text);
        }
        private void C_Click(object sender, EventArgs e)
        {

            label1.Text = "0";
        }
        private void rakam0_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi)
            {
                label1.Text = "";
                _ekrantemizlenecekmi = false;
            }
            if (label1.Text == "0") label1.Text = "";
            label1.Text += "0";
        }
        private void eşittir_Click(object sender, EventArgs e)
        {
            int sonuc = 0;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayi + _ikincisayi;
                    break;
                case '-':
                    sonuc = _ilksayi - _ikincisayi;
                    break;
                case '*':
                    sonuc = _ilksayi * _ikincisayi;
                    break;
                case '/':
                    sonuc = _ilksayi / _ikincisayi;
                    break;
            }
            label1.Text = Convert.ToString(sonuc);
        }
        private void bölme_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(label1.Text);
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
