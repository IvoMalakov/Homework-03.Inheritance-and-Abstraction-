using System;

namespace Humans.Persons.Employees
{
    public interface IEmployee
    {
        decimal Salary { get; set; }
        string Departament { get; set; }
    }
}
