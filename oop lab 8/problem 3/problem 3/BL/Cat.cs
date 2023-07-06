﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_3.BL
{
    public class Cat:Mamal
    {
        public Cat(string name):base(name)
        {
            this.name = name;
        }

        public virtual void greets()
        {
            Console.Write("Meow");
        }

        public override string ToString()
        {
            string info = "name is " + name;
            return info;
        }
    }
}
