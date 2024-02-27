using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prosjek_Ocjena
{
    public partial class Form1 : Form
    {

        int ocjena, zbrOcjena = 0 , zbroj;
        double prosjek;
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_Click(object sender, EventArgs e)
        {
            ocjena = Convert.ToInt32(txtUnosOcjena.Text);
            zbrOcjena++;
            zbroj += ocjena;
            DialogResult odgovor = MessageBox.Show("Zelis li upisat jos ocjena", "Upit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (odgovor)
            {
              case DialogResult.Yes:
                    txtUnosOcjena.Clear();
                    txtUnosOcjena.Focus();
                    break;
                    case DialogResult.No:
                    prosjek = (double)zbroj / zbrOcjena; 
                    txtProsjekOcjena.Text = prosjek.ToString(); 
                    break;
            }


        }
    }
}
