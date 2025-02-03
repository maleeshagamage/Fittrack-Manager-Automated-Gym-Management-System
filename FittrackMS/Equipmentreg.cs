using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FittrackMS
{
    public partial class Equipmentreg : Form
    {
        public Equipmentreg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Equipmentadding form2 = new Equipmentadding();
            form2.ShowDialog();
            this.Show();

        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryView form2 = new InventoryView();
            form2.ShowDialog();
            this.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard form2 = new Dashboard();
            form2.ShowDialog();
            this.Show();
        }
    }
}
