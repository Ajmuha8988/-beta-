namespace CRM_VUS.Models
{
    public class PSchedule
    {
        public int Id { get; set; }
        public int? Curse { get; set; }
        public string NameGroup { get; set; }
        public string NameRoom { get; set; }
        public string Lessons { get; set; }
        public string NameTeacher { get; set; }
        public int NumberLessons { get; set; }
        public string Dayofweek { get; set; }
    }
}
