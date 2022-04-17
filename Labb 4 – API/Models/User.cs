using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_4___API.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public int UserAge { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public int UserPhoneNumber { get; set; }

        public ICollection<Website> Websites { get; set; }
    }
}
