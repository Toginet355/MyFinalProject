﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstratc
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
    }
}
