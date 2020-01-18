using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personels
{
    public partial class AdministrativePersonelForm : Form
    {
        public AdministrativePersonelForm()
        {
            InitializeComponent();
        }
        public string MaritalStatus { get; set; }

        public int step { get; set; }

        public int degree { get; set; }

        public int numOfChildren { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {

         

            AdministrativePersonel adp = new AdministrativePersonel();
            adp.admDuty = checkBox1.Checked;
            label2.Text = Convert.ToString(adp.CalculateSalary(numOfChildren, degree, step, MaritalStatus));

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
