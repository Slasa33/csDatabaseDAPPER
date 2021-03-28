using System;
using System.Collections.Generic;
using System.Text;
using Dapper;

namespace csDatabaseDAPPER
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

    }
}
