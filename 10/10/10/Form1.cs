using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intGetal1, intGetal2;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intGetal1 = Convert.ToInt32(tbGetal1.Text);
            intGetal2 = Convert.ToInt32(tbGetal2.Text);

            if(intGetal1 % 2 == 0 && intGetal2 % 2 == 0)
            {
                lblAllebeiEvenOfNiet.Text = "Allebei even.";
            }

            else if(intGetal1 % 2 != 0 && intGetal2 % 2 != 0)
            {
                lblAllebeiEvenOfNiet.Text = "Allebei oneven.";

            }
        }
    }
}
