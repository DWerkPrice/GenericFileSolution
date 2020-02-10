using System;
using System.Collections.Generic;

namespace GenericCollections
{
    class Program
    {

            static void Main(string[] args) {
                // Dynamic Arrays defined
                var ints = new List<int>();
                ints.Add(1);
                ints.Add(2);
                ints.Add(3);
                Console.WriteLine($"Number of ints is {ints.Count}");
                // Use foreach to print out ==  always use foreach when possible
                foreach (var anInt in ints) {
                    Console.Write($" {anInt}");
                }
                ints.Remove(2);
                Console.WriteLine($"Number of ints is {ints.Count}");
                foreach (var anInt in ints) {
                    Console.Write($" {anInt}");
                }
                var stdnames = new List<string>();
                stdnames.Add("Sarah");
                stdnames.Add("Manish");
                stdnames.Add("Rob");
                stdnames.Add("George");
                stdnames.Add("Parker");
                stdnames.Add("Laura");
                stdnames.Add("Ian");
                stdnames.Add("Vaugn");
                stdnames.Add("Danae");
                stdnames.Add("Armon");
                stdnames.Add("Tracie");
                stdnames.Add("David");
                Console.WriteLine($"Number of Student Names is {stdnames.Count}");

                foreach (var name in stdnames) {
                    Console.Write($" {name}");
                }

                //generic array of strings *** convention name class call plural of class name
                var customers = new List<Customer>();
                var amazon = new Customer(1 , "Amazon" , true);
                var pg = new Customer(2 , "P&G" , true);
                /* different way to pass data on next line which allows you to leave out nulls so that if 
                tons of fields to pass in you can specify just the ones you want to pass, looks
                like more code in this example 
                */
                var meijer = new Customer { Id = 3 , Name = "Meijer" , Active = true };
                var target = new Customer { Id = 4 , Name = "Target" , Active = true };
                var microsoft = new Customer { Id = 5 , Name = "Microsoft" , Active = false };

                customers.Add(amazon);
                customers.Add(pg);
                var custarray = new Customer[] { meijer , target , microsoft };
                customers.AddRange(custarray);
                Console.WriteLine();
            foreach (var customer in customers) {
                //    if (customer.Active == true) {
                //        Console.Write($"[customer.Id}, {customer.Name},{customer.Active}");
                //}
                if (customer.Active == false) {
                    continue;
                }

                Console.Write($"[{customer.Id}, {customer.Name}, {customer.Active}], ");

                Console.WriteLine();

                var custName = "Not Found";

                foreach (var cust in customers) {

                    if (cust.Id == 3) {
                        custName = cust.Name;
                        Console.Write($"Cust with ID of 3 {cust.Name}");
                        break;
                    }

                }
                Console.WriteLine();

                var custDictionary = new Dictionary<int , Customer>();
                custDictionary.Add(amazon.Id , amazon);
                custDictionary.Add(target.Id , target);
                custDictionary.Add(meijer.Id , meijer);
                custDictionary.Add(pg.Id , pg);
                custDictionary.Add(microsoft.Id , microsoft);

                var cust2 = custDictionary[3];
                Console.WriteLine($"Customer id 3 is {cust2.Name}");

                cust2 = custDictionary[2];
                Console.WriteLine($"Customer id 2 is {cust2.Name}");

                // cleaner way is to just do the following
                Console.WriteLine($"Customer Id 2 is {custDictionary[2].Name}");

                // property of custDictionary.Keys
                foreach(var key in custDictionary.Keys) {
                    var customer2 = custDictionary[key];
                    Console.WriteLine($"{customer2.Name}"); 
                }
            }
        }
    }
}