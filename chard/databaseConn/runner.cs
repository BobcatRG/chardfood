using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace databaseConn
{
    class runner
    {
        static void Main(string[] args)
        {
            //Establish a connection with DBConnect class to access patron table
            DBConnect db = new DBConnect();
            Address myAddress = new Address();
            PreviousVisit pVisit = new PreviousVisit();
            Patron myPatron = new Patron(2, "Joe", "Bloggs", "S", "5550134", myAddress,pVisit);

            //holds quiried data. First element will contain cells of first column from table. Second element contains second column and so on....
            List<Patron> list = new List<Patron>();
            
            list = db.SelectPatron("SELECT * FROM patron WHERE firstName = 'Rob'");
            for (int x = 0; x < list.Count; x++)
            {
                Console.WriteLine(list[x].Id);
                Console.WriteLine(list[x].FirstName);
                Console.WriteLine(list[x].LastName);
                Console.WriteLine(list[x].MiddleInitial);
                Console.WriteLine(list[x].Phone);
                Console.WriteLine(list[x].StreetNum);
                Console.WriteLine(list[x].AddressLine1);
                Console.WriteLine(list[x].AddressLine2);
                Console.WriteLine(list[x].City);
                Console.WriteLine(list[x].State);
                Console.WriteLine(list[x].Zip);
                Console.WriteLine(list[x].NumChildren);
                Console.WriteLine(list[x].NumAdults);
                Console.WriteLine(list[x].Date.Month+"/"+list[x].Date.Day+"/"+list[x].Date.Year);
                Console.WriteLine(" ");
            }

            db.deletePatron(2);

            /*list = db.SelectPatron("SELECT * FROM patron WHERE firstName = 'Rob'");
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            for (int x = 0; x < list.Length; x++)
            {
                for(int y=0;y<list[x].Count;y++){
                    Console.WriteLine(list[x].ElementAt(y));
                }
            }*/
            //db.Query("INSERT INTO patron (patron_id, firstName, lastName, middleInitial, phone) VALUES ('10', 'Tom', 'Maey', 'ff', '2353744')");
            
            Console.ReadLine();
        }
    }
}
