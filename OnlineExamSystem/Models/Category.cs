using System.ComponentModel.DataAnnotations;

namespace OnlineExamSystem.Models
{
    public partial class Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            this.exams = new HashSet<exam>();
            this.Questions = new HashSet<Question>();
        }
        [Display(Name = "Category ID")]
        [Required(ErrorMessage = "Category  Id is required")]
        public string category_id { get; set; }
        [Display(Name = "Category name")]
        [Required(ErrorMessage = "category name is required")]
        public string category_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<exam> exams { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Question> Questions { get; set; }
    }
}
