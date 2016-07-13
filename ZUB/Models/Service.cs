using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ZUB.Domain;

namespace ZUB.Domain
{
    public class Service
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ServiceType Type { get; set; }
        public DateTime Date { get; set; }
        public List<Doctor> Doctors { get; set; }
        public Client Client { get; set; }
        public ServiceStatus Status { get; set; }
    }
}
