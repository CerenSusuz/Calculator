using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi.App
{
    public partial class Form1 : Form
    {
        double num1,num2,result;
        int opr;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //form çalışmaya başladığında ilk ekranda 0 yazılsın
            txtinput.Text = "0";
            txtinput.Text = "";
        }

        private void btnone_Click(object sender, EventArgs e)
        {
            txtinput.Text += "1";
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            txtinput.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtinput.Text += "3";
        }

        private void btnfour_Click(object sender, EventArgs e)
        {
            txtinput.Text += "4";
        }

        private void btnfive_Click(object sender, EventArgs e)
        {
            txtinput.Text += "5";
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
            txtinput.Text += "6";
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            txtinput.Text += "7";
        }

        private void btneight_Click(object sender, EventArgs e)
        {
            txtinput.Text += "8";
        }

        private void btnnine_Click(object sender, EventArgs e)
        {
            txtinput.Text += "9";
        }
        private void btnzero_Click(object sender, EventArgs e)
        {
            txtinput.Text += "0";
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtinput.Text); //ekrandaki ikinci sayıyı int'e dönüştür
            txtresult.Text = "";
            txtinput.Text = DoProcess();
        }

        private void btnsubt_Click(object sender, EventArgs e)
        {
            //Subtraction-Çıkarma İşlemi
            num1 = Convert.ToDouble(txtinput.Text); //ekrandaki ilk sayıyı int'e dönüştür
            txtresult.Text = $"{num1}-";
            txtinput.Text = "";
            opr = 1;
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            //Multiplication-Çarpma İşlemi
            num1 = Convert.ToDouble(txtinput.Text); //ekrandaki ilk sayıyı int'e dönüştür
            txtresult.Text = $"{num1}*";
            txtinput.Text = "";
            opr = 2;
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            //Division-Bölme İşlemi
            num1 = Convert.ToDouble(txtinput.Text); //ekrandaki ilk sayıyı int'e dönüştür
            txtresult.Text = $"{num1}/";
            txtinput.Text = "";
            opr = 3;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            txtinput.Text = "";
            txtresult.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtinput.Text += ",";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //Addiction-Toplama İşlemi
            num1 = Convert.ToDouble(txtinput.Text); //ekrandaki ilk sayıyı int'e dönüştür
            txtresult.Text = $"{num1}+";
            txtinput.Text = "";
            opr = 0;
        }
        public string DoProcess()
        {
            switch (opr)
            {
                case 0:
                    result = num1 + num2;
                    break;
                case 1:
                    result = num1 - num2;
                    break;
                case 2:
                    result = num1 * num2;
                    break;
                case 3:
                    result = num1 / num2;
                    break;
                default:
                    break;
            }
            return result.ToString();
        }
        
    }
}
