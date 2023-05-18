using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Machine
    {
        [Key]
        public int Machine_Id { get; set; }
        public string Machine_Details { get; set; }
        public int Model_Id { get; set; }
        public string Model_Name { get; set; }
        public int Brand_Id { get; set; }
        public string Brand_Name { get; set; }
        public string Machine_Available { get; set; }
        public string Price { get; set; }

    }
}
