using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Customer:IEntity
    {
        public string CustomerId { get; set; }
        public String ContactName { get; set; }
        public String CompanyName { get; set; }
        public string City { get; set; }
    }
}
