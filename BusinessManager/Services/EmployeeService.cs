using BusinessManager.Interface;
using CommonLayer.Model;
using RepositoryLayer.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BusinessManager.Services
{
    public class EmployeeService : IEmployee
    {
        private readonly IEmployeeInterface numerable;
        public EmployeeService(IEmployeeInterface numerable)
        {
            this.numerable = numerable;
        }

        IEnumerable<ModalClass> GetAllEmployee()
        {
            return numerable.GetAllEmployee();
        }
    }
}
