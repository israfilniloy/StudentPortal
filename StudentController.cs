using Microsoft.AspNetCore.Mvc;
using StudentPortal.Models;
using StudentPortal.Data;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace StudentPortal.Controllers
{
    public class StudentController : Controller
    {
        public readonly ApplicationDbContext dbContext;
        public StudentController(ApplicationDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModel viewModel)
        {
            var student = new Models.Entities.Student
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                Subscribed = viewModel.Subscribed
            };
            await dbContext.Students.AddAsync(student);
            await dbContext.SaveChangesAsync();


            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var students = await dbContext.Students.ToListAsync();
            return View(students);
        }

        [HttpGet]  
        public async Task<IActionResult> Edit(Guid id)
        {
           var student= await dbContext.Students.FindAsync(id);

            return View(student);   
        }
        [HttpPost]

        public async Task<IActionResult> Edit(Models.Entities.Student viewModel)
        {
            var student =await dbContext.Students.FindAsync(viewModel.Id);
            if(student is not null)
            {
                student.Name = viewModel.Name;  
                student.Email = viewModel.Email;
                student.Phone = viewModel.Phone;
                student.Subscribed = viewModel.Subscribed;

                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("List", "Students");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var student = await dbContext.Students.FindAsync(id);
            if (student is not null)
            {
                dbContext.Students.Remove(student); // Corrected from "viewModel" to "student"
                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("List", "Student"); // Fixed "Students" to "Student"
        }
    }
}
