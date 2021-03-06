﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace task.Models
{
    public class Medicine
    {
        public Medicine()
        {
            RX_Details = new List<RX_details>();
        }
        public int Id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string code { get; set; }

        public virtual ICollection<RX_details> RX_Details { get; set; }

    }
}