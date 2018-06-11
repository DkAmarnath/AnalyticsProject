﻿using AnalyticsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AnalyticsProject.Controllers
{
    public class StudentController : Controller
    {
        IList<Student> studentList = new List<Student>() { 
                    new Student(){ StudentId=1, StudentName="John", Age = 18 },
                    new Student(){ StudentId=2, StudentName="Steve", Age = 21 },
                    new Student(){ StudentId=3, StudentName="Bill", Age = 25 },
                    new Student(){ StudentId=4, StudentName="Ram", Age = 20 },
                    new Student(){ StudentId=5, StudentName="Ron", Age = 31 },
                    new Student(){ StudentId=6, StudentName="Chris", Age = 17 },
                    new Student(){ StudentId=7, StudentName="Rob", Age = 19 }
                };

        // GET: Student
        [ActionName("Hello")]//We can use actionname in url instead of actionMethod name.
        //[NonAction]   //if you don't want to make a public method as actionmethod
        public string Index1()
        {
            return "hello this is Amar";
        }
        public ActionResult Index()
        {
            var studentList = new List<Student>{ 
                            new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
                            new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                            new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                            new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                            new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                            new Student() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
                            new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 } 
                        };
            // Get the students from the database in the real application

            return View(studentList);
        }
        public ActionResult Edit(int StudentId)
        {
            //Get the student from studentList sample collection for demo purpose.
            //You can get the student from the database in the real application
            var std = studentList.Where(s => s.StudentId == StudentId).FirstOrDefault();

            return View(std);
        }
        public ActionResult Hello1()
        {
            return View("Hello");
        }
    }
}