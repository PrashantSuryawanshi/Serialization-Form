﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemo
{
    [Serializable]//attribute
    //informs to the runtime that this class allow to serlize
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
