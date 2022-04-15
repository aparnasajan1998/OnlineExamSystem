using System.ComponentModel.DataAnnotations;

namespace OnlineExamSystem.Models
{
    public partial class admin
    {

        [Display(Name = "Admin ID")]
        [Required(ErrorMessage = "Admin Id is required")]
        public string admin_id { get; set; }
        [Display(Name = "Admin Name")]
        [Required(ErrorMessage = "Admin Name is required")]
        public string admin_name { get; set; }
        [Display(Name = "Admin Password")]
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string admin_password { get; set; }
    }
}
