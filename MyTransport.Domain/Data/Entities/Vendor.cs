using System;
using System.Collections.Generic;
using System.Text;

namespace MyTransport.Domain.Entities
{
    public class Vendor
    {

        public int Id { get; set; }

        public string VendorName { get; set; }

        public string OwnerName { get; set; }

        public string OwnerMobile { get; set; }

        public string OwnerEmail { get; set; }

        public string SupervisorName { get; set; }

        public bool IsActive { get; set; }

    }
}
