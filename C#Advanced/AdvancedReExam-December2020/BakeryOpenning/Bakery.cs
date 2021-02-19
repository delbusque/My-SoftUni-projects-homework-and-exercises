using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        List<Employee> employees;

        public Bakery(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            employees = new List<Employee>();

        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => employees.Count;

        public void Add(Employee employee)
        {   
            if (employees.Count < Capacity)
            {
                employees.Add(employee);
            }
        }

        public bool Remove(string name)
        {
            Employee toRemove = employees.FirstOrDefault(n => n.Name == name);

            if (toRemove == null)
            {
                return false;
            }
            else
            {
                employees.Remove(toRemove);
                return true;
            }
        }

        public Employee GetOldestEmployee()
        {
            employees = employees.OrderByDescending(e => e.Age).ToList();
            return employees[0];
        }

        public Employee GetEmployee(string name)
        {
            return employees.FirstOrDefault(n => n.Name == name);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery {Name}:");

            foreach (var employee in employees)
            {
                sb.AppendLine(employee.ToString());
            }
            
            return sb.ToString();
        }

    }
}
