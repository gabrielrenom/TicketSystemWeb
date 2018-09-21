using System;
using System.Collections.Generic;
using System.Text;

namespace TicketSystemWeb.Data
{
    public class Department:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
