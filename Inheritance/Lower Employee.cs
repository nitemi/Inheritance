using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Lower_Employee
    {
        public string fullName;
            public int age;
            public string maritalstatus;
        public void info(string fullName, int age, string maritalstatus)
        {
            string fullName = fullName;
            int age = age;
            string maritalstatus = maritalstatus;
            

            Console.WriteLine("Information about the employee:");
            Console.WriteLine("Fullname of Employee:" + fullName);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Marital Status:" + maritalstatus);


        }
        public void salary(int salaryamount) 
        {
           int salaryamount = salaryamount;
            Console.WriteLine("The default annual amount for a lower employee is {0}", salaryamount*12);
        }
    }
}
