using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OliverAndEmmaRSVP.Data.Entity
{
    public class RSVPEntity
    {
        public Guid Id { get; set; }
        public int NumberOfGuests { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string Questions { get; set; }
    }
}