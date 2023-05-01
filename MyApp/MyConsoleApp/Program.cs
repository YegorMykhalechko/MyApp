using MyConsoleApp;

Employee employee1 = new Employee("name1", "surname1", 21);
Employee employee2 = new Employee("name2", "surname2", 22);
Employee employee3 = new Employee("name3", "surname3", 23);

employee1.AddScore(3);
employee1.AddScore(6);
employee1.AddScore(8);
employee1.AddScore(3);
employee1.AddScore(1);

employee2.AddScore(1);
employee2.AddScore(5);
employee2.AddScore(4);
employee2.AddScore(5);
employee2.AddScore(7);

employee3.AddScore(9);
employee3.AddScore(9);
employee3.AddScore(5);
employee3.AddScore(9);
employee3.AddScore(9);

List<Employee> employees = new List<Employee>() { employee1, employee2, employee3 };

int maxScore = 0;
Employee currentEmployee = null;

foreach (Employee employee in employees)
{
    if (maxScore < employee.Result)
    {
        maxScore = employee.Result;
        currentEmployee = employee;
    }
}

Console.WriteLine(
    "First Name: " + currentEmployee.FirstName + "; " +
    "Last Name: " + currentEmployee.LastName + "; " +
    "Age: " + currentEmployee.Age + "; " +
    "Score: " + currentEmployee.Result
);
