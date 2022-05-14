using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmpPayrollMultiThreads
{
    class EmployeeRepository
    {
        public List<Employee> list = new List<Employee>();
        public void AddEmployeeToPayroll(List<Employee> list)
        {
            list.ForEach(employeeData =>
            {
                Console.WriteLine("Employee being added: " + employeeData.EmployeeName);
                AddEmployeePayroll(employeeData);
                Console.WriteLine("Employee added: " + employeeData.EmployeeName);
            });
            Console.WriteLine("No. of employees: " + EmployeeCount());
            Thread thread = Thread.CurrentThread;
            Console.WriteLine("Thread: " + thread.ManagedThreadId);
        }

        public void AddEmployeePayroll(Employee emp)
        {
            list.Add(emp);
        }
        public int EmployeeCount()
        {
            return this.list.Count;
        }
    }
}
