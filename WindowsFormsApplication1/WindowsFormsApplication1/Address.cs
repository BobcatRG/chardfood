using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Address
    {
        private int id; 
        private String streetNum;
        private String streetName1;
        private String streetName2;
        private String city;
        private String state;
        private String zip;
        private String city2;
        private String state2;
        private String zip2;

        public Address()
        {
            setAddress(0, "", "", "", "", "", "","","","");
        }

        public Address(int id, String streetNum, String streetName1, String streetName2, String city, String state, String zip, String city2, String state2, String zip2)
        {
            setAddress(id, streetNum, streetName1, streetName2, city, state, zip,city2,state2,zip2);
        }

        public void setAddress(int id, String streetNum, String streetName1, String streetName2, String city, String state, String zip, String city2, String state2, String zip2)
        {
            this.id = id;
            this.streetNum = streetNum;
            this.streetName1 = streetName1;
            this.streetName2 = streetName2;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.city2 = city2;
            this.state2 = state2;
            this.zip2 = zip2;
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

        public String StreetName1
        {
            set { streetName1 = value; }
            get { return streetName1; }
        }

        public String StreetName2
        {
            set { streetName2 = value; }
            get { return streetName2; }
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
        public String City2
        {
            set { city = value; }
            get { return city; }
        }

        public String State2
        {
            set { state = value; }
            get { return state; }
        }

        public String Zip2
        {
            set { zip = value; }
            get { return zip; }
        }
    }
}
