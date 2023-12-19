 using Microsoft.EntityFrameworkCore;
using UdemyEFCore.CodeFirst;
using UdemyEFCore.CodeFirst.DAL;

Initializer.Build();
using (var _context = new AppDbContext())
{
    //_context.Persons.Add(new Manager() { FirstName="M1" ,LastName="M2",Age=22,Grade=1});
    //_context.Persons.Add(new Employee() { FirstName = "M1", LastName = "M2", Age = 22, Salary = 1000 });

    var managers = _context.Managers.ToList();
    var employees = _context.Employees.ToList();
    var person = _context.Persons.ToList();

    person.ForEach(p =>
    {
        switch (p)
        {

            case Manager manager:
                Console.WriteLine($"manager entity:{manager.Grade}");
                break;
            case Employee employee:
                Console.WriteLine($"employee entity:{employee.Salary}");
                break;
        }
    });

    _context.SaveChanges();
}
