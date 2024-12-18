using CRM_VUS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public IEnumerable<TSchedule> TSchedulesModelsList { get; set; }
        public TSchedule TSchedulesModels { get; set; }
        public IEnumerable<DateTime> Dates { get; set; }
    }
}
