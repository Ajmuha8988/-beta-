using CRM_VUS.Data;
using CRM_VUS.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRM_VUS.Controllers
{
    public class TScheduleController : Controller
    {
        private ApplicationDbContext _context;
        public TScheduleController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult AddTSchedule()
        {
            var studentGroups = _context.StudentGroups.ToList();
            var classroomS = _context.classRooms.ToList();
            var lessonssmokymo = _context.classLessons.ToList();
            var teachers = _context.Users.ToList();
            var PScheduleVMModels = _context.pschedules.ToList();
            var PSP = _context.pschedules.FirstOrDefault();
            var TScheduleVMModels = _context.tschedules.ToList();
            var TSP = _context.tschedules.FirstOrDefault();
            var startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1); // Начало текущего месяца
            var endDate = startDate.AddMonths(2).AddDays(-1); // Конец следующего месяца
            var dates = Enumerable.Range(0, (endDate - startDate).Days + 1)
                                  .Select(offset => startDate.AddDays(offset))
                                  .ToList();
            var viewmodel = new PScheduleVM
            {
                studentGroupsModels = studentGroups,
                ClassRoomModels = classroomS,
                ClassLessonsModels = lessonssmokymo,
                UserModels = teachers,
                PSchedulesModelsList = PScheduleVMModels,
                PSchedulesModels = PSP,
                TSchedulesModelsList = TScheduleVMModels,
                TSchedulesModels = TSP,
                Dates = dates
            };
            return View("~/Views/Schedule_Constructor/CSchedule/AddTSchedule.cshtml", viewmodel);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveTS(PScheduleVM vM)
        {
            var existingRecord = _context.tschedules.FirstOrDefault(sg => sg.Curse == vM.TSchedulesModels.Curse
            && sg.NameGroup == vM.TSchedulesModels.NameGroup && sg.NumberLessons == vM.TSchedulesModels.NumberLessons
            && sg.Date == vM.TSchedulesModels.Date);
            if (existingRecord != null)
            {
                existingRecord.NameRoom = vM.TSchedulesModels.NameRoom;
                existingRecord.Lessons = vM.TSchedulesModels.Lessons;
                existingRecord.NameTeacher = vM.TSchedulesModels.NameTeacher;
                _context.tschedules.Update(existingRecord);
                _context.SaveChanges();
                TempData["GroupСurseValue"] = existingRecord.Curse;
                TempData["GroupNameValue"] = existingRecord.NameGroup;
                return RedirectToAction("AddTSchedule", "TSchedule");

            }
            if (existingRecord == null)
            {
                _context.tschedules.Add(vM.TSchedulesModels);
                _context.SaveChanges();
                TempData["GroupСurseValue"] = vM.TSchedulesModels.Curse;
                TempData["GroupNameValue"] = vM.TSchedulesModels.NameGroup;
                return RedirectToAction("AddTSchedule", "TSchedule");
            }
            return RedirectToAction("AddTSchedule", "TSchedule");
        }
    }
}
