using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            matarebeli sadguri= new matarebeli();
            int vagonebis_raod, vagonshi_mgzavr=35;
            sadguri.biletebis_fasi = int.Parse(textBox1.Text);
            sadguri.biletebis_raod = int.Parse(textBox2.Text);

      /*      public void vagonebi(double vagonebi)
            {
                vagonebis_raod = (int)vagonebi;
                double mag = biletebis_raod / vagonshi_mgzavr;
                if (biletebis_raod % vagonshi_mgzavr == 0)
                {
                    vagonebi = mag;
                }
                else
                {
                    vagonebi = Math.Ceiling(mag);
                }
            }*/

            sadguri.mogeba(label1);
            sadguri.gamotana(label2);


        }
    }
}
