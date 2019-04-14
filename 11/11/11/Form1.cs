using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double intTeller = 0, intTeller2, intInvoer;


        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intInvoer = Convert.ToInt16(tbInvoer.Text);

            //string binary = Convert.ToString(intInvoer, 2);


            //tbUitvoer.Text = binary;

            while (Math.Pow(2, intTeller) < intInvoer)
            {
                intTeller++;
            }

            rtTest.Text = intTeller.ToString();


            /*if (Math.Pow(2, intTeller) == intInvoer)
            {
                tbUitvoer.Text += 1.ToString();
                do 
                {
                    tbUitvoer.Text += 0.ToString();
                    intTeller2++;
                }while (intTeller2 < intTeller) ;
            }
            */
            do
            {

                if (intInvoer - Math.Pow(2, intTeller - 1) == 0)
                {
                    tbUitvoer.Text += 1.ToString();
                    intInvoer = intInvoer - Math.Pow(2, intTeller - 1);
                    for (intTeller2 = 1; intTeller2 <= intTeller - 3; intTeller2++)
                    {
                        tbUitvoer.Text += 0.ToString();
                    }
                }

                else if (intInvoer - Math.Pow(2, intTeller - 1) > 0)
                {
                    tbUitvoer.Text += 1.ToString();
                    intInvoer = intInvoer - Math.Pow(2, intTeller - 1);
                }


                else if (intInvoer - Math.Pow(2, intTeller - 1) < 0)
                {
                    tbUitvoer.Text += 0.ToString();
                }


                intTeller--;

            } while (intTeller > 0);
        }
    }
}

