using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intGetal1, intGetal2, intAntwoord;
        string strOperatie;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intGetal1 = Convert.ToInt32(tbGetal1.Text);
            intGetal2 = Convert.ToInt32(tbGetal2.Text);
            strOperatie = tbOperatie.Text;

            switch(strOperatie)
            {
                case "+":
                    tbAntwoord.Text = Convert.ToString(intGetal1 + intGetal2);
                    break;

                case "-":
                    tbAntwoord.Text = Convert.ToString(intGetal1 - intGetal2);
                    break;

                case "*":
                    tbAntwoord.Text = Convert.ToString(intGetal1 * intGetal2);
                    break;

                case "X":
                    tbAntwoord.Text = Convert.ToString(intGetal1 * intGetal2);
                    break;

                case "/":
                    tbAntwoord.Text = Convert.ToString(intGetal1 / intGetal2);
                    break;

            }
        }
    }
}
