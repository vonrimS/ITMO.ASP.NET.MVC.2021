﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Lab01.Models
{

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString() 
        { 
            string s = FirstName + " " + LastName; 
            return s; 
        }
    }
    
}
