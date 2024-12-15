using System;
using System.Diagnostics;
using CRM_VUS.Data;
using CRM_VUS.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRM_VUS.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext    db;
        public HomeController(ApplicationDbContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddGroup()
        {
            return View();
        }
        public IActionResult AddClassRoom()
        {
            return View();
        }
        public IActionResult AddLessons()
        {
            return View();
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
        //            ModelState.AddModelError("Curse", "����� ������� ��� ����������");
        //            //ViewBag.Script = "<script> $(document).ready(function () {\r\n            $('#Create_group').modal('show');\r\n        });</script>";
        //            return View();
        //        }
        //        else
        //        {
        //            // ���� ����� ������ ���, ��������� �����
        //            db.classLessons.Add(lessons);
        //            db.SaveChanges();
        //            ViewBag.Message = "������� ������� ������� ������!";
        //            //ViewBag.Script = "<script> $(document).ready(function () {\r\n            $('#Create_group').modal('show');\r\n        });</script>";
        //            ModelState.Clear();

        //            // ��������� �� ������������� ��� ������
        //            return View();
        //        }
        //    }
        //    //return Model with error
        //    return View();
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddLessons(ClassLessons lessonsSmokymo)
        {
            if (ModelState.IsValid)
            {
                var existingRecord = db.classLessons.FirstOrDefault(sg => sg.Lessons == lessonsSmokymo.Lessons);
                if (existingRecord != null)
                {
                    ModelState.AddModelError("Curse", "����� ������� ��� ����������");
                    return View();
                }
                else
                {
                    db.classLessons.Add(lessonsSmokymo);
                    db.SaveChanges();
                    ViewBag.Message = "������� ������� ������� ������!";
                    //ViewBag.Script = "<script> $(document).ready(function () {\r\n            $('#Create_group').modal('show');\r\n        });</script>";
                    ModelState.Clear();

                    // ��������� �� ������������� ��� ������
                    return View();
                }
            }
            //return Model with error
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddClassRoom(ClassRoom classRoom)
        {
            if (ModelState.IsValid)
            {
                var existingRecord = db.classRooms.FirstOrDefault(sg => sg.NameRoom == classRoom.NameRoom);
                if (existingRecord != null)
                {
                    ModelState.AddModelError("Curse", "����� ������� ��� ������");
                    //ViewBag.Script = "<script> $(document).ready(function () {\r\n            $('#Create_group').modal('show');\r\n        });</script>";
                    return View();
                }
                else
                {
                    // ���� ����� ������ ���, ��������� �����
                    db.classRooms.Add(classRoom);
                    db.SaveChanges();
                    ViewBag.Message = "������� ������� ������!";
                    //ViewBag.Script = "<script> $(document).ready(function () {\r\n            $('#Create_group').modal('show');\r\n        });</script>";
                    ModelState.Clear();

                    // ��������� �� ������������� ��� ������
                    return View();
                }
            }
            //return Model with error
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddGroup(StudentGroup studentGroup)
        {
           if (ModelState.IsValid)
            {
                var existingRecord = db.StudentGroups.FirstOrDefault(sg => sg.Curse == studentGroup.Curse && sg.NameGroup == studentGroup.NameGroup);
                if (existingRecord != null) 
                {
                    ModelState.AddModelError("Curse", "������ � ����� ������� ��� ������");
                    //ViewBag.Script = "<script> $(document).ready(function () {\r\n            $('#Create_group').modal('show');\r\n        });</script>";
                    return View();
                }
                else
                {
                    // ���� ����� ������ ���, ��������� �����
                    db.StudentGroups.Add(studentGroup);
                    db.SaveChanges();
                    ViewBag.Message = "������ ������� �������!";
                    //ViewBag.Script = "<script> $(document).ready(function () {\r\n            $('#Create_group').modal('show');\r\n        });</script>";
                    ModelState.Clear();

                    // ��������� �� ������������� ��� ������
                    return View();
                }
            }
            //return Model with error
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
