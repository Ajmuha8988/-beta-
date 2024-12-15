using System.ComponentModel.DataAnnotations;

namespace CRM_VUS.Models
{
    public class ClassLessons
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указан учебный предмет")]
        public string Lessons { get; set; }
    }
}
