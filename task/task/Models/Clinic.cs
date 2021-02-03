using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace task.Models
{
    public class Clinic
    {
        public Clinic()
        {
            RXes = new List<RX>();
        }

        public int Id { get; set; }

        [StringLength(200)]
        public string address { get; set; }

        [StringLength(50)]
        public string mobile { get; set; }

        [ForeignKey("Doctor")]
        public int doctorID { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual ICollection<RX> RXes { get; set; }

    }
}