using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineExamSystem.Models
{
    public partial class Candidate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Candidate()
        {
            this.Reports = new HashSet<Report>();
        }

        [Display(Name = "User ID")]
        [Required(ErrorMessage = "User Id is required")]
        public string Userid { get; set; }
        [Display(Name = "User first name")]
        [Required(ErrorMessage = "User first name is required")]
        public string Userfname { get; set; }
        [Display(Name = "User Last name")]
        public string Userlname { get; set; }

        [Display(Name = "Phoneno")]
        [Required(ErrorMessage = "*")]
        public string phoneno { get; set; }
        [Display(Name = "User email_id")]
        [Required(ErrorMessage = "Email-Id is required")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [Display(Name = "User password")]
        [Required(ErrorMessage = "password is required")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [NotMapped]
        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Confirm the password")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Confirm  password doesn't match ")]

        public string confirmpassword { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Report> Reports { get; set; }
    }
}
