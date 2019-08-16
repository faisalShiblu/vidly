﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
        public string Details
        {
            get
            {
                if (Customer != null && Customer.Id != 0)
                    return "Update Customer Details";

                return "Add Customer";
            }
        }
    }
}