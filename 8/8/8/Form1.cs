using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            tbOppervlakte.Text = Convert.ToString(4 * Math.PI * Math.Pow(Convert.ToDouble(tbStraal.Text), 2));

            tbInhoud.Text = Convert.ToString(4 * Math.PI * Math.Pow(Convert.ToDouble(tbStraal.Text), 3) / 3);
        }
    }
}
