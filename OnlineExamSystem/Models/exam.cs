﻿using System.ComponentModel.DataAnnotations;

namespace OnlineExamSystem.Models
{
    public partial class exam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public exam()
        {
            this.Reports = new HashSet<Report>();
        }
        [Display(Name = "Exam ID")]
        [Required(ErrorMessage = "Exam Id is required")]
        public string exam_id { get; set; }
        [Display(Name = "Exam Description")]
        public string exam_description { get; set; }
        [Display(Name = "Category Id")]
        [Required(ErrorMessage = "Category Id is required")]
        public string category_id { get; set; }
        [Required(ErrorMessage = "Level is required")]
        public int levelid { get; set; }
        public Nullable<System.DateTime> duration { get; set; }
        [Required(ErrorMessage = "Number is required")]
        public Nullable<int> Noofquestion { get; set; }
        [Required(ErrorMessage = "Marks is required")]
        public Nullable<int> marks { get; set; }
        [Required(ErrorMessage = "Total Marks is required")]
        public Nullable<int> totalmarks { get; set; }
        [Required(ErrorMessage = "Pass Marks is required")]
        public Nullable<int> passmarks { get; set; }

        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Report> Reports { get; set; }
    }
}
