using System.ComponentModel.DataAnnotations;

namespace CRM_VUS.Models
{
    public class ClassRoom
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указан кабинет")]
        public string NameRoom { get; set; }
    }
}
