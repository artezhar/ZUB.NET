using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ZUB.Domain;

namespace ZUB.Domain
{
    public class Client
    {
        [Key]
        public int ID { get; set; }
        public string Description { get; set; }
        public string CardNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Name
        {
            get { return $"{LastName} {FirstName}"; }
        }
        public List<string> EMAILS { get; set; }
        public List<string> PhoneNumbers { get; set; }
    }

   
}