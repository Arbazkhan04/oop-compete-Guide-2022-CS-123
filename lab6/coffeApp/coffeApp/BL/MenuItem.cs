﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeApp.BL
{
    public class MenuItem
    {
        public string name;
        public string type;
        public int price; 
        public MenuItem(string name,string type,int price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }
    }
}
