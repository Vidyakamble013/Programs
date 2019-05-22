
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementApi.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee employee;
        public EmployeeController(IEmployee employee)
        {
            this.employee = employee;
        }

        [HttpGet]
        [Route("getallemp")]
        public IEnumerable<RepositoryClass> GetAllRecord()
        {
            return employee.GetAllEmployee();
        }

        [HttpPost]
        [Route("create")]
        public IEnumerable<RepositoryClass> AddRecord()
        {
            return employee.AddEmployee();
        }

        [HttpPut]
        [Route("update")]
        public IEnumerable<RepositoryClass> UpdateEmployee()
        {
            return employee.UpdateRecord();
        }

        [HttpDelete]
        [Route ("delete/{empId}")]
        public IEnumerable<RepositoryClass> DeleteRecord()
        {
            return employee.DeleteEmployee();
        }

        [HttpGet]
        [Route ("get/{id}")]
        public IEnumerable<RepositoryClass> GetEmployeeId()
        {
            return employee.GetByEmployeeId();
        }
    }
 
}


