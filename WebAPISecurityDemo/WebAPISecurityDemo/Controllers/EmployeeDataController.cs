using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPISecurityDemo.Models;

namespace WebAPISecurityDemo.Controllers
{
    public class EmployeeDataController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/EmployeeData
        [Route("employeedata")]
        public IHttpActionResult GetEmployees()
        {
            return Ok(new
            {
                db.Employees,
                User.Identity.IsAuthenticated,
                User.Identity.Name,
                User.Identity.AuthenticationType
            });
        }

        // GET: api/EmployeeData/5
        [Route("employeedata/{name}")]
        [HttpGet]
        public IHttpActionResult SearchEmployees(string name)
        {
            IQueryable<Employee> Employees = FindEmployee(name);
            if (Employees == null)
            {
                return NotFound();
            }

            return Ok(new
            {
                Employees,
                User.Identity.IsAuthenticated,
                User.Identity.Name,
                User.Identity.AuthenticationType
            });
        }

        [Route("employeedata/secure")]
        [Authorize]
        public IHttpActionResult GetEmployeesSecure()
        {
            return Ok(new
            {
                db.Employees,
                User.Identity.IsAuthenticated,
                User.Identity.Name,
                User.Identity.AuthenticationType
            });

        }

        [Route("employeedata/secure/{name}")]
        [HttpGet]
        public IHttpActionResult SearchEmployeesSecure(string name)
        {
            IQueryable<Employee> Employees = FindEmployee(name);
            if (Employees == null)
            {
                return NotFound();
            }

            return Ok(new
            {
                Employees,
                User.Identity.IsAuthenticated,
                User.Identity.Name,
                User.Identity.AuthenticationType
            });

        }

        private IQueryable<Employee> FindEmployee(string term) => 
                        db.Employees.Where(emp => emp.LastName.Contains(term) ||
                                                    emp.FirstName.Contains(term));
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EmployeeExists(int id)
        {
            return db.Employees.Count(e => e.ID == id) > 0;
        }
    }
}