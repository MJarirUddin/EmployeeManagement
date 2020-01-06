﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "Jerry", Department = "HR", Email = "jerry@yahoo.com"},
                new Employee(){Id = 2, Name = "Frank", Department = "IT", Email = "frank@gmail.com"},
                new Employee(){Id = 3, Name = "Luther", Department = "IT", Email = "luther@hotmail.com"},
            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}