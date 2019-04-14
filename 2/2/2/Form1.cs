using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intGetal, intBreedte;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intGetal = Convert.ToInt32(tbGetal.Text);
            intBreedte = Convert.ToInt32(tbBreedte.Text);

            do
            {
                for(intTeller = 1; intTeller <= intBreedte; intTeller++)
                {
                    rtUitvoer.Text += intGetal.ToString();
                }

                rtUitvoer.Text += Environment.NewLine;

                intBreedte--;

            } while (intBreedte >= 1);

        }
    }
}
