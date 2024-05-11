using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI1.Controllers
{
    public class EmployeeDataController : ApiController
    {
        string[] myEmployees = new string[] { "Laxman", "Roshan", "Amit" };

        [HttpGet]
        public string[] GetEmployees()
        {
            return myEmployees;
        }

        [HttpGet]
        public string GetEmployeeByIndex(int id)
        {
            return myEmployees[id];
        }
    }
}
