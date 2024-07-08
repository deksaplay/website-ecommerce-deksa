namespace website_e_commerce.Models
{
    public class Report : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime ReportDate { get; set; }
    }
}