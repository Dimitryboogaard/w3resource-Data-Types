using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double cdblPi = 3.14;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            tbOmtrek.Text = Convert.ToString(Convert.ToDouble(tbStraal.Text) * 2 * cdblPi);

            tbOpperVlakte.Text = Convert.ToString(Math.Pow(Convert.ToDouble(tbStraal.Text), 2) * cdblPi);

        }
    }
}
