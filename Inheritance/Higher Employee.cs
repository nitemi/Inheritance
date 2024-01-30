using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class HigherEmployee : Lower_Employee
    {

        public void bonus()
        {
           
           int bonus = 13000;

            Console.WriteLine("The higher employer bonus per extra workdone is:", bonus);
            
        }
    }
}
