using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using ZUB.Domain;
using ZUB.Models;

namespace ZUB.Domain
{
    public class Doctor
    {
        [Key]
        public int ID { get; set; }
        public string Description { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name
        {
            get { return $"{LastName} {FirstName}"; }
        }
        public Position Position { get; set; }
        public List<Problem> Problems { get; set; }
    }
}