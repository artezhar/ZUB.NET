using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using ZUB.Domain;

namespace ZUB.Domain
{
    public class Problem
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Urgency { get; set; }
        public Category Category { get; set; }
        public List<Doctor> Doctors { get; set; }
    }

}