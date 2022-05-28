using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddNestedIssue.Models;

namespace AddNestedIssue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddCompanyWithEmployeeTest();
        }

        private static void AddCompanyWithEmployeeTest()
        {
            using (var context = new EFCoreTestContext())
            {
                var company = new Company
                {
                    Id = -1, //Our presentation layer sets Id to -1 for new entities
                    Name = "Tesla",
                    Employees = new List<Employee> {
                        new Employee {
                            Id = -1, //Our presentation layer sets Id to -1 for new entities
                            Name = "Bob Ross" }
                    }
                };

                context.Company.Add(company);
                context.SaveChanges();
            }
        }
    }
}
