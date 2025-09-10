using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Worker> _workers = new list<Worker>();
        public void Save(Worker worker)
        {
            _worker.Add(worker);
            Console.WriteLine($"Employee {worker.Name} saved to repository.");
        }
    }
}
