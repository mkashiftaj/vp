using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgebricEqSolver
{
    public partial class slForm : Form
    {
        public slForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {}

        private void btnok_Click(object sender, EventArgs e)
        {
            if (selcomb.SelectedIndex == 0)
            {
                QEqform obj1 = new QEqform();
                obj1.Show();
            }
            if (selcomb.SelectedIndex == 1)
            {
                LEqform obj3 = new LEqform();
                obj3.Show();
            }
            if (selcomb.SelectedIndex == 2)
            {
                Valuesform obj2 = new Valuesform();
                obj2.Show();
            }
            if (selcomb.SelectedIndex == 3)
            {
                Valuesform obj3 = new Valuesform();
                obj3.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
