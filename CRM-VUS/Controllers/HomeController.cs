using System;
using System.Diagnostics;
using CRM_VUS.Data;
using CRM_VUS.Models;
using CRM_VUS.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRM_VUS.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext    db;
        public HomeController(ApplicationDbContext context)
        {
            db = context;
        }

        public IActionResult Index(PScheduleVM vM)
        {

                var studentGroups = db.StudentGroups.ToList();
                var classroomS = db.classRooms.ToList();
                var lessonssmokymo = db.classLessons.ToList();
                var teachers = db.Users.ToList();
                var PScheduleVMModels = db.pschedules.ToList();
                var PSP = db.pschedules.FirstOrDefault();
                var SGmodel = db.StudentGroups.FirstOrDefault(); 
                var viewmodel = new PScheduleVM
                {
                    studentGroupsModels = studentGroups,
                    ClassRoomModels = classroomS,
                    ClassLessonsModels = lessonssmokymo,
                    UserModels = teachers,
                    PSchedulesModelsList = PScheduleVMModels,
                    PSchedulesModels = PSP,
                    SG = SGmodel
                };
                return View(viewmodel);
        }
        public IActionResult ResultList(PScheduleVM vM)
        {
            TempData["GroupСurseValue"] = vM.SG.Curse;
            TempData["GroupNameValue"] = vM.SG.NameGroup;
            var studentGroups = db.StudentGroups.ToList();
            var classroomS = db.classRooms.ToList();
            var lessonssmokymo = db.classLessons.ToList();
            var teachers = db.Users.ToList();
            var PScheduleVMModels = db.pschedules.ToList();
            var PSP = db.pschedules.FirstOrDefault();
            var viewmodel = new PScheduleVM
            {
                studentGroupsModels = studentGroups,
                ClassRoomModels = classroomS,
                ClassLessonsModels = lessonssmokymo,
                UserModels = teachers,
                PSchedulesModelsList = PScheduleVMModels,
                PSchedulesModels = PSP
            };
            return View("~/Views/Home/Index.cshtml", viewmodel);
        }
        public IActionResult AddGroup()
        {
            var studentGroups = db.StudentGroups.ToList();
            var classroomS = db.classRooms.ToList();
            var lessonssmokymo = db.classLessons.ToList();
            var teachers = db.Users.ToList();
            var PScheduleVMModels = db.pschedules.ToList();
            var PSP = db.pschedules.FirstOrDefault();
            var viewmodel = new PScheduleVM
            {
                studentGroupsModels = studentGroups,
                ClassRoomModels = classroomS,
                ClassLessonsModels = lessonssmokymo,
                UserModels = teachers,
                PSchedulesModelsList = PScheduleVMModels,
                PSchedulesModels = PSP
            };
            return View("~/Views/Home/AddGroup.cshtml", viewmodel);
        }
        public IActionResult AddClassRoom()
        {
            var studentGroups = db.StudentGroups.ToList();
            var classroomS = db.classRooms.ToList();
            var lessonssmokymo = db.classLessons.ToList();
            var teachers = db.Users.ToList();
            var PScheduleVMModels = db.pschedules.ToList();
            var PSP = db.pschedules.FirstOrDefault();
            var viewmodel = new PScheduleVM
            {
                studentGroupsModels = studentGroups,
                ClassRoomModels = classroomS,
                ClassLessonsModels = lessonssmokymo,
                UserModels = teachers,
                PSchedulesModelsList = PScheduleVMModels,
                PSchedulesModels = PSP
            };
            return View(viewmodel);
        }
        public IActionResult AddLessons()
        {
            var studentGroups = db.StudentGroups.ToList();
            var classroomS = db.classRooms.ToList();
            var lessonssmokymo = db.classLessons.ToList();
            var teachers = db.Users.ToList();
            var PScheduleVMModels = db.pschedules.ToList();
            var PSP = db.pschedules.FirstOrDefault();
            var viewmodel = new PScheduleVM
            {
                studentGroupsModels = studentGroups,
                ClassRoomModels = classroomS,
                ClassLessonsModels = lessonssmokymo,
                UserModels = teachers,
                PSchedulesModelsList = PScheduleVMModels,
                PSchedulesModels = PSP
            };
            return View(viewmodel);
        }
        public IActionResult AddTSchedule()
        {
            return RedirectToAction("AddTSchedule", "TSchedule");
        }
        public IActionResult AddPSchedule()
        {
            return RedirectToAction("AddPSchedule", "PSchedule");
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult AddPSchedule(ClassLessons lessons)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var existingRecord = db.classLessons.FirstOrDefault(sg => sg.Lessons == lessons.Lessons);
        //        if (existingRecord != null)
        //        {
        //            ModelState.AddModelError("Curse", "Такой предмет уже существует");
        //            //ViewBag.Script = "<script> $(document).ready(function () {\r\n            $('#Create_group').modal('show');\r\n        });</script>";
        //            return View();
        //        }
        //        else
        //        {
        //            // Если такой записи нет, сохраняем новую
        //            db.classLessons.Add(lessons);
        //            db.SaveChanges();
        //            ViewBag.Message = "Учебный предмет успешно создан!";
        //            //ViewBag.Script = "<script> $(document).ready(function () {\r\n            $('#Create_group').modal('show');\r\n        });</script>";
        //            ModelState.Clear();

        //            // Переходим на представление без ошибок
        //            return View();
        //        }
        //    }
        //    //return Model with error
        //    return View();
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddLessons(PScheduleVM lessonsSmokymo)
        {
            var studentGroups = db.StudentGroups.ToList();
            var classroomS = db.classRooms.ToList();
            var lessonssmokymo = db.classLessons.ToList();
            var teachers = db.Users.ToList();
            var PScheduleVMModels = db.pschedules.ToList();
            var PSP = db.pschedules.FirstOrDefault();
            var viewmodel = new PScheduleVM
            {
                studentGroupsModels = studentGroups,
                ClassRoomModels = classroomS,
                ClassLessonsModels = lessonssmokymo,
                UserModels = teachers,
                PSchedulesModelsList = PScheduleVMModels,
                PSchedulesModels = PSP
            };
            var existingRecord = db.classLessons.FirstOrDefault(sg => sg.Lessons == lessonsSmokymo.СL.Lessons);
                if (existingRecord != null)
                {
                    ModelState.AddModelError("Curse", "Такой предмет уже существует");
                    ViewBag.Message = "Такой предмет уже существует!";
                    return View(viewmodel);
                }
                else
                {
                    db.classLessons.Add(lessonsSmokymo.СL);
                    db.SaveChanges();
                    ViewBag.Message = "Учебный предмет успешно создан!";
                    //ViewBag.Script = "<script> $(document).ready(function () {\r\n            $('#Create_group').modal('show');\r\n        });</script>";
                    ModelState.Clear();

                    // Переходим на представление без ошибок
                    return View(viewmodel);
                }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddClassRoom(PScheduleVM classRoom)
        {
            var studentGroups = db.StudentGroups.ToList();
            var classroomS = db.classRooms.ToList();
            var lessonssmokymo = db.classLessons.ToList();
            var teachers = db.Users.ToList();
            var PScheduleVMModels = db.pschedules.ToList();
            var PSP = db.pschedules.FirstOrDefault();
            var viewmodel = new PScheduleVM
            {
                studentGroupsModels = studentGroups,
                ClassRoomModels = classroomS,
                ClassLessonsModels = lessonssmokymo,
                UserModels = teachers,
                PSchedulesModelsList = PScheduleVMModels,
                PSchedulesModels = PSP
            };
            var existingRecord = db.classRooms.FirstOrDefault(sg => sg.NameRoom == classRoom.СR.NameRoom);
            if (existingRecord != null)
            {
                ModelState.AddModelError("Curse", "Такой кабинет уже создан");
                ViewBag.Message = "Такой кабинет уже существует!";
                //ViewBag.Script = "<script> $(document).ready(function () {\r\n            $('#Create_group').modal('show');\r\n        });</script>";
                return View(viewmodel);
            }
            else
            {
                // Если такой записи нет, сохраняем новую
                db.classRooms.Add(classRoom.СR);
                db.SaveChanges();
                ViewBag.Message = "Кабинет успешно создан!";
                //ViewBag.Script = "<script> $(document).ready(function () {\r\n            $('#Create_group').modal('show');\r\n        });</script>";
                ModelState.Clear();

                // Переходим на представление без ошибок
                return View(viewmodel);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddGroup(PScheduleVM studentGroup)
        {
            var studentGroups = db.StudentGroups.ToList();
            var classroomS = db.classRooms.ToList();
            var lessonssmokymo = db.classLessons.ToList();
            var teachers = db.Users.ToList();
            var PScheduleVMModels = db.pschedules.ToList();
            var PSP = db.pschedules.FirstOrDefault();
            var viewmodel = new PScheduleVM
            {
                studentGroupsModels = studentGroups,
                ClassRoomModels = classroomS,
                ClassLessonsModels = lessonssmokymo,
                UserModels = teachers,
                PSchedulesModelsList = PScheduleVMModels,
                PSchedulesModels = PSP
            };
            var existingRecord = db.StudentGroups.FirstOrDefault(sg => sg.Curse == studentGroup.SG.Curse && sg.NameGroup == studentGroup.SG.NameGroup);
            if (existingRecord != null)
            {
                ModelState.AddModelError("Curse", "Группа с таким номером уже создан");
                ViewBag.Message = "Такая группа уже существует!";
                //ViewBag.Script = "<script> $(document).ready(function () {\r\n            $('#Create_group').modal('show');\r\n        });</script>";
                return View(viewmodel);
            }
            else
            {
                // Если такой записи нет, сохраняем новую
                db.StudentGroups.Add(studentGroup.SG);
                db.SaveChanges();
                ViewBag.Message = "Группа успешно создана!";
                //ViewBag.Script = "<script> $(document).ready(function () {\r\n            $('#Create_group').modal('show');\r\n        });</script>";
                ModelState.Clear();

                // Переходим на представление без ошибок
                return View(viewmodel);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
