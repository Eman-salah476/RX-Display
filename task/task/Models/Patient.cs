using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace task.Models
{
    public class Patient
    {
        public Patient()
        {
            RXes = new List<RX>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string mobile { get; set; }

        public virtual ICollection<RX> RXes { get; set; }

    }
}