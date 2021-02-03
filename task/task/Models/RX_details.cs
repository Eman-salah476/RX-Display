using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace task.Models
{
    public class RX_details
    {
     
      
      
       [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RXId { get; set; }

       
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int medicineId { get; set; }

        [StringLength(50)]
        public string dosage { get; set; }

        public virtual RX RX { get; set; }
        public virtual Medicine Medicine { get; set; }

    }
}