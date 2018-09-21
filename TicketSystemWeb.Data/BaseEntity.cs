using System;
using System.Collections.Generic;
using System.Text;

namespace TicketSystemWeb.Data
{
    public abstract class BaseEntity
    {
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public String Author { get; set; }
    }
}
