﻿using System;
using System.Collections.Generic;
using System.Text;
using System.DateTime;

namespace LSP.models
{
    class Order
    {
        public DateTime Date { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int CustomerId { get; set; }
        public double TotalPrice { get; set }

    }
}