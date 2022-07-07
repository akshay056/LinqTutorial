using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial
{
    public class Employee
    {
       
        public Employee(int id, string name, string dept)
        {
            this.ID = id;
            this.Name = name;
            this.Dept = dept;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        //public static List<Employee> GetListofEmployees()

        //{

        //    List<Employee> emps = new List<Employee>();

        //    emps.Add(new Employee(1, "John", "Trainer"));

        //    emps.Add(new Employee(2, "Mark", "Finance"));

        //    emps.Add(new Employee(3, "Peter", "Technical"));

        //    emps.Add(new Employee(4, "Bob", "Technical"));

        //    emps.Add(new Employee(5, "Robert", "Finance"));

        //    emps.Add(new Employee(6, "Jason", "Trainer"));
        //    return emps;

        //}
        //public static void noOfemployeeinDept()
        //{
        //    List<Employee> emp = GetListofEmployees();
        //    int count;
        //    var employeegroup = from e in emp group e by e.Dept into g select new { Department = g.Key, Name = g };
        //    foreach (var item in employeegroup)
        //    {
        //        count = 0;
        //        Console.WriteLine(" eMPLOYEES in '{0}' department  is:", item.Department);
        //        foreach (var w in item.Name)
        //        {
        //            count++;
        //        }

        //        Console.WriteLine(count);
        //    }

        //}
    }
}
    public class Department
    {
        public Department()
        {
        }
        public Department(string dept, string manager)
        {
            this.Dept = dept;
            this.Manager = manager;
        }
        public string Dept { get; set; }
        public string Manager { get; set; }
       
    }

