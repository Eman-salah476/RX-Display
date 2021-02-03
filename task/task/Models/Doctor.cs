using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace task.Models
{
    public class Doctor
    {
        public Doctor()
        {
            Clinics = new List<Clinic>();
        }
       
        public int Id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string mobile { get; set; }

        public string speciality { get; set; }


        public virtual ICollection<Clinic> Clinics { get; set; }


    }
}