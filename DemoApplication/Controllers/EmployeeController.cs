using Employee.Data;
using Employee.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApplication.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult CreateEmployeeDetails(EmployeeData employeeData)
        {
            if (employeeData.EmpFirstName != null)
            {
                EmployeeModel EmpModel = new EmployeeModel();
                string strresult = EmpModel.CreateEmployeeDetails(employeeData);
                ViewData["result"] = strresult;
                strresult = "";
            }
            return View();
        }
    }
}
