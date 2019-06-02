using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIZI_ORNEK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] takim = new string[11];
        int i = 0;


        private void Button1_Click(object sender, EventArgs e)
        {
            takim[i] = textBox1.Text;

            listBox1.Items.Add(takim[i]);

            i++;

         

            

        }
    }
}
