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
            /*
             * dataGridView2
            private System.Windows.Forms.DataGridViewTextBoxColumn viewAllFirstName;
            private System.Windows.Forms.DataGridViewTextBoxColumn viewAllLastName;
            private System.Windows.Forms.DataGridViewTextBoxColumn viewAllMiddleInitial;
            private System.Windows.Forms.DataGridViewTextBoxColumn viewAllAddressLine1;
            private System.Windows.Forms.DataGridViewTextBoxColumn viewAllAddressLine2;
            private System.Windows.Forms.DataGridViewTextBoxColumn viewAllPhone;
            private System.Windows.Forms.DataGridViewTextBoxColumn viewAllAdults;
            private System.Windows.Forms.DataGridViewTextBoxColumn viewAllChildren;
            private System.Windows.Forms.DataGridViewTextBoxColumn viewAllPrevVisit;
            */

            InitializeComponent();
            DBConnect db = new DBConnect();

            int count = db.Count("SELECT * FROM patron");

            String[] rows = new String[count];

            List<Patron> list = new List<Patron>();
            list = db.SelectPatron("SELECT * FROM patron");

            for (int x = 0; x < list.Count; x++)
            {
                String date = list[x].Date.Month + "/" + list[x].Date.Day + "/" + list[x].Date.Year;
                String children = "";
                children += list[x].NumChildren;
                String adults = "";
                adults += list[x].NumAdults;
                string[] row = { list[x].FirstName, list[x].LastName, list[x].MiddleInitial, list[x].AddressLine1, list[x].AddressLine2, list[x].Phone, children, adults, date };
                dataGridView2.Rows.Add(row);
            }
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

        private void addrTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
