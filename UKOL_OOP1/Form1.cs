using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UKOL_OOP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NakladniAuto nakladauto;
        private void Form1_Load(object sender, EventArgs e)
        {
            nakladauto = new NakladniAuto("4A8 4789", 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cislonaloz = Convert.ToInt32(textBox1.Text);
            nakladauto.NalozNaklad(cislonaloz);
            MessageBox.Show(nakladauto.ToString());
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            int cislovyloz = Convert.ToInt32(textBox2.Text);
            nakladauto.VylozNaklad(cislovyloz);
            MessageBox.Show(nakladauto.ToString());
        }
    }
}
