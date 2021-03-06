﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ZUB.Domain;

namespace ZUB.Domain
{
    public class Position
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Doctor> Doctors { get; set; }
    }
}
