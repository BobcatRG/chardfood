using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Patron
    {
        private int id;
        private String firstName;
        private String lastName;
        private String middleInitial;
        private String phone;
        private Address address;
        private PreviousVisit pv;

        public Patron()
        {
            setPatron(0, "", "", "", "", null, null);
        }

        public Patron(int id, String firstName, String lastName, String middleInitial, String phone, Address address, PreviousVisit previousVisit)
        {
            setPatron(id, firstName, lastName, middleInitial, phone, address, previousVisit);
        }

        public void setPatron(int id, String firstName, String lastName, String middleInitial, String phone, Address address, PreviousVisit previousVisit)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.middleInitial = middleInitial;
            this.phone = phone;
            this.address = address;
            this.pv = previousVisit;
        }

        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public String FirstName
        {
            set { firstName = value; }
            get { return firstName; }
        }

        public String LastName
        {
            set { lastName = value; }
            get { return lastName; }
        }

        public String MiddleInitial
        {
            set { middleInitial = value; }
            get { return middleInitial; }
        }

        public String Phone
        {
            set { phone = value; }
            get { return phone; }
        }

        public String StreetNum
        {
            set { address.StreetNum = value; }
            get { return address.StreetNum; }
        }

        public String AddressLine1
        {
            set { address.AddressLine1 = value; }
            get { return address.AddressLine1; }
        }

        public String AddressLine2
        {
            set { address.AddressLine2 = value; }
            get { return address.AddressLine2; }
        }

        public String City
        {
            set { address.City = value; }
            get { return address.City; }
        }

        public String State
        {
            set { address.State = value; }
            get { return address.State; }
        }

        public String Zip
        {
            set { address.Zip = value; }
            get { return address.Zip; }
        }

        public int NumChildren
        {
            set { pv.NumChildren = value; }
            get { return pv.NumChildren; }
        }

        public int NumAdults
        {
            set { pv.NumAdults = value; }
            get { return pv.NumAdults; }
        }

        public DateTime Date
        {
            set { pv.Date = value; }
            get { return pv.Date; }
        }
    }
}
