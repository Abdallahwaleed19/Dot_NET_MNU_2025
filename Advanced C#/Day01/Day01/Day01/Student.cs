using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    public class Student
    {
        public string Name { get; set; }
        public int? age;
        public List<int> scores;
        public Student(string? name, int? age, List<int> scores) { 
            this.Name = name ?? "Unknown";
            this.age = age ?? 0;
            this.scores = scores;
}
        public double addscores(params int[] scores)
        {
                        return scores.Sum();
        }
        public double avgscores()
        {
            return scores.Average();
        }
    }

}
