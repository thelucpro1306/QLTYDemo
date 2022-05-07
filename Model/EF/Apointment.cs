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

        [Column(TypeName = "date")]
        public DateTime? BookingDate { get; set; }

        [StringLength(250)]
        public string Type { get; set; }

        [Column(TypeName = "ntext")]
        public string Note { get; set; }

        public int? CustumerID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int? status { get; set; }

        public DateTime? DateCreate { get; set; }
    }
}
