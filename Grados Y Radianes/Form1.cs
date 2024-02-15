using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grados_Y_Radianes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double grados = double.Parse(GRADtextBox1.Text);
            double radianes = ConvertirAGrados(grados);

            RESULTlabel1.Text = (grados + " grados es igual a " + radianes + " radianes "); 
        }

        private double ConvertirAGrados(double grados)
        {
            return (grados * Math.PI) / 180;
            throw new NotImplementedException();
        }

        private void GRADtextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
