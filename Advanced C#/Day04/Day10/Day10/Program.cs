using System;
namespace Day10;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Enter First Number:");
        //int num1 = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter Seconed Number:");
        //int num2 = int.Parse(Console.ReadLine());
        //try
        //{
        //    int result = num1 / num2;
        //}
        //catch (DivideByZeroException)
        //{
        //    Console.WriteLine("Wrong");
        //}
        //catch (FormatException)
        //{
        //    Console.WriteLine("program Finished");

        //}

        //var employees = new List<Employee>
        //    {
        //        new Employee{Name="John", Salary=5000, HiringDate=DateTime.Parse("2010-01-01")},
        //        new Employee{Name="Smith", Salary=6000, HiringDate=DateTime.Parse("2011-01-01")},
        //        new Employee{Name="Johnson", Salary=7000, HiringDate=DateTime.Parse("2012-01-01")}
        //    };

        //employees.Sort();

        //foreach (var e in employees)
        //{
        //    Console.WriteLine($"{e.Name} {e.Salary:C} {e.HiringDate:dd-MM-yyyy}");
        //}

        //using (var logger = new Filelogger("log.txt"))
        //{
        //    logger.LogMessage("Hello World");
        //}

        IEmployeeRepository employeeRepository = new EmployeeRepository();
        IPayslipGenerator payslipGenerator = new PayslipGenerator();
        IEmailService emailService = new EmailService();

        var manager = new Manager { Id = 1, Name = "Abdallah", Salary = 100000 };
        var developer = new Developer { Id = 2, Name = "saif", Salary = 80000 };
        var general = new Generalworker { Id = 3, Name = "Mai", Salary = 50000 };

        employeeRepository.Save(manager);
        employeeRepository.Save(developer);
        employeeRepository.Save(general);

        payslipGenerator.GeneratePayslip(manager);
        Console.WriteLine($"Manager's Bonus: {manager.CalculateBonus()}");
        payslipGenerator.GeneratePayslip(developer);
        Console.WriteLine($"Developer's Bonus: {developer.CalculateBonus()}");
        payslipGenerator.GeneratePayslip(general);
        Console.WriteLine($"General Employee's Bonus: {general.CalculateBonus()}");

        emailService.SendEmail(manager);





    }
}