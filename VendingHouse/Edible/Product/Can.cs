﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingHouse
{
    internal class Can : Drink
    {
        protected Product product;
        public Can(string name, int amount,double price) :
            base(name, amount, price)
        {
            this.MinAmount = 20; ;

        }

        public Can(Product product) : base(product)
        {
            this.MinAmount = 20; ;
        }

        public override string GetProduct()
        {
            return $"I'm a {Name} can ";
        }
    }
}
