namespace OnlineExamSystem.Models
{
    public partial class Report
    {
        public int result_id { get; set; }
        public string result_status { get; set; }
        public Nullable<int> result_score { get; set; }
        public string user_id { get; set; }
        public string exam_id { get; set; }
        public Nullable<System.DateTime> edate { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual exam exam { get; set; }
    }
}
