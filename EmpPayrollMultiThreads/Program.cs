using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpPayrollMultiThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Payroll Using Multi Threads Program");

            List<Employee> employeeDetails = new List<Employee>();
            employeeDetails.Add(new Employee { EmployeeID = 1, EmployeeName = "Aniruddha" });
            employeeDetails.Add(new Employee { EmployeeID = 2, EmployeeName = "Amar" });
            employeeDetails.Add(new Employee { EmployeeID = 3, EmployeeName = "Aviral" });
            employeeDetails.Add(new Employee { EmployeeID = 4, EmployeeName = "Nikhil" });

            EmployeeRepository repo = new EmployeeRepository();
            Stopwatch stopWatch1 = new Stopwatch();
            stopWatch1.Start();
            repo.AddEmployeeToPayroll(employeeDetails);
            stopWatch1.Stop();
            Console.WriteLine("Duration without multi thread: " + stopWatch1.ElapsedMilliseconds+" ms");

            Console.ReadLine();
        }
    }
}
