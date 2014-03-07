using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * Work left to do on this database:
 * 
 * -DeletePatron: to delete patron and associated address and visits.
 * -UpdatePatron: should be simple enough
 * -PreviousVisits: I havent given this much thought. Havn't even
 *      written the object yet. I dunno how mutators or accessors 
 *      will work yet either.
 */


namespace databaseConn
{
    class DBConnect
    {
        private MySqlConnection connection;//for connecting to patron database
        private MySqlConnection connection2;
        private MySqlConnection connection3;

        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "patrondb";
            uid = "admin";
            password = "admin";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + 
		    database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            connection2 = new MySqlConnection(connectionString);
            connection3 = new MySqlConnection(connectionString);

        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Query statement
        public void Query(String query)
        {
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Select statement
        public List<Patron> SelectPatron(String query)
        {
            //Create a list to store the result
            List<Patron> list = new List<Patron>();
            
            //Open connection
            if (this.OpenConnection() == true)
            {
             
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                
                while (dataReader.Read())
                {
                    String id = dataReader.GetString(0);
                    String fName = dataReader.GetString(1);
                    String lName = dataReader.GetString(2);
                    String mInitial = dataReader.GetString(3);
                    String phone = dataReader.GetString(4);

                    String stNum = "";
                    String addrLine1 = "";
                    String addrLine2 = "";
                    String city = "";
                    String state = "";
                    String zip = "";

                    

                    connection2.Open();
                    String query2 = "SELECT * FROM address WHERE patron_id = '" + id + "'";
                    MySqlCommand cmd2 = new MySqlCommand(query2, connection2);
                    MySqlDataReader dataReader2 = cmd2.ExecuteReader();

                    while (dataReader2.Read())
                    {
                        //THIS NESTED LOOP WILL NOT WORK PROPERLY IF TWO PEOPLE HAVE THE SAME PATRON_ID (which shouldn't exist anyways)
                        //The loop will assign the address of the last person with the last patron id to the object being stored 
                        stNum = dataReader2.GetString(1);
                        addrLine1 = dataReader2.GetString(2);
                        addrLine2 = dataReader2.GetString(3);
                        city = dataReader2.GetString(4);
                        state = dataReader2.GetString(5);
                        zip = dataReader2.GetString(6);

                    }
                    
                    
                    
                    int numChild=0;
                    int numAdult=0;
                    DateTime date = new DateTime();



                    connection3.Open();
                    String query3 = "SELECT * FROM previousvisits WHERE patron_id = '" + id + "'";
                    MySqlCommand cmd3 = new MySqlCommand(query3, connection3);
                    MySqlDataReader dataReader3 = cmd3.ExecuteReader();
                  //  MessageBox.Show("jjd" + date.ToString() + " " + numChild + " " + numAdult);

                    while (dataReader3.Read())
                    {
                        date = (DateTime)dataReader3.GetValue(1);
                        numChild = (int)dataReader3.GetValue(2);
                        numAdult = (int)dataReader3.GetValue(3);
                        
                    }




                    connection2.Close();
                    dataReader2.Close();
                    connection3.Close();
                    dataReader3.Close();

                   
                    

                    Address address = new Address(Int32.Parse(id), stNum, addrLine1, addrLine2, city, state, zip);
                    PreviousVisit prevVis = new PreviousVisit(Int32.Parse(id),numChild,numAdult,date);
                    Patron patron = new Patron(Int32.Parse(id), fName, lName, mInitial, phone, address,prevVis);

                    list.Add(patron);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                MessageBox.Show("Cannot connect to server.");
                return list;
            }
        }

        public void addPatron(Patron pat)
        {
            if (this.OpenConnection() == true)
            {
                String query1 = "INSERT INTO patron VALUES ('" +
                    pat.Id + "', '" +
                    pat.FirstName + "', '" +
                    pat.LastName + "', '" +
                    pat.MiddleInitial + "', '" +
                    pat.Phone + "')";

                String query2 = "INSERT INTO address VALUES ('" +
                   pat.Id + "', '" +
                   pat.StreetNum + "', '" +
                   pat.AddressLine1 + "', '" +
                   pat.AddressLine2 + "', '" +
                   pat.City + "', '" +
                   pat.State + "', '" +
                   pat.Zip + "')";


                String query3 = "INSERT INTO previousvisits VALUES ('" +
                   pat.Date + "', '" +
                   pat.NumChildren + "', '" +
                   pat.NumAdults + "', '" + "')";

                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                MySqlCommand cmd3 = new MySqlCommand(query3, connection);

                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void deletePatron(int id)
        {

            if (this.OpenConnection())
            {
                String query = "DELETE  FROM patron WHERE patron_id='" + id + "'";
                String query1 = "DELETE FROM address WHERE patron_id='" + id + "'";
                String query2 = "DELETE FROM previousvisits WHERE patron_id='" + id + "'";

                MySqlCommand cmd1 = new MySqlCommand(query, connection);
                MySqlCommand cmd2 = new MySqlCommand(query1, connection);
                MySqlCommand cmd3 = new MySqlCommand(query2, connection);

                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();

                this.CloseConnection();
            }


        }

        //Count statement
        public int Count(String query)
        {
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }
    }
}
