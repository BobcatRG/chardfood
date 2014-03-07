using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

       


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            AddNewEntry adder = new AddNewEntry();
            adder.fNameTextField=fNameTextBox.Text;
            adder.lNameTextField = lNameTextBox.Text;
            adder.miTextField = miTextBox.Text;
            adder.addrTextField = addrTextBox1.Text;
            adder.addrTextField2 = addrTextBox2.Text;
            adder.phoneTextField = phoneTextBox.Text;
            adder.numAdultsTextField = numAdultsTextBox.Text;
            adder.numChildTextField = numChildTextBox.Text;
            adder.miTextField = miTextBox.Text;
            adder.monthTab1 = monthMenuTab1.Text;
           // MessageBox.Show("Saved Patron");
           
        }

        private void searchTextTab2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
