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
    public partial class PersonelForm : Form 
    {
       


        public PersonelForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            AcademicPersonelForm ac = new AcademicPersonelForm();
            AdministrativePersonelForm ad = new AdministrativePersonelForm();

            string ptype = Convert.ToString(comboBox1.SelectedItem);
            ac.label1.Text = ptype; 
            ad.label1.Text = ptype;

          
            
            
            if (ac.label1.Text == "Academic Personel"){
                Hide();
                ac.MaritalStatus = Convert.ToString(comboBox2.Text);
                ac.numOfChildren = Convert.ToInt32(textBox1.Text);
                ac.step = Convert.ToInt32(textBox2.Text);
                ac.degree = Convert.ToInt32(textBox3.Text);
                ac.ShowDialog();
                Close();
               
            }
            if (ad.label1.Text == "Administrative Personel"){
                Hide();
                ad.numOfChildren = Convert.ToInt32(textBox1.Text);
                ad.step = Convert.ToInt32(textBox2.Text);
                ad.degree = Convert.ToInt32(textBox3.Text);
                ad.ShowDialog();
                Close();
            }
        }

        private void PersonelForm_Load(object sender, EventArgs e)
        {

        }
    }
}
