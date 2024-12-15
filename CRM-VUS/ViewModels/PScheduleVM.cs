using CRM_VUS.Models;
using Microsoft.AspNetCore.Identity;
using System.Numerics;

namespace CRM_VUS.ViewModels
{
    public class PScheduleVM
    {
        public IEnumerable<StudentGroup> studentGroupsModels { get; set; }
        public IEnumerable<ClassRoom> ClassRoomModels { get; set; }
        public IEnumerable<ClassLessons> ClassLessonsModels { get; set; }
        public IEnumerable<IdentityUser> UserModels { get; set; }
        public IEnumerable<PSchedule> PSchedulesModelsList { get; set; }
        public PSchedule PSchedulesModels { get; set; }
    }
}
