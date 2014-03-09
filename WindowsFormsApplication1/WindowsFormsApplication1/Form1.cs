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
            AddNewEntry adder = new AddNewEntry(fNameTextBox.Text, lNameTextBox.Text, miTextBox.Text, addrNumNameTextBox1.Text, addrTextBox2.Text, phoneTextBox.Text, numChildTextBox.Text, numAdultsTextBox.Text, monthMenuTab1.Text,yearTab1.Text,dayMenuTab1.Text);
            
           // MessageBox.Show("Saved Patron");
           
        }

        private void searchTextTab2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addrTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
