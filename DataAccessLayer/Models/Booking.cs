using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Booking
    {
        [Key]
        public int Booking_Id { get; set; }
        [ForeignKey ("User")]
       
        public int User_Id { get; set; }
        public User User { get; set; }
        public DateTime Start_Time { get; set; }
        public DateTime End_Time { get; set; }
        [ForeignKey("Machine")]
        public int Machine_Id { get; set; }
        public Machine Machine { get; set; }
        public string Place { get; set;  }
        public string Price { get; set; }
    }
}
