namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Servicess")]
    public partial class Servicess
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servicess()
        {
            Apointments = new HashSet<Apointment>();
            MedicalExaminationForms = new HashSet<MedicalExaminationForm>();
        }

        public long id { get; set; }

        [StringLength(10)]
        public string Name { get; set; }

        public int? Cost { get; set; }

        [StringLength(10)]
        public string DateCreate { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Apointment> Apointments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicalExaminationForm> MedicalExaminationForms { get; set; }
    }
}
