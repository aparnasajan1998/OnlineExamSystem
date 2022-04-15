namespace OnlineExamSystem.Models
{
    public partial class Question
    {
        public int Qid { get; set; }
        public string Q_text { get; set; }
        public string QA { get; set; }
        public string QB { get; set; }
        public string QC { get; set; }
        public string QD { get; set; }
        public string Qcorrectans { get; set; }
        public string category_id { get; set; }
        public Nullable<int> levelid { get; set; }

        public virtual Category Category { get; set; }
    }
}
