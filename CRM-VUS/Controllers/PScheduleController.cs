using CRM_VUS.Data;
using CRM_VUS.Models;
using CRM_VUS.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CRM_VUS.Controllers
{
    public class PScheduleController : Controller
    {
        private ApplicationDbContext _context;
        public PScheduleController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult AddPSchedule()
        {
            var studentGroups = _context.StudentGroups.ToList();
            var classroomS = _context.classRooms.ToList();
            var lessonssmokymo = _context.classLessons.ToList();
            var teachers = _context.Users.ToList();
            var PScheduleVMModels = _context.pschedules.ToList();
            var PSP = _context.pschedules.FirstOrDefault();
            var viewmodel = new PScheduleVM
            {
                studentGroupsModels = studentGroups,
                ClassRoomModels = classroomS,
                ClassLessonsModels = lessonssmokymo,
                UserModels = teachers,
                PSchedulesModelsList = PScheduleVMModels,
                PSchedulesModels = PSP
            };
            return View("~/Views/Schedule_Constructor/PSchedule/AddPSchedule.cshtml", viewmodel);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SavePS(PScheduleVM vM)
        {
            var existingRecord = _context.pschedules.FirstOrDefault(sg => sg.Curse == vM.PSchedulesModels.Curse 
            && sg.NameGroup == vM.PSchedulesModels.NameGroup && sg.NumberLessons == vM.PSchedulesModels.NumberLessons
            && sg.Dayofweek == vM.PSchedulesModels.Dayofweek && sg.KindOfSchedules == vM.PSchedulesModels.KindOfSchedules);
            if (existingRecord != null) 
            {
                existingRecord.NameRoom = vM.PSchedulesModels.NameRoom;
                existingRecord.Lessons = vM.PSchedulesModels.Lessons;
                existingRecord.NameTeacher = vM.PSchedulesModels.NameTeacher;
                _context.pschedules.Update(existingRecord);
                _context.SaveChanges();
                TempData["GroupСurseValue"] = existingRecord.Curse;
                TempData["GroupNameValue"] = existingRecord.NameGroup;
                return RedirectToAction("AddPSchedule", "PSchedule");

            }
            if (existingRecord == null)
            {
                _context.pschedules.Add(vM.PSchedulesModels);
                _context.SaveChanges();
                TempData["GroupСurseValue"] = vM.PSchedulesModels.Curse;
                TempData["GroupNameValue"] = vM.PSchedulesModels.NameGroup;
                return RedirectToAction("AddPSchedule", "PSchedule");
            }
            return RedirectToAction("AddPSchedule", "PSchedule");
        }
    }
}
