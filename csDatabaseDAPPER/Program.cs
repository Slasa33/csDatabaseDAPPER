using System;
using System.Collections.Generic;
using System.Threading.Channels;
using Dapper;
using Microsoft.Data.Sqlite;

namespace csDatabaseDAPPER
{

    class CustomerWithOrder
    {
        public Customer Customer { get; set; }
        public Order Order { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {

            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.SQLite);


            List<Customer> customers = new List<Customer>()
            {
                new Customer()
                {
                    Name = "Jakub",
                    Address = "Karvina"
                },
                new Customer()
                {
                    Name = "Petr",
                    Address = null
                }
            };

            string connectionstring = "Data Source=mydb.db";


            using (SqliteConnection connection = new SqliteConnection(connectionstring))
            {
                connection.Open();


                //Customer c = connection.QueryFirst<Customer>("SELECT * FROM Customer WHERE Id=@Id", new
                //{
                //    Id = 8
                //});

                //c.Name = c.Name.ToUpper();

                //connection.Update(c);


                //foreach (var pair in connection.Query<Customer, Order, CustomerWithOrder>("" +
                //    "SELECT * FROM Customer LEFT JOIN \"Order\" ON Customer.Id = \"Order\".CustomerId",
                //    ((Customer c, Order o) =>  new CustomerWithOrder() { Customer = c, Order = o})
                //    ))
                //{
                //    Console.WriteLine(pair.Customer.Id + " " + pair.Customer.Name + " " + pair.Order?.Product);
                //}

                //connection.Insert<Order>(new Order()
                //{
                //    CustomerId = 8,
                //    Product = "Kondom",
                //    Price = 111
                //});

                //foreach (var customer in customers)
                //{
                //    connection.Insert(customer);
                //}

                //foreach (var c in connection.Query<Customer>("SELECT * FROM Customer"))
                //{
                //    Console.WriteLine(c.Id + " " + c.Name + " " + c.Address);
                //}

                // Console.WriteLine(connection.QuerySingle<long>("SELECT COUNT(*) FROM Customer"));

            }

            //Console.WriteLine("gas");

        }
    }
}
