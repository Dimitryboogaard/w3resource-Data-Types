using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char strTeken;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strTeken = Convert.ToChar(tbTeken.Text);

            if(strTeken == 'a' || strTeken == 'o' || strTeken == 'u' || strTeken == 'i' || strTeken == 'e')
            {
                lblAntwoord.Text = "Het is een kleine letter klinker.";
            }

            else if(strTeken >= '0' && strTeken <= '9')
            {
                lblAntwoord.Text = "Het is een cijfer.";

            }

            else
            {
                lblAntwoord.Text = "Het is iets anders.";
            }
        }
    }
}
