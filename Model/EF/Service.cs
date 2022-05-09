namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Service
    {
        public int id { get; set; }

        [StringLength(50)]
        public string ServicesName { get; set; }

        public decimal? Cost { get; set; }
    }
}
