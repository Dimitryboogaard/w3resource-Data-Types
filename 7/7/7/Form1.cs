using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intAantalSeconden;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intAantalSeconden = Convert.ToInt32(tbUren.Text) * 3600 +
                                Convert.ToInt32(tbMinuten.Text) * 60 +
                                Convert.ToInt32(tbSeconden.Text);

            tbMPerSeconde.Text = Convert.ToString(Math.Round(Convert.ToDouble(tbAfstand.Text) / intAantalSeconden, 2));

            tbkmPerUur.Text = Convert.ToString(Math.Round(Convert.ToDouble(tbMPerSeconde.Text) * 3.6, 2));

            tbMilesPerUur.Text = Convert.ToString(Math.Round(Convert.ToDouble(tbkmPerUur.Text) / 1.609, 2));
        }
    }
}
