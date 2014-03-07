using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace databaseConn
{
    class Address
    {
        private int id; 
        private String streetNum;
        private String addressLine1;
        private String addressLine2;
        private String city;
        private String state;
        private String zip;

        public Address()
        {
            setAddress(0, "", "", "", "", "", "");
        }

        public Address(int id, String streetNum, String addressLine1, String addressLine2, String city, String state, String zip)
        {
            setAddress(id, streetNum, addressLine1, addressLine2, city, state, zip);
        }

        public void setAddress(int id, String streetNum, String addressLine1, String addressLine2, String city, String state, String zip)
        {
            this.id = id;
            this.streetNum = streetNum;
            this.addressLine1 = addressLine1;
            this.addressLine2 = addressLine2;
            this.city = city;
            this.state = state;
            this.zip = zip;
        }

        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public String StreetNum
        {
            set { streetNum = value; }
            get { return streetNum; }
        }

        public String AddressLine1
        {
            set { addressLine1 = value; }
            get { return addressLine1; }
        }

        public String AddressLine2
        {
            set { addressLine2 = value; }
            get { return addressLine2; }
        }

        public String City
        {
            set { city = value; }
            get { return city; }
        }

        public String State
        {
            set { state = value; }
            get { return state; }
        }

        public String Zip
        {
            set { zip = value; }
            get { return zip; }
        }
    }
}
