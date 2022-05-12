namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetailsMedicalForm")]
    public partial class DetailsMedicalForm
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long illid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MEFid { get; set; }

        [StringLength(250)]
        public string symptom { get; set; }

        [StringLength(250)]
        public string diagnose { get; set; }

        public virtual illness illness { get; set; }

        public virtual MedicalExaminationForm MedicalExaminationForm { get; set; }
    }
}
