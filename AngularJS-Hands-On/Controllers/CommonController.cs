using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading;
using AngularJS.HandsOn.Models;

namespace AngularJS.HandsOn.Controllers
{
    public class CommonController : ApiController
    {
        public HttpResponseMessage GetEmployees()
        {
            HttpResponseMessage response = new HttpResponseMessage();

            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee() {Name = "A", Age = 40});
            employees.Add(new Employee() { Name = "B", Age = 22 });
            employees.Add(new Employee() { Name = "C", Age = 34 });
            employees.Add(new Employee() { Name = "D", Age = 50 });

            response.StatusCode = HttpStatusCode.OK;
            response.Content = new ObjectContent(typeof(List<Employee>), employees, GlobalConfiguration.Configuration.Formatters.JsonFormatter);
            return response;
        }
    }
}