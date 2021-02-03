using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace task.Models
{
    public class RX
    {
        public RX()
        {
            RX_Details = new List<RX_details>();
        }

        public int Id { get; set; }

        [ForeignKey("Patient")]
        public int patientID { get; set; }

        [ForeignKey("Clinic")]
        public int clinicID { get; set; }

         [Column(TypeName = "date")]       
        public DateTime date { get; set; }

        public virtual Clinic Clinic { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual ICollection<RX_details> RX_Details { get; set; }


    }
}