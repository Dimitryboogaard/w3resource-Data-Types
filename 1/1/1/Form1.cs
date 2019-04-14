using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller = 0;
        string[] arrayLetters = new string[3];

        private void btnInvoerenAntwoord_Click(object sender, EventArgs e)
        {
            
            if(btnInvoerenAntwoord.Text == "Invoeren")
            {
                arrayLetters[intTeller] = tbInvoer.Text;
                tbInvoer.Text = "";
                intTeller++;
                lblTeller.Text = Convert.ToString(Convert.ToInt16(lblTeller.Text) - 1);

                if (Convert.ToInt16(lblTeller.Text) == 0)
                {
                    btnInvoerenAntwoord.Text = "Antwoord";
                }
            }

            else if(btnInvoerenAntwoord.Text == "Antwoord")
            {
                for(intTeller = 2; intTeller >= 0; intTeller--)
                {
                    tbUitvoer.Text += arrayLetters[intTeller];
                }
            }
        }
    }
}
