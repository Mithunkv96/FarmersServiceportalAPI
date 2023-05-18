using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Father_Name { get; set; }
        
        public int Aadhar_No { get; set; }
        public int Contact_No { get; set; }
        public string Location { get; set; }

    }
    
}
