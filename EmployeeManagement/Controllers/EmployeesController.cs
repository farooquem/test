using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeManagement.Context;
using EmployeeManagement.Models;

namespace EmployeeManagement.Controllers
{
    [Authorize]
    public class EmployeesController : Controller
    {
        private readonly Context.EmployeeManagement _dbContext = new Context.EmployeeManagement();
        // GET: Employees
        public ActionResult Index()
        {
            var employees = _dbContext.Employees.ToList();
            var employeeModels = employees.Select(ConvertModel).ToList();
            return View(employeeModels);
        }

        private EmployeeModel ConvertModel(Employee x)
        {
            return new EmployeeModel
            {
                Address = x.Address,
                ContactNumber = x.ContactNumber,
                DateOfBirth = x.DateOfBirth.ToString("dd/MM/yyyy"),
                DateofJoining = x.DateofJoining.ToString("dd/MM/yyyy"),
                DateOfLeaving = x.DateOfLeaving.HasValue ? x.DateOfLeaving.Value.ToString("dd/MM/yyyy") : string.Empty,
                DepartmentName = x.Department.Name,
                Email = x.Email,
                EmployeeId = x.EmployeeId,
                Gender = x.Gender,
                Id = x.Id,
                Job_Title = x.Job_Title,
                Name = string.Format("{0} {1} {2}",x.FirstName, x.MiddleName, x.LastName)
            };
        }

        // GET: Employees/Details/5
        public ActionResult Details(int id)
        {
            var employees = _dbContext.Employees.FirstOrDefault(x=> x.Id==id);
            var employeeModels = employees == null ? null : ConvertModel(employees);
            return View(employeeModels);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        public ActionResult Create(Employee collection)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    _dbContext.Employees.Add(collection);
                    _dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int id)
        {
            var employees = _dbContext.Employees.FirstOrDefault(x => x.Id == id);
            var employeeModels = employees == null ? null : ConvertModel(employees);
            return View(employeeModels);
        }

        // POST: Employees/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _dbContext.Entry(employee).State = EntityState.Modified;
                    _dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(employee);
            }
            catch
            {
                return View(employee);
            }
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int id)
        {
            var employees = _dbContext.Employees.FirstOrDefault(x => x.Id == id);
            var employeeModels = employees == null ? null : ConvertModel(employees);
            return View(employeeModels);
        }

        // POST: Employees/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Employee employee = _dbContext.Employees.Find(id);
                _dbContext.Employees.Remove(employee);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
