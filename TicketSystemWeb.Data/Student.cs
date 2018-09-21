using System;
using System.Collections.Generic;
using System.Text;

namespace TicketSystemWeb.Data
{
    public class Student:BaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string TelephoneNumber { get; set; }
    }
}
