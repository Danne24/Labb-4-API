using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_4___API.Models
{
    public class Website
    {
        [Key]
        public int WebsiteID { get; set; }
        public string WebsiteLink { get; set; }

        public int HobbyID { get; set; }
        public Hobby Hobby { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }
    }
}
