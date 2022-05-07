using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShopOnline.Models
{
    public class AppointmentModel
    {
        [Key]
        public long Id { get; set; }

        [Column(TypeName = "date")]
        [Required]
        public DateTime? BookingDate { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (BookingDate < DateTime.Now)
            {
                yield return new ValidationResult(
                    errorMessage: "Booking date must be greater than Today",
                    memberNames: new[] { "EndDate" }
               );
            }
        }

        [StringLength(250)]
        public string Type { get; set; }

        [Column(TypeName = "ntext")]
        public string Note { get; set; }

        public int? CustumerID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Phone { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public int? status { get; set; }

        public DateTime? DateCreated { get; set; }

        public int Time { get; set; }
    }
}