﻿using System;
using System.Collections.Generic;
using System.Text;

namespace aulaInterfaces.services
{
    class BrasulTaxservices : ITaxServices
    {

        public double Tax(double amount)
        {
            if (amount <= 100.00)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }


    }
}
