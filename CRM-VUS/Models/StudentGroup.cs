using System.ComponentModel.DataAnnotations;

namespace CRM_VUS.Models
{
    public class StudentGroup
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указан номер группы")]
        public int? Curse { get; set; }
        [Required(ErrorMessage = "Не указан группа")]
        public string NameGroup { get; set; }
    }
}
