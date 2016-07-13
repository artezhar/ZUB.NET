using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ZUB.Domain;

namespace ZUB.Domain
{
    public class OnlineForm
    {
        [Key]
        public int ID { get; set; }
        public string Description { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime Date { get; set; }
        public Problem Problem { get; set; }
        public Client Client { get; set; }
    }
}
