namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MedicalExaminationForm")]
    public partial class MedicalExaminationForm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MedicalExaminationForm()
        {
            DetailsMedicalForms = new HashSet<DetailsMedicalForm>();
        }

        public long id { get; set; }

        [StringLength(50)]
        public string PetName { get; set; }

        public int? Weight { get; set; }

        [StringLength(50)]
        public string HairColor { get; set; }

        [StringLength(50)]
        public string species { get; set; }

        [StringLength(50)]
        public string PetGender { get; set; }

        public DateTime? CreateDate { get; set; }

        [Column(TypeName = "image")]
        public byte[] Images { get; set; }

        public long? ClientId { get; set; }

        public long? ServiceId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailsMedicalForm> DetailsMedicalForms { get; set; }

        public virtual Servicess Servicess { get; set; }
    }
}
