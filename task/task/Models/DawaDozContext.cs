using System;
using System.Data.Entity;
using System.Linq;

namespace task.Models
{
    public class DawaDozContext : DbContext
    {
        public DawaDozContext()
            : base("name=DawaDozContext")
        {
        }

      
        public virtual DbSet<Clinic> Clinics { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<RX> RXes { get; set; }
        public virtual DbSet<RX_details> RX_Details { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}