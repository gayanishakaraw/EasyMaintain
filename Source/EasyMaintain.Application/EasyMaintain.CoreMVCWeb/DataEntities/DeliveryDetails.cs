﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyMaintain.CoreWebMVC.DataEntities
{
    public class DeliveryDetails
    {
        public int DeliveryDetailsId { get; set; }
        public string DeliveryDate { get; set; }
        public string DeliveryMethod { get; set; }
        public string PersonInCharge { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string AddtionalNotes { get; set; }
    }
}