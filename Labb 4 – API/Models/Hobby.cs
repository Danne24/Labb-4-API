using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_4___API.Models
{
    public class Hobby
    {
        [Key]
        public int HobbyID { get; set; }
        public string HobbyName { get; set; }
        public string HobbyDescription { get; set; }

        public ICollection<Website> Websites { get; set; }
    }
}
