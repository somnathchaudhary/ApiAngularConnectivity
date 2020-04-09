using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeesApi.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesApi.Controllers
{

    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class EmpsController : ControllerBase
    {
         EmployeesModel[] Employee = new EmployeesModel[]
        {
            new EmployeesModel { EmpId = 101, EmpName = "Rahul", EmpDesig = "Doctor"},
            new EmployeesModel { EmpId = 102, EmpName = "Akahul", EmpDesig = "Doctor"},
            new EmployeesModel { EmpId = 103, EmpName = "Jahul", EmpDesig = "Doctor"}
        };

        // GET: api/Emps
        [HttpGet]
        public IEnumerable<EmployeesModel> Get()
        {
            return Employee;
        }
        
      
    }
}
