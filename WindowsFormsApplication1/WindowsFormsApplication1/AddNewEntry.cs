using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    public class AddNewEntry
    {
        private String fNameTextField;
        private String lNameTextField;
        private String miTextField;
        private String addrTextField;
        private String addrTextField2;
        private String phoneTextField;
        private String prevVisTextField;
        private String numChildTextField;
        private String numAdultsTextField;
        private String monthTab1;
        private String yearTab1;
        private String dayTab1;

        public AddNewEntry()
        {
            fNameTextField = "";
            lNameTextField = "";
            miTextField = "";
            addrTextField = "";
            addrTextField2 = "";
            phoneTextField = "";
            prevVisTextField = "";
            numChildTextField = "";
            numAdultsTextField = "";
            monthTab1 = "";
            yearTab1 = "";
            dayTab1 = "";
            
        }
        public AddNewEntry(String fName, String lName, String mi, String addr1, String addr2, String phone, String numC, String numA, String month, String year, String day)
        {
            fNameTextField = fName;
            lNameTextField = lName;
            miTextField = mi;
            addrTextField = addr1;
            addrTextField2 = addr2;
            phoneTextField = phone;
            //prevVisTextField = prevVis;
            numChildTextField = numC;
            numAdultsTextField = numA;
            monthTab1 = month;
            yearTab1 = year;
            dayTab1 = day;
        }
        public void save(AddNewEntry cust)
        {
            DBConnect db = new DBConnect();
            //need to fill in addr
            Address addr = new Address();

            DateTime d1 = new DateTime(Convert.ToInt32(cust.yearTab1), Convert.ToInt32(cust.monthTab1), Convert.ToInt32(cust.dayTab1));
            PreviousVisit pv = new PreviousVisit(0, Convert.ToInt32(cust.numChildTextField), Convert.ToInt32(cust.numAdultsTextField), d1);
            Patron p = new Patron(0, cust.fNameTextField, cust.lNameTextField, cust.miTextField, cust.phoneTextField, addr, pv);
            db.addPatron(p);
        }
    }
}