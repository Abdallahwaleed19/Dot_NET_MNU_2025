using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    public class Employee : IComparable<Employee>
    {
        public string Name;
        public double Salary;
        public DateTime HiringDate; 
        public int CompareTo(Employee other)
        {
            int result = this.HiringDate.Year.CompareTo(other?.HiringDate.Year);
            if (result == 0)
            {
                result = this.HiringDate.Month.CompareTo(other?.HiringDate.Month);
            }
            if (result == 0)
            {
                result = this.HiringDate.Day.CompareTo(other?.HiringDate.Day);
            }
            return result;

        }
    }
}
