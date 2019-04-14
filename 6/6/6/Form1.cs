using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller;
        double dblAntwoord;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            for(intTeller = -5; intTeller <= 5; intTeller++)
            {
                dblAntwoord = Math.Pow(intTeller, 2) + 2 * intTeller + 1;
                rtUitvoer.Text += intTeller.ToString() + "   " + dblAntwoord.ToString() + Environment.NewLine;
            }
        }
    }
}
