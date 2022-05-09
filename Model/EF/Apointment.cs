namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Apointment")]
    public partial class Apointment
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "Date is required")]
        [Column(TypeName = "date")]
        public DateTime? BookingDate { get; set; }
        
        public TimeSpan? BookingTime { get; set; }
        
        public long? ServicesId { get; set; }

        [Column(TypeName = "ntext")]
        public string Note { get; set; }

        public long? CustumerID { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Phone is required")]
        [StringLength(50)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [StringLength(50)]
        public string Email { get; set; }

        public int? status { get; set; }

        public DateTime? DateCreate { get; set; }

        public virtual Servicess Servicess { get; set; }

        public virtual User User { get; set; }

        public List<Servicess> list = new List<Servicess>();

    }
}
