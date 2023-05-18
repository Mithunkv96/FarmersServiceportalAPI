using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Market
    {
        [Key]
        public int Prodect_Id { get; set; }
        public string Product_Name { get; set; }
        public string Product_Details { get; set; }
        public string Product_Price { get; set; }
    }
}
